using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDM.DataModel;

namespace TDM.Controller
{
    class SettingsLongTermCSVSimulator
    {
        public CSVSettingsMap Simulate()
        {
            CSVSettingsMap res = new CSVSettingsMap();

            res.DatePosition = 0;
            res.IdPosition = 6;
            res.AssetTypeIdPosition = 3;
            res.CurrencyPosition = 16;

            res.TimeSerDataProps = new List<CSVPropertyMap>();
            res.MasterDataProps = new List<CSVPropertyMap>();

            res.TimeSerDataProps.Add(new CSVPropertyMap()
            {
                Position = 7,
                PropertySetType = "LongTermFixIncSetTimeSeries",
                PropertyId = "PrecioSucio"
            });
            res.TimeSerDataProps.Add(new CSVPropertyMap()
            {
                Position = 8,
                PropertySetType = "LongTermFixIncSetTimeSeries",
                PropertyId = "PlazoPortafolio"
            });
            res.TimeSerDataProps.Add(new CSVPropertyMap()
            {
                Position = 11,
                PropertySetType = "LongTermFixIncSetTimeSeries",
                PropertyId = "DнasAVencimiento"
            });
            res.TimeSerDataProps.Add(new CSVPropertyMap()
            {
                Position = 12,
                PropertySetType = "LongTermFixIncSetTimeSeries",
                PropertyId = "Rendimiento"
            });
            res.TimeSerDataProps.Add(new CSVPropertyMap()
            {
                Position = 13,
                PropertySetType = "LongTermFixIncSetTimeSeries",
                PropertyId = "Tнtulos"
            });
            res.TimeSerDataProps.Add(new CSVPropertyMap()
            {
                Position = 14,
                PropertySetType = "LongTermFixIncSetTimeSeries",
                PropertyId = "Duraciуn"
            });
            res.TimeSerDataProps.Add(new CSVPropertyMap()
            {
                Position = 15,
                PropertySetType = "LongTermFixIncSetTimeSeries",
                PropertyId = "Saldo"
            });
            res.MasterDataProps.Add(new CSVPropertyMap()
            {
                Position = 9,
                PropertySetType = "LongTermFixIncSetTimeSeries",
                PropertyId = "PlazoOriginal"
            });
            res.MasterDataProps.Add(new CSVPropertyMap()
            {
                Position = 10,
                PropertySetType = "LongTermFixIncSetTimeSeries",
                PropertyId = "FechaEmisiуn"
            });

            return res;
        }
    }
}
