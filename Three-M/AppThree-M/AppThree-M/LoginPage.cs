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
    public partial class LoginPage : DevExpress.XtraEditors.XtraForm
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            LoginPage.ActiveForm.Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
           
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            
        }
    }
}