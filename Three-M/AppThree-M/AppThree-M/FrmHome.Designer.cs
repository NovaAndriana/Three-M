namespace AppThree_M
{
    partial class FrmHome
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHome));
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.skinRibbonGalleryBarItem = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.employeesBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.customersBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.BtnMatrial = new DevExpress.XtraBars.BarButtonItem();
            this.BtnMachine = new DevExpress.XtraBars.BarButtonItem();
            this.BtnEmployee = new DevExpress.XtraBars.BarButtonItem();
            this.BtnCustomerSPK = new DevExpress.XtraBars.BarButtonItem();
            this.BtnProdactionReport = new DevExpress.XtraBars.BarButtonItem();
            this.BtnMatrialCost = new DevExpress.XtraBars.BarButtonItem();
            this.A = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.Lb_ID = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.TabHome_Employee = new DevExpress.XtraTab.XtraTabPage();
            this.TabHome_Machine = new DevExpress.XtraTab.XtraTabPage();
            this.TabHome_Matrial = new DevExpress.XtraTab.XtraTabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TabHome = new DevExpress.XtraTab.XtraTabControl();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            this.TabHome_Matrial.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabHome)).BeginInit();
            this.TabHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.BackColor = System.Drawing.Color.White;
            this.ribbonControl.ColorScheme = DevExpress.XtraBars.Ribbon.RibbonControlColorScheme.DarkBlue;
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.skinRibbonGalleryBarItem,
            this.employeesBarButtonItem,
            this.customersBarButtonItem,
            this.BtnMatrial,
            this.BtnMachine,
            this.BtnEmployee,
            this.BtnCustomerSPK,
            this.BtnProdactionReport,
            this.BtnMatrialCost,
            this.A,
            this.barButtonItem7,
            this.Lb_ID});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 59;
            this.ribbonControl.MdiMergeStyle = DevExpress.XtraBars.Ribbon.RibbonMdiMergeStyle.Always;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage});
            this.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.Size = new System.Drawing.Size(1054, 144);
            this.ribbonControl.StatusBar = this.ribbonStatusBar;
            this.ribbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // skinRibbonGalleryBarItem
            // 
            this.skinRibbonGalleryBarItem.Id = 14;
            this.skinRibbonGalleryBarItem.Name = "skinRibbonGalleryBarItem";
            // 
            // employeesBarButtonItem
            // 
            this.employeesBarButtonItem.Id = 48;
            this.employeesBarButtonItem.Name = "employeesBarButtonItem";
            // 
            // customersBarButtonItem
            // 
            this.customersBarButtonItem.Id = 49;
            this.customersBarButtonItem.Name = "customersBarButtonItem";
            // 
            // BtnMatrial
            // 
            this.BtnMatrial.Caption = "Matrial";
            this.BtnMatrial.Id = 50;
            this.BtnMatrial.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnMatrial.ImageOptions.Image")));
            this.BtnMatrial.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnMatrial.ImageOptions.LargeImage")));
            this.BtnMatrial.Name = "BtnMatrial";
            this.BtnMatrial.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnMatrial_ItemClick);
            // 
            // BtnMachine
            // 
            this.BtnMachine.Caption = "Machine";
            this.BtnMachine.Id = 51;
            this.BtnMachine.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnMachine.ImageOptions.Image")));
            this.BtnMachine.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnMachine.ImageOptions.LargeImage")));
            this.BtnMachine.Name = "BtnMachine";
            this.BtnMachine.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnMachine_ItemClick);
            // 
            // BtnEmployee
            // 
            this.BtnEmployee.Caption = "Employee";
            this.BtnEmployee.Id = 52;
            this.BtnEmployee.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnEmployee.ImageOptions.Image")));
            this.BtnEmployee.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnEmployee.ImageOptions.LargeImage")));
            this.BtnEmployee.Name = "BtnEmployee";
            this.BtnEmployee.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnEmployee_ItemClick);
            // 
            // BtnCustomerSPK
            // 
            this.BtnCustomerSPK.Caption = "Customer SPK";
            this.BtnCustomerSPK.Id = 53;
            this.BtnCustomerSPK.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnCustomerSPK.ImageOptions.Image")));
            this.BtnCustomerSPK.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnCustomerSPK.ImageOptions.LargeImage")));
            this.BtnCustomerSPK.Name = "BtnCustomerSPK";
            this.BtnCustomerSPK.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnCustomerSPK_ItemClick);
            // 
            // BtnProdactionReport
            // 
            this.BtnProdactionReport.Caption = "Prodaction Report";
            this.BtnProdactionReport.Id = 54;
            this.BtnProdactionReport.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnProdactionReport.ImageOptions.Image")));
            this.BtnProdactionReport.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnProdactionReport.ImageOptions.LargeImage")));
            this.BtnProdactionReport.Name = "BtnProdactionReport";
            this.BtnProdactionReport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnProdactionReport_ItemClick);
            // 
            // BtnMatrialCost
            // 
            this.BtnMatrialCost.Caption = "Matrial Cost";
            this.BtnMatrialCost.Id = 55;
            this.BtnMatrialCost.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnMatrialCost.ImageOptions.Image")));
            this.BtnMatrialCost.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnMatrialCost.ImageOptions.LargeImage")));
            this.BtnMatrialCost.Name = "BtnMatrialCost";
            this.BtnMatrialCost.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnMatrialCost_ItemClick);
            // 
            // A
            // 
            this.A.Caption = "Expense Report";
            this.A.Id = 56;
            this.A.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("A.ImageOptions.Image")));
            this.A.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("A.ImageOptions.LargeImage")));
            this.A.Name = "A";
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = "barButtonItem7";
            this.barButtonItem7.Id = 57;
            this.barButtonItem7.Name = "barButtonItem7";
            // 
            // Lb_ID
            // 
            this.Lb_ID.Caption = "...";
            this.Lb_ID.Id = 58;
            this.Lb_ID.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Lb_ID.ImageOptions.Image")));
            this.Lb_ID.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Lb_ID.ImageOptions.LargeImage")));
            this.Lb_ID.Name = "Lb_ID";
            // 
            // ribbonPage
            // 
            this.ribbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage.Image")));
            this.ribbonPage.Name = "ribbonPage";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnMatrial);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnMachine);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnEmployee);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnCustomerSPK);
            this.ribbonPageGroup1.ItemLinks.Add(this.A);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnProdactionReport);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnMatrialCost);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.Lb_ID);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 575);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbonControl;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1054, 24);
            this.ribbonStatusBar.Click += new System.EventHandler(this.ribbonStatusBar_Click);
            // 
            // TabHome_Employee
            // 
            this.TabHome_Employee.Image = ((System.Drawing.Image)(resources.GetObject("TabHome_Employee.Image")));
            this.TabHome_Employee.Name = "TabHome_Employee";
            this.TabHome_Employee.PageVisible = false;
            this.TabHome_Employee.Size = new System.Drawing.Size(1046, 400);
            this.TabHome_Employee.Text = "Employee";
            // 
            // TabHome_Machine
            // 
            this.TabHome_Machine.Image = ((System.Drawing.Image)(resources.GetObject("TabHome_Machine.Image")));
            this.TabHome_Machine.Name = "TabHome_Machine";
            this.TabHome_Machine.PageVisible = false;
            this.TabHome_Machine.Size = new System.Drawing.Size(1046, 400);
            this.TabHome_Machine.Text = "Machine";
            // 
            // TabHome_Matrial
            // 
            this.TabHome_Matrial.Controls.Add(this.tableLayoutPanel2);
            this.TabHome_Matrial.Controls.Add(this.tableLayoutPanel1);
            this.TabHome_Matrial.Image = ((System.Drawing.Image)(resources.GetObject("TabHome_Matrial.Image")));
            this.TabHome_Matrial.Name = "TabHome_Matrial";
            this.TabHome_Matrial.PageVisible = false;
            this.TabHome_Matrial.Size = new System.Drawing.Size(1046, 400);
            this.TabHome_Matrial.Text = "Matrial";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 154);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1046, 246);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1040, 240);
            this.dataGridView1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 266F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 407F));
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 232F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1046, 154);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // TabHome
            // 
            this.TabHome.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPageHeaders;
            this.TabHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabHome.Location = new System.Drawing.Point(0, 144);
            this.TabHome.Name = "TabHome";
            this.TabHome.SelectedTabPage = this.TabHome_Matrial;
            this.TabHome.Size = new System.Drawing.Size(1054, 431);
            this.TabHome.TabIndex = 4;
            this.TabHome.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.TabHome_Matrial,
            this.TabHome_Machine,
            this.TabHome_Employee});
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "The Asphalt World";
            // 
            // FrmHome
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 599);
            this.Controls.Add(this.TabHome);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbonControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "FrmHome";
            this.Ribbon = this.ribbonControl;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "CV. Mitra Muda Manggala";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            this.TabHome_Matrial.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabHome)).EndInit();
            this.TabHome.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem skinRibbonGalleryBarItem;
        private DevExpress.XtraBars.BarButtonItem employeesBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem customersBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem BtnMatrial;
        private DevExpress.XtraBars.BarButtonItem BtnMachine;
        private DevExpress.XtraBars.BarButtonItem BtnEmployee;
        private DevExpress.XtraBars.BarButtonItem BtnCustomerSPK;
        private DevExpress.XtraBars.BarButtonItem BtnProdactionReport;
        private DevExpress.XtraBars.BarButtonItem BtnMatrialCost;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem A;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private DevExpress.XtraTab.XtraTabPage TabHome_Employee;
        private DevExpress.XtraTab.XtraTabPage TabHome_Machine;
        private DevExpress.XtraTab.XtraTabPage TabHome_Matrial;
        private DevExpress.XtraTab.XtraTabControl TabHome;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraBars.BarButtonItem Lb_ID;
    }
}