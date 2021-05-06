using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Collections;

namespace Chapter14ProgramCreateDatabase.zip
{
    public partial class frmCardExchange : Form
    {
        ArrayList myList = new ArrayList();

        Int32 countOfFriends;
        Int32 countOfCardTypes;
        Int32 countOfExchanges;

        private frmMain mdiParent;
        private string serverName;
        private string databaseName;


        clsCardsExchanged myExchange;
        clsFriend myData;
        clsCardTypes myTypes;

        private string connectStr;
        private TextBox txtDateSent;
        private Label label9;
        private TextBox txtDateReceived;
        private Label label11;
        private ComboBox cmbList;
        private Label label10;

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnFindRecord;
        private System.Windows.Forms.TextBox txtFindRecordNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkStatus;
        private System.Windows.Forms.TextBox txtLastContact;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAddr2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAddr1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFirstName;
        public frmCardExchange()
        {
            InitializeComponent();
        }

        public frmCardExchange(frmMain me) : this()
        {

            this.mdiParent = me;
            serverName = me.getServerName;
            databaseName = me.getDatabaseName;
            connectStr = me.getConnectString;

            myData = new clsFriend();                               // Number of friends in DB
            countOfFriends = myData.RecordCount(connectStr);


            myExchange = new clsCardsExchanged(connectStr);         // Number of cards in DB
            countOfExchanges = myExchange.RecordCount(connectStr);

            myTypes = new clsCardTypes(connectStr);                 // Number of card types...
            countOfCardTypes = myTypes.GetCardTypesCount();

            myExchange.PopulateListboxWithCardTypes(myList);        // ...displayed in combo box
            for (int i = 0; i < myList.Count; i++)
            {
                cmbList.Items.Add(myList[i]);
            }
            cmbList.SelectedIndex = 0;
            txtFindRecordNumber.Focus();

        }

        private void frmCardExchange_Load(object sender, EventArgs e)
        {
        }

        /*****
         * Purpose: Find a friend record
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

            myData = new clsFriend();
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

        #region Reading-Displaying data

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

        /*****
         * Purpose: Copies data from textboxes to class members.
         * 
         * Parameter list:
         *  n/a
         *  
         * Return value:
         *  void
         ******/

        private void CopyData()
        {
            int rec;
            bool flag = int.TryParse(txtFindRecordNumber.Text, out rec);

            myExchange = new clsCardsExchanged(connectStr);         // Number of cards in DB

            if (flag == false)
            {
                MessageBox.Show("Must have integer value for record number.");
                return;
            }
            myExchange.ID = rec;                    // Who is the card tied to?

            myExchange.CardType = cmbList.SelectedIndex;       // What type of card?

            if (txtDateReceived.Text.Length != 0)
            {
                myExchange.CardReceived = txtDateReceived.Text;
                myExchange.CardSent = "";
            }
            else
            {
                myExchange.CardSent = txtDateSent.Text;
                myExchange.CardReceived = "";
            }

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

            txtDateReceived.Text = "";
            txtDateSent.Text = "";

            txtLastName.Focus();
        }
        #endregion

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        /*****
         * Purpose: Save a card exchange to DB
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
            int flag;

            CopyData();             // Move data into class
            flag = myExchange.WriteOneRecord();
            switch (flag)
            {
                case 1:
                    MessageBox.Show("Data written to database");
                    break;
                case 2:
                    MessageBox.Show("Error writting data to database");
                    break;
                case 3:
                    MessageBox.Show("Error closing database");
                    break;
                default:
                    MessageBox.Show("Unknown error");
                    break;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
    }
}
