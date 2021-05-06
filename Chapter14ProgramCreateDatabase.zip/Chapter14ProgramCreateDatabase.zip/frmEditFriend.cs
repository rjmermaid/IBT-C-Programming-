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

namespace Chapter14ProgramCreateDatabase.zip
{
    public partial class frmEditFriend : Form
    {

        Int32 records;

        private string connectStr;

        clsDB myDB;
        clsFriend myData;

        private GroupBox groupBox1;
        private CheckBox chkStatus;
        private TextBox txtLastContact;
        private Label label13;
        private Label label6;
        private TextBox txtZip;
        private Label label7;
        private TextBox txtState;
        private Label label8;
        private TextBox txtCity;
        private Label label5;
        private TextBox txtAddr2;
        private Label label4;
        private TextBox txtAddr1;
        private Label label3;
        private TextBox txtLastName;
        private Label label1;
        private TextBox txtFirstName;
        private Label label2;
        private TextBox txtFindRecordNumber;
        private Button btnSave;
        private Button btnClear;
        private Button btnClose;
        private Button btnFindRecord;
        public frmEditFriend()
        {
            InitializeComponent();
            ClearFields();
        }

        public frmEditFriend(string connect)
        : this()
        {
            connectStr = connect;
            myDB = new clsDB(connectStr);
            records = myDB.ReadRecordCount(connectStr);
            txtFindRecordNumber.Focus();
        }



        #region Reading-Displaying data

        //==================================== Helper Methods ============================

        /*****
         * Purpose: Move the record data into the textboxes
         * 
         * Parameter list:
         *  n/a
         *  
         * Return value:
         *  void
         ******/
        private void ShowOneRecord()
        {
            txtFindRecordNumber.Text = myData.ID.ToString();
            txtFirstName.Text = myData.FirstName;
            txtLastName.Text = myData.LastName;
            txtAddr1.Text = myData.Address1;
            txtAddr2.Text = myData.Address2;
            txtCity.Text = myData.City;
            txtState.Text = myData.State;
            txtZip.Text = myData.Zip;
            txtLastContact.Text = myData.LastContact;
            int status = myData.Status;
            if (status == 1)
                chkStatus.Checked = true;
            else
                chkStatus.Checked = false;

        }

        #endregion



        #region Save-Add-Delete buttons code


        /*****
         * Purpose: Clears out the textboxes and gets ready to accept new record
         * 
         * Parameter list:
         *  object sender   control that caused the event
         *  EventArgs e     details about the sender
         *  
         * Return value:
         *  void
         ******/
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ClearFields();

        }

        private void ClearFields()
        {
            txtFindRecordNumber.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtAddr1.Text = "";
            txtAddr2.Text = "";
            txtCity.Text = "";
            txtState.Text = "";
            txtZip.Text = "";
            txtLastContact.Text = "";

            txtLastName.Focus();
        }

        #endregion

        /*****
         * Purpose: Find info for a record.
         * 
         * Parameter list:
         *  object sender   control that caused the event
         *  EventArgs e     details about the sender
         *  
         * Return value:
         *  void
         ******/
        private void btnFindRecord_Click(object sender, EventArgs e)
        {
            int retValue;
            string sql;

            if (txtLastName.Text.Length == 0)
                sql = "SELECT * FROM Friends WHERE ID = " + txtFindRecordNumber.Text;           // Search by record ID
            else
                sql = "SELECT * FROM Friends WHERE LastName = '" + txtLastName.Text + "'";      // Search by Name

            myData = new clsFriend();
            retValue = myData.ReadOneRecord(sql, connectStr);
            if (retValue > 0)
                ShowOneRecord();
            else
                MessageBox.Show("Could not read friend record");

        }

        private void frmEditFriend_Load(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        /*****
         * Purpose: Save textbox info as a record in Friends table.
         * 
         * Parameter list:
         *  object sender   control that caused the event
         *  EventArgs e     details about the sender
         *  
         * Return value:
         *  void
         ******/
        private void btnSave_Click(object sender, EventArgs e)
        {
            int status;
            int flag;
            string sqlCommand;


            if (chkStatus.Checked == true)
                status = 1;
            else
                status = 0;

            myData = new clsFriend(connectStr);

            // Build UPDATE command
            sqlCommand = "UPDATE Friends SET " +
                         "FirstName = '" + txtFirstName.Text + "'," +
                         "LastName = '" + txtLastName.Text + "'," +
                         "Addr1 = '" + txtAddr1.Text + "'," +
                         "Addr2 = '" + txtAddr2.Text + "'," +
                         "City = '" + txtCity.Text + "'," +
                         "State = '" + txtState.Text.ToUpper() + "'," +
                         "Zip = '" + txtZip.Text + "'," +
                         "LastContact = '" + txtLastContact.Text + "'," +
                         "Status = " + status.ToString() +
                         " WHERE ID = " + txtFindRecordNumber.Text;
            try
            {
                flag = myData.ProcessCommand(sqlCommand);
                if (flag > 0)
                {
                    MessageBox.Show("Record updated successfully.");
                }
                else
                {
                    MessageBox.Show("Failed to update data.", "Process Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


    }
}
