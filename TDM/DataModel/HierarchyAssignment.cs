using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDM.DataModel
{
    class HierarchyAssignment
    {
        private string assetId;
        private string nodeId;
        private string hierarchyId;

        public string AssetId { get => assetId; set => assetId = value; }
        public string NodeId { get => nodeId; set => nodeId = value; }
        public string HierarchyId { get => hierarchyId; set => hierarchyId = value; }
    }
}
