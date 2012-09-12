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
    /// <summary>
    /// メインのフォームのクラス
    /// </summary>
    public partial class AttendanceManagementApplicationForm : Form
    {
        public AttendanceManagementApplicationForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// フォーム読み込み時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AttendanceManagementApplicationForm_Load(object sender, EventArgs e)
        {
            IDmTick.Enabled = true;
            ClockTick.Enabled = true;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
        private void showTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IDmTick.Stop();
            ShowTableForm showTableForm = new ShowTableForm();
            this.AddOwnedForm(showTableForm);
            showTableForm.ShowDialog(this);
            showTableForm.Dispose();
            IDmTick.Start();
        }
        /// <summary>
        /// テーブル作成
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IDmTick.Stop();
            CreateDatabaseForm createDatabaseForm = new CreateDatabaseForm();
            this.AddOwnedForm(createDatabaseForm);
            createDatabaseForm.ShowDialog(this);
            createDatabaseForm.Dispose();
            IDmTick.Start();
        }
        /// <summary>
        /// テーブル削除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dropTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IDmTick.Stop();
            DropTablesForm dropTablesForm = new DropTablesForm();
            this.AddOwnedForm(dropTablesForm);
            dropTablesForm.ShowDialog(this);
            dropTablesForm.Dispose();
            IDmTick.Start();
        }
        /// <summary>
        /// アカウント作成
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewaccountButton_Click(object sender, EventArgs e)
        {
            IDmTick.Stop();
            NewAccountForm newAccountForm = new NewAccountForm();
            this.AddOwnedForm(newAccountForm);
            newAccountForm.ShowDialog(this);
            newAccountForm.Dispose();
            IDmTick.Start();
        }
        /// <summary>
        /// IDm取得・取得したIDとマッチしたデータを表示するTickイベントを定義したメソッド
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IDmTick_Tick(object sender, EventArgs e)
        {
            
            Connector timeDataSet = new Connector();
            //messageBoxFormat();
            IDmTick.Interval = 200;
            string idm;
            GetIDm getidm = new GetIDm();
            idm = getidm.getID();
            //idmが空でない & 前回とidmが同じではなけれは処理開始
            if (idm != null && (compareStr(idm) == false))
            {
                PlaySound("../../Audio/botan_b45.wav");
                IDmTick.Stop();
                //idmが一致した人の入出時間を入れる
                timeDataSet.entryTime(idm);
                //Hash化して生IDを表示するのを防ぐ
                byte[] idmEncodeUtf8 = Encoding.UTF8.GetBytes(idm);
                System.Security.Cryptography.MD5CryptoServiceProvider md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
                byte[] idmHash = md5.ComputeHash(idmEncodeUtf8);
                int hashCount;
                string dispHashIdm = "";
                /*枠いっぱいに表示するためには7が調度良い*/
                for (hashCount = 0; hashCount < 7; hashCount++)
                {
                    dispHashIdm += idmHash[hashCount];
                }
                IdmRichTextBox.Text = dispHashIdm;
                /*IDmから照合し、取得したデータをメインフォームに表示*/
                DataTable dataTable = new DataTable();
                if (Connector.userInfoDisp(dataTable, idm) == true)
                {
                    if (dataTable.Rows.Count != 0)
                    {
                        string time;
                        string dataName, dataStudentid, dataGrade;
                        dataName = dataTable.Rows[0][1].ToString();
                        dataStudentid = dataTable.Rows[0][2].ToString();
                        dataGrade = dataTable.Rows[0][3].ToString();
                        NameRichTextBox.Text = dataName;
                        StudentidRichTextBox.Text = dataStudentid;
                        GradeRichTextBox.Text = dataGrade;
                        Connector nowTime = new Connector();
                        time = nowTime.getTimeNow();
                        IntimeRichTextBox.Text = time;
                    }
                    else if (dataTable.Rows.Count == 0)
                    {
                        messageBoxFormat();
                    }
                    IDmTick.Interval = 2000;
                    IDmTick.Start();
                }
            }
        }
        /// <summary>
        /// 1度前に取得したIDmと比較し同じIDmかどうか判断するメソッド
        /// </summary>
        private static string compareIdm;
        public bool compareStr(string idm)
        {
            if (compareIdm == idm)
            {
                return true;
            }
            else
            {
                compareIdm = idm;
                return false;
            }

        }
        /// <summary>
        /// メッセージボックス内のテキストをフォーマットするメソッド
        /// </summary>
        private void messageBoxFormat()
        {
            IdmRichTextBox.Text = null;
            NameRichTextBox.Text = null;
            GradeRichTextBox.Text = null;
            StudentidRichTextBox.Text = null;
            IntimeRichTextBox.Text = null;
            OuttimeRichTextBox.Text = null;
        }
        /// <summary>
        /// 時計を表示する際に使うTickイベント用メソッド
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClockTick_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            ClockToolStripStatusLabel.Text = dt.ToString();
        }
        /// <summary>
        /// IDm取得時にサウンドを再生するメソッド
        /// </summary>
        private void PlaySound(string waveFile)
        {
            SoundPlayer sound = new SoundPlayer(waveFile);
            sound.Play();
        }

    }
}
