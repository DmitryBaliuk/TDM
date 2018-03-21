using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDM.DataModel;
using TDM.Serializers;

namespace TDM.Parsers
{
    class MexBondsDailyParser
    {
        public StringBuilder parseSCV(string path, CSVSettingsMap setMap)
        {
            StringBuilder res = new StringBuilder();
            string[] content = File.ReadAllLines(path);
            List<Asset> assets = (new AssetMasterSerializator()).DeserializeAssetCSV();

            foreach (var line in content)
            {
                string newLine = "";
                string[] columns = line.Split(',');

                foreach (var prop in setMap.TimeSerDataProps)
                {
                    var asset = assets.Find(x => x.AssetId == columns[setMap.IdPosition]);
                    if (asset != null)
                    {
                        newLine = "";
                        newLine += columns[setMap.DatePosition] + ",";
                        newLine += columns[setMap.IdPosition] + ",";
                        newLine += asset.AssetTypeId;
                        newLine += "," + prop.PropertySetType + "," + prop.PropertyId +
                            "," + (columns[prop.Position] == "" ? "0" : columns[prop.Position]) +
                            "," + columns[setMap.CurrencyPosition];
                        res.AppendLine(newLine);
                    }
                }
            }
            return res;
        }
    }
}
