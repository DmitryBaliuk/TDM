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
    class MetaModel
    {
        [DataMember]
        private List<Property> properties;
        [DataMember]
        private List<AssetType> assetTypes;
        [DataMember]
        private List<PropertySetType> propertySetType;

        public List<Property> Properties { get => properties; set => properties = value; }
        public List<AssetType> AssetTypes { get => assetTypes; set => assetTypes = value; }
        public List<PropertySetType> PropertySetType { get => propertySetType; set => propertySetType = value; }
    }
}
