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
    class Property
    {
        [DataMember]
        private string propertyId;
        [DataMember]
        private string propertyName;
        [DataMember]
        private string dataType;

        public string PropertyId { get => propertyId; set => propertyId = value; }
        public string PropertyName { get => propertyName; set => propertyName = value; }
        public string DataType { get => dataType; set => dataType = value; }
    }
}
