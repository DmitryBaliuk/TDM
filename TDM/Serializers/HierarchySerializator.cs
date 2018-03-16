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
        public string SerializeHierarchy(Hierarchy hierarchy,
            List<HierarchyAssignment> hAssign, List<HierarchyNode> hNode)
        {
            string result = "1";
            var hierarchyCsv = new StringBuilder();
            var hierarchyAssignCsv = new StringBuilder();
            var hierarchyNodeCsv = new StringBuilder();

            if (hierarchy.HierarchyId.ToString().Length == 0)
            {
                result = "0";
            }
            else
            {
                var hierarchyName = "";
                hierarchyName += hierarchy.HierarchyName.ToString();
                hierarchyCsv.AppendLine(hierarchy.HierarchyId.ToString() + "," + hierarchyName);
                File.WriteAllText(Constants.Res_HIERARCHY, hierarchyCsv.ToString());
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
                File.WriteAllText(Constants.Res_HIERARCHY_ASSIGNMENT, hierarchyAssignCsv.ToString());
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
                File.WriteAllText(Constants.Res_HIERARCHY_NODE, hierarchyNodeCsv.ToString());
            }

            return result;
        }
    }
}
