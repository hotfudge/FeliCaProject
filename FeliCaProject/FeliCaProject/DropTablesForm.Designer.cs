namespace FeliCaProject
{
    partial class DropTablesForm
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
            this.DropTableTextBox = new System.Windows.Forms.TextBox();
            this.DropTableLabel = new System.Windows.Forms.Label();
            this.DatabaseDropButton = new System.Windows.Forms.Button();
            this.DatabaseShowCancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DropTableTextBox
            // 
            this.DropTableTextBox.Location = new System.Drawing.Point(78, 12);
            this.DropTableTextBox.Name = "DropTableTextBox";
            this.DropTableTextBox.Size = new System.Drawing.Size(297, 19);
            this.DropTableTextBox.TabIndex = 0;
            // 
            // DropTableLabel
            // 
            this.DropTableLabel.AutoSize = true;
            this.DropTableLabel.Location = new System.Drawing.Point(10, 15);
            this.DropTableLabel.Name = "DropTableLabel";
            this.DropTableLabel.Size = new System.Drawing.Size(62, 12);
            this.DropTableLabel.TabIndex = 1;
            this.DropTableLabel.Text = "TableName";
            // 
            // DatabaseDropButton
            // 
            this.DatabaseDropButton.Location = new System.Drawing.Point(182, 48);
            this.DatabaseDropButton.Name = "DatabaseDropButton";
            this.DatabaseDropButton.Size = new System.Drawing.Size(89, 26);
            this.DatabaseDropButton.TabIndex = 2;
            this.DatabaseDropButton.Text = "Drop";
            this.DatabaseDropButton.UseVisualStyleBackColor = true;
            this.DatabaseDropButton.Click += new System.EventHandler(this.DatabaseDropButton_Click);
            // 
            // DatabaseShowCancelButton
            // 
            this.DatabaseShowCancelButton.Location = new System.Drawing.Point(286, 48);
            this.DatabaseShowCancelButton.Name = "DatabaseShowCancelButton";
            this.DatabaseShowCancelButton.Size = new System.Drawing.Size(89, 26);
            this.DatabaseShowCancelButton.TabIndex = 3;
            this.DatabaseShowCancelButton.Text = "Cancel";
            this.DatabaseShowCancelButton.UseVisualStyleBackColor = true;
            this.DatabaseShowCancelButton.Click += new System.EventHandler(this.DatabaseDropCancelButton_Click);
            // 
            // DropTablesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 89);
            this.Controls.Add(this.DatabaseShowCancelButton);
            this.Controls.Add(this.DatabaseDropButton);
            this.Controls.Add(this.DropTableLabel);
            this.Controls.Add(this.DropTableTextBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DropTablesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Drop Table";
            this.Load += new System.EventHandler(this.ShowTables_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DropTableTextBox;
        private System.Windows.Forms.Label DropTableLabel;
        private System.Windows.Forms.Button DatabaseDropButton;
        private System.Windows.Forms.Button DatabaseShowCancelButton;
    }
}