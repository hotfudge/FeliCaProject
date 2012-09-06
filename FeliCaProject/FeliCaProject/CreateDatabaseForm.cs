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
    public partial class CreateDatabaseForm : Form
    {
        public CreateDatabaseForm()
        {
            InitializeComponent();
        }

        private void AttendanceManagementSoftwareForm2_Load(object sender, EventArgs e)
        {
            textBoxFormat();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            TableNameToolTip.SetToolTip(TableNameTextBox, "Tableの名前を入力します");
            SetColumToolTip.SetToolTip(SetColummTextBox, "カラムを,で区切って入力してください\n例)id INT(11),title VARCHAR(64)");
            PrimaryKeyToolTip.SetToolTip(PrimaryKeyTextBox, "主キーがある場合記述してください");
        }

        private void TableCreateButton_Click(object sender, EventArgs e)
        {
            if (TableNameTextBox.Text.Trim() != "" && SetColummTextBox.Text.Trim() != "" && PrimaryKeyTextBox.Text.Trim() != "")
            {
                Connector tableCreate = new Connector();
                tableCreate.MysqlCreateTable(TableNameTextBox.Text, SetColummTextBox.Text, PrimaryKeyTextBox.Text);
                tableCreate.createTable();
            }
            else if (TableNameTextBox.Text != "" && SetColummTextBox.Text.Trim() != "" && PrimaryKeyTextBox.Text.Trim() == "")
            {
                Connector tableCreate = new Connector();
                tableCreate.MysqlCreateTable(TableNameTextBox.Text, SetColummTextBox.Text);
                tableCreate.createTable();
            }
            else
            {
                MessageBox.Show("値が有効ではありません");
                textBoxFormat();
            }
        }
        private void textBoxFormat()
        {
            TableNameTextBox.Text = "";
            SetColummTextBox.Text = "";
            PrimaryKeyTextBox.Text = "";
        }

        private void CreateTableCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }



    }
}
