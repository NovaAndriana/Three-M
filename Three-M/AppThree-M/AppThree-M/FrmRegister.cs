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
using MySql.Data.MySqlClient;

namespace AppThree_M
{
    public partial class FrmRegister : DevExpress.XtraEditors.XtraForm
    {


        public FrmRegister()
        {
            InitializeComponent();
        }
        string MyConnectionString = "Server='localhost';user id='root';password=;database='3MDB';";
        //"Server=localhost:8080;user id=root;password=;SslMode=none;database=3MDB"
        private void FrmRegister_Load(object sender, EventArgs e)
        {
            int idx = 0;
            MySqlConnection con = new MySqlConnection(MyConnectionString);
            // MySqlCommand cmd = new MySqlCommand();
            con.Open();
            try
            {
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT COALESCE(MAX(EMP_ID),0) + 1 AS idk FROM MASTER_USER";

                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    idx = Convert.ToInt32(dr["idk"].ToString());
                }
                string ID = "PA-" + DateTime.Now.Day + DateTime.Now.Month + DateTime.Now.Year + "-" +"000" + idx;
                //string ID = "PA-" + "000" + idx;
                TxtID.Text = ID.ToString();
                dr.Close();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();

                }
            }
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
    }
    
}