using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDM.DataModel;
using System.IO;

namespace TDM.Parsers
{
    class LongTermFixIncParser
    {
        public StringBuilder parseSCV(string path, CSVSettingsMap setMap)
        {
            StringBuilder res = new StringBuilder();
            string[] content = File.ReadAllLines(path);

            foreach (var line in content)
            {
                string newLine = "";
                string[] columns = line.Split(',');
                
                foreach (var prop in setMap.TimeSerDataProps)
                {
                    newLine = "";
                    newLine += columns[setMap.DatePosition] + ",";
                    newLine += columns[setMap.IdPosition] + ",";
                    newLine += columns[setMap.AssetTypeIdPosition];
                    newLine += "," + prop.PropertySetType + "," + prop.PropertyId +
                        "," + (columns[prop.Position] == "" ? "0" : columns[prop.Position]) +
                        "," + columns[setMap.CurrencyPosition];
                    res.AppendLine(newLine);
                }
            }
            return res;
        }
    }
}
