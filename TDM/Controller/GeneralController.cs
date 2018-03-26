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
using TDM.Parsers;

namespace TDM.Controller
{
    class GeneralController
    {
        public void SerilizeHierarchy(Hierarchy obj, string hierPath)
        {
            MemoryStream stream = new MemoryStream();
            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(Hierarchy));
            ser.WriteObject(stream, obj);
            byte[] json = stream.ToArray();
            stream.Close();
            string jsonStr = Encoding.UTF8.GetString(json, 0, json.Length);
            string result = JValue.Parse(jsonStr).ToString(Formatting.Indented);
            File.WriteAllText(hierPath, result);
        }

        public void SerilizeAssets(List<Asset> obj)
        {
            StringBuilder assets = new StringBuilder();
            foreach (var asset in obj)
            {
                assets.AppendLine(asset.AssetId + "," + asset.AssetTypeId + "," + asset.Name);
            }
            File.WriteAllText(Constants.AssetMasterSrc, assets.ToString());
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
            Hierarchy kpiHierarchy = DeserilizeHierarchy(Constants.KpiHierarchySrc);
            List<HierarchyAssignment> hierarchyAssignment = new List<HierarchyAssignment>();
            List<HierarchyNode> hierarchyNodePairs = new List<HierarchyNode>();
            HashSet<string> assets = new HashSet<string>();

            List<Asset> assetMaster = new List<Asset>();
            var assetSerial = new AssetMasterSerializator();
            assetMaster = assetSerial.DeserializeAssetCSV();

            // *******************************************************************************
            // ASSET
            // *******************************************************************************
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
            hierarchyAssignment.Add(new HierarchyAssignment()
            {
                HierarchyId = hierarchy.HierarchyId,
                AssetId = hierarchy.RootAssetId,
                NodeId = Guid.NewGuid().ToString("N")
            });
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
                    Name = asset.Name == null ? "" : asset.Name
                });
            }

            hierarchyNodePairs.Add(new HierarchyNode()
            {
                NodeId = hierarchyAssignment.Find(x => x.AssetId == hierarchy.RootAssetId).NodeId,
                HierarchyId = hierarchy.HierarchyId,
                ParentNodeId = "0",
                Name = assetMaster.Find(x => x.AssetId == hierarchy.RootAssetId).Name
            });
            // *******************************************************************************
            // KPI
            // *******************************************************************************
            foreach (var hPair in kpiHierarchy.HierarchyPairs)
            {
                assets.Add(hPair[0]);
                assets.Add(hPair[1]);
            }
            foreach (string asset in assets)
            {
                hierarchyAssignment.Add(new HierarchyAssignment()
                {
                    HierarchyId = kpiHierarchy.HierarchyId,
                    AssetId = asset,
                    NodeId = Guid.NewGuid().ToString("N")
                });
            }
            hierarchyAssignment.Add(new HierarchyAssignment()
            {
                HierarchyId = kpiHierarchy.HierarchyId,
                AssetId = kpiHierarchy.RootAssetId,
                NodeId = Guid.NewGuid().ToString("N")
            });
            foreach (var hPair in kpiHierarchy.HierarchyPairs)
            {
                HierarchyAssignment child = hierarchyAssignment.Find(x => x.AssetId == hPair[0]);
                HierarchyAssignment parent = hierarchyAssignment.Find(x => x.AssetId == hPair[1]);
                Asset asset = assetMaster.Find(x => x.AssetId == hPair[0]);
                hierarchyNodePairs.Add(new HierarchyNode()
                {
                    NodeId = child.NodeId,
                    HierarchyId = child.HierarchyId,
                    ParentNodeId = parent.NodeId,
                    Name = asset.Name == null ? "" : asset.Name
                });
            }

            hierarchyNodePairs.Add(new HierarchyNode()
            {
                NodeId = hierarchyAssignment.Find(x => x.AssetId == kpiHierarchy.RootAssetId).NodeId,
                HierarchyId = kpiHierarchy.HierarchyId,
                ParentNodeId = "0",
                Name = assetMaster.Find(x => x.AssetId == kpiHierarchy.RootAssetId).Name
            });
            //**********************************************************************************

            List<Hierarchy> hiers = new List<Hierarchy>();
            hiers.Add(hierarchy);
            hiers.Add(kpiHierarchy);
            var ser = new HierarchySerializator();
            ser.SerializeHierarchy(hiers, hierarchyAssignment, hierarchyNodePairs,
                Constants.Res_HIERARCHY, Constants.Res_HIERARCHY_ASSIGNMENT,
                Constants.Res_HIERARCHY_NODE);


            return result;
        }

        public void SerializeSCVSettings(string path, CSVSettingsMap setMap)
        {
            MemoryStream stream = new MemoryStream();
            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(CSVSettingsMap));
            ser.WriteObject(stream, setMap);
            byte[] json = stream.ToArray();
            stream.Close();
            string jsonStr = Encoding.UTF8.GetString(json, 0, json.Length);
            string result = JValue.Parse(jsonStr).ToString(Formatting.Indented);
            File.WriteAllText(path, result);
        }

        public CSVSettingsMap DeserilizeSCVSettings(string path)
        {
            CSVSettingsMap result = new CSVSettingsMap();

            string json = File.ReadAllText(path);
            MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(json));
            DataContractJsonSerializer ser = new DataContractJsonSerializer(result.GetType());
            result = ser.ReadObject(ms) as CSVSettingsMap;
            ms.Close();

            return result;
        }

        public string ParseLongTermFixInc()
        {
            string res = "1";
            CSVSettingsMap settings = DeserilizeSCVSettings(Constants.SetMapCSVLongTerm);
            LongTermFixIncParser parser = new LongTermFixIncParser();
            StringBuilder strTS = parser.parse_TimeS_SCV(Constants.Src_LongTermFixInc, settings);
            StringBuilder strMD = parser.parse_MasterD_SCV(Constants.Src_LongTermFixInc, settings);
            File.WriteAllText(Constants.Res_TimeSerLongTermFixInc, strTS.ToString());
            File.WriteAllText(Constants.Res_MasterDLongTermFixInc, strMD.ToString());

            return res;
        }

        public string ParseMexBondsDaily()
        {
            string res = "1";
            CSVSettingsMap settings = DeserilizeSCVSettings(Constants.SetMapCSVMexBondsDaily);
            MexBondsDailyParser parser = new MexBondsDailyParser();
            StringBuilder str = parser.parseSCV(Constants.Src_MexBondsDaily, settings);
            File.WriteAllText(Constants.Res_TimeSerMexBondsDaily, str.ToString());

            return res;
        }

        public string ParsePeriodicETF()
        {
            string res = "1";
            CSVSettingsMap settings = DeserilizeSCVSettings(Constants.SetMapCSV_ETF_data);
            ETFParser parser = new ETFParser();
            StringBuilder str = parser.parseSCV(Constants.Src_ETF_data, settings);
            File.WriteAllText(Constants.Res_TimeSer_ETF_data, str.ToString());

            return res;
        }

        public string ParseDailyETF()
        {
            string res = "1";
            CSVSettingsMap settings = DeserilizeSCVSettings(Constants.SetMapCSV_ETF_daily_data);
            ETFParser parser = new ETFParser();
            StringBuilder str = parser.parseSCV(Constants.Src_ETF_daily_data, settings);
            File.WriteAllText(Constants.Res_TimeSer_ETF_daily_data, str.ToString());

            return res;
        }

        public List<Asset> DeserializeAssets()
        {
            List<Asset> result = (new AssetMasterSerializator()).DeserializeAssetCSV();
            return result;
        }

        public string ParseKPI()
        {
            string res = "1";
            CSVSettingsMap settings = DeserilizeSCVSettings(Constants.SetMapKPI);
            ETFParser parser = new ETFParser();
            StringBuilder str = parser.parseSCV(Constants.Src_KPI, settings);
            File.WriteAllText(Constants.Res_TimeSer_KPI, str.ToString());

            return res;
        }
    }
}
