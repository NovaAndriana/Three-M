using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace AppThree_M
{
    public partial class FrmLogin : DevExpress.XtraEditors.XtraForm
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        private void Clear()
        {
            TxtUname.Text = "";
            TxtPass.Text = "";
            TxtUname.Focus();
        }
        private void BtnExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            switch (MessageBox.Show("Do you want to exit ?",
              "WijayaSoft",
              MessageBoxButtons.YesNo,
              MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    FrmLogin.ActiveForm.Close();
                    break;

                case DialogResult.No:
                    TxtUname.Focus();
                    break;
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}