using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDM
{
    abstract class Constants
    {
        private static string hierarchySource = "C:\\Users\\dmitr\\OneDrive\\02. LeverX\\01. TDM\\" +
               "TDM Convertor files\\hierarchy.txt";

        private static string res_HIERARCHY = "C:\\Users\\dmitr\\OneDrive\\02. LeverX\\01. TDM\\" +
               "TDM Convertor files\\res_HIERARCHY.txt";
        private static string res_HIERARCHY_NODE = "C:\\Users\\dmitr\\OneDrive\\02. LeverX\\01. TDM\\" +
               "TDM Convertor files\\res_HIERARCHY_NODE.txt";
        private static string res_HIERARCHY_ASSIGNMENT = "C:\\Users\\dmitr\\OneDrive\\02. LeverX\\01. TDM\\" +
               "TDM Convertor files\\res_HIERARCHY_ASSIGNMENT.txt";

        public static string HierarchySource { get => hierarchySource; set => hierarchySource = value; }
        public static string Res_HIERARCHY { get => res_HIERARCHY; set => res_HIERARCHY = value; }
        public static string Res_HIERARCHY_NODE { get => res_HIERARCHY_NODE; set => res_HIERARCHY_NODE = value; }
        public static string Res_HIERARCHY_ASSIGNMENT { get => res_HIERARCHY_ASSIGNMENT; set => res_HIERARCHY_ASSIGNMENT = value; }
    }
}
