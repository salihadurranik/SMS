namespace Sms
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.setupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SessionBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.ProgramBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.ProgramOfferBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.PartsBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.SubjectBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.ProgramCourseLinkBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.DepartmentBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.TeacherBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.currecularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AdmissionBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.EntrollementBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.AttendanceBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.ExaminationBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setupToolStripMenuItem,
            this.currecularToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(811, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // setupToolStripMenuItem
            // 
            this.setupToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SessionBtn,
            this.ProgramBtn,
            this.ProgramOfferBtn,
            this.toolStripMenuItem1,
            this.PartsBtn,
            this.SubjectBtn,
            this.toolStripMenuItem3,
            this.ProgramCourseLinkBtn,
            this.toolStripMenuItem2,
            this.DepartmentBtn,
            this.TeacherBtn,
            this.toolStripMenuItem4,
            this.ExitBtn});
            this.setupToolStripMenuItem.Name = "setupToolStripMenuItem";
            this.setupToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.setupToolStripMenuItem.Text = "Setup";
            // 
            // SessionBtn
            // 
            this.SessionBtn.Name = "SessionBtn";
            this.SessionBtn.Size = new System.Drawing.Size(185, 22);
            this.SessionBtn.Text = "Session";
            this.SessionBtn.Click += new System.EventHandler(this.OnMenuClicked);
            // 
            // ProgramBtn
            // 
            this.ProgramBtn.Name = "ProgramBtn";
            this.ProgramBtn.Size = new System.Drawing.Size(185, 22);
            this.ProgramBtn.Text = "Programs";
            this.ProgramBtn.Click += new System.EventHandler(this.OnMenuClicked);
            // 
            // ProgramOfferBtn
            // 
            this.ProgramOfferBtn.Name = "ProgramOfferBtn";
            this.ProgramOfferBtn.Size = new System.Drawing.Size(185, 22);
            this.ProgramOfferBtn.Text = "Program Offer";
            this.ProgramOfferBtn.Click += new System.EventHandler(this.OnMenuClicked);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(182, 6);
            // 
            // PartsBtn
            // 
            this.PartsBtn.Name = "PartsBtn";
            this.PartsBtn.Size = new System.Drawing.Size(185, 22);
            this.PartsBtn.Text = "Parts";
            this.PartsBtn.Click += new System.EventHandler(this.OnMenuClicked);
            // 
            // SubjectBtn
            // 
            this.SubjectBtn.Name = "SubjectBtn";
            this.SubjectBtn.Size = new System.Drawing.Size(185, 22);
            this.SubjectBtn.Text = "Subjects";
            this.SubjectBtn.Click += new System.EventHandler(this.OnMenuClicked);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(182, 6);
            // 
            // ProgramCourseLinkBtn
            // 
            this.ProgramCourseLinkBtn.Name = "ProgramCourseLinkBtn";
            this.ProgramCourseLinkBtn.Size = new System.Drawing.Size(185, 22);
            this.ProgramCourseLinkBtn.Text = "Program Course Link";
            this.ProgramCourseLinkBtn.Click += new System.EventHandler(this.OnMenuClicked);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(182, 6);
            // 
            // DepartmentBtn
            // 
            this.DepartmentBtn.Name = "DepartmentBtn";
            this.DepartmentBtn.Size = new System.Drawing.Size(185, 22);
            this.DepartmentBtn.Text = "Departments";
            this.DepartmentBtn.Click += new System.EventHandler(this.OnMenuClicked);
            // 
            // TeacherBtn
            // 
            this.TeacherBtn.Name = "TeacherBtn";
            this.TeacherBtn.Size = new System.Drawing.Size(185, 22);
            this.TeacherBtn.Text = "Teacher";
            this.TeacherBtn.Click += new System.EventHandler(this.OnMenuClicked);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(182, 6);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(185, 22);
            this.ExitBtn.Text = "E&xit";
            this.ExitBtn.Click += new System.EventHandler(this.OnMenuClicked);
            // 
            // currecularToolStripMenuItem
            // 
            this.currecularToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AdmissionBtn,
            this.EntrollementBtn,
            this.toolStripMenuItem5,
            this.AttendanceBtn,
            this.ExaminationBtn});
            this.currecularToolStripMenuItem.Name = "currecularToolStripMenuItem";
            this.currecularToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.currecularToolStripMenuItem.Text = "Currecular";
            // 
            // AdmissionBtn
            // 
            this.AdmissionBtn.Name = "AdmissionBtn";
            this.AdmissionBtn.Size = new System.Drawing.Size(180, 22);
            this.AdmissionBtn.Text = "Admission Form";
            this.AdmissionBtn.Click += new System.EventHandler(this.OnMenuClicked);
            // 
            // EntrollementBtn
            // 
            this.EntrollementBtn.Name = "EntrollementBtn";
            this.EntrollementBtn.Size = new System.Drawing.Size(180, 22);
            this.EntrollementBtn.Text = "Enrollement";
            this.EntrollementBtn.Click += new System.EventHandler(this.OnMenuClicked);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(177, 6);
            // 
            // AttendanceBtn
            // 
            this.AttendanceBtn.Name = "AttendanceBtn";
            this.AttendanceBtn.Size = new System.Drawing.Size(180, 22);
            this.AttendanceBtn.Text = "Attendance";
            this.AttendanceBtn.Click += new System.EventHandler(this.OnMenuClicked);
            // 
            // ExaminationBtn
            // 
            this.ExaminationBtn.Name = "ExaminationBtn";
            this.ExaminationBtn.Size = new System.Drawing.Size(180, 22);
            this.ExaminationBtn.Text = "Examination";
            this.ExaminationBtn.Click += new System.EventHandler(this.OnMenuClicked);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutBtn});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // AboutBtn
            // 
            this.AboutBtn.Name = "AboutBtn";
            this.AboutBtn.Size = new System.Drawing.Size(180, 22);
            this.AboutBtn.Text = "About";
            this.AboutBtn.Click += new System.EventHandler(this.OnMenuClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 494);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SMS (School Management System)";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem setupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SessionBtn;
        private System.Windows.Forms.ToolStripMenuItem ProgramBtn;
        private System.Windows.Forms.ToolStripMenuItem ProgramOfferBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem PartsBtn;
        private System.Windows.Forms.ToolStripMenuItem SubjectBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem DepartmentBtn;
        private System.Windows.Forms.ToolStripMenuItem TeacherBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem ProgramCourseLinkBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem ExitBtn;
        private System.Windows.Forms.ToolStripMenuItem currecularToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AdmissionBtn;
        private System.Windows.Forms.ToolStripMenuItem EntrollementBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem AttendanceBtn;
        private System.Windows.Forms.ToolStripMenuItem ExaminationBtn;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutBtn;
    }
}

