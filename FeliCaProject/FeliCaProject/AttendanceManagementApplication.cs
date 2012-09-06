using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using getidm;
using connectorMySQL;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace FeliCaProject
{
    public partial class AttendanceManagementApplicationForm : Form
    {
        public AttendanceManagementApplicationForm()
        {
            InitializeComponent();
        }

        private void GetIDmButton_Click(object sender, EventArgs e)
        {
            GetIDm getidm = new GetIDm();
            string idm;
            DataTable dataTable = new DataTable();
            idm = getidm.getID();
            string dataName,dataStudentid,dataGrade;
            IdmRichTextBox.Text = idm;
            if (Connector.userInfoDisp(dataTable,idm) == true)
            { 
                dataName = dataTable.Rows[0][1].ToString();
                dataStudentid = dataTable.Rows[0][2].ToString();
                dataGrade = dataTable.Rows[0][3].ToString();
                NameRichTextBox.Text = dataName;
                StudentidRichTextBox.Text = dataStudentid;
                GradeRichTextBox.Text = dataGrade;
            }
            else
            {

            }
        }

        private void AttendanceManagementApplicationForm_Load(object sender, EventArgs e)
        {
            ClockTimer.Interval = 200;
            ClockTimer.Enabled = true;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void ClockTimer_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            ClockToolStripStatusLabel.Text = dt.ToString();
        }

        private void configToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void createTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateDatabaseForm createDatabaseForm = new CreateDatabaseForm();
            this.AddOwnedForm(createDatabaseForm);
            createDatabaseForm.ShowDialog(this);
            createDatabaseForm.Dispose();
        }

        private void showTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DropTablesForm dropTablesForm = new DropTablesForm();
            this.AddOwnedForm(dropTablesForm);
            dropTablesForm.ShowDialog(this);
            dropTablesForm.Dispose();
        }

        private void NewaccountButton_Click(object sender, EventArgs e)
        {
            NewAccountForm newAccountForm = new NewAccountForm();
            this.AddOwnedForm(newAccountForm);
            newAccountForm.ShowDialog(this);
            newAccountForm.Dispose();
        }

    }
}
