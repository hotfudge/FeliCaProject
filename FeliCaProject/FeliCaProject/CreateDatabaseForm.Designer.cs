namespace FeliCaProject
{
    partial class CreateDatabaseForm
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
            this.components = new System.ComponentModel.Container();
            this.TableNameTextBox = new System.Windows.Forms.TextBox();
            this.CreateTableNameLabel = new System.Windows.Forms.Label();
            this.SetColummLabel = new System.Windows.Forms.Label();
            this.SetColummTextBox = new System.Windows.Forms.TextBox();
            this.PrimaryKeyTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TableCreateButton = new System.Windows.Forms.Button();
            this.CreateTableCancelButton = new System.Windows.Forms.Button();
            this.TableNameToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SetColumToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.PrimaryKeyToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // TableNameTextBox
            // 
            this.TableNameTextBox.Location = new System.Drawing.Point(103, 21);
            this.TableNameTextBox.Name = "TableNameTextBox";
            this.TableNameTextBox.Size = new System.Drawing.Size(464, 19);
            this.TableNameTextBox.TabIndex = 0;
            // 
            // CreateTableNameLabel
            // 
            this.CreateTableNameLabel.AutoSize = true;
            this.CreateTableNameLabel.Location = new System.Drawing.Point(12, 24);
            this.CreateTableNameLabel.Name = "CreateTableNameLabel";
            this.CreateTableNameLabel.Size = new System.Drawing.Size(62, 12);
            this.CreateTableNameLabel.TabIndex = 1;
            this.CreateTableNameLabel.Text = "TableName";
            // 
            // SetColummLabel
            // 
            this.SetColummLabel.AutoSize = true;
            this.SetColummLabel.Location = new System.Drawing.Point(12, 60);
            this.SetColummLabel.Name = "SetColummLabel";
            this.SetColummLabel.Size = new System.Drawing.Size(63, 12);
            this.SetColummLabel.TabIndex = 2;
            this.SetColummLabel.Text = "SetColumm";
            // 
            // SetColummTextBox
            // 
            this.SetColummTextBox.AcceptsReturn = true;
            this.SetColummTextBox.Location = new System.Drawing.Point(103, 57);
            this.SetColummTextBox.Multiline = true;
            this.SetColummTextBox.Name = "SetColummTextBox";
            this.SetColummTextBox.Size = new System.Drawing.Size(464, 59);
            this.SetColummTextBox.TabIndex = 3;
            // 
            // PrimaryKeyTextBox
            // 
            this.PrimaryKeyTextBox.Location = new System.Drawing.Point(103, 132);
            this.PrimaryKeyTextBox.Name = "PrimaryKeyTextBox";
            this.PrimaryKeyTextBox.Size = new System.Drawing.Size(464, 19);
            this.PrimaryKeyTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "PRIMARY KEY";
            // 
            // TableCreateButton
            // 
            this.TableCreateButton.Location = new System.Drawing.Point(355, 182);
            this.TableCreateButton.Name = "TableCreateButton";
            this.TableCreateButton.Size = new System.Drawing.Size(94, 27);
            this.TableCreateButton.TabIndex = 6;
            this.TableCreateButton.Text = "Create";
            this.TableCreateButton.UseVisualStyleBackColor = true;
            this.TableCreateButton.Click += new System.EventHandler(this.TableCreateButton_Click);
            // 
            // CreateTableCancelButton
            // 
            this.CreateTableCancelButton.Location = new System.Drawing.Point(473, 182);
            this.CreateTableCancelButton.Name = "CreateTableCancelButton";
            this.CreateTableCancelButton.Size = new System.Drawing.Size(94, 27);
            this.CreateTableCancelButton.TabIndex = 7;
            this.CreateTableCancelButton.Text = "Cancel";
            this.CreateTableCancelButton.UseVisualStyleBackColor = true;
            this.CreateTableCancelButton.Click += new System.EventHandler(this.CreateTableCancelButton_Click);
            // 
            // TableNameToolTip
            // 
            this.TableNameToolTip.AutoPopDelay = 50000;
            this.TableNameToolTip.InitialDelay = 50;
            this.TableNameToolTip.ReshowDelay = 10;
            // 
            // SetColumToolTip
            // 
            this.SetColumToolTip.AutoPopDelay = 50000;
            this.SetColumToolTip.InitialDelay = 50;
            this.SetColumToolTip.ReshowDelay = 10;
            // 
            // PrimaryKeyToolTip
            // 
            this.PrimaryKeyToolTip.AutoPopDelay = 50000;
            this.PrimaryKeyToolTip.InitialDelay = 50;
            this.PrimaryKeyToolTip.ReshowDelay = 10;
            // 
            // CreateDatabaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 221);
            this.Controls.Add(this.CreateTableCancelButton);
            this.Controls.Add(this.TableCreateButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PrimaryKeyTextBox);
            this.Controls.Add(this.SetColummTextBox);
            this.Controls.Add(this.SetColummLabel);
            this.Controls.Add(this.CreateTableNameLabel);
            this.Controls.Add(this.TableNameTextBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateDatabaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create Table";
            this.Load += new System.EventHandler(this.AttendanceManagementSoftwareForm2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TableNameTextBox;
        private System.Windows.Forms.Label CreateTableNameLabel;
        private System.Windows.Forms.Label SetColummLabel;
        private System.Windows.Forms.TextBox SetColummTextBox;
        private System.Windows.Forms.TextBox PrimaryKeyTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button TableCreateButton;
        private System.Windows.Forms.Button CreateTableCancelButton;
        private System.Windows.Forms.ToolTip TableNameToolTip;
        private System.Windows.Forms.ToolTip SetColumToolTip;
        private System.Windows.Forms.ToolTip PrimaryKeyToolTip;
    }
}