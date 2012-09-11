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

namespace FeliCaProject
{
    public partial class NewAccountForm : Form
    {
        public NewAccountForm()
        {
            InitializeComponent();
        }

        private void NewAccount_Load(object sender, EventArgs e)
        {
            textBoxFormat();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void InputCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InputIdmButton_Click(object sender, EventArgs e)
        {
            GetIDm idm = new GetIDm();
            InputIdmTextBox.Text = idm.getID();
        }

        private void InputCreateButton_Click(object sender, EventArgs e)
        {
            Connector newAccount = new Connector();
            int result;
            if (InputIdmTextBox.Text.Trim() != "" && InputGradeTextBox.Text.Trim() != "" && InputNameTextBox.Text.Trim() != "" && InputStudentidTextBox.Text.Trim() != "")
            {
                if (int.TryParse(InputGradeTextBox.Text, out result))
                {
                    newAccount.createNewAccount(InputIdmTextBox.Text, InputNameTextBox.Text, InputStudentidTextBox.Text, int.Parse(InputGradeTextBox.Text));
                    textBoxFormat();
                }
                else
                {
                    MessageBox.Show( InputGradeTextBox.Text + "は不正な値です。");
                }
            }  
            else
            {
                MessageBox.Show("値が有効ではないか記入漏れがあります");
            }
        }
        private void textBoxFormat()
        {
            InputGradeTextBox.Text = "";
            InputIdmTextBox.Text = "";
            InputNameTextBox.Text = "";
            InputStudentidTextBox.Text = "";
        }
    }
}
