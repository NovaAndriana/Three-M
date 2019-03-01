using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using MySql.Data.MySqlClient;

namespace AppThree_M
{
    public partial class Frm_Mesin : DevExpress.XtraEditors.XtraForm
    {
        string MyConnectionString = "Server='localhost';user id='root';password=;database='3MDB';";
        public Frm_Mesin()
        {
            InitializeComponent();
        }

        private void Frm_Mesin_Load(object sender, EventArgs e)
        {
            AutoIDMesinDRT();
            Mesin_DRT();
            AutoIDMesinDT();
            Mesin_DT();
            AutoIDMesinRelling();
            Mesin_Relling();
        }

        #region ShowData
        private void Mesin_Relling()
        {
            try
            {
                MySqlConnection con = new MySqlConnection(MyConnectionString);
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "select * from MASTER_MESIN_REELING";
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                DG_Relling.DataSource = ds.Tables[0].DefaultView;
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
        private void Mesin_DT()
        {
            try
            {
                MySqlConnection con = new MySqlConnection(MyConnectionString);
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "select * from MASTER_MESIN_DT";
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                DG_DT.DataSource = ds.Tables[0].DefaultView;
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
        private void Mesin_DRT()
        {
            try
            {
                MySqlConnection con = new MySqlConnection(MyConnectionString);
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "select * from MASTER_MESIN_DRT";
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                DG_DRT.DataSource = ds.Tables[0].DefaultView;
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

        #region AutoID
        private void AutoIDMesinRelling()
        {
            long idx3;
            string urut3;
            MySqlConnection con = new MySqlConnection(MyConnectionString);
            con.Open();
            try
            {
                MySqlCommand cmd = con.CreateCommand();
                //SELECT MAX(ID_MESIN) AS IDX FROM MASTER_MESIN_DRT ORDER BY ID_MESIN DESC---cmd = new SqlCommand("select ID_MESIN from MASTER_MESIN_DRT where ID_MESIN in(select max(ID_MESIN) from MASTER_MESIN_DRT) order by ID_MESIN desc", con);
                //Perintah Query untuk mendapatkan nilai terbesar dari EMP_ID
                cmd.CommandText = "select ID_MESIN from MASTER_MESIN_REELING where ID_MESIN in(select max(ID_MESIN) from MASTER_MESIN_REELING) order by ID_MESIN desc";

                MySqlDataReader dr = cmd.ExecuteReader();

                //Jika Data Terbaca/Ditemukan
                if (dr.Read())
                {
                    //Menambahkan Data dari Field Nomor
                    idx3 = Convert.ToInt64(dr[0].ToString().Substring(dr["ID_MESIN"].ToString().Length - 4, 4)) + 1;

                    string joinstr = "0000" + idx3;

                    //Mengambil empat karakter kanan terakhir dari string joinstr lalu di tambahkan dengan variable string URUT
                    urut3 = "RL" + DateTime.Now.Day + DateTime.Now.Month + DateTime.Now.Year + joinstr.Substring(joinstr.Length - 4, 4);
                }
                else
                {
                    //Jika tidak ditemukan maka mengisi variable urut dengan 3M-71220180001
                    urut3 = "RL" + DateTime.Now.Day + DateTime.Now.Month + DateTime.Now.Year + "0001";
                }
                dr.Close();
                TxtIDMesinRelling.Text = urut3;
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
        private void AutoIDMesinDT()
        {
            long idx2;
            string urut2;
            MySqlConnection con = new MySqlConnection(MyConnectionString);
            con.Open();
            try
            {
                MySqlCommand cmd = con.CreateCommand();
                //SELECT MAX(ID_MESIN) AS IDX FROM MASTER_MESIN_DRT ORDER BY ID_MESIN DESC---cmd = new SqlCommand("select ID_MESIN from MASTER_MESIN_DRT where ID_MESIN in(select max(ID_MESIN) from MASTER_MESIN_DRT) order by ID_MESIN desc", con);
                //Perintah Query untuk mendapatkan nilai terbesar dari EMP_ID
                cmd.CommandText = "select ID_MESIN from MASTER_MESIN_DT where ID_MESIN in(select max(ID_MESIN) from MASTER_MESIN_DT) order by ID_MESIN desc";

                MySqlDataReader dr = cmd.ExecuteReader();

                //Jika Data Terbaca/Ditemukan
                if (dr.Read())
                {
                    //Menambahkan Data dari Field Nomor
                    idx2 = Convert.ToInt64(dr[0].ToString().Substring(dr["ID_MESIN"].ToString().Length - 4, 4)) + 1;

                    string joinstr = "0000" + idx2;

                    //Mengambil empat karakter kanan terakhir dari string joinstr lalu di tambahkan dengan variable string URUT
                    urut2 = "DT" + DateTime.Now.Day + DateTime.Now.Month + DateTime.Now.Year + joinstr.Substring(joinstr.Length - 4, 4);
                }
                else
                {
                    //Jika tidak ditemukan maka mengisi variable urut dengan 3M-71220180001
                    urut2 = "DT" + DateTime.Now.Day + DateTime.Now.Month + DateTime.Now.Year + "0001";
                }
                dr.Close();
                TxtIDMesinDT.Text = urut2;
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
        private void AutoIDMesinDRT()
        {
            long idx;
            string urut;
            MySqlConnection con = new MySqlConnection(MyConnectionString);
            con.Open();
            try
            {
                MySqlCommand cmd = con.CreateCommand();
                //SELECT MAX(ID_MESIN) AS IDX FROM MASTER_MESIN_DRT ORDER BY ID_MESIN DESC---cmd = new SqlCommand("select ID_MESIN from MASTER_MESIN_DRT where ID_MESIN in(select max(ID_MESIN) from MASTER_MESIN_DRT) order by ID_MESIN desc", con);
                //Perintah Query untuk mendapatkan nilai terbesar dari EMP_ID
                cmd.CommandText = "select ID_MESIN from MASTER_MESIN_DRT where ID_MESIN in(select max(ID_MESIN) from MASTER_MESIN_DRT) order by ID_MESIN desc";

                MySqlDataReader dr = cmd.ExecuteReader();

                //Jika Data Terbaca/Ditemukan
                if (dr.Read())
                {
                    //Menambahkan Data dari Field Nomor
                    idx = Convert.ToInt64(dr[0].ToString().Substring(dr["ID_MESIN"].ToString().Length - 4, 4)) + 1;

                    string joinstr = "0000" + idx;

                    //Mengambil empat karakter kanan terakhir dari string joinstr lalu di tambahkan dengan variable string URUT
                    urut = "DRT" + DateTime.Now.Day + DateTime.Now.Month + DateTime.Now.Year + joinstr.Substring(joinstr.Length - 4, 4);
                }
                else
                {
                    //Jika tidak ditemukan maka mengisi variable urut dengan 3M-71220180001
                    urut = "DRT" + DateTime.Now.Day + DateTime.Now.Month + DateTime.Now.Year + "0001";
                }
                dr.Close();
                Txt_IDMesinDRT.Text = urut;
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

        #region ClearTextBox
        private void ClearRelling()
        {
            TxtHankRelling.Text = "";
            TxtMinSpeedRelling.Text = "";
            TxtMaxSpeedRelling.Text = "";
            TxtMinDiameterRelling.Text = "";
            TxtMaxDiameterRelling.Text = "";
            TxtDurationRelling.Text = "";
            TxtHankRelling.Focus();
            AutoIDMesinRelling();
        }
        private void ClearDT()
        {
            TxtDurationDT.Text = "";
            TxtMaxSpeedDT.Text = "";
            TxtMaxTwistDT.Text = "";
            TxtMinSpeedDT.Text = "";
            TxtMinTwistDT.Text = "";
            TxtSpindleDT.Text = "";
            TxtSpindleDT.Focus();
            AutoIDMesinDT();
        }
        private void ClearDRT()
        {
            TxtDurationDRT.Text = "";
            Txt_MaxSpeedDRT.Text = "";
            Txt_MinSpeedDRT.Text = "";
            Txt_SpindleDRT.Text = "";
            Txt_SpindleDRT.Focus();
            AutoIDMesinDRT();
        }
        #endregion

        #region Delete
        private void DeleteRelling()
        {
            try
            {
                if (TxtIDMesinRelling.Text == "")
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
                            cmd.CommandText = "delete from MASTER_MESIN_REELING where ID_MESIN=@ID";
                            cmd.Parameters.AddWithValue("@ID", TxtIDMesinRelling.Text);
                            cmd.ExecuteNonQuery();
                            con.Close();
                            MessageBox.Show("Record Has been Deleted !");
                            ClearRelling();
                            AutoIDMesinRelling();
                            Mesin_Relling();
                            break;

                        case DialogResult.No:
                            ClearRelling();
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
        private void DeleteDT()
        {
            try
            {
                if (Txt_IDMesinDRT.Text == "")
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
                            cmd.CommandText = "delete from MASTER_MESIN_DT where ID_MESIN=@ID";
                            cmd.Parameters.AddWithValue("@ID", TxtIDMesinDT.Text);
                            cmd.ExecuteNonQuery();
                            con.Close();
                            MessageBox.Show("Record Has been Deleted !");
                            ClearDT();
                            AutoIDMesinDT();
                            Mesin_DT();
                            break;

                        case DialogResult.No:
                            ClearDT();
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
        private void DeleteDRT()
        {
            try
            {
                if (Txt_IDMesinDRT.Text == "")
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
                            cmd.CommandText = "delete from MASTER_MESIN_DRT where ID_MESIN=@ID";
                            cmd.Parameters.AddWithValue("@ID", Txt_IDMesinDRT.Text);
                            cmd.ExecuteNonQuery();
                            con.Close();
                            MessageBox.Show("Record Has been Deleted !");
                            ClearDRT();
                            AutoIDMesinDRT();
                            Mesin_DRT();
                            break;

                        case DialogResult.No:
                            ClearDRT();
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
        #endregion

        #region InsetrData
        static string CECKID3;
        private void SaveRelling()
        {
            // MessageBox.Show("Test");
            MySqlConnection con = new MySqlConnection(MyConnectionString);
            //con.Open();
            if (TxtIDMesinRelling.Text == "" || TxtHankRelling.Text == "" || TxtMaxSpeedRelling.Text == "" || TxtMinSpeedRelling.Text == "")
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
                    //string myIP = Dns.GetHostByName(hostName).AddressList[0].ToString();
                    MySqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "select ID_MESIN from MASTER_MESIN_REELING where ID_MESIN='" + TxtIDMesinRelling.Text + "'";
                    con.Open();
                    MySqlDataReader Reader = cmd.ExecuteReader();

                    while (Reader.Read())
                    {
                        CECKID3 = Reader.GetValue(0).ToString();
                    }
                    Reader.Close();
                    con.Close();
                    if (CECKID3 == "" || CECKID3 == null)
                    {
                        con.Open();
                        cmd.CommandText = "insert into MASTER_MESIN_REELING (ID_MESIN,JUMLAH_HANK,MAX_SPEED,MIN_SPEED,MAX_DIAMETER,MIN_DIAMETER,LAMA_PENGERJAAN) VALUES (@ID_MESIN,@JUMLAH_HANK,@MAX_SPEED,@MIN_SPEED,@MAX_DIAMETER,@MIN_DIAMETER,@LAMA_PENGERJAAN)";
                        cmd.Parameters.AddWithValue("@ID_MESIN", TxtIDMesinRelling.Text);
                        cmd.Parameters.AddWithValue("@JUMLAH_HANK", TxtHankRelling.Text);
                        cmd.Parameters.AddWithValue("@MAX_SPEED", TxtMaxSpeedRelling.Text);
                        cmd.Parameters.AddWithValue("@MIN_SPEED", TxtMinSpeedRelling.Text);
                        cmd.Parameters.AddWithValue("@MAX_DIAMETER", TxtMaxDiameterRelling.Text);
                        cmd.Parameters.AddWithValue("@MIN_DIAMETER", TxtMinDiameterRelling.Text);
                        cmd.Parameters.AddWithValue("@LAMA_PENGERJAAN", TxtDurationRelling.Text);
                        cmd.ExecuteNonQuery();
                        string pesan = "Data have been saved";
                        string judul = "WijayaSoft";
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        MessageBox.Show(pesan, judul, buttons, MessageBoxIcon.Information);
                        ClearRelling();
                        con.Close();
                        Mesin_Relling();
                        AutoIDMesinRelling();
                    }
                    else
                    {
                        con.Open();
                        cmd.CommandText = "update MASTER_MESIN_REELING set JUMLAH_HANK='" + TxtHankRelling.Text + "',MAX_SPEED='" + TxtMaxSpeedRelling.Text + "',MIN_SPEED='" + TxtMinSpeedRelling.Text + "',MAX_DIAMETER='" + TxtMaxDiameterRelling.Text + "',MIN_DIAMETER='" + TxtMinDiameterRelling.Text + "',LAMA_PENGERJAAN='" + TxtDurationRelling.Text + "' where ID_MESIN='" + TxtIDMesinRelling.Text + "'";
                        cmd.ExecuteNonQuery();
                        string pesan = "Data have been Update";
                        string judul = "WijayaSoft";
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        MessageBox.Show(pesan, judul, buttons, MessageBoxIcon.Information);
                        ClearRelling();
                        con.Close();
                        Mesin_Relling();
                        AutoIDMesinRelling();
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
        private void SaveDT()
        {
            // MessageBox.Show("Test");
            MySqlConnection con = new MySqlConnection(MyConnectionString);
            //con.Open();
            if (TxtIDMesinDT.Text == "" || TxtMaxSpeedDT.Text == "" || TxtMinSpeedDT.Text == "" || TxtMinTwistDT.Text == "")
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
                    //string myIP = Dns.GetHostByName(hostName).AddressList[0].ToString();
                    MySqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "select ID_MESIN from MASTER_MESIN_DT where ID_MESIN='" + TxtIDMesinDT.Text + "'";
                    con.Open();
                    MySqlDataReader Reader = cmd.ExecuteReader();

                    while (Reader.Read())
                    {
                        CECKID2 = Reader.GetValue(0).ToString();
                    }
                    Reader.Close();
                    con.Close();
                    if (CECKID2 == "" || CECKID2 == null)
                    {
                        con.Open();
                        cmd.CommandText = "insert into MASTER_MESIN_DT (ID_MESIN,JUMLAH_SPINDLE,MAX_SPEED,MIN_SPEED,MAX_TWIST,MIN_TWIST,LAMA_PENGERJAAN) VALUES (@ID_MESIN,@JUMLAH_SPINDLE,@MAX_SPEED,@MIN_SPEED,@MAX_TWIST,@MIN_TWIST,@LAMA_PENGERJAAN)";
                        cmd.Parameters.AddWithValue("@ID_MESIN", TxtIDMesinDT.Text);
                        cmd.Parameters.AddWithValue("@JUMLAH_SPINDLE", TxtSpindleDT.Text);
                        cmd.Parameters.AddWithValue("@MAX_SPEED", TxtMaxSpeedDT.Text);
                        cmd.Parameters.AddWithValue("@MIN_SPEED", TxtMinSpeedDT.Text);
                        cmd.Parameters.AddWithValue("@MAX_TWIST", TxtMaxTwistDT.Text);
                        cmd.Parameters.AddWithValue("@MIN_TWIST", TxtMinTwistDT.Text);
                        cmd.Parameters.AddWithValue("@LAMA_PENGERJAAN", TxtDurationDT.Text);
                        cmd.ExecuteNonQuery();
                        string pesan = "Data have been saved";
                        string judul = "WijayaSoft";
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        MessageBox.Show(pesan, judul, buttons, MessageBoxIcon.Information);
                        ClearDT();
                        con.Close();
                        Mesin_DT();
                        AutoIDMesinDT();
                    }
                    else
                    {
                        con.Open();
                        cmd.CommandText = "update MASTER_MESIN_DT set JUMLAH_SPINDLE='" + TxtSpindleDT.Text + "',MAX_SPEED='" + TxtMaxSpeedDT.Text + "',MIN_SPEED='" + TxtMinSpeedDT.Text + "',MAX_TWIST='" + TxtMaxTwistDT.Text + "',MIN_TWIST='" + TxtMinTwistDT.Text + "',LAMA_PENGERJAAN='" + TxtDurationDT.Text + "' where ID_MESIN='" + TxtIDMesinDT.Text + "'";
                        cmd.ExecuteNonQuery();
                        string pesan = "Data have been Update";
                        string judul = "WijayaSoft";
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        MessageBox.Show(pesan, judul, buttons, MessageBoxIcon.Information);
                        ClearDT();
                        con.Close();
                        Mesin_DT();
                        AutoIDMesinDT();
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
        static string CECKID;
        private void SaveDRT()
        {

            // MessageBox.Show("Test");
            MySqlConnection con = new MySqlConnection(MyConnectionString);
            //con.Open();
            if (Txt_IDMesinDRT.Text == "" || Txt_MaxSpeedDRT.Text == "" || Txt_MinSpeedDRT.Text == "" || Txt_SpindleDRT.Text == "")
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
                    //string myIP = Dns.GetHostByName(hostName).AddressList[0].ToString();
                    MySqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "select ID_MESIN from MASTER_MESIN_DRT where ID_MESIN='" + Txt_IDMesinDRT.Text + "'";
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
                        cmd.CommandText = "insert into MASTER_MESIN_DRT (ID_MESIN,JUMLAH_SPINDLE,MAX_SPEED,MIN_SPEED,LAMA_PENGERJAAN) VALUES (@ID_MESIN,@JUMLAH_SPINDLE,@MAX_SPEED,@MIN_SPEED,@LAMA_PENGERJAAN)";
                        cmd.Parameters.AddWithValue("@ID_MESIN", Txt_IDMesinDRT.Text);
                        cmd.Parameters.AddWithValue("@JUMLAH_SPINDLE", Txt_SpindleDRT.Text);
                        cmd.Parameters.AddWithValue("@MAX_SPEED", Txt_MaxSpeedDRT.Text);
                        cmd.Parameters.AddWithValue("@MIN_SPEED", Txt_MinSpeedDRT.Text);
                        cmd.Parameters.AddWithValue("@LAMA_PENGERJAAN", TxtDurationDRT.Text);
                        cmd.ExecuteNonQuery();
                        string pesan = "Data have been saved";
                        string judul = "WijayaSoft";
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        MessageBox.Show(pesan, judul, buttons, MessageBoxIcon.Information);
                        ClearDRT();
                        con.Close();
                        Mesin_DRT();
                        AutoIDMesinDRT();
                    }
                    else
                    {
                        con.Open();
                        cmd.CommandText = "update MASTER_MESIN_DRT set JUMLAH_SPINDLE='" + Txt_SpindleDRT.Text + "',MAX_SPEED='" + Txt_MaxSpeedDRT.Text + "',MIN_SPEED='" + Txt_MinSpeedDRT.Text + "',LAMA_PENGERJAAN='" + TxtDurationDRT.Text + "' where ID_MESIN='" + Txt_IDMesinDRT.Text + "'";
                        cmd.ExecuteNonQuery();
                        string pesan = "Data have been Update";
                        string judul = "WijayaSoft";
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        MessageBox.Show(pesan, judul, buttons, MessageBoxIcon.Information);
                        ClearDRT();
                        con.Close();
                        Mesin_DRT();
                        AutoIDMesinDRT();
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
        #endregion

        #region ClickButton
        private void BtnSaveRelling_Click(object sender, EventArgs e)
        {
            SaveRelling();
        }

        private void BtnDeleteRelling_Click(object sender, EventArgs e)
        {
            DeleteRelling();
        }

        private void BtnClearRelling_Click(object sender, EventArgs e)
        {
            ClearRelling();
        }
        private void BtnSaveDRT_Click(object sender, EventArgs e)
        {
            SaveDRT();
        }
        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearDRT();
        }
        private void BtnDeleteDRT_Click(object sender, EventArgs e)
        {
            DeleteDRT();
        }
        private void BtnSaveDT_Click(object sender, EventArgs e)
        {
            SaveDT();
        }

        private void BtnDeleteDT_Click(object sender, EventArgs e)
        {
            DeleteDT();
        }

        private void BtnClearDT_Click(object sender, EventArgs e)
        {
            ClearDT();
        }
        #endregion

        private void DG_DRT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = DG_DRT.Rows[index];
            Txt_IDMesinDRT.Text = selectedRow.Cells[0].Value.ToString();
            Txt_SpindleDRT.Text = selectedRow.Cells[1].Value.ToString();
            Txt_MaxSpeedDRT.Text = selectedRow.Cells[2].Value.ToString();
            Txt_MinSpeedDRT.Text = selectedRow.Cells[3].Value.ToString();
            TxtDurationDRT.Text = selectedRow.Cells[4].Value.ToString();
        }

        private void DG_DT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = DG_DT.Rows[index];
            TxtIDMesinDT.Text = selectedRow.Cells[0].Value.ToString();
            TxtSpindleDT.Text = selectedRow.Cells[1].Value.ToString();
            TxtMaxSpeedDT.Text = selectedRow.Cells[2].Value.ToString();
            TxtMinSpeedDT.Text = selectedRow.Cells[3].Value.ToString();
            TxtMaxTwistDT.Text = selectedRow.Cells[4].Value.ToString();
            TxtMinTwistDT.Text = selectedRow.Cells[5].Value.ToString();
            TxtDurationDRT.Text = selectedRow.Cells[6].Value.ToString();
        }

        private void DG_Relling_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = DG_Relling.Rows[index];
            TxtIDMesinRelling.Text = selectedRow.Cells[0].Value.ToString();
            TxtHankRelling.Text = selectedRow.Cells[1].Value.ToString();
            TxtMaxSpeedRelling.Text = selectedRow.Cells[2].Value.ToString();
            TxtMinSpeedRelling.Text = selectedRow.Cells[3].Value.ToString();
            TxtMaxDiameterRelling.Text = selectedRow.Cells[4].Value.ToString();
            TxtMaxDiameterRelling.Text = selectedRow.Cells[5].Value.ToString();
            TxtDurationRelling.Text = selectedRow.Cells[6].Value.ToString();
        }
    }
}