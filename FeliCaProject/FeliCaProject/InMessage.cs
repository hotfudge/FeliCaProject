using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace FeliCaProject
{
    public partial class InMessageForm : Form
    {
        public InMessageForm()
        {
            InitializeComponent();
        }

        private void InMessage_Load(object sender, EventArgs e)
        {

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            Thread.Sleep(5000);
            this.Close();
        }
    }
}
