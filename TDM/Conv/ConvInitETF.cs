using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDM.Conv
{
    class ConvInitETF : IConvertor
    {
        public string Convert(string src, string res)
        {
            string result = "1";
            var csv = new StringBuilder();
            foreach (string file in Directory.EnumerateFiles(src, "*.csv"))
            {
                string[] contents = File.ReadAllLines(file);
                for (int i = 0; i < contents.Length; i++)
                {
                    var line = contents[i];
                    var nexIndex = i + 1;
                    string[] nextLine;
                    double change = 0;
                    double perChange = 0;
                    if ((i + 1) >= contents.Length)
                    {
                        nexIndex = i;
                    }
                    nextLine = contents[nexIndex].Split(',');
                    DateTime dt;
                    var oldLine = line.Split(',');
                    var newLine = "";

                    if (DateTime.TryParseExact(oldLine[0],
                                                "d/M/yyyy",
                                                new CultureInfo("en-CA"),
                                                DateTimeStyles.AdjustToUniversal,
                        out dt))
                    {
                        if (oldLine.Length == 2 && ((i + 1) < contents.Length))
                        {
                            change = Math.Round(Double.Parse(oldLine[1]) - Double.Parse(nextLine[1]), 4);
                            perChange = Math.Round(change / Double.Parse(nextLine[1]), 5);
                            newLine += dt.ToString("yyyy-MM-dd") + "," + oldLine[1] + "," + change.ToString() + "," +
                                perChange.ToString() + "," +
                            (file.Split('\\').Last().ToString()).Split('.')[0].Replace(" ", string.Empty);
                            csv.AppendLine(newLine);
                        }
                        else if (oldLine.Length == 4 && ((i + 1) < contents.Length))
                        {
                            newLine += dt.ToString("yyyy-MM-dd") + "," + oldLine[1] + "," + oldLine[2] + "," +
                                oldLine[3] + "," +
                            (file.Split('\\').Last().ToString()).Split('.')[0].Replace(" ", string.Empty);
                            csv.AppendLine(newLine);
                        }
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
