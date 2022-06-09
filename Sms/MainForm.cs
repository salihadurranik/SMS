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
                case "SessionBtn":
                    var session = new Views.SessionView();
                    session.MdiParent = this;
                    session.Show();
                    break;
            }
        }
    }
}
