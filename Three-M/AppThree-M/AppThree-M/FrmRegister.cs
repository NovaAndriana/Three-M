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
        string MyConnectionString = "Server=localhost:8080;Port=3306;UID=root;PWD=;Database=3MDB";
        //server=localhost:8080;user id=root;persistsecurityinfo=True;database=3mdb;port=3306;password=rmsprd
        private void FrmRegister_Load(object sender, EventArgs e)
        {
           // int idx = 0;
           // MySqlConnection con = new MySqlConnection(MyConnectionString);
           //// MySqlCommand cmd = new MySqlCommand();
           // con.Open();
           // try
           // {
           //     MySqlCommand cmd = con.CreateCommand();
           //     cmd.CommandText = "select isnull(max(EMP_ID)) + 1 from MASTER_USER";

           //     MySqlDataReader dr = cmd.ExecuteReader();
           //     while (dr.Read())
           //     {
           //         idx = Convert.ToInt16(dr["EMP_ID"].ToString());
           //     }
           //     //string ID = "PA-" + DateTime.Now.Day + "-" + DateTime.Now.Month + "-" + DateTime.Now.Year + "-" + idx;
           //     string ID = "PA-" + "000" + idx;
           //     TxtID.Text = ID;
           //     dr.Close();
           // }
           // catch (Exception)
           // {
           //     throw;
           // }
           // finally
           // {
           //     if (con.State == ConnectionState.Open)
           //     {
           //         con.Close();

           //     }
           // }
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(MyConnectionString);
            con.Open();
            MessageBox.Show("Sukses");
        }
    }
}