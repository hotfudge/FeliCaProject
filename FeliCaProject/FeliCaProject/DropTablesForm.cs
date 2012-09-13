using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using connectorMySQL;

namespace FeliCaProject
{
    public partial class DropTablesForm : Form
    {
        public DropTablesForm()
        {
            InitializeComponent();
        }

        private void ShowTables_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void DatabaseDropCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// テーブルのドロップ開始ボタンのメソッド
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DatabaseDropButton_Click(object sender, EventArgs e)
        {
            if (DropTableTextBox.Text.Trim() != "")
            {
                Connector dropTable = new Connector();
                dropTable.dropTables(DropTableTextBox.Text);
                textBoxFormat();
            }
            else
            {
                MessageBox.Show("無効な値です");
                textBoxFormat();
            }

        }
        /// <summary>
        /// フォームのテキストフォーマット
        /// </summary>
        private void textBoxFormat()
        {
            DropTableTextBox.Text = "";
        }

    }
}
