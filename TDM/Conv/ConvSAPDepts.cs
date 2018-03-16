using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDM.Conv
{
    class ConvSAPDepts : IConvertor
    {
        public string Convert(string src, string res)
        {
            string result = "1";

            var csv = new StringBuilder();
            string[] contents = File.ReadAllLines(src);
            foreach (var line in contents)
            {
                DateTime dt;
                var oldLine = line.Split(',');
                var newLine = "";
                if (DateTime.TryParseExact(oldLine[0],
                                            "M/d/yyyy",
                                            new CultureInfo("en-CA"),
                                            DateTimeStyles.AdjustToUniversal,
                    out dt))
                {
                    newLine += dt.ToString("yyyy-MM-dd") + "," + oldLine[1] + "," +
                        oldLine[2] + "," + oldLine[3] + "," + oldLine[4];
                    csv.AppendLine(newLine);
                }
                else
                {
                    //MessageBox.Show("Parse date error");
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
