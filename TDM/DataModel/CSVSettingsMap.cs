using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TDM.DataModel
{
    [DataContract]
    class CSVSettingsMap
    {
        [DataMember]
        private int datePosition;
        [DataMember]
        private int idPosition;
        [DataMember]
        private int assetTypeIdPosition;
        [DataMember]
        private int currencyPosition;
        [DataMember]
        private List<CSVPropertyMap> masterDataProps;
        [DataMember]
        private List<CSVPropertyMap> timeSerDataProps;

        public int DatePosition { get => datePosition; set => datePosition = value; }
        public int IdPosition { get => idPosition; set => idPosition = value; }
        public int AssetTypeIdPosition { get => assetTypeIdPosition; set => assetTypeIdPosition = value; }
        public int CurrencyPosition { get => currencyPosition; set => currencyPosition = value; }
        internal List<CSVPropertyMap> MasterDataProps { get => masterDataProps; set => masterDataProps = value; }
        internal List<CSVPropertyMap> TimeSerDataProps { get => timeSerDataProps; set => timeSerDataProps = value; }
    }
}
