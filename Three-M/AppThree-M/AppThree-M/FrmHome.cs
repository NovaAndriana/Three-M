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
using DevExpress.XtraTab;
using DevExpress.XtraTab.ViewInfo;

namespace AppThree_M
{
    public partial class FrmHome : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        #region Lain2
        //Koneksi Database
        string MyConnectionString = "Server='localhost';user id='root';password=;database='3MDB';";
        string hostName = Dns.GetHostName();
        //public event EventHandler CloseButtonClick;


        //private void TabHome_Matrial_CloseButtonClick(object sender, ClosePageButtonEventArgs e)
        //{
        //    //ClosePageButtonEventArgs arg = e as ClosePageButtonEventArgs;
        //    TabHome_Matrial.PageVisible = false;
        //}
        private void TotalHargaMatrial()
        {
            try
            {
                TxtTotalMatrial.Text = Convert.ToString(Convert.ToDouble(TxtHargaMatrial.Text) * Convert.ToDouble(TxtQtyMatrial.Text));
            }
            catch (Exception err)
            {
                MessageBox.Show("Error Data Input !" + err.ToString());
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
        private void FrmHome_Load(object sender, EventArgs e)
        {
            // timer1.Enabled = true;
        }
        private void TabHome_Machine_Paint(object sender, PaintEventArgs e)
        {

        }
        private void TxtHargaMatrial_EditValueChanged(object sender, EventArgs e)
        {
            TotalHargaMatrial();
        }
        private void TxtQtyMatrial_EditValueChanged(object sender, EventArgs e)
        {
            TotalHargaMatrial();
        }
        #endregion
        //-------------------------------------------------------------
        #region Clear
        private void ClearMatrial()
        {
            TxtHargaMatrial.Text = "";
            TxtJenisMatrial.Text = "";
            TxtNamaMatrial.Text = "";
            TxtNamaSupplierMatrial.Text = "";
            TxtQtyMatrial.Text = "";
            TxtTotalMatrial.Text = "";
            AutoIDMatrial();
        }
        private void ClearEmployee()
        {
            TxtAlamatKaryawan.Text = "";
            TxtNamaKaryawan.Text = "";
            TxtNoHPKaryawan.Text = "";
            CmbDepartemen.Text = "-";
            CmbJabatan.Text = "-";
            AutoIDEmployee();
        }
        #endregion
//-------------------------------------------------------------
        #region Show_Data_Table
        private void Mesin_DT()
        {
            try
            {
                //MySqlConnection con = new MySqlConnection(MyConnectionString);
                //con.Open();
                //MySqlCommand cmd = con.CreateCommand();
                //cmd.CommandText = "select * from MASTER_MESIN_DT";
                //MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                //DataSet ds = new DataSet();
                //da.Fill(ds);
                //DG_Machine_DT.DataSource = ds.Tables[0].DefaultView;
                //con.Close();
            }
            catch (Exception err)
            {
                string pesan = "Error when try to load data from Database. Please contact Developer" + err.ToString();
                string judul = "Developer System WijayaSoft";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(pesan, judul, buttons, MessageBoxIcon.Error);
            }
        }
        private void Mesin_Setter()
        {
            try
            {
                MySqlConnection con = new MySqlConnection(MyConnectionString);
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "select * from MASTER_MESIN_SETTER";
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                //DG_Machine_Setter.DataSource = ds.Tables[0].DefaultView;
                con.Close();
            }
            catch (Exception err)
            {
                string pesan = "" + err.ToString();
                string judul = "";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(pesan, judul, buttons, MessageBoxIcon.Warning);
            }
        }
        private void Mesin_DRT()
        {
            try
            {
                //MySqlConnection con = new MySqlConnection(MyConnectionString);
                //con.Open();
                //MySqlCommand cmd = con.CreateCommand();
                //cmd.CommandText = "select * from MASTER_MESIN_DRT";
                //MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                //DataSet ds = new DataSet();
                //da.Fill(ds);
                //DG_Machine_DRT.DataSource = ds.Tables[0].DefaultView;
                //con.Close();
            }
            catch (Exception err)
            {
                string pesan = "Error when try to load data from Database. Please contact Developer" + err.ToString();
                string judul = "Developer System WijayaSoft";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(pesan, judul, buttons, MessageBoxIcon.Error);
            }
        }
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
        private void DataEmployee()
        {
            try
            {
                MySqlConnection con = new MySqlConnection(MyConnectionString);
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "select * from MASTER_KARYAWAN";
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                DG_Karyawan.DataSource = ds.Tables[0].DefaultView;
                con.Close();
            }
            catch (Exception err)
            {
                string pesan = "Error when try to load data from Database. Please contact Developer" + err.ToString();
                string judul = "Developer System WijayaSoft";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(pesan, judul, buttons, MessageBoxIcon.Error);
            }
        }
        #endregion
//-----------------------------------------------------------------------------
        #region AutoID
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

        private void AutoIDEmployee()
        {
            long idx;
            string urut;
            MySqlConnection con = new MySqlConnection(MyConnectionString);
            con.Open();
            try
            {
                MySqlCommand cmd = con.CreateCommand();

                //Perintah Query untuk mendapatkan nilai terbesar dari EMP_ID
                cmd.CommandText = "SELECT COALESCE(MAX(ID_KARYAWAN)) AS IDX FROM MASTER_KARYAWAN ORDER BY ID_KARYAWAN DESC";

                MySqlDataReader dr = cmd.ExecuteReader();

                //Jika Data Terbaca/Ditemukan
                if (dr.Read())
                {
                    //Menambahkan Data dari Field Nomor
                    idx = Convert.ToInt64(dr[0].ToString().Substring(dr["IDX"].ToString().Length - 4, 4)) + 1;

                    string joinstr = "0000" + idx;

                    //Mengambil empat karakter kanan terakhir dari string joinstr lalu di tambahkan dengan variable string URUT
                    urut = "EMP" + DateTime.Now.Day + DateTime.Now.Month + DateTime.Now.Year + joinstr.Substring(joinstr.Length - 4, 4);
                }
                else
                {
                    //Jika tidak ditemukan maka mengisi variable urut dengan 3M-71220180001
                    urut = "EMP" + DateTime.Now.Day + DateTime.Now.Month + DateTime.Now.Year + "0001";
                }
                dr.Close();
                TxtIDKaryawan.Text = urut;
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
        #endregion
        //--------------------------------------------------------------------
        #region Click
        private void BtnMatrial_ItemClick(object sender, ItemClickEventArgs e)
        {
            TabHome.Visible = true;
            TabHome_Matrial.PageVisible = true;
            DataMatrial();
            AutoIDMatrial();
            DG_Matrial.ForeColor = Color.White;
            DG_Matrial.BorderStyle = BorderStyle.Fixed3D;
        }

        private void BtnMachine_ItemClick(object sender, ItemClickEventArgs e)
        {
            TabHome.Visible = true;
            TabHome_Machine.PageVisible = true;
            Mesin_DRT();
            Mesin_DT();
        }

        private void BtnEmployee_ItemClick(object sender, ItemClickEventArgs e)
        {
            TabHome.Visible = true;
            TabHome_Employee.PageVisible = true;
            DataEmployee();
            AutoIDEmployee();
            DG_Karyawan.ForeColor = Color.White;
            DG_Karyawan.BorderStyle = BorderStyle.Fixed3D;
        }
        private void DG_Matrial_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = DG_Matrial.Rows[index];
            TxtIDMatrial.Text = selectedRow.Cells[0].Value.ToString();
            TxtNamaMatrial.Text = selectedRow.Cells[1].Value.ToString();
            TxtQtyMatrial.Text = selectedRow.Cells[2].Value.ToString();
            TxtJenisMatrial.Text = selectedRow.Cells[4].Value.ToString();
            TxtHargaMatrial.Text = selectedRow.Cells[3].Value.ToString();
            TxtNamaSupplierMatrial.Text = selectedRow.Cells[6].Value.ToString();
            TxtTotalMatrial.Text = selectedRow.Cells[5].Value.ToString();
        }

        private void DG_Karyawan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = DG_Karyawan.Rows[index];
            TxtIDKaryawan.Text = selectedRow.Cells[0].Value.ToString();
            TxtNamaKaryawan.Text = selectedRow.Cells[1].Value.ToString();
            CmbJabatan.Text = selectedRow.Cells[2].Value.ToString();
            CmbDepartemen.Text = selectedRow.Cells[3].Value.ToString();
            TxtNoHPKaryawan.Text = selectedRow.Cells[4].Value.ToString();
            TxtAlamatKaryawan.Text = selectedRow.Cells[5].Value.ToString();
        }

        private void DG_Matrial_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        static string a, b, c;

        private void BtnCustomerSPK_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void BtnProdactionReport_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void BtnMatrialCost_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
        private void BtnDeleteMatrial_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Do you want to delete this record ?",
              "WijayaSoft",
              MessageBoxButtons.YesNo,
              MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    DeleteMatrial();
                    break;

                case DialogResult.No:
                    ClearMatrial();
                    break;
            }
        }
        private void BtnSaveMatrial_Click(object sender, EventArgs e)
        {
            SaveMatrial();
        }
        private void BtnClearMatrial_Click(object sender, EventArgs e)
        {
            ClearMatrial();
        }
        private void BtnSaveKaryawan_Click(object sender, EventArgs e)
        {
            SaveDataEmployee();
        }

