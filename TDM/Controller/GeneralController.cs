using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDM.Conv;
using TDM.DataModel;
using System.Runtime.Serialization;
using System.IO;
using System.Runtime.Serialization.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using TDM.Serializers;

namespace TDM.Controller
{
    class GeneralController
    {
        public void SerilizeHierarchy(Hierarchy obj)
        {
            MemoryStream stream = new MemoryStream();
            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(Hierarchy));
            ser.WriteObject(stream, obj);
            byte[] json = stream.ToArray();
            stream.Close();
            string jsonStr = Encoding.UTF8.GetString(json, 0, json.Length);
            string result = JValue.Parse(jsonStr).ToString(Formatting.Indented);
            File.WriteAllText(Constants.HierarchySource, result);
        }

        public void SerilizeMetaModel(MetaModel obj)
        {
            MemoryStream stream = new MemoryStream();
            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(MetaModel));
            ser.WriteObject(stream, obj);
            byte[] json = stream.ToArray();
            stream.Close();
            string jsonStr = Encoding.UTF8.GetString(json, 0, json.Length);
            string result = JValue.Parse(jsonStr).ToString(Formatting.Indented);
            File.WriteAllText(Constants.MetaModelSrc, result);
        }

        public Hierarchy DeserilizeHierarchy(string path)
        {
            Hierarchy result = new Hierarchy();

            string json = File.ReadAllText(path);
            MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(json));
            DataContractJsonSerializer ser = new DataContractJsonSerializer(result.GetType());
            result = ser.ReadObject(ms) as Hierarchy;
            ms.Close();

            return result;
        }

        public string BuildHierarchyTableData()
        {
            string result = "1";
            string hierarchyPath = Constants.HierarchySource;
            Hierarchy hierarchy = DeserilizeHierarchy(hierarchyPath);
            List<HierarchyAssignment> hierarchyAssignment = new List<HierarchyAssignment>();
            List<HierarchyNode> hierarchyNodePairs = new List<HierarchyNode>();
            HashSet<string> assets = new HashSet<string>();

            List<Asset> assetMaster = new List<Asset>();
            var assetSerial = new AssetMasterSerializator();
            assetMaster = assetSerial.DeserializeAssetCSV();

            foreach (var hPair in hierarchy.HierarchyPairs)
            {
                assets.Add(hPair[0]);
                assets.Add(hPair[1]);
            }
            foreach (string asset in assets)
            {
                hierarchyAssignment.Add(new HierarchyAssignment()
                {
                    HierarchyId = hierarchy.HierarchyId,
                    AssetId = asset,
                    NodeId = Guid.NewGuid().ToString("N")
                });
            }
            foreach (var hPair in hierarchy.HierarchyPairs)
            {
                HierarchyAssignment child = hierarchyAssignment.Find(x => x.AssetId == hPair[0]);
                HierarchyAssignment parent = hierarchyAssignment.Find(x => x.AssetId == hPair[1]);
                Asset asset = assetMaster.Find(x => x.AssetId == hPair[0]);
                hierarchyNodePairs.Add(new HierarchyNode()
                {
                    NodeId = child.NodeId,
                    HierarchyId = child.HierarchyId,
                    ParentNodeId = parent.NodeId,
                    Name = asset.Name
                });
            }

            hierarchyNodePairs.Add(new HierarchyNode()
            {
                NodeId = hierarchyAssignment.Find(x => x.AssetId == hierarchy.RootAssetId).NodeId,
                HierarchyId = hierarchy.HierarchyId,
                ParentNodeId = "0",
                Name = assetMaster.Find(x => x.AssetId == hierarchy.RootAssetId).Name
            });

            var ser = new HierarchySerializator();
            ser.SerializeHierarchy(hierarchy, hierarchyAssignment, hierarchyNodePairs);


            return result;
        }
    }
}
