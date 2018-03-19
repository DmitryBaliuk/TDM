using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDM.DataModel;

namespace TDM.Serializers
{
    class MetaModelSerializator
    {
        public string SerializeHierarchy(MetaModel mm)
        {
            string result = "1";
            var propertyCsv = new StringBuilder();
            var assetTypeCsv = new StringBuilder();
            var propertySetCsv = new StringBuilder();
            var propertySetTypeCsv = new StringBuilder();
            var propertySetTypeAssetTypeCsv = new StringBuilder();


            foreach (var prop in mm.Properties)
            {
                propertyCsv.AppendLine(prop.PropertyId.ToString() + "," +
                    prop.PropertyName.ToString() + "," +
                    prop.DataType.ToString());
            }
            if (propertyCsv.Length == 0)
            {
                result = "0";
            }
            else
            {
                File.WriteAllText(Constants.Res_PROPERTY, propertyCsv.ToString());
            }

            foreach (var propSetT in mm.PropertySetType)
            {
                propertySetTypeCsv.AppendLine(propSetT.PropSetTypeId.ToString() + "," +
                    propSetT.PropSetTypeName.ToString());
                foreach (var prop in propSetT.Properties)
                {
                    propertySetCsv.AppendLine(prop.ToString() + "," +
                        propSetT.PropSetTypeId.ToString());
                }

            }
            if (propertySetTypeCsv.Length == 0 || propertySetCsv.Length == 0)
            {
                result = "0";
            }
            else
            {
                File.WriteAllText(Constants.Res_PROPERTY_SET_TYPE, propertySetTypeCsv.ToString());
                File.WriteAllText(Constants.Res_PROPERTY_SET, propertySetCsv.ToString());
            }

            foreach (var aType in mm.AssetTypes)
            {
                assetTypeCsv.AppendLine(aType.AssetTypeId.ToString() + "," +
                    aType.AssetTypeName.ToString());
                foreach (var propST in aType.PropertySetTypes)
                {
                    if (propST != "")
                    {
                        propertySetTypeAssetTypeCsv.AppendLine(aType.AssetTypeId.ToString() + "," +
                            propST.ToString());
                    }
                }
                
            }
            if (assetTypeCsv.Length == 0 || propertySetTypeAssetTypeCsv.Length == 0)
            {
                result = "0";
            }
            else
            {
                File.WriteAllText(Constants.Res_ASSET_TYPE, assetTypeCsv.ToString());
                File.WriteAllText(Constants.Res_PROPERTY_SET_TYPE_ASSET_TYPE, propertySetTypeAssetTypeCsv.ToString());
            }

            return result;
        }
    }
}
