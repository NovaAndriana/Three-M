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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegister));
            this.TxtID = new DevExpress.XtraEditors.TextEdit();
            this.ribbonControl2 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.BtnExit = new DevExpress.XtraBars.BarButtonItem();
            this.TxtUID = new DevExpress.XtraEditors.TextEdit();
            this.BtnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.BtnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.TxtSalt = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.TxtConfirmPass = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.CmdUserType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.StyleFormRegister = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.TxtID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtUID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSalt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtConfirmPass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmdUserType.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtID
            // 
            this.TxtID.Cursor = System.Windows.Forms.Cursors.No;
            this.TxtID.Enabled = false;
            this.TxtID.Location = new System.Drawing.Point(107, 53);
            this.TxtID.MenuManager = this.ribbonControl2;
            this.TxtID.Name = "TxtID";
            this.TxtID.Properties.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtID.Properties.Appearance.Options.UseFont = true;
            this.TxtID.Properties.MaxLength = 10;
            this.TxtID.Size = new System.Drawing.Size(245, 26);
            this.TxtID.TabIndex = 16;
            // 
            // ribbonControl2
            // 
            this.ribbonControl2.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.ribbonControl2.AllowKeyTips = false;
            this.ribbonControl2.ButtonGroupsVertAlign = DevExpress.Utils.VertAlignment.Center;
            this.ribbonControl2.ColorScheme = DevExpress.XtraBars.Ribbon.RibbonControlColorScheme.DarkBlue;
            this.ribbonControl2.ExpandCollapseItem.Id = 0;
            this.ribbonControl2.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl2.ExpandCollapseItem,
            this.barButtonItem1,
            this.BtnExit});
            this.ribbonControl2.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl2.MaxItemId = 3;
            this.ribbonControl2.Name = "ribbonControl2";
            this.ribbonControl2.QuickToolbarItemLinks.Add(this.BtnExit);
            this.ribbonControl2.RibbonCaptionAlignment = DevExpress.XtraBars.Ribbon.RibbonCaptionAlignment.Center;
            this.ribbonControl2.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.MacOffice;
            this.ribbonControl2.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl2.ShowCategoryInCaption = false;
            this.ribbonControl2.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl2.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl2.Size = new System.Drawing.Size(389, 48);
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
            // TxtUID
            // 
            this.TxtUID.Location = new System.Drawing.Point(107, 84);
            this.TxtUID.MenuManager = this.ribbonControl2;
            this.TxtUID.Name = "TxtUID";
            this.TxtUID.Properties.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUID.Properties.Appearance.Options.UseFont = true;
            this.TxtUID.Properties.MaxLength = 10;
            this.TxtUID.Size = new System.Drawing.Size(245, 26);
            this.TxtUID.TabIndex = 15;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.Appearance.Options.UseFont = true;
            this.BtnCancel.Location = new System.Drawing.Point(262, 219);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(90, 31);
            this.BtnCancel.TabIndex = 14;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(13, 87);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(67, 20);
            this.labelControl2.TabIndex = 13;
            this.labelControl2.Text = "Username";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(13, 56);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(13, 20);
            this.labelControl1.TabIndex = 12;
            this.labelControl1.Text = "ID";
            // 
            // BtnAdd
            // 
            this.BtnAdd.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.Appearance.Options.UseFont = true;
            this.BtnAdd.Location = new System.Drawing.Point(107, 219);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(90, 31);
            this.BtnAdd.TabIndex = 11;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // TxtSalt
            // 
            this.TxtSalt.Location = new System.Drawing.Point(107, 149);
            this.TxtSalt.MenuManager = this.ribbonControl2;
            this.TxtSalt.Name = "TxtSalt";
            this.TxtSalt.Properties.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSalt.Properties.Appearance.Options.UseFont = true;
            this.TxtSalt.Properties.MaxLength = 10;
            this.TxtSalt.Properties.PasswordChar = '*';
            this.TxtSalt.Properties.UseSystemPasswordChar = true;
            this.TxtSalt.Properties.XlsxFormatString = "*";
            this.TxtSalt.Size = new System.Drawing.Size(245, 26);
            this.TxtSalt.TabIndex = 19;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(13, 152);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(61, 20);
            this.labelControl3.TabIndex = 18;
            this.labelControl3.Text = "Password";
            // 
            // TxtConfirmPass
            // 
            this.TxtConfirmPass.Location = new System.Drawing.Point(107, 181);
            this.TxtConfirmPass.MenuManager = this.ribbonControl2;
            this.TxtConfirmPass.Name = "TxtConfirmPass";
            this.TxtConfirmPass.Properties.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtConfirmPass.Properties.Appearance.Options.UseFont = true;
            this.TxtConfirmPass.Properties.MaxLength = 10;
            this.TxtConfirmPass.Properties.PasswordChar = '*';
            this.TxtConfirmPass.Properties.UseSystemPasswordChar = true;
            this.TxtConfirmPass.Properties.XlsxFormatString = "*";
            this.TxtConfirmPass.Size = new System.Drawing.Size(245, 26);
            this.TxtConfirmPass.TabIndex = 22;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(13, 184);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(87, 20);
            this.labelControl4.TabIndex = 21;
            this.labelControl4.Text = "Confirm Pass";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(13, 122);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(67, 20);
            this.labelControl5.TabIndex = 24;
            this.labelControl5.Text = "User Type";
            // 
            // CmdUserType
            // 
            this.CmdUserType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CmdUserType.Location = new System.Drawing.Point(107, 116);
            this.CmdUserType.MenuManager = this.ribbonControl2;
            this.CmdUserType.Name = "CmdUserType";
            this.CmdUserType.Properties.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdUserType.Properties.Appearance.Options.UseFont = true;
            this.CmdUserType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CmdUserType.Properties.Items.AddRange(new object[] {
            "Administrator",
            "Operator"});
            this.CmdUserType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.CmdUserType.Size = new System.Drawing.Size(245, 26);
            this.CmdUserType.TabIndex = 26;
            // 
            // StyleFormRegister
            // 
            this.StyleFormRegister.LookAndFeel.SkinName = "The Asphalt World";
            // 
            // FrmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 274);
            this.Controls.Add(this.CmdUserType);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.TxtConfirmPass);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.TxtSalt);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.TxtID);
            this.Controls.Add(this.TxtUID);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.ribbonControl2);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.BtnAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRegister";
            this.Load += new System.EventHandler(this.FrmRegister_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TxtID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtUID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSalt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtConfirmPass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmdUserType.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit TxtID;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem BtnExit;
        private DevExpress.XtraEditors.TextEdit TxtUID;
        private DevExpress.XtraEditors.SimpleButton BtnCancel;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton BtnAdd;
        private DevExpress.XtraEditors.TextEdit TxtSalt;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit TxtConfirmPass;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.ComboBoxEdit CmdUserType;
        private DevExpress.LookAndFeel.DefaultLookAndFeel StyleFormRegister;
    }
}