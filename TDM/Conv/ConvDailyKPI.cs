using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDM.Conv
{
    class ConvDailyKPI : IConvertor
    {
        public string Convert(string src, string res)
        {
            string result = "1";

            var csv = new StringBuilder();
            string[] addContents = File.ReadAllLines("C:\\Users\\dmitr\\OneDrive\\02. LeverX\\01. TDM\\" +
                "Tecnológico de Monterrey Value Prototyping\\" +
                "DAILY_DATA\\KPIs\\ACWI (WEEKLY).csv");
            foreach (var line in addContents)
            {
                DateTime dt;
                var oldLine = line.Split(',');
                var newLine = "";
                if (DateTime.TryParseExact(oldLine[0],
                                            "d/M/yyyy",
                                            new CultureInfo("en-CA"),
                                            DateTimeStyles.AdjustToUniversal,
                    out dt))
                {
                    if (oldLine[2].Length > 0 && oldLine[3].Length > 0)
                    {
                        newLine += dt.ToString("yyyy-MM-dd") + "," + oldLine[1] + "," +
                                                oldLine[2] + "," + oldLine[3] + "," + "USD,ACWI(WEEKLY)";
                        csv.AppendLine(newLine);
                    }
                }
            }
            //==========================================================================================
            addContents = File.ReadAllLines("C:\\Users\\dmitr\\OneDrive\\02. LeverX\\01. TDM\\" +
               "Tecnológico de Monterrey Value Prototyping\\" +
               "DAILY_DATA\\KPIs\\Argentina_Index_MERVAL (WEEKLY).csv");
            foreach (var line in addContents)
            {
                DateTime dt;
                var oldLine = line.Split(',');
                var newLine = "";
                var newLine2 = "";
                if (DateTime.TryParseExact(oldLine[0],
                                            "d/M/yyyy",
                                            new CultureInfo("en-CA"),
                                            DateTimeStyles.AdjustToUniversal,
                    out dt))
                {
                    if (oldLine[2].Length > 0 && oldLine[5].Length > 0)
                    {
                        newLine += dt.ToString("yyyy-MM-dd") + "," + oldLine[1] + "," +
                                                oldLine[2] + "," + oldLine[3] + "," + "USD,Argentina_Index_MERVAL(WEEKLY)";
                        newLine2 += dt.ToString("yyyy-MM-dd") + "," + oldLine[4] + "," +
                                                oldLine[5] + "," + oldLine[6] + "," + "ARS,Argentina_Index_MERVAL(WEEKLY)";
                        csv.AppendLine(newLine);
                        csv.AppendLine(newLine2);
                    }
                }
            }

            //==========================================================================================
            addContents = File.ReadAllLines("C:\\Users\\dmitr\\OneDrive\\02. LeverX\\01. TDM\\" +
                "Tecnológico de Monterrey Value Prototyping\\" +
                "DAILY_DATA\\KPIs\\Argentina_USDARS (MONTHLY).csv");
            foreach (var line in addContents)
            {
                DateTime dt;
                var oldLine = line.Split(',');
                var newLine = "";
                if (DateTime.TryParseExact(oldLine[0],
                                            "d/M/yyyy",
                                            new CultureInfo("en-CA"),
                                            DateTimeStyles.AdjustToUniversal,
                    out dt))
                {
                    if (oldLine[2].Length > 0 && oldLine[3].Length > 0)
                    {
                        newLine += dt.ToString("yyyy-MM-dd") + "," + oldLine[1] + "," +
                                                oldLine[2] + "," + oldLine[3] + "," + "USD,Argentina_USDARS(MONTHLY)";
                        csv.AppendLine(newLine);
                    }
                }
            }
            //==========================================================================================
            //==========================================================================================
            addContents = File.ReadAllLines("C:\\Users\\dmitr\\OneDrive\\02. LeverX\\01. TDM\\" +
               "Tecnológico de Monterrey Value Prototyping\\" +
               "DAILY_DATA\\KPIs\\Brazil_INDEX_IBOV (WEEKLY).csv");
            foreach (var line in addContents)
            {
                DateTime dt;
                var oldLine = line.Split(',');
                var newLine = "";
                var newLine2 = "";
                if (DateTime.TryParseExact(oldLine[0],
                                            "d/M/yyyy",
                                            new CultureInfo("en-CA"),
                                            DateTimeStyles.AdjustToUniversal,
                    out dt))
                {
                    if (oldLine[2].Length > 0 && oldLine[5].Length > 0)
                    {
                        newLine += dt.ToString("yyyy-MM-dd") + "," + oldLine[1] + "," +
                                                oldLine[2] + "," + oldLine[3] + "," + "USD,Brazil_INDEX_IBOV(WEEKLY)";
                        newLine2 += dt.ToString("yyyy-MM-dd") + "," + oldLine[4] + "," +
                                                oldLine[5] + "," + oldLine[6] + "," + "BRL,Brazil_INDEX_IBOV(WEEKLY)";
                        csv.AppendLine(newLine);
                        csv.AppendLine(newLine2);
                    }
                }
            }
            //==========================================================================================
            addContents = File.ReadAllLines("C:\\Users\\dmitr\\OneDrive\\02. LeverX\\01. TDM\\" +
                "Tecnológico de Monterrey Value Prototyping\\" +
                "DAILY_DATA\\KPIs\\Brazil_USDBRL (WEEKLY).csv");
            foreach (var line in addContents)
            {
                DateTime dt;
                var oldLine = line.Split(',');
                var newLine = "";
                if (DateTime.TryParseExact(oldLine[0],
                                            "d/M/yyyy",
                                            new CultureInfo("en-CA"),
                                            DateTimeStyles.AdjustToUniversal,
                    out dt))
                {
                    if (oldLine[2].Length > 0 && oldLine[3].Length > 0)
                    {
                        newLine += dt.ToString("yyyy-MM-dd") + "," + oldLine[1] + "," +
                                                oldLine[2] + "," + oldLine[3] + "," + "USD,Brazil_USDBRL(WEEKLY)";
                        csv.AppendLine(newLine);
                    }
                }
            }
            //==========================================================================================
            addContents = File.ReadAllLines("C:\\Users\\dmitr\\OneDrive\\02. LeverX\\01. TDM\\" +
               "Tecnológico de Monterrey Value Prototyping\\" +
               "DAILY_DATA\\KPIs\\Canada_Index_SPTSX (WEEKLY).csv");
            foreach (var line in addContents)
            {
                DateTime dt;
                var oldLine = line.Split(',');
                var newLine = "";
                var newLine2 = "";
                if (DateTime.TryParseExact(oldLine[0],
                                            "d/M/yyyy",
                                            new CultureInfo("en-CA"),
                                            DateTimeStyles.AdjustToUniversal,
                    out dt))
                {
                    if (oldLine[2].Length > 0 && oldLine[5].Length > 0)
                    {
                        newLine += dt.ToString("yyyy-MM-dd") + "," + oldLine[1] + "," +
                                                oldLine[2] + "," + oldLine[3] + "," + "USD,Canada_Index_SPTSX(WEEKLY)";
                        newLine2 += dt.ToString("yyyy-MM-dd") + "," + oldLine[4] + "," +
                                                oldLine[5] + "," + oldLine[6] + "," + "CAD,Canada_Index_SPTSX(WEEKLY)";
                        csv.AppendLine(newLine);
                        csv.AppendLine(newLine2);
                    }
                }
            }
            //==========================================================================================
            addContents = File.ReadAllLines("C:\\Users\\dmitr\\OneDrive\\02. LeverX\\01. TDM\\" +
                "Tecnológico de Monterrey Value Prototyping\\" +
                "DAILY_DATA\\KPIs\\Canada_USDCAD (WEEKLY).csv");
            foreach (var line in addContents)
            {
                DateTime dt;
                var oldLine = line.Split(',');
                var newLine = "";
                if (DateTime.TryParseExact(oldLine[0],
                                            "d/M/yyyy",
                                            new CultureInfo("en-CA"),
                                            DateTimeStyles.AdjustToUniversal,
                    out dt))
                {
                    if (oldLine[2].Length > 0 && oldLine[3].Length > 0)
                    {
                        newLine += dt.ToString("yyyy-MM-dd") + "," + oldLine[1] + "," +
                                                oldLine[2] + "," + oldLine[3] + "," + "USD,Canada_USDCAD(WEEKLY)";
                        csv.AppendLine(newLine);
                    }
                }
            }
            //==========================================================================================
            addContents = File.ReadAllLines("C:\\Users\\dmitr\\OneDrive\\02. LeverX\\01. TDM\\" +
               "Tecnológico de Monterrey Value Prototyping\\" +
               "DAILY_DATA\\KPIs\\Mexico_Index_MEXBOL (WEEKLY).csv");
            foreach (var line in addContents)
            {
                DateTime dt;
                var oldLine = line.Split(',');
                var newLine = "";
                var newLine2 = "";
                if (DateTime.TryParseExact(oldLine[0],
                                            "d/M/yyyy",
                                            new CultureInfo("en-CA"),
                                            DateTimeStyles.AdjustToUniversal,
                    out dt))
                {
                    if (oldLine[2].Length > 0 && oldLine[5].Length > 0)
                    {
                        newLine += dt.ToString("yyyy-MM-dd") + "," + oldLine[1] + "," +
                                                oldLine[2] + "," + oldLine[3] + "," + "USD,Mexico_Index_MEXBOL(WEEKLY)";
                        newLine2 += dt.ToString("yyyy-MM-dd") + "," + oldLine[4] + "," +
                                                oldLine[5] + "," + oldLine[6] + "," + "MXN,Mexico_Index_MEXBOL(WEEKLY)";
                        csv.AppendLine(newLine);
                        csv.AppendLine(newLine2);
                    }
                }
            }
            //==========================================================================================
            addContents = File.ReadAllLines("C:\\Users\\dmitr\\OneDrive\\02. LeverX\\01. TDM\\" +
                "Tecnológico de Monterrey Value Prototyping\\" +
                "DAILY_DATA\\KPIs\\Mexico_USDMXN (WEEKLY).csv");
            foreach (var line in addContents)
            {
                DateTime dt;
                var oldLine = line.Split(',');
                var newLine = "";
                if (DateTime.TryParseExact(oldLine[0],
                                            "d/M/yyyy",
                                            new CultureInfo("en-CA"),
                                            DateTimeStyles.AdjustToUniversal,
                    out dt))
                {
                    if (oldLine[2].Length > 0 && oldLine[3].Length > 0)
                    {
                        newLine += dt.ToString("yyyy-MM-dd") + "," + oldLine[1] + "," +
                                                oldLine[2] + "," + oldLine[3] + "," + "USD,Mexico_USDMXN(WEEKLY)";
                        csv.AppendLine(newLine);
                    }
                }
            }
            //==========================================================================================
            addContents = File.ReadAllLines("C:\\Users\\dmitr\\OneDrive\\02. LeverX\\01. TDM\\" +
                "Tecnológico de Monterrey Value Prototyping\\" +
                "DAILY_DATA\\KPIs\\USA_Index_S&P500 (WEEKLY).csv");
            foreach (var line in addContents)
            {
                DateTime dt;
                var oldLine = line.Split(',');
                var newLine = "";
                if (DateTime.TryParseExact(oldLine[0],
                                            "d/M/yyyy",
                                            new CultureInfo("en-CA"),
                                            DateTimeStyles.AdjustToUniversal,
                    out dt))
                {
                    if (oldLine[2].Length > 0 && oldLine[3].Length > 0)
                    {
                        newLine += dt.ToString("yyyy-MM-dd") + "," + oldLine[1] + "," +
                                                oldLine[2] + "," + oldLine[3] + "," + "USD,USA_Index_S&P500(WEEKLY)";
                        csv.AppendLine(newLine);
                    }
                }
            }
            //==========================================================================================
            addContents = File.ReadAllLines("C:\\Users\\dmitr\\OneDrive\\02. LeverX\\01. TDM\\" +
                "Tecnológico de Monterrey Value Prototyping\\" +
                "DAILY_DATA\\KPIs\\Oil (Daily).csv");
            foreach (var line in addContents)
            {
                DateTime dt;
                var oldLine = line.Split(',');
                var newLine = "";
                if (DateTime.TryParseExact(oldLine[0],
                                            "d/M/yyyy",
                                            new CultureInfo("en-CA"),
                                            DateTimeStyles.AdjustToUniversal,
                    out dt))
                {
                    if (oldLine[2].Length > 0 && oldLine[3].Length > 0)
                    {
                        newLine += dt.ToString("yyyy-MM-dd") + "," + oldLine[1] + "," +
                                                oldLine[2] + "," + oldLine[3] + "," + "USD,Oil(Daily)";
                        csv.AppendLine(newLine);
                    }
                }
            }
            //==========================================================================================
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