        private void BtnDeleteKaryawan_Click(object sender, EventArgs e)
        {
            DeleteEmployee();
        }

        private void BtnClearKaryawan_Click(object sender, EventArgs e)
        {
            ClearEmployee();
        }
        private void ribbonStatusBar_Click(object sender, EventArgs e)
        {

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            //a = LB_Berjalan.Caption;
            //b = a.Substring(0, 1);
            //c = a.Substring(1, a.Length - 1);
            //LB_Berjalan.Caption = c + b;
        }
        #endregion
        //-------------------------------------------------------------
        #region InsertData
       
        static string CECKID;
        private void SaveMatrial()
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
                    cmd.CommandText = "select ID_MATRIAL from MASTER_MATRIAL where ID_MATRIAL='" + TxtIDMatrial.Text + "'";
                    con.Open();
                    MySqlDataReader Reader = cmd.ExecuteReader();

                    while (Reader.Read())
                    {
                        CECKID = Reader.GetValue(0).ToString();
                    }
                    Reader.Close();
                    con.Close();
                    if (CECKID == "" || CECKID == null)
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
                        cmd.CommandText = "update MASTER_MATRIAL set NAMA='" + TxtNamaMatrial.Text + "',QTY='" + TxtQtyMatrial.Text + "',HARGA_SATUAN='" + TxtHargaMatrial.Text + "',JENIS='" + TxtJenisMatrial.Text + "',TOTAL_HARGA='" + TxtTotalMatrial.Text + "',NAMA_SUPPLIER='" + TxtNamaSupplierMatrial.Text + "',MOD_DATE='" + DateTime.Now.ToString() + "',MOD_BY='" + Lb_ID.Caption + "' where ID_MATRIAL='" + TxtIDMatrial.Text + "'";
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

