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
    public partial class CreateTableForm : Form
    {
        public CreateTableForm()
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
            Connector tableCreate = new Connector();
            tableCreate.createTable(TableNameTextBox.Text, SetColummTextBox.Text, PrimaryKeyTextBox.Text);
            if((TableNameTextBox.Text.Trim() == "" || SetColummTextBox.Text.Trim() == ""))
            {
                MessageBox.Show("未入力があります。");
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
