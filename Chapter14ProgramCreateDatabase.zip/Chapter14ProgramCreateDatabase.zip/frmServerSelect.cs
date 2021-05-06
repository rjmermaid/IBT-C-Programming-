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

namespace Chapter14ProgramCreateDatabase.zip
{
    public partial class frmServerSelect : Form
    {

        private const int SYSTEMDBTYPES = 4;

        #region Windows stuff
        private Label label3;
        private ComboBox cmbServer;
        private ComboBox cmbDatabase;
        private Label lblDb;
        private Button btnServer;
        private Button btnClose;

        public frmServerSelect()
        {
            InitializeComponent();
        }

        private frmMain mdiParent;

        string serverToUse;

        //==================================== Constructor ===========================
        public frmServerSelect(frmMain me)
        {
            InitializeComponent();
            this.mdiParent = me;
            string serverName;

            try
            {
                clsSqlServerList SqlSL = new clsSqlServerList();
                SqlDataSourceEnumerator instance = SqlDataSourceEnumerator.Instance;
                DataTable mySources = instance.GetDataSources();
                foreach (DataRow row in mySources.Rows)
                {
                    SqlSL = new clsSqlServerList();
                    serverName = row[0].ToString();
                    cmbServer.Items.Add(serverName);
                }
                cmbServer.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        /*****
         * Purpose: List the available DB's
         * 
         * Parameter list:
         *  object sender   control that caused the event
         *  EventArgs e     details about the sender
         *  
         * Return value:
         *  void
         ******/
        private void btnServer_Click(object sender, EventArgs e)
        {
            short i;

            cmbServer.SelectedIndex = 0;                    // Use the server they selected to list databases
            serverToUse = cmbServer.SelectedItem.ToString();

            string conn = "Data Source=" + serverToUse + "; Integrated Security=True;";
            cmbDatabase.Visible = true;
            lblDb.Visible = true;

            try
            {
                using (SqlConnection sqlConn = new SqlConnection(conn))
                {
                    sqlConn.Open();
                    DataTable tblDbs = sqlConn.GetSchema("Databases");
                    sqlConn.Close();

                    foreach (DataRow row in tblDbs.Rows)
                    {
                        i = (short)row.ItemArray[1];
                        if (i > SYSTEMDBTYPES)
                            cmbDatabase.Items.Add(row["database_name"].ToString());
                    }
                }
                cmbDatabase.SelectedIndex = 0;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error occurred while reading database data: " + ex.Message);
            }
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            // Now send the selections back to the parent.
            this.mdiParent.getServerName = cmbServer.SelectedItem.ToString();
            this.mdiParent.getDatabaseName = cmbDatabase.SelectedItem.ToString();
            Close();
        }

    }
}
#endregion