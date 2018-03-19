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
    class PropertySetType
    {
        [DataMember]
        private string propSetTypeId;
        [DataMember]
        private string propSetTypeName;
        [DataMember]
        private string[] properties;

        public string PropSetTypeName { get => propSetTypeName; set => propSetTypeName = value; }
        public string[] Properties { get => properties; set => properties = value; }
        public string PropSetTypeId { get => propSetTypeId; set => propSetTypeId = value; }
    }
}
