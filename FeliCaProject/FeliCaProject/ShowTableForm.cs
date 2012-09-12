using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using connectorMySQL;
using MySql.Data.MySqlClient;

namespace FeliCaProject
{
    public partial class ShowTableForm : Form
    {
        public ShowTableForm()
        {
            InitializeComponent();
        }
        private void ShowTableForm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            Connector.Connect("root","root");
            DataTable dt = new DataTable();
            String commandStr = "SELECT name,studentid,grade,intime,outtime FROM userinfo,entrytime WHERE userinfo.idm = entrytime.idm;";
            Connector.tableReader(commandStr, dt);
            ShowMysqlGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            ShowMysqlGridView.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ShowMysqlGridView.DataSource = dt;
            
        }
    }
}
