namespace FeliCaProject
{
    partial class AttendanceManagementApplicationForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.IDmLabel = new System.Windows.Forms.Label();
            this.IdmRichTextBox = new System.Windows.Forms.RichTextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameRichTextBox = new System.Windows.Forms.RichTextBox();
            this.StudentidRichTextBox = new System.Windows.Forms.RichTextBox();
            this.GradeRichTextBox = new System.Windows.Forms.RichTextBox();
            this.OuttimeRichTextBox = new System.Windows.Forms.RichTextBox();
            this.IntimeRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GradeLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.StudentidLabel = new System.Windows.Forms.Label();
            this.NewaccountButton = new System.Windows.Forms.Button();
            this.CheckAttendanceButton = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ClockToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataBaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DropTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IDmTick = new System.Windows.Forms.Timer(this.components);
            this.ClockTick = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // IDmLabel
            // 
            this.IDmLabel.AutoSize = true;
            this.IDmLabel.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.IDmLabel.Location = new System.Drawing.Point(12, 58);
            this.IDmLabel.Name = "IDmLabel";
            this.IDmLabel.Size = new System.Drawing.Size(34, 16);
            this.IDmLabel.TabIndex = 0;
            this.IDmLabel.Text = "IDm";
            // 
            // IdmRichTextBox
            // 
            this.IdmRichTextBox.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.IdmRichTextBox.Location = new System.Drawing.Point(95, 46);
            this.IdmRichTextBox.Name = "IdmRichTextBox";
            this.IdmRichTextBox.ReadOnly = true;
            this.IdmRichTextBox.Size = new System.Drawing.Size(280, 50);
            this.IdmRichTextBox.TabIndex = 1;
            this.IdmRichTextBox.Text = "";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.NameLabel.Location = new System.Drawing.Point(404, 58);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(46, 16);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "Name";
            // 
            // NameRichTextBox
            // 
            this.NameRichTextBox.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.NameRichTextBox.Location = new System.Drawing.Point(486, 46);
            this.NameRichTextBox.Name = "NameRichTextBox";
            this.NameRichTextBox.ReadOnly = true;
            this.NameRichTextBox.Size = new System.Drawing.Size(291, 50);
            this.NameRichTextBox.TabIndex = 3;
            this.NameRichTextBox.Text = "";
            // 
            // StudentidRichTextBox
            // 
            this.StudentidRichTextBox.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.StudentidRichTextBox.Location = new System.Drawing.Point(95, 137);
            this.StudentidRichTextBox.Name = "StudentidRichTextBox";
            this.StudentidRichTextBox.ReadOnly = true;
            this.StudentidRichTextBox.Size = new System.Drawing.Size(280, 50);
            this.StudentidRichTextBox.TabIndex = 4;
            this.StudentidRichTextBox.Text = "";
            // 
            // GradeRichTextBox
            // 
            this.GradeRichTextBox.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.GradeRichTextBox.Location = new System.Drawing.Point(486, 137);
            this.GradeRichTextBox.Name = "GradeRichTextBox";
            this.GradeRichTextBox.ReadOnly = true;
            this.GradeRichTextBox.Size = new System.Drawing.Size(148, 50);
            this.GradeRichTextBox.TabIndex = 5;
            this.GradeRichTextBox.Text = "";
            // 
            // OuttimeRichTextBox
            // 
            this.OuttimeRichTextBox.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.OuttimeRichTextBox.Location = new System.Drawing.Point(486, 232);
            this.OuttimeRichTextBox.Name = "OuttimeRichTextBox";
            this.OuttimeRichTextBox.ReadOnly = true;
            this.OuttimeRichTextBox.Size = new System.Drawing.Size(291, 50);
            this.OuttimeRichTextBox.TabIndex = 6;
            this.OuttimeRichTextBox.Text = "";
            // 
            // IntimeRichTextBox
            // 
            this.IntimeRichTextBox.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.IntimeRichTextBox.Location = new System.Drawing.Point(95, 232);
            this.IntimeRichTextBox.Name = "IntimeRichTextBox";
            this.IntimeRichTextBox.ReadOnly = true;
            this.IntimeRichTextBox.Size = new System.Drawing.Size(280, 50);
            this.IntimeRichTextBox.TabIndex = 7;
            this.IntimeRichTextBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.label1.Location = new System.Drawing.Point(404, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Out Time";
            // 
            // GradeLabel
            // 
            this.GradeLabel.AutoSize = true;
            this.GradeLabel.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.GradeLabel.Location = new System.Drawing.Point(404, 149);
            this.GradeLabel.Name = "GradeLabel";
            this.GradeLabel.Size = new System.Drawing.Size(49, 16);
            this.GradeLabel.TabIndex = 9;
            this.GradeLabel.Text = "Grade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.label3.Location = new System.Drawing.Point(12, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "In Time";
            // 
            // StudentidLabel
            // 
            this.StudentidLabel.AutoSize = true;
            this.StudentidLabel.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.StudentidLabel.Location = new System.Drawing.Point(12, 149);
            this.StudentidLabel.Name = "StudentidLabel";
            this.StudentidLabel.Size = new System.Drawing.Size(76, 16);
            this.StudentidLabel.TabIndex = 11;
            this.StudentidLabel.Text = "StudentID";
            // 
            // NewaccountButton
            // 
            this.NewaccountButton.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.NewaccountButton.Location = new System.Drawing.Point(36, 299);
            this.NewaccountButton.Name = "NewaccountButton";
            this.NewaccountButton.Size = new System.Drawing.Size(222, 63);
            this.NewaccountButton.TabIndex = 12;
            this.NewaccountButton.Text = "NewAccount";
            this.NewaccountButton.UseVisualStyleBackColor = true;
            this.NewaccountButton.Click += new System.EventHandler(this.NewaccountButton_Click);
            // 
            // CheckAttendanceButton
            // 
            this.CheckAttendanceButton.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.CheckAttendanceButton.Location = new System.Drawing.Point(36, 388);
            this.CheckAttendanceButton.Name = "CheckAttendanceButton";
            this.CheckAttendanceButton.Size = new System.Drawing.Size(222, 63);
            this.CheckAttendanceButton.TabIndex = 13;
            this.CheckAttendanceButton.Text = "Check Attendance";
            this.CheckAttendanceButton.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ClockToolStripStatusLabel,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 461);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(815, 22);
            this.statusStrip1.TabIndex = 17;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ClockToolStripStatusLabel
            // 
            this.ClockToolStripStatusLabel.Name = "ClockToolStripStatusLabel";
            this.ClockToolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(800, 17);
            this.toolStripStatusLabel1.Spring = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gainsboro;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingToolStripMenuItem,
            this.dataBaseToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(815, 26);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configToolStripMenuItem});
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(62, 22);
            this.settingToolStripMenuItem.Text = "Setting";
            // 
            // configToolStripMenuItem
            // 
            this.configToolStripMenuItem.Name = "configToolStripMenuItem";
            this.configToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.configToolStripMenuItem.Text = "Config";
            // 
            // dataBaseToolStripMenuItem
            // 
            this.dataBaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createTableToolStripMenuItem,
            this.DropTableToolStripMenuItem,
            this.showTableToolStripMenuItem});
            this.dataBaseToolStripMenuItem.Name = "dataBaseToolStripMenuItem";
            this.dataBaseToolStripMenuItem.Size = new System.Drawing.Size(76, 22);
            this.dataBaseToolStripMenuItem.Text = "DataBase";
            // 
            // createTableToolStripMenuItem
            // 
            this.createTableToolStripMenuItem.Name = "createTableToolStripMenuItem";
            this.createTableToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.createTableToolStripMenuItem.Text = "CreateTable";
            this.createTableToolStripMenuItem.Click += new System.EventHandler(this.createTableToolStripMenuItem_Click);
            // 
            // DropTableToolStripMenuItem
            // 
            this.DropTableToolStripMenuItem.Name = "DropTableToolStripMenuItem";
            this.DropTableToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.DropTableToolStripMenuItem.Text = "DropTable";
            this.DropTableToolStripMenuItem.Click += new System.EventHandler(this.dropTableToolStripMenuItem_Click);
            // 
            // showTableToolStripMenuItem
            // 
            this.showTableToolStripMenuItem.Name = "showTableToolStripMenuItem";
            this.showTableToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.showTableToolStripMenuItem.Text = "ShowTable";
            this.showTableToolStripMenuItem.Click += new System.EventHandler(this.showTableToolStripMenuItem_Click);
            // 
            // IDmTick
            // 
            this.IDmTick.Interval = 500;
            this.IDmTick.Tick += new System.EventHandler(this.IDmTick_Tick);
            // 
            // ClockTick
            // 
            this.ClockTick.Interval = 200;
            this.ClockTick.Tick += new System.EventHandler(this.ClockTick_Tick);
            // 
            // AttendanceManagementApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(815, 483);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.CheckAttendanceButton);
            this.Controls.Add(this.NewaccountButton);
            this.Controls.Add(this.StudentidLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.GradeLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IntimeRichTextBox);
            this.Controls.Add(this.OuttimeRichTextBox);
            this.Controls.Add(this.GradeRichTextBox);
            this.Controls.Add(this.StudentidRichTextBox);
            this.Controls.Add(this.NameRichTextBox);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.IdmRichTextBox);
            this.Controls.Add(this.IDmLabel);
            this.MaximizeBox = false;
            this.Name = "AttendanceManagementApplicationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AttendanceManagementApplication";
            this.Load += new System.EventHandler(this.AttendanceManagementApplicationForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IDmLabel;
        private System.Windows.Forms.RichTextBox IdmRichTextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.RichTextBox NameRichTextBox;
        private System.Windows.Forms.RichTextBox StudentidRichTextBox;
        private System.Windows.Forms.RichTextBox GradeRichTextBox;
        private System.Windows.Forms.RichTextBox OuttimeRichTextBox;
        private System.Windows.Forms.RichTextBox IntimeRichTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label GradeLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label StudentidLabel;
        private System.Windows.Forms.Button NewaccountButton;
        private System.Windows.Forms.Button CheckAttendanceButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel ClockToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataBaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DropTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showTableToolStripMenuItem;
        private System.Windows.Forms.Timer IDmTick;
        private System.Windows.Forms.Timer ClockTick;
    }
}

