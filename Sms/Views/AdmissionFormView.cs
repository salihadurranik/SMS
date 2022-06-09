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
    public partial class AdmissionFormView : Form
    {
        public AdmissionFormView()
        {
            InitializeComponent();
        }

        private void AdmissionFormView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'smsDataSet.ProgramOfferView' table. You can move, or remove it, as needed.
            this.programOfferViewTableAdapter.Fill(this.smsDataSet.ProgramOfferView);
            // TODO: This line of code loads data into the 'smsDataSet.Students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter.Fill(this.smsDataSet.Students);

        }
    }
}
