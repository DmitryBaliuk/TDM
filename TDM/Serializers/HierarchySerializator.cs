using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDM.DataModel;

namespace TDM.Serializers
{
    class HierarchySerializator
    {
        public string SerializeHierarchy(List<Hierarchy> hierarchy,
            List<HierarchyAssignment> hAssign, List<HierarchyNode> hNode,
            string hierPath, string hierAssignPath, string hierNodePath)
        {
            string result = "1";
            var hierarchyCsv = new StringBuilder();
            var hierarchyAssignCsv = new StringBuilder();
            var hierarchyNodeCsv = new StringBuilder();

            foreach (var hier in hierarchy)
            {
                if (hier.HierarchyId.ToString().Length == 0)
                {
                    result = "0";
                }
                else
                {
                    var hierarchyName = "";
                    hierarchyName += hier.HierarchyName.ToString();
                    hierarchyCsv.AppendLine(hier.HierarchyId.ToString() + "," + hierarchyName);
                }
            }

            if (result == "1")
            {
                File.WriteAllText(hierPath, hierarchyCsv.ToString());
            }

            foreach (var assignment in hAssign)
            {
                hierarchyAssignCsv.AppendLine(assignment.AssetId.ToString() + "," +
                    assignment.NodeId.ToString() + "," +
                    assignment.HierarchyId.ToString());
            }

            if (hierarchyAssignCsv.Length == 0)
            {
                result = "0";
            }
            else
            {
                File.WriteAllText(hierAssignPath, hierarchyAssignCsv.ToString());
            }

            foreach (var node in hNode)
            {
                hierarchyNodeCsv.AppendLine(node.NodeId.ToString() + "," +
                    node.HierarchyId.ToString() + "," +
                    node.ParentNodeId.ToString() + "," +
                    node.Name.ToString());
            }

            if (hierarchyNodeCsv.Length == 0)
            {
                result = "0";
            }
            else
            {
                File.WriteAllText(hierNodePath, hierarchyNodeCsv.ToString());
            }

            return result;
        }
    }
}
