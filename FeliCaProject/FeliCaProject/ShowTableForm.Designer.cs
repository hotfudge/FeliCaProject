namespace FeliCaProject
{
    partial class ShowTableForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ShowMysqlGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ShowMysqlGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ShowMysqlGridView
            // 
            this.ShowMysqlGridView.AllowUserToAddRows = false;
            this.ShowMysqlGridView.AllowUserToDeleteRows = false;
            this.ShowMysqlGridView.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ShowMysqlGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ShowMysqlGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ShowMysqlGridView.Location = new System.Drawing.Point(12, 12);
            this.ShowMysqlGridView.Name = "ShowMysqlGridView";
            this.ShowMysqlGridView.ReadOnly = true;
            this.ShowMysqlGridView.RowTemplate.Height = 21;
            this.ShowMysqlGridView.Size = new System.Drawing.Size(538, 360);
            this.ShowMysqlGridView.TabIndex = 0;
            // 
            // ShowTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 389);
            this.Controls.Add(this.ShowMysqlGridView);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ShowTableForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ShowTableForm";
            this.Load += new System.EventHandler(this.ShowTableForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ShowMysqlGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ShowMysqlGridView;
    }
}