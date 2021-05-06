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
using System.Collections;

namespace Chapter14ProgramCreateDatabase.zip
{
    public partial class frmCardReport : Form
    {

        int idToUse;

        Int32 countOfCardTypes;
        Int32 countOfExchanges;

        private string serverName;
        private string databaseName;
        private string connectStr;

        ArrayList myFriends = new ArrayList();
        ArrayList myCardList = new ArrayList();

        private frmMain mdiParent;

        clsCardsExchanged myExchange;
        clsFriend myData;
        clsCardTypes myTypes;

        private ListBox lstResult;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox cmbLastName;

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbDate;
        private System.Windows.Forms.RadioButton rbSent;
        private System.Windows.Forms.RadioButton rbReceived;
        private System.Windows.Forms.RadioButton rbType;
        private System.Windows.Forms.RadioButton rbPerson;
        private System.Windows.Forms.RadioButton rbAll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox cmbList;
        public frmCardReport()
        {
            InitializeComponent();
        }


        public frmCardReport(frmMain me) : this()
        {
            int index;
            int i;
            string temp;

            this.mdiParent = me;
            serverName = me.getServerName;
            databaseName = me.getDatabaseName;
            connectStr = me.getConnectString;

            myData = new clsFriend();
            myData.PopulatListWithFriend(myFriends, connectStr);
            for (i = 0; i < myFriends.Count; i++)
            {
                temp = myFriends[i].ToString();
                index = temp.IndexOf(' ');
                myFriends[i] = temp.Substring(index + 1);
                cmbLastName.Items.Add(myFriends[i]);
            }
            cmbLastName.SelectedIndex = 0;

            myExchange = new clsCardsExchanged(connectStr);         // Number of cards in DB
            countOfExchanges = myExchange.RecordCount(connectStr);

            myTypes = new clsCardTypes(connectStr);                 // Number of card types...
            countOfCardTypes = myTypes.GetCardTypesCount();

            myExchange.PopulateListboxWithCardTypes(myCardList);    // ...displayed in combo box
            for (i = 0; i < myCardList.Count; i++)
            {
                temp = myCardList[i].ToString();

                index = temp.IndexOf(' ');
                myCardList[i] = temp.Substring(index + 3);
                cmbList.Items.Add(myCardList[i]);
            }
            cmbList.SelectedIndex = 0;
            rbAll.Checked = true;                                   // Default search is for all

            cmbLastName.Enabled = false;
            cmbList.Enabled = false;
            txtDate.Enabled = false;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        /*****
         * Purpose: Find all exchanged cards that meet the query
         * 
         * Parameter list:
         *  object sender   control that caused the event
         *  EventArgs e     details about the sender
         *  
         * Return value:
         *  void
         ******/
        private void btnSearch_Click(object sender, System.EventArgs e)
        {

            lstResult.Items.Clear();

            if (rbAll.Checked == true)                          // List everything
            {
                ReadAll("SELECT * FROM CardsExchanged");

            }
            else if (rbPerson.Checked == true)                  // By friend
            {
                idToUse = cmbLastName.SelectedIndex + 1;        // Zero-based index
                ReadAll("SELECT * FROM CardsExchanged WHERE ID=" + idToUse.ToString());
            }
            else if (rbReceived.Checked == true)                // By date received
            {
                if (txtDate.Text.Length == 0)
                {
                    MessageBox.Show("Enter date received");
                    txtDate.Enabled = true;
                    txtDate.Focus();
                }
                ReadAll("SELECT * FROM CardsExchanged WHERE Received='" + txtDate.Text + "'");
            }
            else if (rbSent.Checked == true)                    // By date sent
            {
                if (txtDate.Text.Length == 0)
                {
                    MessageBox.Show("Enter date sent");
                    txtDate.Enabled = true;
                    txtDate.Focus();
                }
                ReadAll("SELECT * FROM CardsExchanged WHERE Sent='" + txtDate.Text + "'");
            }
            else if (rbType.Checked == true)                    // By card type
            {
                idToUse = cmbList.SelectedIndex;
                ReadAll("SELECT * FROM CardsExchanged WHERE TypeOfCard=" + idToUse.ToString());
            }
            else if (rbDate.Checked == true)                    // By either date
            {
                ReadAll("SELECT * FROM CardsExchanged WHERE Sent='" + txtDate.Text + "' OR Received='" + txtDate.Text + "'");
            }
        }

        /*****
        * Purpose: A data dump of the exchanged cards table
        * 
        * Parameter list:
        *  string sql
        *  
        * Return value:
        *  void
        ******/
        private void ReadAll(string sql)
        {
            int nameIndex;
            int cardIndex;
            int count = 0;

            string result;
            string lastName;
            string whichCard;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectStr))
                {
                    conn.Open();
                    SqlDataReader myReader = null;
                    SqlCommand myCommand = new SqlCommand(sql, conn);
                    myReader = myCommand.ExecuteReader();
                    while (myReader.Read())
                    {
                        nameIndex = (int)myReader[0];
                        lastName = myFriends[nameIndex - 1].ToString();     // Need to subtract one because it's zero-based
                        cardIndex = (int)myReader[1];
                        whichCard = myCardList[cardIndex].ToString();
                        result = string.Format("{0, -20} {1, -25} {2, -15} {3, -15}", lastName, whichCard, myReader[2], myReader[3]);
                        lstResult.Items.Add(result);
                        count++;
                    }
                    myReader.Close();
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }


            if (count == 0)
            {
                MessageBox.Show("No data found");
            }

        }

        private void rbDate_CheckedChanged(object sender, System.EventArgs e)
        {
            if (rbDate.Checked == true)
            {
                cmbList.Enabled = false;
                cmbLastName.Enabled = false;
                txtDate.Enabled = true;
            }
        }

        private void rbPerson_CheckedChanged(object sender, System.EventArgs e)
        {
            if (rbPerson.Checked == true)
            {
                cmbList.Enabled = false;
                cmbLastName.Enabled = true;
                txtDate.Enabled = false;
            }
        }

        private void rbReceived_CheckedChanged(object sender, System.EventArgs e)
        {
            if (rbReceived.Checked == true)
            {
                cmbLastName.Enabled = false;
                cmbList.Enabled = false;
                txtDate.Enabled = true;
            }

        }

        private void rbSent_CheckedChanged(object sender, System.EventArgs e)
        {
            if (rbSent.Checked == true)
            {
                cmbLastName.Enabled = false;
                cmbList.Enabled = false;
                txtDate.Enabled = true;
            }
        }

        private void rbDate_CheckedChanged_1(object sender, System.EventArgs e)
        {
            if (rbDate.Checked == true)
            {
                cmbLastName.Enabled = false;
                cmbList.Enabled = false;
                txtDate.Enabled = true;
            }
        }

        private void rbType_CheckedChanged(object sender, System.EventArgs e)
        {
            if (rbType.Checked == true)
            {
                cmbLastName.Enabled = false;
                txtDate.Enabled = false;
                cmbList.Enabled = true;
            }
        }

        private void rbAll_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAll.Checked == true)
            {
                cmbLastName.Enabled = false;
                txtDate.Enabled = false;
                cmbList.Enabled = false;
            }

        }

        private void frmCardReport_Load(object sender, EventArgs e)
        {

        }
    }
}
