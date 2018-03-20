using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TDM.Conv;
using TDM.Controller;
using TDM.DataModel;
using TDM.Serializers;
using TDM.Parsers;

namespace TDM
{
    public partial class FormMain : Form
    {
        private GeneralController contr; 

        public FormMain()
        {
            InitializeComponent();
            contr = new GeneralController();
        }

        private void btnConvInitKPI_Click(object sender, EventArgs e)
        {
            IConvertor conv = new ConvInitKPI();
            string res = conv.Convert(tBInitKPIConvSrc.Text.ToString(), tBInitKPIConvRes.Text.ToString());
            MessageBox.Show(res == "1" ? "Success" : "Fail");
        }

        private void btnConvInitETF_Click(object sender, EventArgs e)
        {
            IConvertor conv = new ConvInitETF();
            string res = conv.Convert(tBConvInitETFSrc.Text.ToString(), tBConvInitETFRes.Text.ToString());
            MessageBox.Show(res == "1" ? "Success" : "Fail");
        }

        private void btnConvLengTIncMx_Click(object sender, EventArgs e)
        {
            IConvertor conv = new ConvLengTIncMx();
            string res = conv.Convert(tBConvLongTIncMxSrc.Text.ToString(), tBConvLongTMxRes.Text.ToString());
            MessageBox.Show(res == "1" ? "Success" : "Fail");
        }

        private void btnConvShortIncTMx_Click(object sender, EventArgs e)
        {
            IConvertor conv = new ConvShortIncTMx();
            string res = conv.Convert(tBConvShortTIncMxSrc.Text.ToString(), tBConvShortTIncMxRes.Text.ToString());
            MessageBox.Show(res == "1" ? "Success" : "Fail");
        }

        // Convert Steffen depts
        private void bConvSAPDepts_Click(object sender, EventArgs e)
        {
            IConvertor conv = new ConvSAPDepts();
            string res = conv.Convert(tBConvSAPDeptsSrc.Text.ToString(), textBox10.Text.ToString());
            MessageBox.Show(res == "1" ? "Success" : "Fail");
        }

        private void btnConvDailyETF_Click(object sender, EventArgs e)
        {
            IConvertor conv = new ConvDailyETF();
            string res = conv.Convert(tBConvDailyETFSrc.Text.ToString(), tBConvDailyETFRes.Text.ToString());
            MessageBox.Show(res == "1" ? "Success" : "Fail");
        }

        private void btnConvDailyKPI_Click(object sender, EventArgs e)
        {
            IConvertor conv = new ConvDailyKPI();
            string res = conv.Convert("", tBConvDailyKPISrc.Text.ToString());
            MessageBox.Show(res == "1" ? "Success" : "Fail");
        }

        private void btnConvDailyMexBonds_Click(object sender, EventArgs e)
        {
            IConvertor conv = new ConvDailyMexBonds();
            string res = conv.Convert(tBConvDailyMexBondSrc.Text.ToString(), tBConvDailyMexBondRes.Text.ToString());
            MessageBox.Show(res == "1" ? "Success" : "Fail");
        }

        private void btnBuildHierarchy_Click(object sender, EventArgs e)
        {
            string res = contr.BuildHierarchyTableData();
            MessageBox.Show(res == "1" ? "Success" : "Fail");
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            //SettingsLongTermCSVSimulator setSim = new SettingsLongTermCSVSimulator();
            //CSVSettingsMap settings = setSim.Simulate();
            //contr.SerializeSCVSettings(Constants.SetMapCSVLongTerm, settings);
            //MetaModel mm = (new MetaDataSimulator()).Simulate();

            //contr.SerilizeMetaModel(mm);

            //MetaModelSerializator ser = new MetaModelSerializator();
            //ser.SerializeHierarchy(mm);

        }

        private void btnParseLongTermFixIncCSV_Click(object sender, EventArgs e)
        {
            string res = contr.ParseLongTermFixInc();
            MessageBox.Show(res == "1" ? "Success" : "Fail");
        }

        private void btnEnrichHierarchy_Click(object sender, EventArgs e)
        {
            if (openFDEnrichHierarchy.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFDEnrichHierarchy.FileName);
                
                string[] stringSeparators = new string[] { "\r\n" };
                string[] hierarchyNodes = (sr.ReadToEnd()).Split(stringSeparators, StringSplitOptions.None);

                Hierarchy hier = contr.DeserilizeHierarchy(Constants.HierarchySource);

                foreach (var pair in hierarchyNodes)
                {
                    if (pair.Length != 0)
                    {
                        string[] combination = pair.Split(',');
                        hier.HierarchyPairs.Add(new string[] { combination[1], combination[0] });
                    }
                    
                }

                contr.SerilizeHierarchy(hier);
                sr.Close();
            }
        }
    }
}
