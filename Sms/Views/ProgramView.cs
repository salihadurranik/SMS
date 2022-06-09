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
    public partial class ProgramView : Form
    {
        public ProgramView()
        {
            InitializeComponent();
        }

        private void ProgramView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'smsDataSet.Programs' table. You can move, or remove it, as needed.
            this.programsTableAdapter.Fill(this.smsDataSet.Programs);

        }
    }
}
