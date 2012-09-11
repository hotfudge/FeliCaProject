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
using System.Media;
using System.Threading;

namespace FeliCaProject
{
    public partial class AttendanceManagementApplicationForm : Form
    {
        private SoundPlayer sound = null;

        public AttendanceManagementApplicationForm()
        {
            InitializeComponent();
        }

        private void AttendanceManagementApplicationForm_Load(object sender, EventArgs e)
        {
            IDmTick.Enabled = true;
            ClockTick.Enabled = true;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void createTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IDmTick.Stop();
            CreateDatabaseForm createDatabaseForm = new CreateDatabaseForm();
            this.AddOwnedForm(createDatabaseForm);
            createDatabaseForm.ShowDialog(this);
            createDatabaseForm.Dispose();
            IDmTick.Start();
        }

        private void showTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IDmTick.Stop();
            DropTablesForm dropTablesForm = new DropTablesForm();
            this.AddOwnedForm(dropTablesForm);
            dropTablesForm.ShowDialog(this);
            dropTablesForm.Dispose();
            IDmTick.Start();
        }

        private void NewaccountButton_Click(object sender, EventArgs e)
        {
            IDmTick.Stop();
            NewAccountForm newAccountForm = new NewAccountForm();
            this.AddOwnedForm(newAccountForm);
            newAccountForm.ShowDialog(this);
            newAccountForm.Dispose();
            IDmTick.Start();
        }
        private void IDmTick_Tick(object sender, EventArgs e)
        {
            messageBoxFormat();
            IDmTick.Interval = 200;
            string idm,time;
            GetIDm getidm = new GetIDm();
            idm = getidm.getID();
            if (idm != null)
            {
                PlaySound("../../Audio/botan_b45.wav");
                IDmTick.Stop();
                IdmRichTextBox.Text = idm;
                string dataName, dataStudentid, dataGrade;
                DataTable dataTable = new DataTable();
                if (Connector.userInfoDisp(dataTable, idm) == true)
                {
                    dataName = dataTable.Rows[0][1].ToString();
                    dataStudentid = dataTable.Rows[0][2].ToString();
                    dataGrade = dataTable.Rows[0][3].ToString();
                    NameRichTextBox.Text = dataName;
                    StudentidRichTextBox.Text = dataStudentid;
                    GradeRichTextBox.Text = dataGrade;
                    Connector nowTime = new Connector();
                    time = nowTime.getTimeNow();
                    IntimeRichTextBox.Text = time;
                    IDmTick.Interval = 3000;
                    IDmTick.Start();

                }
            }

        }
        private void messageBoxFormat()
        {
            IdmRichTextBox.Text = null;
            NameRichTextBox.Text = null;
            GradeRichTextBox.Text = null;
            StudentidRichTextBox.Text = null;
            IntimeRichTextBox.Text = null;
            OuttimeRichTextBox.Text = null;
        }

        private void ClockTick_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            ClockToolStripStatusLabel.Text = dt.ToString();
        }
        private void PlaySound(string waveFile)
        {
            sound = new SoundPlayer(waveFile);
            sound.Play();
        }
    }
}
