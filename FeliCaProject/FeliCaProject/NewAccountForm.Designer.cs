namespace FeliCaProject
{
    partial class NewAccountForm
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
            this.InputIdmLabel = new System.Windows.Forms.Label();
            this.InputGradeLabel = new System.Windows.Forms.Label();
            this.InputStudentidLabel = new System.Windows.Forms.Label();
            this.InputNameLabel = new System.Windows.Forms.Label();
            this.InputIdmTextBox = new System.Windows.Forms.TextBox();
            this.InputStudentidTextBox = new System.Windows.Forms.TextBox();
            this.InputGradeTextBox = new System.Windows.Forms.TextBox();
            this.InputNameTextBox = new System.Windows.Forms.TextBox();
            this.InputIdmButton = new System.Windows.Forms.Button();
            this.InputCreateButton = new System.Windows.Forms.Button();
            this.InputCancelButton = new System.Windows.Forms.Button();
            this.nameExampleLabel = new System.Windows.Forms.Label();
            this.studentidExampleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InputIdmLabel
            // 
            this.InputIdmLabel.AutoSize = true;
            this.InputIdmLabel.Location = new System.Drawing.Point(23, 35);
            this.InputIdmLabel.Name = "InputIdmLabel";
            this.InputIdmLabel.Size = new System.Drawing.Size(25, 12);
            this.InputIdmLabel.TabIndex = 0;
            this.InputIdmLabel.Text = "IDm";
            // 
            // InputGradeLabel
            // 
            this.InputGradeLabel.AutoSize = true;
            this.InputGradeLabel.Location = new System.Drawing.Point(297, 35);
            this.InputGradeLabel.Name = "InputGradeLabel";
            this.InputGradeLabel.Size = new System.Drawing.Size(35, 12);
            this.InputGradeLabel.TabIndex = 1;
            this.InputGradeLabel.Text = "Grade";
            // 
            // InputStudentidLabel
            // 
            this.InputStudentidLabel.AutoSize = true;
            this.InputStudentidLabel.Location = new System.Drawing.Point(9, 129);
            this.InputStudentidLabel.Name = "InputStudentidLabel";
            this.InputStudentidLabel.Size = new System.Drawing.Size(55, 12);
            this.InputStudentidLabel.TabIndex = 2;
            this.InputStudentidLabel.Text = "StudentID";
            // 
            // InputNameLabel
            // 
            this.InputNameLabel.AutoSize = true;
            this.InputNameLabel.Location = new System.Drawing.Point(297, 129);
            this.InputNameLabel.Name = "InputNameLabel";
            this.InputNameLabel.Size = new System.Drawing.Size(34, 12);
            this.InputNameLabel.TabIndex = 3;
            this.InputNameLabel.Text = "Name";
            // 
            // InputIdmTextBox
            // 
            this.InputIdmTextBox.Location = new System.Drawing.Point(82, 32);
            this.InputIdmTextBox.Name = "InputIdmTextBox";
            this.InputIdmTextBox.ReadOnly = true;
            this.InputIdmTextBox.Size = new System.Drawing.Size(184, 19);
            this.InputIdmTextBox.TabIndex = 4;
            // 
            // InputStudentidTextBox
            // 
            this.InputStudentidTextBox.Location = new System.Drawing.Point(82, 126);
            this.InputStudentidTextBox.Name = "InputStudentidTextBox";
            this.InputStudentidTextBox.Size = new System.Drawing.Size(184, 19);
            this.InputStudentidTextBox.TabIndex = 5;
            // 
            // InputGradeTextBox
            // 
            this.InputGradeTextBox.Location = new System.Drawing.Point(359, 32);
            this.InputGradeTextBox.Name = "InputGradeTextBox";
            this.InputGradeTextBox.Size = new System.Drawing.Size(84, 19);
            this.InputGradeTextBox.TabIndex = 6;
            // 
            // InputNameTextBox
            // 
            this.InputNameTextBox.Location = new System.Drawing.Point(359, 126);
            this.InputNameTextBox.Name = "InputNameTextBox";
            this.InputNameTextBox.Size = new System.Drawing.Size(184, 19);
            this.InputNameTextBox.TabIndex = 7;
            // 
            // InputIdmButton
            // 
            this.InputIdmButton.Font = new System.Drawing.Font("MS UI Gothic", 9F);
            this.InputIdmButton.Location = new System.Drawing.Point(210, 57);
            this.InputIdmButton.Name = "InputIdmButton";
            this.InputIdmButton.Size = new System.Drawing.Size(56, 22);
            this.InputIdmButton.TabIndex = 8;
            this.InputIdmButton.Text = "GetIDm";
            this.InputIdmButton.UseVisualStyleBackColor = true;
            this.InputIdmButton.Click += new System.EventHandler(this.InputIdmButton_Click);
            // 
            // InputCreateButton
            // 
            this.InputCreateButton.Location = new System.Drawing.Point(359, 194);
            this.InputCreateButton.Name = "InputCreateButton";
            this.InputCreateButton.Size = new System.Drawing.Size(100, 32);
            this.InputCreateButton.TabIndex = 9;
            this.InputCreateButton.Text = "Create";
            this.InputCreateButton.UseVisualStyleBackColor = true;
            this.InputCreateButton.Click += new System.EventHandler(this.InputCreateButton_Click);
            // 
            // InputCancelButton
            // 
            this.InputCancelButton.Location = new System.Drawing.Point(483, 194);
            this.InputCancelButton.Name = "InputCancelButton";
            this.InputCancelButton.Size = new System.Drawing.Size(100, 32);
            this.InputCancelButton.TabIndex = 10;
            this.InputCancelButton.Text = "Cancel";
            this.InputCancelButton.UseVisualStyleBackColor = true;
            this.InputCancelButton.Click += new System.EventHandler(this.InputCancelButton_Click);
            // 
            // nameExampleLabel
            // 
            this.nameExampleLabel.AutoSize = true;
            this.nameExampleLabel.Location = new System.Drawing.Point(405, 157);
            this.nameExampleLabel.Name = "nameExampleLabel";
            this.nameExampleLabel.Size = new System.Drawing.Size(138, 12);
            this.nameExampleLabel.TabIndex = 11;
            this.nameExampleLabel.Text = "※(例) TOMOYA IBARAGI";
            // 
            // studentidExampleLabel
            // 
            this.studentidExampleLabel.AutoSize = true;
            this.studentidExampleLabel.Location = new System.Drawing.Point(181, 157);
            this.studentidExampleLabel.Name = "studentidExampleLabel";
            this.studentidExampleLabel.Size = new System.Drawing.Size(85, 12);
            this.studentidExampleLabel.TabIndex = 12;
            this.studentidExampleLabel.Text = "※(例) H109013";
            // 
            // NewAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 238);
            this.Controls.Add(this.studentidExampleLabel);
            this.Controls.Add(this.nameExampleLabel);
            this.Controls.Add(this.InputCancelButton);
            this.Controls.Add(this.InputCreateButton);
            this.Controls.Add(this.InputIdmButton);
            this.Controls.Add(this.InputNameTextBox);
            this.Controls.Add(this.InputGradeTextBox);
            this.Controls.Add(this.InputStudentidTextBox);
            this.Controls.Add(this.InputIdmTextBox);
            this.Controls.Add(this.InputNameLabel);
            this.Controls.Add(this.InputStudentidLabel);
            this.Controls.Add(this.InputGradeLabel);
            this.Controls.Add(this.InputIdmLabel);
            this.Name = "NewAccountForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "NewAccount";
            this.Load += new System.EventHandler(this.NewAccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InputIdmLabel;
        private System.Windows.Forms.Label InputGradeLabel;
        private System.Windows.Forms.Label InputStudentidLabel;
        private System.Windows.Forms.Label InputNameLabel;
        private System.Windows.Forms.TextBox InputIdmTextBox;
        private System.Windows.Forms.TextBox InputStudentidTextBox;
        private System.Windows.Forms.TextBox InputGradeTextBox;
        private System.Windows.Forms.TextBox InputNameTextBox;
        private System.Windows.Forms.Button InputIdmButton;
        private System.Windows.Forms.Button InputCreateButton;
        private System.Windows.Forms.Button InputCancelButton;
        private System.Windows.Forms.Label nameExampleLabel;
        private System.Windows.Forms.Label studentidExampleLabel;
    }
}