using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;

namespace Chapter14ProgramCreateDatabase.zip
{
    class clsDB
    {
        private string serverName;                  // Server for DB
        private string databaseName;                // Name of DB
        private Int32 recordCount;                  // How many friends in DB
        private string connectString;

        public clsDB()
        {
            databaseName = "";
        }
        public clsDB(string conn) : this()
        {
            connectString = conn;
        }


        public string getConnectString
        {
            get
            {
                return connectString;
            }
            set
            {
                if (value.Length > 0)
                    connectString = value;
            }
        }

        public string getServerName
        {
            get
            {
                return serverName;
            }
            set
            {
                if (value.Length > 0)
                    serverName = value;
            }
        }

        public string getDatabaseName
        {
            get
            {
                return databaseName;
            }
            set
            {
                if (value.Length > 0)
                    databaseName = value;
            }
        }

        public Int32 getRecordCount
        {
            get
            {
                return recordCount;
            }
            set
            {
                if (value > -1)
                    recordCount = value;
            }
        }

        public Int32 ReadRecordCount(string connectStr)
        {
            try
            {
                SqlConnection conn = new SqlConnection(connectStr);
                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT COUNT(LastName) FROM Friends", conn);
                recordCount = (Int32)cmd.ExecuteScalar();

            }
            catch
            {
                return -1;
            }
            return recordCount;
        }

        public int ProcessCommand(string sqlCommand)
        {
            int flag = 1;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectString))
                {
                    conn.Open();

                    SqlCommand command = new SqlCommand(sqlCommand, conn);
                    flag = command.ExecuteNonQuery();                      // Add new record
                    conn.Close();
                }
            }
            catch
            {
                flag = 0;
            }
            return flag;
        }
    }
}
