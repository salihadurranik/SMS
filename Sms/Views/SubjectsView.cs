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
    public partial class SubjectsView : Form
    {
        public SubjectsView()
        {
            InitializeComponent();
        }

        private void SubjectsView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'smsDataSet.Teachers' table. You can move, or remove it, as needed.
            this.teachersTableAdapter.Fill(this.smsDataSet.Teachers);
            // TODO: This line of code loads data into the 'smsDataSet.Subjects' table. You can move, or remove it, as needed.
            this.subjectsTableAdapter.Fill(this.smsDataSet.Subjects);

        }
    }
}
