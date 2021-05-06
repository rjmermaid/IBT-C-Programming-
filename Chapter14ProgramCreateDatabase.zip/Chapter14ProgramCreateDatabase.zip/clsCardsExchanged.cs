using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections;

namespace Chapter14ProgramCreateDatabase.zip
{
    class clsCardsExchanged
    {
        private Int32 records;
        private string connectStr;
        clsDB myDB;

        private int id;
        private int cardType;
        private string dateSent;
        private string dateReceived;

        public clsCardsExchanged()
        {
            dateSent = "";
            dateReceived = "";
        }

        public clsCardsExchanged(string connect) : this()
        {
            connectStr = connect;
            myDB = new clsDB(connectStr);
            records = myDB.ReadRecordCount(connectStr);

        }


        public int ID
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }
        public int CardType
        {
            get
            {
                return cardType;
            }

            set
            {
                cardType = value;
            }
        }
        public string CardSent
        {
            get
            {
                return dateSent;
            }

            set
            {
                if (value.Length > 0)
                    dateSent = value;
            }
        }

        public string CardReceived
        {
            get
            {
                return dateReceived;
            }

            set
            {
                if (value.Length > 0)
                    dateReceived = value;
            }
        }

        public Int32 RecordCount(string connectStr)
        {
            try
            {
                SqlConnection conn = new SqlConnection(connectStr);
                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT COUNT(LastName) FROM CardsExchanged", conn);
                records = (Int32)cmd.ExecuteScalar();

            }
            catch
            {
                return -1;
            }
            return records;
        }


        public int ReadOneRecord(string sql, SqlConnection myConnection)
        {
            try
            {
                SqlDataReader myReader = null;
                SqlCommand myCommand = new SqlCommand(sql, myConnection);
                myReader = myCommand.ExecuteReader();
                myReader.Read();

                id = (int)myReader[0];
                cardType = (int)myReader[1];
                dateSent = (string)myReader[2];
                dateReceived = (string)myReader[3];
                myReader.Close();

            }
            catch
            {
                return -1;
            }
            return 1;               // Everything ok
        }


        public int PopulateListboxWithCardTypes(ArrayList myList)
        {
            string sql = "SELECT * FROM CardTypes";
            string temp;
            int i = 0;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectStr))
                {
                    conn.Open();
                    SqlDataReader myReader = null;
                    SqlCommand myCommand = new SqlCommand(sql, conn);
                    myReader = myCommand.ExecuteReader();
                    i++;
                    while (myReader.Read())
                    {
                        temp = i.ToString() + "    " + myReader[1].ToString();   // We are only reading the description               
                        myList.Add(temp);
                        i++;
                    }
                    myReader.Close();
                    conn.Close();
                }
            }
            catch
            {
                return -1;
            }
            return 1;
        }

        public int WriteOneRecord()
        {
            int flag = 1;
            string sqlCommand;
            string date;

            if (dateReceived.Length > 0)
                date = dateReceived;
            else
                date = dateSent;

            sqlCommand = "UPDATE Friends SET LastContact = '" + date +  // Build UPDATE command
                         "' WHERE ID = " + id.ToString();

            try
            {
                clsFriend myData = new clsFriend(connectStr);
                flag = myData.ProcessCommand(sqlCommand);
            }
            catch
            {
                return flag;
            }

            // Build INSERT command
            sqlCommand = "INSERT INTO CardsExchanged" +
                         " (ID,TypeOfCard, Sent, Received) VALUES (";
            // Now add the values
            sqlCommand += id + "," + cardType + ",'" + dateSent + "','" + dateReceived + "')";

            try
            {
                using (SqlConnection myConnection = new SqlConnection(connectStr))
                {
                    myConnection.Open();
                    using (SqlCommand myCommand = new SqlCommand(sqlCommand, myConnection))
                    {
                        myCommand.ExecuteNonQuery();
                    }
                    myConnection.Close();
                }
            }
            catch
            {
                return -1;           // Something's amiss...
            }

            return 1;
        }

    }
}
