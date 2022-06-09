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
    public partial class SessionView : Form
    {
        public SessionView()
        {
            InitializeComponent();
        }

        private void SessionView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'smsDataSet.Sessions' table. You can move, or remove it, as needed.
            this.sessionsTableAdapter.Fill(this.smsDataSet.Sessions);

        }
    }
}
