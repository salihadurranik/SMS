using System;
using System.Windows.Forms;

namespace Sms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void OnMenuClicked(object sender, EventArgs e)
        {
            var sendingMenu = ((ToolStripMenuItem)sender).Name;

            switch (sendingMenu)
            {
                case "ExitBtn":
                    Application.Exit();
                    break;
                case "SessionBtn":
                    var session = new Views.SessionView();
                    session.MdiParent = this;
                    session.Show();
                    break;
                case "ProgramBtn":
                    var program = new Views.ProgramView();
                    program.MdiParent = this;
                    program.Show();
                    break;
                case "ProgramOfferBtn":
                    var programOffer = new Views.ProgramOfferView();
                    programOffer.MdiParent = this;
                    programOffer.Show();
                    break;
                case "PartsBtn":
                    var parts = new Views.PartsView();
                    parts.MdiParent = this;
                    parts.Show();
                    break;
                case "SubjectBtn":
                    var subjects = new Views.SubjectsView();
                    subjects.MdiParent = this;
                    subjects.Show();
                    break;
                case "DepartmentBtn":
                    var department = new Views.DepartmentsView();
                    department.MdiParent = this;
                    department.Show();
                    break;
                case "TeacherBtn":
                    var teacher = new Views.TeacherView();
                    teacher.MdiParent = this;
                    teacher.Show();
                    break;
                case "ProgramCourseLinkBtn":
                    var programCl = new Views.ProgramCourseLinkView();
                    programCl.MdiParent = this;
                    programCl.Show();
                    break;
                case "AdmissionBtn":
                    var admission = new Views.AdmissionFormView();
                    admission.MdiParent = this;
                    admission.Show();
                    break;
                case "EntrollementBtn":
                    var enrollment = new Views.EnrollementView();
                    enrollment.MdiParent = this;
                    enrollment.Show();
                    break;
                case "AttendanceBtn":
                    var attendance = new Views.AttendanceView();
                    attendance.MdiParent = this;
                    attendance.Show();
                    break;
                case "ExaminationBtn":
                    var examination = new Views.ExaminationView();
                    examination.MdiParent = this;
                    examination.Show();
                    break;
                case "AboutBtn":
                    MessageBox.Show("SMS Application developed by Reg# 2020427");
                    break;
            }
        }
    }
}
