namespace AppThree_M
{
    partial class FrmRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegister));
            this.TxtID = new DevExpress.XtraEditors.TextEdit();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.BtnExit = new DevExpress.XtraBars.BarButtonItem();
            this.TxtPass = new DevExpress.XtraEditors.TextEdit();
            this.BtnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.BtnSubmit = new DevExpress.XtraEditors.SimpleButton();
            this.defaultLookAndFeel3 = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            ((System.ComponentModel.ISupportInitialize)(this.TxtID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPass.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtID
            // 
            this.TxtID.Location = new System.Drawing.Point(127, 117);
            this.TxtID.MenuManager = this.ribbonControl1;
            this.TxtID.Name = "TxtID";
            this.TxtID.Properties.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtID.Properties.Appearance.Options.UseFont = true;
            this.TxtID.Properties.MaxLength = 10;
            this.TxtID.Size = new System.Drawing.Size(245, 26);
            this.TxtID.TabIndex = 16;
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.ribbonControl1.AllowKeyTips = false;
            this.ribbonControl1.ButtonGroupsVertAlign = DevExpress.Utils.VertAlignment.Center;
            this.ribbonControl1.ColorScheme = DevExpress.XtraBars.Ribbon.RibbonControlColorScheme.DarkBlue;
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.barButtonItem1,
            this.BtnExit});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 3;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.QuickToolbarItemLinks.Add(this.BtnExit);
            this.ribbonControl1.RibbonCaptionAlignment = DevExpress.XtraBars.Ribbon.RibbonCaptionAlignment.Center;
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.MacOffice;
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowCategoryInCaption = false;
            this.ribbonControl1.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.Size = new System.Drawing.Size(643, 47);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Exit";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // BtnExit
            // 
            this.BtnExit.Caption = "Exit";
            this.BtnExit.Id = 2;
            this.BtnExit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnExit.ImageOptions.Image")));
            this.BtnExit.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnExit.ImageOptions.LargeImage")));
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // TxtPass
            // 
            this.TxtPass.Location = new System.Drawing.Point(127, 148);
            this.TxtPass.MenuManager = this.ribbonControl1;
            this.TxtPass.Name = "TxtPass";
            this.TxtPass.Properties.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPass.Properties.Appearance.Options.UseFont = true;
            this.TxtPass.Properties.MaxLength = 10;
            this.TxtPass.Properties.PasswordChar = '*';
            this.TxtPass.Properties.UseSystemPasswordChar = true;
            this.TxtPass.Properties.XlsxFormatString = "*";
            this.TxtPass.Size = new System.Drawing.Size(245, 26);
            this.TxtPass.TabIndex = 15;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.Appearance.Options.UseFont = true;
            this.BtnCancel.Location = new System.Drawing.Point(282, 186);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(90, 31);
            this.BtnCancel.TabIndex = 14;
            this.BtnCancel.Text = "Cancel";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(33, 151);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(67, 20);
            this.labelControl2.TabIndex = 13;
            this.labelControl2.Text = "Username";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(33, 120);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(13, 20);
            this.labelControl1.TabIndex = 12;
            this.labelControl1.Text = "ID";
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSubmit.Appearance.Options.UseFont = true;
            this.BtnSubmit.Location = new System.Drawing.Point(127, 186);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(90, 31);
            this.BtnSubmit.TabIndex = 11;
            this.BtnSubmit.Text = "Submit";
            this.BtnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // defaultLookAndFeel3
            // 
            this.defaultLookAndFeel3.LookAndFeel.SkinName = "Sharp Plus";
            // 
            // FrmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 293);
            this.Controls.Add(this.TxtID);
            this.Controls.Add(this.TxtPass);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.ribbonControl1);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.BtnSubmit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRegister";
            this.Text = "FrmRegister";
            this.Load += new System.EventHandler(this.FrmRegister_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TxtID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPass.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit TxtID;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem BtnExit;
        private DevExpress.XtraEditors.TextEdit TxtPass;
        private DevExpress.XtraEditors.SimpleButton BtnCancel;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton BtnSubmit;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel3;
    }
}