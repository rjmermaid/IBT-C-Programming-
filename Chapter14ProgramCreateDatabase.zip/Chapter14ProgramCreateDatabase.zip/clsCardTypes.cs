﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Odbc;
using System.Data.Sql;

namespace Chapter14ProgramCreateDatabase.zip
{
    class clsCardTypes
    {
        private const int MAXLENGTH = 25;

        private string cardDescription;
        private Int32 records;
        private string connectStr;

        clsDB myDB;

        public clsCardTypes(string connect)
        {
            connectStr = connect;
            myDB = new clsDB(connectStr);
            records = myDB.ReadRecordCount(connectStr);
        }

        public string getDescription
        {
            get
            {
                return cardDescription;
            }
            set
            {
                if (value.Length > 0 || value.Length <= MAXLENGTH)
                {
                    cardDescription = value;
                }
            }
        }

        public Int32 getRecordCount
        {
            get
            {
                return records;
            }
            set
            {
                records = value;
            }
        }

        public Int32 GetCardTypesCount()
        {
            try
            {
                SqlConnection conn = new SqlConnection(connectStr);
                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT COUNT(Description) FROM CardTypes", conn);
                records = (Int32)cmd.ExecuteScalar();
                conn.Close();
            }
            catch
            {
                return -1;
            }
            return records;
        }
    }
}
