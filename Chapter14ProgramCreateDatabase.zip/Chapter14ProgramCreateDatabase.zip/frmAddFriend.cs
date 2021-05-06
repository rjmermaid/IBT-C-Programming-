using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Collections;

namespace Chapter14ProgramCreateDatabase.zip
{
    public partial class frmAddFriend : Form
    {

        int records;
        private string connectStr;
        clsDB myDB;
        public frmAddFriend()
        {
            InitializeComponent();
        }

        public frmAddFriend(string connect) : this()
        {
            connectStr = connect;
            myDB = new clsDB(connectStr);
            records = myDB.ReadRecordCount(connectStr);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int status;
            string sqlCommand;

            if (checkBox1.Checked == true)
                status = 1;
            else
                status = 0;
            try
            {
                myDB = new clsDB(connectStr);
                records = myDB.ReadRecordCount(connectStr);
                records++;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
                return;
            }

            sqlCommand = "INSERT INTO Friends" + " (ID,FirstName,LastName,Addr1,Addr2,City,State,Zip,LastContact,Status) Values (";

            sqlCommand += records + "," + txtFirstName.Text + "," + txtLastName + "," + txtAddr1 + "," + txtAddr2 + "," + txtCity + "," + txtState + "," + txtZip + "," + txtLastContact + "," + status + ")";
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
                    MessageBox.Show("Add new friend successful");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
                return;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAddr1.Clear();
            txtAddr2.Clear();
            txtCity.Clear();
            txtFirstName.Clear();
            txtLastContact.Clear();
            txtLastName.Clear();
            txtState.Clear();
            txtZip.Clear();
            checkBox1.Checked = true;

            txtFirstName.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
