using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDM.Conv
{
    class ConvDailyMexBonds : IConvertor
    {
        public string Convert(string src, string res)
        {
            string result = "1";

            var csv = new StringBuilder();
            foreach (string file in Directory.EnumerateFiles(src, "*.csv"))
            {
                string[] contents = File.ReadAllLines(file.ToString());
                foreach (var line in contents)
                {
                    DateTime dt;
                    var oldLine = line.Split(',');
                    var newLine = "";
                    if (DateTime.TryParseExact(oldLine[2],
                                                "d/M/yyyy",
                                                new CultureInfo("en-CA"),
                                                DateTimeStyles.AdjustToUniversal,
                        out dt))
                    {
                        newLine += dt.ToString("yyyy-MM-dd") + "," + oldLine[0] + "," +
                            oldLine[1] + "," + oldLine[3] + "," + oldLine[4];
                        csv.AppendLine(newLine);
                    }
                    else
                    {
                        //MessageBox.Show("Parse date error");
                    }
                }
            }

            if (csv.Length == 0)
            {
                result = "0";
            }
            else
            {
                File.WriteAllText(res, csv.ToString());
            }
            return result;
        }
    }
}
