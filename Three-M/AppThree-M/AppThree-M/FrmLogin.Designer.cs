namespace AppThree_M
{
    partial class FrmLogin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.BtnSubmit = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.ribbonControl3 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.BtnExit = new DevExpress.XtraBars.BarButtonItem();
            this.BtnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.TxtPass = new DevExpress.XtraEditors.TextEdit();
            this.TxtUname = new DevExpress.XtraEditors.TextEdit();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.StyleFormLogin = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.LbID = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtUname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSubmit.Appearance.Options.UseFont = true;
            this.BtnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSubmit.Location = new System.Drawing.Point(222, 171);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(90, 31);
            this.BtnSubmit.TabIndex = 1;
            this.BtnSubmit.Text = "Submit";
            this.BtnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(128, 105);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(67, 20);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Username";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(128, 136);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(61, 20);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Password";
            // 
            // ribbonControl3
            // 
            this.ribbonControl3.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.ribbonControl3.AllowKeyTips = false;
            this.ribbonControl3.ButtonGroupsVertAlign = DevExpress.Utils.VertAlignment.Center;
            this.ribbonControl3.ColorScheme = DevExpress.XtraBars.Ribbon.RibbonControlColorScheme.DarkBlue;
            this.ribbonControl3.ExpandCollapseItem.Id = 0;
            this.ribbonControl3.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl3.ExpandCollapseItem,
            this.barButtonItem1,
            this.BtnExit});
            this.ribbonControl3.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl3.MaxItemId = 3;
            this.ribbonControl3.Name = "ribbonControl3";
            this.ribbonControl3.QuickToolbarItemLinks.Add(this.BtnExit);
            this.ribbonControl3.RibbonCaptionAlignment = DevExpress.XtraBars.Ribbon.RibbonCaptionAlignment.Center;
            this.ribbonControl3.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.MacOffice;
            this.ribbonControl3.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl3.ShowCategoryInCaption = false;
            this.ribbonControl3.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl3.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl3.Size = new System.Drawing.Size(686, 48);
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
            this.BtnExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnExit_ItemClick);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.Appearance.Options.UseFont = true;
            this.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancel.Location = new System.Drawing.Point(377, 171);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(90, 31);
            this.BtnCancel.TabIndex = 7;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // TxtPass
            // 
            this.TxtPass.Location = new System.Drawing.Point(222, 133);
            this.TxtPass.MenuManager = this.ribbonControl3;
            this.TxtPass.Name = "TxtPass";
            this.TxtPass.Properties.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPass.Properties.Appearance.Options.UseFont = true;
            this.TxtPass.Properties.MaxLength = 10;
            this.TxtPass.Properties.PasswordChar = '*';
            this.TxtPass.Properties.UseSystemPasswordChar = true;
            this.TxtPass.Properties.XlsxFormatString = "*";
            this.TxtPass.Size = new System.Drawing.Size(245, 26);
            this.TxtPass.TabIndex = 8;
            // 
            // TxtUname
            // 
            this.TxtUname.Location = new System.Drawing.Point(222, 102);
            this.TxtUname.MenuManager = this.ribbonControl3;
            this.TxtUname.Name = "TxtUname";
            this.TxtUname.Properties.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUname.Properties.Appearance.Options.UseFont = true;
            this.TxtUname.Properties.MaxLength = 10;
            this.TxtUname.Size = new System.Drawing.Size(245, 26);
            this.TxtUname.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 257);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // StyleFormLogin
            // 
            this.StyleFormLogin.LookAndFeel.SkinName = "The Asphalt World";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(309, 61);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(63, 22);
            this.labelControl3.TabIndex = 10;
            this.labelControl3.Text = "LOGIN";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(72, 269);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(132, 15);
            this.labelControl4.TabIndex = 15;
            this.labelControl4.Text = "CV. Mitra Muda Manggala";
            // 
            // LbID
            // 
            this.LbID.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbID.Appearance.Options.UseFont = true;
            this.LbID.Location = new System.Drawing.Point(650, 273);
            this.LbID.Name = "LbID";
            this.LbID.Size = new System.Drawing.Size(24, 20);
            this.LbID.TabIndex = 17;
            this.LbID.Text = "....";
            this.LbID.Visible = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 296);
            this.Controls.Add(this.LbID);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.TxtUname);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnSubmit);
            this.Controls.Add(this.ribbonControl3);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.TxtPass);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.labelControl2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CV Mitra Muda Manggala";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtUname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton BtnSubmit;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl3;
        private DevExpress.XtraEditors.SimpleButton BtnCancel;
        private DevExpress.XtraEditors.TextEdit TxtPass;
        private DevExpress.XtraEditors.TextEdit TxtUname;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem BtnExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel StyleFormLogin;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl LbID;
    }
}