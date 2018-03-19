namespace TDM
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnConvInitKPI = new System.Windows.Forms.Button();
            this.tBInitKPIConvSrc = new System.Windows.Forms.TextBox();
            this.tBInitKPIConvRes = new System.Windows.Forms.TextBox();
            this.btnConvInitETF = new System.Windows.Forms.Button();
            this.tBConvInitETFSrc = new System.Windows.Forms.TextBox();
            this.tBConvInitETFRes = new System.Windows.Forms.TextBox();
            this.btnConvLengTIncMx = new System.Windows.Forms.Button();
            this.tBConvLongTIncMxSrc = new System.Windows.Forms.TextBox();
            this.tBConvLongTMxRes = new System.Windows.Forms.TextBox();
            this.btnConvShortIncTMx = new System.Windows.Forms.Button();
            this.tBConvShortTIncMxSrc = new System.Windows.Forms.TextBox();
            this.tBConvShortTIncMxRes = new System.Windows.Forms.TextBox();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnBuildHierarchy = new System.Windows.Forms.Button();
            this.tabPTDMDataInit = new System.Windows.Forms.TabPage();
            this.tabPSAPData = new System.Windows.Forms.TabPage();
            this.bConvSAPDepts = new System.Windows.Forms.Button();
            this.tBConvSAPDeptsSrc = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.tabPTDMDataDaily = new System.Windows.Forms.TabPage();
            this.tBConvDailyMexBondRes = new System.Windows.Forms.TextBox();
            this.tBConvDailyMexBondSrc = new System.Windows.Forms.TextBox();
            this.btnConvDailyMexBonds = new System.Windows.Forms.Button();
            this.btnConvDailyKPI = new System.Windows.Forms.Button();
            this.tBConvDailyKPISrc = new System.Windows.Forms.TextBox();
            this.tBConvDailyKPIRes = new System.Windows.Forms.TextBox();
            this.btnConvDailyETF = new System.Windows.Forms.Button();
            this.tBConvDailyETFSrc = new System.Windows.Forms.TextBox();
            this.tBConvDailyETFRes = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.tabControlMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPTDMDataInit.SuspendLayout();
            this.tabPSAPData.SuspendLayout();
            this.tabPTDMDataDaily.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConvInitKPI
            // 
            this.btnConvInitKPI.Location = new System.Drawing.Point(6, 6);
            this.btnConvInitKPI.Name = "btnConvInitKPI";
            this.btnConvInitKPI.Size = new System.Drawing.Size(159, 40);
            this.btnConvInitKPI.TabIndex = 0;
            this.btnConvInitKPI.Text = "Convert KPI";
            this.btnConvInitKPI.UseVisualStyleBackColor = true;
            this.btnConvInitKPI.Click += new System.EventHandler(this.btnConvInitKPI_Click);
            // 
            // tBInitKPIConvSrc
            // 
            this.tBInitKPIConvSrc.Location = new System.Drawing.Point(6, 52);
            this.tBInitKPIConvSrc.Name = "tBInitKPIConvSrc";
            this.tBInitKPIConvSrc.Size = new System.Drawing.Size(767, 22);
            this.tBInitKPIConvSrc.TabIndex = 1;
            this.tBInitKPIConvSrc.Text = "C:\\Users\\dmitr\\OneDrive\\02. LeverX\\01. TDM\\Tecnológico de Monterrey Value Prototy" +
    "ping\\DATA\\Economic KPIs";
            // 
            // tBInitKPIConvRes
            // 
            this.tBInitKPIConvRes.Location = new System.Drawing.Point(6, 80);
            this.tBInitKPIConvRes.Name = "tBInitKPIConvRes";
            this.tBInitKPIConvRes.Size = new System.Drawing.Size(767, 22);
            this.tBInitKPIConvRes.TabIndex = 2;
            this.tBInitKPIConvRes.Text = "C:\\Users\\dmitr\\OneDrive\\02. LeverX\\01. TDM\\KPI_data.csv";
            // 
            // btnConvInitETF
            // 
            this.btnConvInitETF.Location = new System.Drawing.Point(6, 108);
            this.btnConvInitETF.Name = "btnConvInitETF";
            this.btnConvInitETF.Size = new System.Drawing.Size(159, 36);
            this.btnConvInitETF.TabIndex = 3;
            this.btnConvInitETF.Text = "Convert ETF";
            this.btnConvInitETF.UseVisualStyleBackColor = true;
            this.btnConvInitETF.Click += new System.EventHandler(this.btnConvInitETF_Click);
            // 
            // tBConvInitETFSrc
            // 
            this.tBConvInitETFSrc.Location = new System.Drawing.Point(3, 150);
            this.tBConvInitETFSrc.Name = "tBConvInitETFSrc";
            this.tBConvInitETFSrc.Size = new System.Drawing.Size(767, 22);
            this.tBConvInitETFSrc.TabIndex = 4;
            this.tBConvInitETFSrc.Text = "C:\\Users\\dmitr\\OneDrive\\02. LeverX\\01. TDM\\Tecnológico de Monterrey Value Prototy" +
    "ping\\DATA\\ETFs";
            // 
            // tBConvInitETFRes
            // 
            this.tBConvInitETFRes.Location = new System.Drawing.Point(6, 178);
            this.tBConvInitETFRes.Name = "tBConvInitETFRes";
            this.tBConvInitETFRes.Size = new System.Drawing.Size(767, 22);
            this.tBConvInitETFRes.TabIndex = 5;
            this.tBConvInitETFRes.Text = "C:\\Users\\dmitr\\OneDrive\\02. LeverX\\01. TDM\\ETF_cons.csv";
            // 
            // btnConvLengTIncMx
            // 
            this.btnConvLengTIncMx.Location = new System.Drawing.Point(6, 206);
            this.btnConvLengTIncMx.Name = "btnConvLengTIncMx";
            this.btnConvLengTIncMx.Size = new System.Drawing.Size(240, 39);
            this.btnConvLengTIncMx.TabIndex = 6;
            this.btnConvLengTIncMx.Text = "Convert Long Term Income MX";
            this.btnConvLengTIncMx.UseVisualStyleBackColor = true;
            this.btnConvLengTIncMx.Click += new System.EventHandler(this.btnConvLengTIncMx_Click);
            // 
            // tBConvLongTIncMxSrc
            // 
            this.tBConvLongTIncMxSrc.Location = new System.Drawing.Point(6, 251);
            this.tBConvLongTIncMxSrc.Name = "tBConvLongTIncMxSrc";
            this.tBConvLongTIncMxSrc.Size = new System.Drawing.Size(767, 22);
            this.tBConvLongTIncMxSrc.TabIndex = 7;
            this.tBConvLongTIncMxSrc.Text = "C:\\Users\\dmitr\\OneDrive\\02. LeverX\\01. TDM\\Tecnológico de Monterrey Value Prototy" +
    "ping\\DATA\\Long Term Fixed Income MX v2.csv";
            // 
            // tBConvLongTMxRes
            // 
            this.tBConvLongTMxRes.Location = new System.Drawing.Point(6, 279);
            this.tBConvLongTMxRes.Name = "tBConvLongTMxRes";
            this.tBConvLongTMxRes.Size = new System.Drawing.Size(767, 22);
            this.tBConvLongTMxRes.TabIndex = 8;
            this.tBConvLongTMxRes.Text = "C:\\Users\\dmitr\\OneDrive\\02. LeverX\\01. TDM\\Long_term_inc.csv";
            // 
            // btnConvShortIncTMx
            // 
            this.btnConvShortIncTMx.Location = new System.Drawing.Point(6, 307);
            this.btnConvShortIncTMx.Name = "btnConvShortIncTMx";
            this.btnConvShortIncTMx.Size = new System.Drawing.Size(240, 38);
            this.btnConvShortIncTMx.TabIndex = 9;
            this.btnConvShortIncTMx.Text = "Convert Short Term Income MX";
            this.btnConvShortIncTMx.UseVisualStyleBackColor = true;
            this.btnConvShortIncTMx.Click += new System.EventHandler(this.btnConvShortIncTMx_Click);
            // 
            // tBConvShortTIncMxSrc
            // 
            this.tBConvShortTIncMxSrc.Location = new System.Drawing.Point(6, 351);
            this.tBConvShortTIncMxSrc.Name = "tBConvShortTIncMxSrc";
            this.tBConvShortTIncMxSrc.Size = new System.Drawing.Size(767, 22);
            this.tBConvShortTIncMxSrc.TabIndex = 10;
            this.tBConvShortTIncMxSrc.Text = "C:\\Users\\dmitr\\OneDrive\\02. LeverX\\01. TDM\\Tecnológico de Monterrey Value Prototy" +
    "ping\\DATA\\Short Term Fixed Income MX.csv";
            // 
            // tBConvShortTIncMxRes
            // 
            this.tBConvShortTIncMxRes.Location = new System.Drawing.Point(6, 379);
            this.tBConvShortTIncMxRes.Name = "tBConvShortTIncMxRes";
            this.tBConvShortTIncMxRes.Size = new System.Drawing.Size(767, 22);
            this.tBConvShortTIncMxRes.TabIndex = 11;
            this.tBConvShortTIncMxRes.Text = "C:\\Users\\dmitr\\OneDrive\\02. LeverX\\01. TDM\\Short_term_inc.csv";
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPage1);
            this.tabControlMain.Controls.Add(this.tabPTDMDataInit);
            this.tabControlMain.Controls.Add(this.tabPSAPData);
            this.tabControlMain.Controls.Add(this.tabPTDMDataDaily);
            this.tabControlMain.Location = new System.Drawing.Point(12, 12);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(902, 515);
            this.tabControlMain.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnCheck);
            this.tabPage1.Controls.Add(this.btnBuildHierarchy);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(894, 486);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Data Model CSV Builder";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnBuildHierarchy
            // 
            this.btnBuildHierarchy.Location = new System.Drawing.Point(19, 14);
            this.btnBuildHierarchy.Name = "btnBuildHierarchy";
            this.btnBuildHierarchy.Size = new System.Drawing.Size(172, 39);
            this.btnBuildHierarchy.TabIndex = 0;
            this.btnBuildHierarchy.Text = "Build Hierarchy Tables";
            this.btnBuildHierarchy.UseVisualStyleBackColor = true;
            this.btnBuildHierarchy.Click += new System.EventHandler(this.btnBuildHierarchy_Click);
            // 
            // tabPTDMDataInit
            // 
            this.tabPTDMDataInit.Controls.Add(this.btnConvInitKPI);
            this.tabPTDMDataInit.Controls.Add(this.tBConvShortTIncMxRes);
            this.tabPTDMDataInit.Controls.Add(this.tBInitKPIConvSrc);
            this.tabPTDMDataInit.Controls.Add(this.tBConvShortTIncMxSrc);
            this.tabPTDMDataInit.Controls.Add(this.tBInitKPIConvRes);
            this.tabPTDMDataInit.Controls.Add(this.btnConvShortIncTMx);
            this.tabPTDMDataInit.Controls.Add(this.btnConvInitETF);
            this.tabPTDMDataInit.Controls.Add(this.tBConvLongTMxRes);
            this.tabPTDMDataInit.Controls.Add(this.tBConvInitETFSrc);
            this.tabPTDMDataInit.Controls.Add(this.tBConvLongTIncMxSrc);
            this.tabPTDMDataInit.Controls.Add(this.tBConvInitETFRes);
            this.tabPTDMDataInit.Controls.Add(this.btnConvLengTIncMx);
            this.tabPTDMDataInit.Location = new System.Drawing.Point(4, 25);
            this.tabPTDMDataInit.Name = "tabPTDMDataInit";
            this.tabPTDMDataInit.Padding = new System.Windows.Forms.Padding(3);
            this.tabPTDMDataInit.Size = new System.Drawing.Size(894, 486);
            this.tabPTDMDataInit.TabIndex = 0;
            this.tabPTDMDataInit.Text = "Initial TDM Data Conv";
            this.tabPTDMDataInit.UseVisualStyleBackColor = true;
            // 
            // tabPSAPData
            // 
            this.tabPSAPData.Controls.Add(this.bConvSAPDepts);
            this.tabPSAPData.Controls.Add(this.tBConvSAPDeptsSrc);
            this.tabPSAPData.Controls.Add(this.textBox10);
            this.tabPSAPData.Location = new System.Drawing.Point(4, 25);
            this.tabPSAPData.Name = "tabPSAPData";
            this.tabPSAPData.Padding = new System.Windows.Forms.Padding(3);
            this.tabPSAPData.Size = new System.Drawing.Size(894, 486);
            this.tabPSAPData.TabIndex = 1;
            this.tabPSAPData.Text = "SAP addit. Data";
            this.tabPSAPData.UseVisualStyleBackColor = true;
            // 
            // bConvSAPDepts
            // 
            this.bConvSAPDepts.Location = new System.Drawing.Point(6, 6);
            this.bConvSAPDepts.Name = "bConvSAPDepts";
            this.bConvSAPDepts.Size = new System.Drawing.Size(140, 40);
            this.bConvSAPDepts.TabIndex = 3;
            this.bConvSAPDepts.Text = "Depts 2008 2017";
            this.bConvSAPDepts.UseVisualStyleBackColor = true;
            this.bConvSAPDepts.Click += new System.EventHandler(this.bConvSAPDepts_Click);
            // 
            // tBConvSAPDeptsSrc
            // 
            this.tBConvSAPDeptsSrc.Location = new System.Drawing.Point(6, 52);
            this.tBConvSAPDeptsSrc.Name = "tBConvSAPDeptsSrc";
            this.tBConvSAPDeptsSrc.Size = new System.Drawing.Size(832, 22);
            this.tBConvSAPDeptsSrc.TabIndex = 4;
            this.tBConvSAPDeptsSrc.Text = "C:\\Users\\dmitr\\OneDrive\\02. LeverX\\01. TDM\\Tecnológico de Monterrey Value Prototy" +
    "ping\\DATA\\SAP Data\\dept_2008_2017.csv";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(6, 80);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(832, 22);
            this.textBox10.TabIndex = 5;
            this.textBox10.Text = "C:\\Users\\dmitr\\OneDrive\\02. LeverX\\01. TDM\\Tecnológico de Monterrey Value Prototy" +
    "ping\\DATA\\SAP Data\\dept_2008_2017_conv.csv";
            // 
            // tabPTDMDataDaily
            // 
            this.tabPTDMDataDaily.Controls.Add(this.tBConvDailyMexBondRes);
            this.tabPTDMDataDaily.Controls.Add(this.tBConvDailyMexBondSrc);
            this.tabPTDMDataDaily.Controls.Add(this.btnConvDailyMexBonds);
            this.tabPTDMDataDaily.Controls.Add(this.btnConvDailyKPI);
            this.tabPTDMDataDaily.Controls.Add(this.tBConvDailyKPISrc);
            this.tabPTDMDataDaily.Controls.Add(this.tBConvDailyKPIRes);
            this.tabPTDMDataDaily.Controls.Add(this.btnConvDailyETF);
            this.tabPTDMDataDaily.Controls.Add(this.tBConvDailyETFSrc);
            this.tabPTDMDataDaily.Controls.Add(this.tBConvDailyETFRes);
            this.tabPTDMDataDaily.Location = new System.Drawing.Point(4, 25);
            this.tabPTDMDataDaily.Name = "tabPTDMDataDaily";
            this.tabPTDMDataDaily.Padding = new System.Windows.Forms.Padding(3);
            this.tabPTDMDataDaily.Size = new System.Drawing.Size(894, 486);
            this.tabPTDMDataDaily.TabIndex = 2;
            this.tabPTDMDataDaily.Text = "TDM Daily Data";
            this.tabPTDMDataDaily.UseVisualStyleBackColor = true;
            // 
            // tBConvDailyMexBondRes
            // 
            this.tBConvDailyMexBondRes.Location = new System.Drawing.Point(6, 284);
            this.tBConvDailyMexBondRes.Name = "tBConvDailyMexBondRes";
            this.tBConvDailyMexBondRes.Size = new System.Drawing.Size(767, 22);
            this.tBConvDailyMexBondRes.TabIndex = 11;
            this.tBConvDailyMexBondRes.Text = "C:\\Users\\dmitr\\OneDrive\\02. LeverX\\01. TDM\\Tecnológico de Monterrey Value Prototy" +
    "ping\\DAILY_DATA\\daily_mex_bond_conv.csv";
            // 
            // tBConvDailyMexBondSrc
            // 
            this.tBConvDailyMexBondSrc.Location = new System.Drawing.Point(6, 256);
            this.tBConvDailyMexBondSrc.Name = "tBConvDailyMexBondSrc";
            this.tBConvDailyMexBondSrc.Size = new System.Drawing.Size(767, 22);
            this.tBConvDailyMexBondSrc.TabIndex = 10;
            this.tBConvDailyMexBondSrc.Text = "C:\\Users\\dmitr\\OneDrive\\02. LeverX\\01. TDM\\Tecnológico de Monterrey Value Prototy" +
    "ping\\DAILY_DATA\\Mexican Bonds";
            // 
            // btnConvDailyMexBonds
            // 
            this.btnConvDailyMexBonds.Location = new System.Drawing.Point(6, 210);
            this.btnConvDailyMexBonds.Name = "btnConvDailyMexBonds";
            this.btnConvDailyMexBonds.Size = new System.Drawing.Size(215, 40);
            this.btnConvDailyMexBonds.TabIndex = 9;
            this.btnConvDailyMexBonds.Text = "Convert Daily Mex Bonds";
            this.btnConvDailyMexBonds.UseVisualStyleBackColor = true;
            this.btnConvDailyMexBonds.Click += new System.EventHandler(this.btnConvDailyMexBonds_Click);
            // 
            // btnConvDailyKPI
            // 
            this.btnConvDailyKPI.Location = new System.Drawing.Point(6, 108);
            this.btnConvDailyKPI.Name = "btnConvDailyKPI";
            this.btnConvDailyKPI.Size = new System.Drawing.Size(215, 40);
            this.btnConvDailyKPI.TabIndex = 6;
            this.btnConvDailyKPI.Text = "Convert Daily KPIs";
            this.btnConvDailyKPI.UseVisualStyleBackColor = true;
            this.btnConvDailyKPI.Click += new System.EventHandler(this.btnConvDailyKPI_Click);
            // 
            // tBConvDailyKPISrc
            // 
            this.tBConvDailyKPISrc.Location = new System.Drawing.Point(6, 154);
            this.tBConvDailyKPISrc.Name = "tBConvDailyKPISrc";
            this.tBConvDailyKPISrc.Size = new System.Drawing.Size(767, 22);
            this.tBConvDailyKPISrc.TabIndex = 7;
            this.tBConvDailyKPISrc.Text = "C:\\Users\\dmitr\\OneDrive\\02. LeverX\\01. TDM\\Tecnológico de Monterrey Value Prototy" +
    "ping\\DAILY_DATA\\KPIs\\!totals.csv";
            // 
            // tBConvDailyKPIRes
            // 
            this.tBConvDailyKPIRes.Location = new System.Drawing.Point(6, 182);
            this.tBConvDailyKPIRes.Name = "tBConvDailyKPIRes";
            this.tBConvDailyKPIRes.Size = new System.Drawing.Size(767, 22);
            this.tBConvDailyKPIRes.TabIndex = 8;
            this.tBConvDailyKPIRes.Text = "C:\\Users\\dmitr\\OneDrive\\02. LeverX\\01. TDM\\Tecnológico de Monterrey Value Prototy" +
    "ping\\DAILY_DATA\\daily_kpi_conv.csv";
            // 
            // btnConvDailyETF
            // 
            this.btnConvDailyETF.Location = new System.Drawing.Point(6, 6);
            this.btnConvDailyETF.Name = "btnConvDailyETF";
            this.btnConvDailyETF.Size = new System.Drawing.Size(215, 40);
            this.btnConvDailyETF.TabIndex = 3;
            this.btnConvDailyETF.Text = "Convert Daily ETFs";
            this.btnConvDailyETF.UseVisualStyleBackColor = true;
            this.btnConvDailyETF.Click += new System.EventHandler(this.btnConvDailyETF_Click);
            // 
            // tBConvDailyETFSrc
            // 
            this.tBConvDailyETFSrc.Location = new System.Drawing.Point(6, 52);
            this.tBConvDailyETFSrc.Name = "tBConvDailyETFSrc";
            this.tBConvDailyETFSrc.Size = new System.Drawing.Size(767, 22);
            this.tBConvDailyETFSrc.TabIndex = 4;
            this.tBConvDailyETFSrc.Text = "C:\\Users\\dmitr\\OneDrive\\02. LeverX\\01. TDM\\Tecnológico de Monterrey Value Prototy" +
    "ping\\DAILY_DATA\\ETFs";
            // 
            // tBConvDailyETFRes
            // 
            this.tBConvDailyETFRes.Location = new System.Drawing.Point(6, 80);
            this.tBConvDailyETFRes.Name = "tBConvDailyETFRes";
            this.tBConvDailyETFRes.Size = new System.Drawing.Size(767, 22);
            this.tBConvDailyETFRes.TabIndex = 5;
            this.tBConvDailyETFRes.Text = "C:\\Users\\dmitr\\OneDrive\\02. LeverX\\01. TDM\\Tecnológico de Monterrey Value Prototy" +
    "ping\\DAILY_DATA\\daily_etf_conv.csv";
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(19, 425);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(98, 48);
            this.btnCheck.TabIndex = 1;
            this.btnCheck.Text = "check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 566);
            this.Controls.Add(this.tabControlMain);
            this.Name = "FormMain";
            this.Text = "TDM PoC";
            this.tabControlMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPTDMDataInit.ResumeLayout(false);
            this.tabPTDMDataInit.PerformLayout();
            this.tabPSAPData.ResumeLayout(false);
            this.tabPSAPData.PerformLayout();
            this.tabPTDMDataDaily.ResumeLayout(false);
            this.tabPTDMDataDaily.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConvInitKPI;
        private System.Windows.Forms.TextBox tBInitKPIConvSrc;
        private System.Windows.Forms.TextBox tBInitKPIConvRes;
        private System.Windows.Forms.Button btnConvInitETF;
        private System.Windows.Forms.TextBox tBConvInitETFSrc;
        private System.Windows.Forms.TextBox tBConvInitETFRes;
        private System.Windows.Forms.Button btnConvLengTIncMx;
        private System.Windows.Forms.TextBox tBConvLongTIncMxSrc;
        private System.Windows.Forms.TextBox tBConvLongTMxRes;
        private System.Windows.Forms.Button btnConvShortIncTMx;
        private System.Windows.Forms.TextBox tBConvShortTIncMxSrc;
        private System.Windows.Forms.TextBox tBConvShortTIncMxRes;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPTDMDataInit;
        private System.Windows.Forms.TabPage tabPSAPData;
        private System.Windows.Forms.Button bConvSAPDepts;
        private System.Windows.Forms.TextBox tBConvSAPDeptsSrc;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TabPage tabPTDMDataDaily;
        private System.Windows.Forms.Button btnConvDailyETF;
        private System.Windows.Forms.TextBox tBConvDailyETFSrc;
        private System.Windows.Forms.TextBox tBConvDailyETFRes;
        private System.Windows.Forms.Button btnConvDailyKPI;
        private System.Windows.Forms.TextBox tBConvDailyKPISrc;
        private System.Windows.Forms.TextBox tBConvDailyKPIRes;
        private System.Windows.Forms.TextBox tBConvDailyMexBondRes;
        private System.Windows.Forms.TextBox tBConvDailyMexBondSrc;
        private System.Windows.Forms.Button btnConvDailyMexBonds;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnBuildHierarchy;
        private System.Windows.Forms.Button btnCheck;
    }
}

