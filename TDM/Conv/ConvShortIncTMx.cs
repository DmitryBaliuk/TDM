using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDM.Conv
{
    class ConvShortIncTMx : IConvertor
    {
        public string Convert(string src, string res)
        {
            string result = "1";

            var csv = new StringBuilder();
            Dictionary<string, string> monthMap = new Dictionary<string, string>()
            {
                { "Enero", "01" },
                { "Febrero", "02" },
                { "Marzo", "03" },
                { "Abril", "04" },
                { "Mayo", "05" },
                { "Junio", "06" },
                { "Julio", "07" },
                { "Agosto", "08" },
                { "Septiembre", "09" },
                { "Octubre", "10" },
                { "Noviembre", "11" },
                { "Diciembre", "12" }
            };

            string[] contents = File.ReadAllLines(src);
            for (int i = 1; i < contents.Length; i++)
            {
                string line = contents[i];
                string[] columns = line.Split(',');
                string convDate = columns[0] + '-' + monthMap[columns[1]] + '-' + "01";
                string newLine = convDate;

                for (int y = 2; y < columns.Length; y++)
                {
                    newLine = newLine + ',' + columns[y];
                }

                csv.AppendLine(newLine.Replace(" ", string.Empty));
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
