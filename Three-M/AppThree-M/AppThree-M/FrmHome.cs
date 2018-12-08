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
using DevExpress.XtraBars.Docking2010.Views;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Navigation;

namespace AppThree_M
{
    public partial class FrmHome : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public string GetID
        {
            get { return Lb_ID.Caption; }
        }
        public FrmHome()
        {
            InitializeComponent();
        }
        private void BtnMatrial_ItemClick(object sender, ItemClickEventArgs e)
        {
            TabHome_Matrial.PageVisible = true;
        }

        private void BtnMachine_ItemClick(object sender, ItemClickEventArgs e)
        {
            TabHome_Machine.PageVisible = true;
        }

        private void BtnEmployee_ItemClick(object sender, ItemClickEventArgs e)
        {
            TabHome_Employee.PageVisible = true;
        }

        private void BtnCustomerSPK_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void BtnProdactionReport_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void BtnMatrialCost_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void FrmHome_Load(object sender, EventArgs e)
        {

        }

        private void ribbonStatusBar_Click(object sender, EventArgs e)
        {

        }
    }
}