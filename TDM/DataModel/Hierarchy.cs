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
        private string rootAssetId;
        [DataMember]
        private List<string[]> hierarchyPairs;

        public string HierarchyId { get => hierarchyId; set => hierarchyId = value; }
        public string HierarchyName { get => hierarchyName; set => hierarchyName = value; }
        public List<string[]> HierarchyPairs { get => hierarchyPairs; set => hierarchyPairs = value; }
        public string RootAssetId { get => rootAssetId; set => rootAssetId = value; }
    }
}
