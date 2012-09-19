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
using System.Media;


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
            //ClockTick.Enabled = true;
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
            CreateTableForm createDatabaseForm = new CreateTableForm();
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
            
            //messageBoxFormat();
            IDmTick.Interval = 3000;
            string idm;
            GetIDm getidm = new GetIDm();
            idm = getidm.getID();
            //idmが空でなければ
            if (idm != null)
            {
                PlaySound("../../Audio/botan_b45.wav");
                IDmTick.Stop();
                Connector checkIdmConnect = new Connector();
                bool idmExist;
                idmExist = checkIdmConnect.checkIdmExist(idm);
                checkIdmConnect.Dispose();
                if (idmExist == true)
                {
                    //idmが一致した人の入出時間を入れる
                    using (Connector entryTimeConnect = new Connector())
                    {
                        entryTimeConnect.entryTime(idm);
                        entryTimeConnect.Dispose();
                        //Hash化して生IDを表示するのを防ぐ
                        byte[] idmEncodeUtf8 = Encoding.UTF8.GetBytes(idm);
                        System.Security.Cryptography.MD5CryptoServiceProvider md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
                        byte[] idmHash = md5.ComputeHash(idmEncodeUtf8);
                        StringBuilder hashStrData = new StringBuilder();
                        foreach (byte hashData in idmHash)
                        {
                            hashStrData.Append(hashData.ToString("X2"));
                        }
                        IdmRichTextBox.Text = hashStrData.ToString();
                        /*IDmから照合し、取得したデータをメインフォームに表示*/
                        MySqlDataReader dataReader = null;
                        Connector dataReadConnect = new Connector();
                        dataReader = dataReadConnect.userInfoDisp(dataReader, idm);
                        if (dataReader == null)
                        {
                            messageBoxFormat();
                            //dataReader.Dispose();　初期値がnullであるためdataReaderがnullだった場合Disposeできない（そもそもインスタンス化されていない）
                            dataReadConnect.Dispose();
                        }
                        else
                        {
                            NameRichTextBox.Text = dataReader["idm"].ToString();
                            StudentidRichTextBox.Text = dataReader["studentid"].ToString();
                            GradeRichTextBox.Text = dataReader["grade"].ToString();
                            dataReader.Close();
                            dataReadConnect.Dispose();
                            MySqlDataReader readEntryTime = null;
                            Connector getTimeConnect = new Connector();
                            readEntryTime = getTimeConnect.getEntryTimeTable(idm, readEntryTime);
                            OuttimeRichTextBox.Text = readEntryTime["outtime"].ToString();
                            IntimeRichTextBox.Text = readEntryTime["intime"].ToString();
                            readEntryTime.Close();
                            getTimeConnect.Dispose();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("読み込まれたIdmは登録されていません");
                }
                IDmTick.Interval = 3000;
                IDmTick.Start();
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
