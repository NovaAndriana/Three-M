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
using System.Net;
using MySql.Data.MySqlClient;
namespace AppThree_M
{
    public partial class FrmHome : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        //Koneksi Database
        string MyConnectionString = "Server='localhost';user id='root';password=;database='3MDB';";

        string hostName = Dns.GetHostName();

        private void DataMatrial()
        {
            try
            {
                MySqlConnection con = new MySqlConnection(MyConnectionString);
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "select * from MASTER_MATRIAL";
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                DG_Matrial.DataSource = ds.Tables[0].DefaultView;
                con.Close();
            }
            catch(Exception err)
            {
                string pesan = "Error when try to load data from Database. Please contact Developer" + err.ToString();
                string judul = "Developer System WijayaSoft";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(pesan, judul, buttons, MessageBoxIcon.Error);
            }
        }
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
            DataMatrial();
            AutoIDMatrial();
            DG_Matrial.ForeColor = Color.White;
            DG_Matrial.BorderStyle = BorderStyle.Fixed3D;
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
            timer1.Enabled = true;
        }

        private void ribbonStatusBar_Click(object sender, EventArgs e)
        {

        }
        private void ClearMatrial()
        {
            TxtHargaMatrial.Text = "";
            TxtJenisMatrial.Text = "";
            TxtNamaMatrial.Text = "";
            TxtNamaSupplierMatrial.Text = "";
            TxtQtyMatrial.Text = "";
            TxtTotalMatrial.Text = "";
        }
        private void AutoIDMatrial()
        {
            long idx;
            string urut;
            MySqlConnection con = new MySqlConnection(MyConnectionString);
            con.Open();
            try
            {
                MySqlCommand cmd = con.CreateCommand();

                //Perintah Query untuk mendapatkan nilai terbesar dari EMP_ID
                cmd.CommandText = "SELECT COALESCE(MAX(ID_MATRIAL)) AS IDX FROM MASTER_MATRIAL ORDER BY ID_MATRIAL DESC";

                MySqlDataReader dr = cmd.ExecuteReader();

                //Jika Data Terbaca/Ditemukan
                if (dr.Read())
                {
                    //Menambahkan Data dari Field Nomor
                    idx = Convert.ToInt64(dr[0].ToString().Substring(dr["IDX"].ToString().Length - 4, 4)) + 1;

                    string joinstr = "0000" + idx;

                    //Mengambil empat karakter kanan terakhir dari string joinstr lalu di tambahkan dengan variable string URUT
                    urut = "MT" + DateTime.Now.Day + DateTime.Now.Month + DateTime.Now.Year + joinstr.Substring(joinstr.Length - 4, 4);
                }
                else
                {
                    //Jika tidak ditemukan maka mengisi variable urut dengan 3M-71220180001
                    urut = "MT" + DateTime.Now.Day + DateTime.Now.Month + DateTime.Now.Year + "0001";
                }
                dr.Close();
                TxtIDMatrial.Text = urut;
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
        static string CECKID;
        private void BtnSaveMatrial_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("Test");
            MySqlConnection con = new MySqlConnection(MyConnectionString);
            //con.Open();
            if (TxtIDMatrial.Text == "" || TxtNamaMatrial.Text == "" || TxtQtyMatrial.Text == "")
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
                    MySqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "select ID_MATRIAL from MASTER_MATRIAL where ID_MATRIAL='"+TxtIDMatrial.Text+"'";
                    con.Open();
                    MySqlDataReader Reader = cmd.ExecuteReader();
                    
                    while (Reader.Read())
                    {
                        CECKID = Reader.GetValue(0).ToString();
                    }
                    Reader.Close();
                    con.Close();
                    if (CECKID == "" || CECKID == null )
                    {
                        con.Open();
                        cmd.CommandText = "insert into MASTER_MATRIAL (ID_MATRIAL,NAMA,QTY,HARGA_SATUAN,JENIS,TOTAL_HARGA,NAMA_SUPPLIER,CRE_DATE,CRE_BY,COMP_ID) VALUES (@ID_MATRIAL,@NAMA,@QTY,@HARGA_SATUAN,@JENIS,@TOTAL_HARGA,@NAMA_SUPPLIER,@CRE_DATE,@CRE_BY,@COMP_ID)";
                        cmd.Parameters.AddWithValue("@ID_MATRIAL", TxtIDMatrial.Text);
                        cmd.Parameters.AddWithValue("@NAMA", TxtNamaMatrial.Text);
                        cmd.Parameters.AddWithValue("@QTY", TxtQtyMatrial.Text);
                        cmd.Parameters.AddWithValue("@HARGA_SATUAN", TxtHargaMatrial.Text);
                        cmd.Parameters.AddWithValue("@JENIS", TxtJenisMatrial.Text);
                        cmd.Parameters.AddWithValue("@TOTAL_HARGA", TxtTotalMatrial.Text);
                        cmd.Parameters.AddWithValue("@NAMA_SUPPLIER", TxtNamaSupplierMatrial.Text);
                        cmd.Parameters.AddWithValue("@CRE_DATE", DateTime.Now.ToString());
                        cmd.Parameters.AddWithValue("@CRE_BY", Lb_ID.Caption);
                        cmd.Parameters.AddWithValue("@COMP_ID", myIP);
                        cmd.ExecuteNonQuery();
                        string pesan = "Data have been saved";
                        string judul = "WijayaSoft";
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        MessageBox.Show(pesan, judul, buttons, MessageBoxIcon.Information);
                        ClearMatrial();
                        con.Close();
                        DataMatrial();
                        AutoIDMatrial();
                    }
                    else
                    {
                        con.Open();
                        cmd.CommandText = "update MASTER_MATRIAL set NAMA='" + TxtNamaMatrial.Text + "',QTY='" + TxtQtyMatrial.Text + "',HARGA_SATUAN='" + TxtHargaMatrial.Text + "',JENIS='" + TxtJenisMatrial.Text + "',TOTAL_HARGA='" + TxtTotalMatrial.Text + "',NAMA_SUPPLIER='" + TxtNamaSupplierMatrial.Text + "',MOD_DATE='" + DateTime.Now.ToString() + "',MOD_BY='" + Lb_ID.Caption + "' where ID_MATRIAL='"+TxtIDMatrial.Text+"'";
                        cmd.ExecuteNonQuery();
                        string pesan = "Data have been Update";
                        string judul = "WijayaSoft";
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        MessageBox.Show(pesan, judul, buttons, MessageBoxIcon.Information);
                        ClearMatrial();
                        con.Close();
                        DataMatrial();
                        AutoIDMatrial();
                    }
                       
                }
                catch (Exception err)
                {
                    string pesan = "Error when try to Insert data to Database. Please contact Developer" + err.ToString();
                    string judul = "Developer System WijayaSoft";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBox.Show(pesan, judul, buttons, MessageBoxIcon.Error);
                }
            }
        }
        private void DG_Matrial_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow rows = DG_Matrial.Rows[e.RowIndex];
            TxtIDMatrial.Text = rows.Cells[0].Value.ToString();
            TxtNamaMatrial.Text = rows.Cells[1].Value.ToString();
        }
        private void DG_Matrial_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // value from datagrid where clicked cells is same in the textbox
            DataGridViewRow rows = DG_Matrial.Rows[e.RowIndex];
            TxtIDMatrial.Text = rows.Cells[0].Value.ToString();
            TxtNamaMatrial.Text = rows.Cells[1].Value.ToString();
        }
        static string a, b, c;
        private void timer1_Tick(object sender, EventArgs e)
        {
            a = LB_Berjalan.Caption;
            b = a.Substring(0, 1);
            c = a.Substring(1, a.Length - 1);
            LB_Berjalan.Caption = c + b;
        }
    }
}