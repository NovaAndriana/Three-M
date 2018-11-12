using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using Three_M;

namespace Three_M.reg
{
    public partial class reg : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        private void Cleartextbox()
        {
            txtAddress.Text = string.Empty;
            txtEmpID.Text = string.Empty;
            //txtEmpName.Text = string.Empty;
            //txtPassword.Text = string.Empty;
            //txtUserId.Text = string.Empty;
        }
    }
}