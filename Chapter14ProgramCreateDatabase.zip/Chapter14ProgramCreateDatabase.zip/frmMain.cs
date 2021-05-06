using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter14ProgramCreateDatabase.zip
{
    public partial class frmMain : Form
    {

        private string dbName;
        public string whichServer;
        private string connectionString;

        #region Windows code

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuFile;
        private ToolStripMenuItem mnuDB;
        private ToolStripMenuItem mnuAddRecord;
        private ToolStripMenuItem mnuEdit;
        private ToolStripMenuItem mnuSendReceivedReport;
        private ToolStripMenuItem mnuListFriends;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem mnuAbout;
        private ToolStripMenuItem mnuSelectServer;
        private ToolStripSeparator toolStripSeparator1;
        private Label lblWaiting;
        private ToolStripMenuItem mnuAddNewCard;
        private ToolStripMenuItem mnuAddNewCardType;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem cardsSentReceivedToolStripMenuItem;
        private ToolStripMenuItem mnuExit;


        public frmMain()
        {
            InitializeComponent();
        }


        [STAThread]
        public static void Main()
        {
            frmMain main = new frmMain();
            Application.Run(main);
        }


        //================================ Property Methods ====================================
        public string getServerName
        {
            get
            {
                return whichServer;
            }
            set
            {
                whichServer = value;
            }
        }
        public string getDatabaseName
        {
            get
            {
                return dbName;
            }
            set
            {
                dbName = value;
            }
        }
        public string getConnectString
        {
            get
            {
                return connectionString;
            }
            set
            {
                connectionString = value;
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Close();
        }




        private void mnuAddRecord_Click(object sender, EventArgs e)
        {
            frmAddFriend newRec = new frmAddFriend(connectionString);
            newRec.ShowDialog();
        }

        private void mnuEdit_Click(object sender, EventArgs e)
        {
            frmEditFriend editRec = new frmEditFriend(connectionString);
            editRec.ShowDialog();
        }

        private void mnuListFriends_Click(object sender, EventArgs e)
        {
            frmReport myFriendReport = new frmReport(this);
            myFriendReport.ShowDialog();
        }

        private void mnuAbout_Click(object sender, EventArgs e)
        {
            frmAbout myAbout = new frmAbout();
            myAbout.ShowDialog();
        }

        private void mnuSelectServer_Click(object sender, EventArgs e)
        {

            //### Debug code set here:
            /*
            whichServer = "ECONJACK-PC";
                    dbName = "Cards";
                    connectionString = connectionString = "server=" + whichServer + ";integrated security=SSPI;database=" + dbName;
            */

            frmServerSelect myServer = new frmServerSelect(this);
            myServer.ShowDialog();
            if (whichServer.Length == 0 || dbName.Length == 0)
            {
                MessageBox.Show("You must select a server and database name.");
                return;
            }
            this.Text = "Database Management Subsystem:      Server:  " + whichServer + "     Database:  " + dbName;
            connectionString = "server=" + whichServer + ";integrated security=SSPI;database=" + dbName;

        }

        private void mnuAddNewCardType_Click(object sender, EventArgs e)
        {
            frmAddNewCardType myNewCard = new frmAddNewCardType(this);
            myNewCard.ShowDialog();
        }

        private void mnuAddNewCard_Click(object sender, EventArgs e)
        {
            frmCardExchange myExchange = new frmCardExchange(this);
            myExchange.ShowDialog();
        }

        private void cardsSentReceivedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCardReport myReport = new frmCardReport(this);
            myReport.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }


    }
}
#endregion