        static string CECKID2;
        private void SaveDataEmployee()
        {
            try
            {
                MySqlConnection con = new MySqlConnection(MyConnectionString);
                if (TxtIDKaryawan.Text == "")
                {
                    string pesan = "Input data must be Complete. Invalid input Data !";
                    string judul = "Developer System Wijayasoft";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBox.Show(pesan, judul, buttons, MessageBoxIcon.Warning);
                }
                else
                {

                    try
                    {
                        string myIP2 = Dns.GetHostByName(hostName).AddressList[0].ToString();
                        MySqlCommand cmd = con.CreateCommand();
                        cmd.CommandText = "select ID_KARYAWAN from MASTER_KARYAWAN where ID_KARYAWAN='" + TxtIDKaryawan.Text + "'";
                        con.Open();
                        MySqlDataReader Reader = cmd.ExecuteReader();

                        while (Reader.Read())
                        {
                            CECKID = Reader.GetValue(0).ToString();
                        }
                        Reader.Close();
                        con.Close();
                        if (CECKID == "" || CECKID == null)
                        {
                            con.Open();
                            cmd.CommandText = "insert into MASTER_KARYAWAN (ID_KARYAWAN,NAMA,JABATAN,DEPARTEMEN,NO_HP,ALAMAT,CRE_DATE,CRE_BY,IP_ADDRESS) VALUES (@ID_KARYAWAN,@NAMA,@JABATAN,@DEPARTEMEN,@NO_HP,@ALAMAT,@CRE_DATE,@CRE_BY,@IP_ADDRESS)";
                            cmd.Parameters.AddWithValue("@ID_KARYAWAN", TxtIDKaryawan.Text);
                            cmd.Parameters.AddWithValue("@NAMA", TxtNamaKaryawan.Text);
                            cmd.Parameters.AddWithValue("@JABATAN", CmbJabatan.Text);
                            cmd.Parameters.AddWithValue("@DEPARTEMEN", CmbDepartemen.Text);
                            cmd.Parameters.AddWithValue("@NO_HP", TxtNoHPKaryawan.Text);
                            cmd.Parameters.AddWithValue("@ALAMAT", TxtAlamatKaryawan.Text);
                            cmd.Parameters.AddWithValue("@CRE_DATE", DateTime.Now.ToString());
                            cmd.Parameters.AddWithValue("@CRE_BY", Lb_ID.Caption);
                            cmd.Parameters.AddWithValue("@IP_ADDRESS", myIP2);
                            cmd.ExecuteNonQuery();
                            string pesan = "Data have been saved";
                            string judul = "WijayaSoft";
                            MessageBoxButtons buttons = MessageBoxButtons.OK;
                            MessageBox.Show(pesan, judul, buttons, MessageBoxIcon.Information);
                            ClearEmployee();
                            con.Close();
                            DataEmployee();
                            AutoIDEmployee();
                        }
                        else
                        {
                            con.Open();
                            cmd.CommandText = "update MASTER_KARYAWAN set NAMA='" + TxtNamaKaryawan.Text + "',JABATAN='" + CmbJabatan.Text + "',DEPARTEMEN='" + CmbDepartemen.Text + "',NO_HP='" + TxtNoHPKaryawan.Text + "',ALAMAT='" + TxtAlamatKaryawan.Text + "',MOD_DATE='" + DateTime.Now.ToString() + "',MOD_BY='" + Lb_ID.Caption + "' where ID_KARYAWAN='" + TxtIDKaryawan.Text + "'";
                            cmd.ExecuteNonQuery();
                            string pesan = "Data have been Update";
                            string judul = "WijayaSoft";
                            MessageBoxButtons buttons = MessageBoxButtons.OK;
                            MessageBox.Show(pesan, judul, buttons, MessageBoxIcon.Information);
                            ClearEmployee();
                            con.Close();
                            DataEmployee();
                            AutoIDEmployee();
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
            catch (Exception err)
            {
                MessageBox.Show("Error" + err.ToString());
            }
        }

        private void TabHome_CloseButtonClick(object sender, EventArgs e)
        {
            ClosePageButtonEventArgs arg = e as ClosePageButtonEventArgs;
            (arg.Page as XtraTabPage).PageVisible = false;

        }
        #endregion
        //--------------------------------------------------------------------
        #region Delete
        private void DeleteMatrial()
        {
            try
            {
                if (TxtIDMatrial.Text == "")
                {
                    string pesan = "Invalid input data. Please check again or Contact Developer !";
                    string judul = "Developer System Wijayasoft";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBox.Show(pesan, judul, buttons, MessageBoxIcon.Error);
                }
                else
                {
                    switch (MessageBox.Show("Do you want to exit ?",
                              "WijayaSoft",
                              MessageBoxButtons.YesNo,
                              MessageBoxIcon.Question))
                                                {
                        case DialogResult.Yes:
                            MySqlConnection con = new MySqlConnection(MyConnectionString);
                            con.Open();
                            MySqlCommand cmd = con.CreateCommand();
                            cmd.CommandText = "delete from MASTER_MATRIAL where ID_MATRIAL=@ID";
                            cmd.Parameters.AddWithValue("@ID", TxtIDMatrial.Text);
                            cmd.ExecuteNonQuery();
                            con.Close();
                            MessageBox.Show("Record Has been Deleted !");
                            ClearMatrial();
                            AutoIDMatrial();
                            DataMatrial();
                            AutoIDMatrial();
                            break;

                        case DialogResult.No:
                            ClearMatrial();
                            break;
                    }
                }
               
               // }
            }
            catch (Exception err)
            {
                MessageBox.Show("Error when try to delete data." + err.ToString());
            }
        }

        private void DeleteEmployee()
        {
            try
            {
                if (TxtIDKaryawan.Text == "")
                {
                    string pesan = "Invalid input data. Please check again or Contact Developer !";
                    string judul = "Developer System Wijayasoft";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBox.Show(pesan, judul, buttons, MessageBoxIcon.Error);
                }
                else
                {
                    switch (MessageBox.Show("Do you want to exit ?",
                              "WijayaSoft",
                              MessageBoxButtons.YesNo,
                              MessageBoxIcon.Question))
                    {
                        case DialogResult.Yes:
                            MySqlConnection con = new MySqlConnection(MyConnectionString);
                            con.Open();
                            MySqlCommand cmd = con.CreateCommand();
                            cmd.CommandText = "delete from MASTER_KARYAWAN where ID_KARYAWAN=@ID";
                            cmd.Parameters.AddWithValue("@ID", TxtIDKaryawan.Text);
                            cmd.ExecuteNonQuery();
                            con.Close();
                            MessageBox.Show("Record Has been Deleted !");
                            ClearEmployee();
                            AutoIDEmployee();
                            DataEmployee();
                            break;

                        case DialogResult.No:
                            ClearEmployee();
                            AutoIDEmployee();
                            break;
                    }
                }
               
            }
            catch (Exception err)
            {
                MessageBox.Show("Error when try to delete data." + err.ToString());
            }
        }
        #endregion
//-----------------------------------------------------

    }
}