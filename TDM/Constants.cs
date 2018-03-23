using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDM
{
    abstract class Constants
    {
        private static string hierarchySrc = "C:\\Users\\dmitr\\OneDrive\\02. LeverX\\01. TDM\\" +
               "TDM Convertor files\\hierarchy.txt";
        private static string metaModelSrc = "C:\\Users\\dmitr\\OneDrive\\02. LeverX\\01. TDM\\" +
               "TDM Convertor files\\metaModel.txt";
        private static string assetMasterSrc = "C:\\Users\\dmitr\\OneDrive\\02. LeverX\\01. TDM\\" +
               "TDM Convertor files\\assetMaster.txt";
        private static string setMapCSVLongTerm = "C:\\Users\\dmitr\\OneDrive\\02. LeverX\\01. TDM\\" +
               "TDM Convertor files\\01 Long Term Fix Inc Mex\\setMapCSVLongTerm.txt";
        private static string setMapCSVMexBondsDaily = "C:\\Users\\dmitr\\OneDrive\\02. LeverX\\01. TDM\\" +
               "TDM Convertor files\\02 Mex Bonds Daily based\\setMapCSVMexBondDaily.txt";
        private static string setMapCSV_ETF_data = "C:\\Users\\dmitr\\OneDrive\\02. LeverX\\01. TDM\\" +
               "TDM Convertor files\\03 ETF init\\setMapCSV_ETF_data.txt";
        private static string setMapCSV_ETF_daily_data = "C:\\Users\\dmitr\\OneDrive\\02. LeverX\\01. TDM\\" +
               "TDM Convertor files\\04 ETF daily\\setMapCSV_ETF_data.txt";

        private static string res_HIERARCHY = "C:\\Users\\dmitr\\OneDrive\\02. LeverX\\01. TDM\\" +
               "TDM Convertor files\\res_HIERARCHY.csv";
        private static string res_HIERARCHY_NODE = "C:\\Users\\dmitr\\OneDrive\\02. LeverX\\01. TDM\\" +
               "TDM Convertor files\\res_HIERARCHY_NODE.csv";
        private static string res_HIERARCHY_ASSIGNMENT = "C:\\Users\\dmitr\\OneDrive\\02. LeverX\\01. TDM\\" +
               "TDM Convertor files\\res_HIERARCHY_ASSIGNMENT.csv";
        private static string res_PROPERTY_SET = "C:\\Users\\dmitr\\OneDrive\\02. LeverX\\01. TDM\\" +
               "TDM Convertor files\\res_PROPERTY_SET.csv";
        private static string res_PROPERTY = "C:\\Users\\dmitr\\OneDrive\\02. LeverX\\01. TDM\\" +
               "TDM Convertor files\\res_PROPERTY.csv";
        private static string res_PROPERTY_SET_TYPE = "C:\\Users\\dmitr\\OneDrive\\02. LeverX\\01. TDM\\" +
               "TDM Convertor files\\res_PROPERTY_SET_TYPE.csv";
        private static string res_PROPERTY_SET_TYPE_ASSET_TYPE = "C:\\Users\\dmitr\\OneDrive\\02. LeverX\\01. TDM\\" +
               "TDM Convertor files\\res_PROPERTY_SET_TYPE_ASSET_TYPE.csv";
        private static string res_ASSET_TYPE = "C:\\Users\\dmitr\\OneDrive\\02. LeverX\\01. TDM\\" +
               "TDM Convertor files\\res_ASSET_TYPE.csv";

        private static string src_LongTermFixInc = "C:\\Users\\dmitr\\OneDrive\\02. LeverX\\01. TDM\\" +
            "TDM Convertor files\\01 Long Term Fix Inc Mex\\src_long_term_fix_inc.csv";
        private static string res_TimeSerLongTermFixInc = "C:\\Users\\dmitr\\OneDrive\\02. LeverX\\01. TDM\\" +
            "TDM Convertor files\\TimeSeriesResultCSV\\res_TimeSerLongTermFixInc.csv";
        private static string src_MexBondsDaily = "C:\\Users\\dmitr\\OneDrive\\02. LeverX\\01. TDM\\" +
            "TDM Convertor files\\02 Mex Bonds Daily based\\daily_mex_bond.csv";
        private static string res_TimeSerMexBondsDaily = "C:\\Users\\dmitr\\OneDrive\\02. LeverX\\01. TDM\\" +
            "TDM Convertor files\\TimeSeriesResultCSV\\res_TimeSerMexBondsDaily.csv";
        private static string src_ETF_data = "C:\\Users\\dmitr\\OneDrive\\02. LeverX\\01. TDM\\" +
            "TDM Convertor files\\03 ETF init\\src_ETF_data.csv";
        private static string res_TimeSer_ETF_data = "C:\\Users\\dmitr\\OneDrive\\02. LeverX\\01. TDM\\" +
            "TDM Convertor files\\TimeSeriesResultCSV\\res_TimeSer_ETF_data.csv";
        private static string src_ETF_daily_data = "C:\\Users\\dmitr\\OneDrive\\02. LeverX\\01. TDM\\" +
            "TDM Convertor files\\04 ETF daily\\src_ETF_data.csv";
        private static string res_TimeSer_ETF_daily_data = "C:\\Users\\dmitr\\OneDrive\\02. LeverX\\01. TDM\\" +
            "TDM Convertor files\\TimeSeriesResultCSV\\res_TimeSer_ETF_daily_data.csv";

        public static string HierarchySource { get => hierarchySrc; set => hierarchySrc = value; }
        public static string Res_HIERARCHY { get => res_HIERARCHY; set => res_HIERARCHY = value; }
        public static string Res_HIERARCHY_NODE { get => res_HIERARCHY_NODE; set => res_HIERARCHY_NODE = value; }
        public static string Res_HIERARCHY_ASSIGNMENT { get => res_HIERARCHY_ASSIGNMENT; set => res_HIERARCHY_ASSIGNMENT = value; }
        public static string AssetMasterSrc { get => assetMasterSrc; set => assetMasterSrc = value; }
        public static string MetaModelSrc { get => metaModelSrc; set => metaModelSrc = value; }
        public static string Res_PROPERTY_SET { get => res_PROPERTY_SET; set => res_PROPERTY_SET = value; }
        public static string Res_PROPERTY { get => res_PROPERTY; set => res_PROPERTY = value; }
        public static string Res_PROPERTY_SET_TYPE { get => res_PROPERTY_SET_TYPE; set => res_PROPERTY_SET_TYPE = value; }
        public static string Res_PROPERTY_SET_TYPE_ASSET_TYPE { get => res_PROPERTY_SET_TYPE_ASSET_TYPE; set => res_PROPERTY_SET_TYPE_ASSET_TYPE = value; }
        public static string Res_ASSET_TYPE { get => res_ASSET_TYPE; set => res_ASSET_TYPE = value; }
        public static string SetMapCSVLongTerm { get => setMapCSVLongTerm; set => setMapCSVLongTerm = value; }
        public static string Src_LongTermFixInc { get => src_LongTermFixInc; set => src_LongTermFixInc = value; }
        public static string Res_TimeSerLongTermFixInc { get => res_TimeSerLongTermFixInc; set => res_TimeSerLongTermFixInc = value; }
        public static string SetMapCSVMexBondsDaily { get => setMapCSVMexBondsDaily; set => setMapCSVMexBondsDaily = value; }
        public static string Src_MexBondsDaily { get => src_MexBondsDaily; set => src_MexBondsDaily = value; }
        public static string Res_TimeSerMexBondsDaily { get => res_TimeSerMexBondsDaily; set => res_TimeSerMexBondsDaily = value; }
        public static string Res_TimeSer_ETF_data { get => res_TimeSer_ETF_data; set => res_TimeSer_ETF_data = value; }
        public static string Src_ETF_data { get => src_ETF_data; set => src_ETF_data = value; }
        public static string SetMapCSV_ETF_data { get => setMapCSV_ETF_data; set => setMapCSV_ETF_data = value; }
        public static string SetMapCSV_ETF_daily_data { get => setMapCSV_ETF_daily_data; set => setMapCSV_ETF_daily_data = value; }
        public static string Src_ETF_daily_data { get => src_ETF_daily_data; set => src_ETF_daily_data = value; }
        public static string Res_TimeSer_ETF_daily_data { get => res_TimeSer_ETF_daily_data; set => res_TimeSer_ETF_daily_data = value; }
    }
}
