using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using NGANHANG.GUI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace NGANHANG
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static SqlConnection conn = new SqlConnection();
        public static String connstr;
        public static String constr_publisher = "Data Source=THANHTAN;Initial Catalog=NGANHANG;Integrated Security=True";

        public static SqlDataReader myReader;
        public static String servername = "";
        public static String mlogin = "";
        public static String userName = "";
        public static String pass = "";


        public static String database = "NGANHANG";
        public static String remoteLogin = "HTKN";
        public static String remotePass = "123456";
        public static String mloginDn = "";
        public static String mPassDn = "";
        public static String mGroup = "";
        public static String mHoTen = "";
        public static int mChiNhanh = 0;
        public static BindingSource bds_dspm = new BindingSource();
        public static string maChiNhanh = "";

        //public static FormMain mf;
        public static int ketNoiCsdl()
        {
            if (Program.conn != null && Program.conn.State == ConnectionState.Open)
                Program.conn.Close();
            try
            {
                Program.connstr = "Data Source=" + Program.servername + ";Initial Catalog=" +
                    Program.database + ";User ID=" +
                    Program.mlogin + ";password=" + Program.pass;
                Program.conn.ConnectionString = Program.connstr;
                Program.conn.Open();
                return 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                return 0;
            }
        }



        //public static DataTable excuteDataTable(string query)
        //{
        //    DataTable dt = new DataTable();
        //    if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
        //    SqlDataAdapter da = new SqlDataAdapter(query, conn);
        //    da.Fill(dt);
        //    conn.Close();
        //    return dt;
        //}
        //public static SqlDataReader execSqlDataReader(String query)
        //{
        //    SqlDataReader myReader;
        //    SqlCommand cmd = new SqlCommand(query, Program.conn);
        //    cmd.CommandType = CommandType.Text;
        //    if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
        //    try
        //    {
        //        myReader = cmd.ExecuteReader(); return myReader;
        //    }
        //    catch (Exception ex)
        //    {
        //        Program.conn.Close();
        //        MessageBox.Show(ex.Message);
        //        return null;
        //    }
        //}


        //public static void ShowMainForm()
        //{
        //    mf = new mainForm();
        //    mf.ShowDialog();
        //}
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormDangNhap());
        }
    }
}
