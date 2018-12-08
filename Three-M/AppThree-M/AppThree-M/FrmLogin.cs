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
using System.Net;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
namespace AppThree_M
{
    public partial class FrmLogin : DevExpress.XtraEditors.XtraForm
    {
        //Koneksi Database
        string MyConnectionString = "Server='localhost';user id='root';password=;database='3MDB';";

        //Declare Fungsi Descript Password
        HashCode hc = new HashCode();

        string hostName = Dns.GetHostName();
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
        private bool Validate_login(string user, string pass)
        {
            //string myIP = Dns.GetHostByName(hostName).AddressList[0].ToString();
            MySqlConnection con = new MySqlConnection(MyConnectionString);
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "select * from MASTER_USER where UID=@user and SALT=@pass";
            cmd.Parameters.AddWithValue("@user", user);
            cmd.Parameters.AddWithValue("@pass", pass);
            cmd.Connection = con;
            MySqlDataReader dt = cmd.ExecuteReader();
            
            if (dt.Read())
            {
                FrmHome home = new FrmHome();
                this.LbID.Text = dt[1].ToString();
                
                con.Close();
                return true;
            }
            else
            {
                con.Close();
                return false;
            }

        }
        private void UpdateLogin()
        {
            try
            {
                string myIP = Dns.GetHostByName(hostName).AddressList[0].ToString();
                MySqlConnection con2 = new MySqlConnection(MyConnectionString);
                //con.Close();
                con2.Open();
                MySqlCommand cmd2 = con2.CreateCommand();
                cmd2.CommandText = "update MASTER_USER set LAST_LOG='" + DateTime.Now.ToString() + "',LAST_IP='" + myIP + "' where EMP_ID ='" + this.LbID.Text + "';";
                cmd2.Connection = con2;
                cmd2.ExecuteNonQuery();
                //MessageBox.Show("sukses");
                con2.Close();
            }
            catch (Exception err)
            {
                string pesan = "Error when try to update login. Please contact Developer" + err.ToString();
                string judul = "Developer System WijayaSoft";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(pesan, judul, buttons, MessageBoxIcon.Warning);
            }
        }
        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            if (TxtUname.Text == "" || TxtPass.Text == "") {

                string Pesan = "Input data must be complete. Invalid input data !";
                string judul = "Developer System WijayaSoft";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(Pesan, judul, buttons, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    string user = TxtUname.Text;
                    string pass = TxtPass.Text;
                    FrmHome FrmHome1 = new FrmHome();
                    if (user == "" || pass == "")
                    {
                        MessageBox.Show("Empty Field Detected ! Please fill up all the fields");
                        return;
                    }
                    bool r = Validate_login(user, hc.PassHash(pass));
                    if (r == true)
                    {
                        MessageBox.Show("Correct Login Credentials");
                        Clear();
                        this.Hide();
                        FrmHome1.Show();
                        UpdateLogin();
        
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Login Credentials");
                        Clear();
                    }

                }
                catch (Exception err)
                {
                    string Pesan = "Error when to try Read Data. Please Contact Developer." + Environment.NewLine + Environment.NewLine + err.ToString();
                    string judul = "Developer System WijayaSoft - Error Message";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBox.Show(Pesan, judul, buttons, MessageBoxIcon.Error);
                }
            }
        }
    }
}