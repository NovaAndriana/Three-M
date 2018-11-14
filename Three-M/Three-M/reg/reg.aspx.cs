using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using Three_M;

namespace Three_M.reg
{
    public partial class reg : System.Web.UI.Page
    {
        MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!Page.IsPostBack)
                {
                    //BindGridView();

                }
            }
            catch (Exception ex)
            {
                ShowMessage(ex.Message);
            }
        }
        void ShowMessage(string msg)
        {
            ClientScript.RegisterStartupScript(Page.GetType(), "validation", "<script language = 'javascript' > alert('" + msg + "');</ script > ");  
        }
        private void Cleartextbox()
        {
           
            txtEmpID.Text = string.Empty;
            ddlPosition.Text = "-";
            txtPass.Text = string.Empty;
        }
        protected void b1_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("Insert into MASTER_USER(EMP_ID,UID,SALT,UTYPE,LAST_LOG,LAST_IP) values(@EMP_ID,@UID,@SALT,@UTYPE,'" + "1.1.1" + "','" + DateTime.Now + "')", conn);
                cmd.Parameters.AddWithValue("@EMP_ID", txtEmpID.Text);
                //Here i have implemented the code for doing encryption of password
                string ePass = Helper.ComputeHash(txtPass.Text, "SHA512", null);

                cmd.Parameters.AddWithValue("@SALT", ePass);
                cmd.Parameters.AddWithValue("@EmpName", txtUid.Text);
                cmd.Parameters.AddWithValue("@UTYPE", ddlPosition.Text);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                ShowMessage("Registered successfully......!");
                Cleartextbox();
            }
            catch (MySqlException ex)
            {
                ShowMessage(ex.Message);
            }
            finally
            {
                conn.Close();
            }

        }
    }
}