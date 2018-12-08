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
using System.Security.Cryptography;
using System.Net;

namespace AppThree_M
{
    public partial class FrmRegister : DevExpress.XtraEditors.XtraForm
    {


        public FrmRegister()
        {
            InitializeComponent();
        }
        //Koneksi Database
        string MyConnectionString = "Server='localhost';user id='root';password=;database='3MDB';";

        //Declare Fungsi Descript Password
        HashCode hc = new HashCode();

        string hostName = Dns.GetHostName();
       

        private void AutoID()
        {
            long idx;
            string urut;
            MySqlConnection con = new MySqlConnection(MyConnectionString);
            con.Open();
            try
            {
                MySqlCommand cmd = con.CreateCommand();

                //Perintah Query untuk mendapatkan nilai terbesar dari EMP_ID
                cmd.CommandText = "SELECT COALESCE(MAX(EMP_ID)) AS IDX FROM MASTER_USER ORDER BY EMP_ID DESC";

                MySqlDataReader dr = cmd.ExecuteReader();

                //Jika Data Terbaca/Ditemukan
                if (dr.Read())
                {
                    //Menambahkan Data dari Field Nomor
                    idx = Convert.ToInt64(dr[0].ToString().Substring(dr["IDX"].ToString().Length - 4, 4)) + 1;

                    string joinstr = "0000" + idx;

                    //Mengambil empat karakter kanan terakhir dari string joinstr lalu di tambahkan dengan variable string URUT
                    urut = "3M-" + DateTime.Now.Day + DateTime.Now.Month + DateTime.Now.Year + joinstr.Substring(joinstr.Length - 4, 4);
                }
                else
                {
                    //Jika tidak ditemukan maka mengisi variable urut dengan 3M-71220180001
                    urut = "3M-" + DateTime.Now.Day + DateTime.Now.Month + DateTime.Now.Year + "0001";
                }
                dr.Close();
                TxtID.Text = urut;
                TxtUID.Focus();
                con.Close();
            }
            catch (Exception err)
            {
                string Pesan = "Error when try to Load data from Database. Please Contact Developer." + Environment.NewLine + Environment.NewLine + err.ToString();
                string judul = "Developer System WijayaSoft - Error Message";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(Pesan, judul, buttons, MessageBoxIcon.Error);
                
            }
        }
        private void FrmRegister_Load(object sender, EventArgs e)
        {
            AutoID();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            if (TxtUID.Text == "" || TxtSalt.Text == "" || TxtConfirmPass.Text == "")
            {
                string Pesan = "Input data must be complete. Invalid input data !";
                string judul = "Developer System WijayaSoft";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(Pesan, judul, buttons, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    string myIP = Dns.GetHostByName(hostName).AddressList[0].ToString();
                    MySqlConnection con = new MySqlConnection(MyConnectionString);
                    con.Open();
                    MySqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "insert into MASTER_USER (EMP_ID,UID,SALT,UTYPE,CRE_DATE,MOD_IP) values (@EMP_ID,@UID,@SALT,@UTYPE,@CRE_DATE,@MOD_IP)";
                    cmd.Parameters.AddWithValue("@EMP_ID", TxtID.Text);
                    cmd.Parameters.AddWithValue("@UID", TxtUID.Text);
                    cmd.Parameters.AddWithValue("@SALT", hc.PassHash(TxtSalt.Text));
                    cmd.Parameters.AddWithValue("@UTYPE", CmdUserType.Text);
                    cmd.Parameters.AddWithValue("@CRE_DATE", DateTime.Now);
                    cmd.Parameters.AddWithValue("@MOD_IP", myIP);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Has been saved !", "Success");
                    AutoID();
                    Clear();
                    con.Close();
                }
                catch (Exception err)
                {
                    string Pesan = "Error when try to Input data to Database. Please Check Again your data input or Contact Developer." + Environment.NewLine + Environment.NewLine + err.ToString();
                    string judul = "Developer System WijayaSoft - Error Message";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBox.Show(Pesan, judul, buttons, MessageBoxIcon.Error);
                }

            }
        }
        private void Clear()
        {
            AutoID();
            TxtSalt.Text = "";
            TxtUID.Text = "";
            TxtConfirmPass.Text = "";
            CmdUserType.Text = "";
            TxtUID.Focus();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void BtnExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmRegister.ActiveForm.Close();
        }
    }

}