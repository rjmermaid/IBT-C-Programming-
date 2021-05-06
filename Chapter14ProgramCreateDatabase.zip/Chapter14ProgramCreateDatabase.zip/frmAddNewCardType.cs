using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Collections;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace Chapter14ProgramCreateDatabase.zip
{
    public partial class frmAddNewCardType : Form
    {

        private frmMain mdiParent;
        private string serverName;
        private string databaseName;

        Int32 records;
        private string connectStr;
        clsCardTypes myCardTypes;


        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCardDescription;
        private System.Windows.Forms.Button btnSave;
        private Button btnClear;
        private System.Windows.Forms.Button btnClose;

        public frmAddNewCardType()
        {
            InitializeComponent();
        }

        public frmAddNewCardType(frmMain me)
        {
            InitializeComponent();
            this.mdiParent = me;
            serverName = me.getServerName;
            databaseName = me.getDatabaseName;
            connectStr = me.getConnectString;

            myCardTypes = new clsCardTypes(connectStr);

            try
            {
                records = myCardTypes.GetCardTypesCount();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }


        }

        private void frmAddNewCardType_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }


        /*****
        * Purpose: Save a new card type into DB
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
            string sqlCommand;

            myCardTypes = new clsCardTypes(connectStr);

            records++;          // Going to add new record

            SqlConnection myConnection = new SqlConnection(connectStr);
            try
            {
                myConnection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error openning database: " + ex.Message);
                return;
            }

            // Build INSERT command
            sqlCommand = "INSERT INTO CardTypes" + " (CardType,Description) VALUES ('";

            // Now add the values
            sqlCommand += records.ToString() + "','" + txtCardDescription.Text + "')";

            try
            {
                SqlCommand myCommand = new SqlCommand(sqlCommand, myConnection);
                myCommand.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to add data, Error: " + ex.Message);
                return;
            }

            try
            {
                myConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to close database, Error: " + ex.Message);
                return;
            }
            MessageBox.Show("Card type added to database");

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCardDescription.Text = "";
            txtCardDescription.Focus();
        }
    }
}
