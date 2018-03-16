using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDM.DataModel
{
    class Asset
    {
        private string assetId;
        private string assetTypeId;
        private string name;

        public string AssetId { get => assetId; set => assetId = value; }
        public string AssetTypeId { get => assetTypeId; set => assetTypeId = value; }
        public string Name { get => name; set => name = value; }
    }
}
