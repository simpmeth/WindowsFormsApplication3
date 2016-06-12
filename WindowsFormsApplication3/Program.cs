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
        public SqlConnection DbSqlConnection;
        public SqlDataReader Reader;
        public SqlCommand cmd;
        public DataReaderBySql()
        {
            DbSqlConnection= new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"" + Application.StartupPath + "\\sql.mdf\";Integrated Security = True; Connect Timeout = 30");
        }
        public SqlDataReader GetDataReaderBySql(string sqlQuery) 
        {
            if (sqlQuery.Length==0) return null; 
            cmd = new SqlCommand();
            
            cmd.CommandText = sqlQuery;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = DbSqlConnection;

            DbSqlConnection.Open();

            Reader = cmd.ExecuteReader();


            return Reader;
        }

        public int DoSqlCommand(string sqlQuery)
        {
            cmd = new SqlCommand();

            cmd.CommandText = sqlQuery;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = DbSqlConnection;

            if (sqlQuery.Length == 0) return 0;

           
            try
            {   
                cmd.Connection.Open();
                var countAff =  cmd.ExecuteReader().RecordsAffected;
                cmd.Connection.Close();
                
                return countAff;
            }
            catch(Exception e)
            {
                var exception = e;
                return -1; 
            }

        }

        public void CloseDbConnection()
        {
            DbSqlConnection.Close();
        }

        public DataTable GetDataSource()
        {
            if (!Reader.HasRows) return null;

            var dt = new DataTable();
            dt.Load(Reader);
            return dt;
        }
    }
}
