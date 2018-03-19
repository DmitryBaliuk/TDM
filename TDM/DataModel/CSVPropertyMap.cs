using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TDM.DataModel
{
    [DataContract]
    class CSVPropertyMap
    {
        [DataMember]
        private int position;
        [DataMember]
        private string propertySetType;
        [DataMember]
        private string propertyId;

        public int Position { get => position; set => position = value; }
        public string PropertySetType { get => propertySetType; set => propertySetType = value; }
        public string PropertyId { get => propertyId; set => propertyId = value; }
    }
}
