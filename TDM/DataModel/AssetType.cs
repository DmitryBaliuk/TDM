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
    class AssetType
    {
        [DataMember]
        private string assetTypeId;
        [DataMember]
        private string assetTypeName;
        [DataMember]
        private string[] propertySetTypes;

        public string AssetTypeId { get => assetTypeId; set => assetTypeId = value; }
        public string AssetTypeName { get => assetTypeName; set => assetTypeName = value; }
        public string[] PropertySetTypes { get => propertySetTypes; set => propertySetTypes = value; }
    }
}
