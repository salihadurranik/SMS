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
    public partial class ProgramOfferView : Form
    {
        public ProgramOfferView()
        {
            InitializeComponent();
        }

        private void ProgramOfferView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'smsDataSet.Programs' table. You can move, or remove it, as needed.
            this.programsTableAdapter.Fill(this.smsDataSet.Programs);
            // TODO: This line of code loads data into the 'smsDataSet.Sessions' table. You can move, or remove it, as needed.
            this.sessionsTableAdapter.Fill(this.smsDataSet.Sessions);
            // TODO: This line of code loads data into the 'smsDataSet.ProgramOffers' table. You can move, or remove it, as needed.
            this.programOffersTableAdapter.Fill(this.smsDataSet.ProgramOffers);

        }
    }
}
