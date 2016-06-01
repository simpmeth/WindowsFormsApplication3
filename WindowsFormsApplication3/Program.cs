using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace WindowsFormsApplication3
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ShopForm());
        }
    }

    public class DataReaderBySql
    {
        public SqlConnection dbSqlConnection;
        public SqlDataReader reader;
        public DataReaderBySql()
        {
            dbSqlConnection= new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\""+Application.StartupPath+"\\sql.mdf\";Integrated Security=True;Connect Timeout=30;Context Connection=False");
        }

        public SqlDataReader GetDataReaderBySql(string sqlQuery) 
        {
            if (sqlQuery.Length==0) return null; 
            SqlCommand cmd = new SqlCommand();
            

            cmd.CommandText = sqlQuery;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = dbSqlConnection;

            dbSqlConnection.Open();

            reader = cmd.ExecuteReader();
            return reader;
        }

        public void CloseDbConnection()
        {
            dbSqlConnection.Close();
        }

        public DataTable GetDataSource()
        {
            if (!reader.HasRows) return null;

            var dt = new DataTable();
            dt.Load(reader);
            return dt;
        }
    }
}
