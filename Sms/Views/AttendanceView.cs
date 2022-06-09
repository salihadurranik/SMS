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
    public partial class AttendanceView : Form
    {
        public AttendanceView()
        {
            InitializeComponent();
        }

        private void AttendanceView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'smsDataSet.Students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter.Fill(this.smsDataSet.Students);
            // TODO: This line of code loads data into the 'smsDataSet.AttendanceDetails' table. You can move, or remove it, as needed.
            this.attendanceDetailsTableAdapter.Fill(this.smsDataSet.AttendanceDetails);
            // TODO: This line of code loads data into the 'smsDataSet.CourseOfferView' table. You can move, or remove it, as needed.
            this.courseOfferViewTableAdapter.Fill(this.smsDataSet.CourseOfferView);
            // TODO: This line of code loads data into the 'smsDataSet.AttendanceMaster' table. You can move, or remove it, as needed.
            this.attendanceMasterTableAdapter.Fill(this.smsDataSet.AttendanceMaster);

        }
    }
}
