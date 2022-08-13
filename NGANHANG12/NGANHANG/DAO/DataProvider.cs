using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DangTinThueTro.DAO
{
    public class DataProvider
    {
        private static DataProvider instance;

        public const string connectionStrPublisher = "Data Source=TRUONG;Initial Catalog=NGANHANG;User ID=sa;Pwd=2711;";
        public static string connectionStr = "";

        private SqlConnection connection;

        public const string LOGIN_HTKN = "HTKN";
        public const string PASSWORD_HTKN = "2711";
        public static DataProvider Instance {
            get { 
                if(instance == null)
                {
                    instance = new DataProvider();
                }
                return instance;
            } 
            private set => instance = value;
        }
        public bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public void CloseConnection()
        {
            connection.Close(); 
        }
        public string GetConnectionStr()
        {
            return connectionStr;
        }
        // Thay đổi chuổi kết nối
        public void SetConnectionStr(string dataSource, string userId, string pwd)
        {
            connectionStr = "Data Source=" + dataSource + ";Initial Catalog=NGANHANG;User ID=" + userId + ";Pwd=" + pwd + ";";
            connection = new SqlConnection(connectionStr);
        }
        // Thay đổi chuổi kết nối thành mặc định (site chủ)
        public void SetConnectionStrDefault()
        {
            connectionStr = connectionStrPublisher;
            connection = new SqlConnection(connectionStr);
        }
        // Thực thi query trả về datatable
        public DataTable ExecuteQuerry(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();
            // Format lại query: thay các từ có chứa @ bằng tham số
            SqlCommand command = new SqlCommand(query, connection);
            if (parameter != null)
            {
                string[] listPara = query.Split(' ');
                int i = 0;
                foreach (string str in listPara)
                {
                    if (str.Contains('@'))
                    {
                        command.Parameters.AddWithValue(str, parameter[i]);
                        i++;
                    }
                }
            }
            // Thực hiện lấy dữ liệu từ db
            try
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
            }
            catch(Exception e)
            {
                throw e;
            }
            finally
            {
                connection.Close();
            }
            return data;
        }
        // Thực thi query
        public int ExecuteNonQuerry(string query, object[] parameter = null)
        {
            int data = 0;
            // Format lại query: thay các từ có chứa @ bằng tham số
            SqlCommand command = new SqlCommand(query, connection);
            if (parameter != null)
            {
                string[] listPara = query.Split(' ');
                int i = 0;
                foreach (string str in listPara)
                {
                    if (str.Contains('@'))
                    {
                        command.Parameters.AddWithValue(str, parameter[i]);
                        i++;
                    }
                }
            }
            // Thực hiện lấy dữ liệu từ db
            try
            {
                connection.Open();
                data = command.ExecuteNonQuery();
            }
            catch(Exception e)
            {
                throw e;
            }
            finally
            {
                connection.Close();
            }
            return data;
        }
        // Thực thi query trả về datareader
        public SqlDataReader ExecuteSqlDataReader(String query, object[] parameter = null)
        {
            SqlDataReader myReader = null;
            // Format lại query: thay các từ có chứa @ bằng tham số
            SqlCommand command = new SqlCommand(query, connection);
            if (parameter != null)
            {
                string[] listPara = query.Split(' ');
                int i = 0;
                foreach (string str in listPara)
                {
                    if (str.Contains('@'))
                    {
                        command.Parameters.AddWithValue(str, parameter[i]);
                        i++;
                    }
                }
            }
            // Thực hiện lấy dữ liệu từ db
            try
            {
                myReader = command.ExecuteReader();
            }
            catch (Exception e)
            {
                throw e;
            }
            return myReader;
        }
    }
}
