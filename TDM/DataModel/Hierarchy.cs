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
    class Hierarchy
    {
        [DataMember]
        private string hierarchyId;
        [DataMember]
        private string hierarchyName;
        [DataMember]
        private List<string[]> hierarchyPairs;

        public string HierarchyId { get => hierarchyId; set => hierarchyId = value; }
        public string HierarchyName { get => hierarchyName; set => hierarchyName = value; }
        public List<string[]> HierarchyPairs { get => hierarchyPairs; set => hierarchyPairs = value; }
    }
}
