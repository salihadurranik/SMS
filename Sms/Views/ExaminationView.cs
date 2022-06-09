using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sms.Views
{
    public partial class ExaminationView : Form
    {
        public ExaminationView()
        {
            InitializeComponent();
        }

        private void ExaminationView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'smsDataSet.Students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter.Fill(this.smsDataSet.Students);
            // TODO: This line of code loads data into the 'smsDataSet.ExamDetail' table. You can move, or remove it, as needed.
            this.examDetailTableAdapter.Fill(this.smsDataSet.ExamDetail);
            // TODO: This line of code loads data into the 'smsDataSet.CourseOfferView' table. You can move, or remove it, as needed.
            this.courseOfferViewTableAdapter.Fill(this.smsDataSet.CourseOfferView);
            // TODO: This line of code loads data into the 'smsDataSet.ExamMaster' table. You can move, or remove it, as needed.
            this.examMasterTableAdapter.Fill(this.smsDataSet.ExamMaster);

        }
    }
}
