using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDM.DataModel;

namespace TDM.Controller
{
    class MetaDataSimulator
    {
        public MetaModel Simulate()
        {
            MetaModel mm = new MetaModel()
            {
                Properties = new List<Property>(),
                PropertySetType = new List<PropertySetType>(),
                AssetTypes = new List<AssetType>()
            };

            mm.Properties.Add(new Property()
            { PropertyId = "PlazoOriginal", PropertyName = "OriginalTerm", DataType = "Integer" });
            mm.Properties.Add(new Property()
            { PropertyId = "FechaEmisiуn", PropertyName = "EmissionDate", DataType = "Date" });
            mm.Properties.Add(new Property()
            { PropertyId = "PrecioSucio", PropertyName = "DirtyPrice", DataType = "Float" });
            mm.Properties.Add(new Property()
            { PropertyId = "PlazoPortafolio", PropertyName = "TermOnDealDay", DataType = "Integer" });
            mm.Properties.Add(new Property()
            { PropertyId = "DнasAVencimiento", PropertyName = "DaysToExpiration", DataType = "Integer" });
            mm.Properties.Add(new Property()
            { PropertyId = "Tнtulos", PropertyName = "Titles", DataType = "Integer" });
            mm.Properties.Add(new Property()
            { PropertyId = "Duraciуn", PropertyName = "Duration", DataType = "Float" });
            mm.Properties.Add(new Property()
            { PropertyId = "Saldo", PropertyName = "Balance", DataType = "Float" });
            mm.Properties.Add(new Property()
            { PropertyId = "Rendimiento", PropertyName = "Performance", DataType = "Float" });

            mm.AssetTypes.Add(new AssetType()
            {
                AssetTypeId = "CertificadoBurs6til",
                AssetTypeName = "Certificate",
                PropertySetTypes = (new string[] { "LongTermFixIncSetMasterData", "LongTermFixIncSetTimeSeries" })
            });
            mm.AssetTypes.Add(new AssetType()
            {
                AssetTypeId = "AssetSubClass",
                AssetTypeName = "AssetSubClass",
                PropertySetTypes = (new string[] { "" })
            });
            mm.AssetTypes.Add(new AssetType()
            {
                AssetTypeId = "Region",
                AssetTypeName = "Region",
                PropertySetTypes = (new string[] { "" })
            });
            mm.AssetTypes.Add(new AssetType()
            {
                AssetTypeId = "AssetClass",
                AssetTypeName = "AssetClass",
                PropertySetTypes = (new string[] { "" })
            });

            mm.PropertySetType.Add(new PropertySetType()
            {
                PropSetTypeId = "LongTermFixIncSetMasterData",
                PropSetTypeName = "LongTermFixIncSetMasterData",
                Properties = (new string[] { "PlazoOriginal", "FechaEmisiуn" })
            });
            mm.PropertySetType.Add(new PropertySetType()
            {
                PropSetTypeId = "LongTermFixIncSetTimeSeries",
                PropSetTypeName = "LongTermFixIncSetTimeSeries",
                Properties = (new string[] { "PrecioSucio", "PlazoPortafolio", "DнasAVencimiento",
                    "Tнtulos", "Duraciуn", "Saldo", "Rendimiento" })
            });

            return mm;
        }
    }
}
