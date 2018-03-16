using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDM.DataModel;

namespace TDM.Serializers
{
    class AssetMasterSerializator
    {
        public List<Asset> DeserializeAssetCSV()
        {
            List<Asset> result = new List<Asset>();
            string[] contents = File.ReadAllLines(Constants.AssetMasterSrc);
            foreach (var line in contents)
            {
                string[] splittedLine = line.Split(',');
                result.Add(new Asset
                {
                    AssetId = splittedLine[0],
                    AssetTypeId = splittedLine[1],
                    Name = splittedLine[2]                    
                });
            }
            return result;
        }
    }
}
