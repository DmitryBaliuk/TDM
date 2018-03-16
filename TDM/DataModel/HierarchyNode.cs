using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDM.DataModel
{
    class HierarchyNode
    {
        private string nodeId;
        private string parentNodeId;
        private string hierarchyId;
        private string name;

        public string ParentNodeId { get => parentNodeId; set => parentNodeId = value; }
        public string NodeId { get => nodeId; set => nodeId = value; }
        public string HierarchyId { get => hierarchyId; set => hierarchyId = value; }
        public string Name { get => name; set => name = value; }
    }
}
