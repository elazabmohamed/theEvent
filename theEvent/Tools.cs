using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace theEvent
{
    public partial class Tools : Form
    {
        public Tools(string email)
        {
            InitializeComponent();
            LogLabel.Text = email;
        }

        private void Tools_Load(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {
            SearchMemberN s = new SearchMemberN();
            s.ShowDialog();

        }

        private void label8_Click(object sender, EventArgs e)
        {
            SearchMemberL s = new SearchMemberL();
            s.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            UpdateInfo s = new UpdateInfo(LogLabel.Text);
            s.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            UpdateEvent s = new UpdateEvent(LogLabel.Text);
            s.ShowDialog();
        }

        private void label14_Click(object sender, EventArgs e)
        {
            SearchEventL s = new SearchEventL();
            s.ShowDialog();
        }

        private void label15_Click(object sender, EventArgs e)
        {
            SearchEventN s = new SearchEventN();
            s.ShowDialog();
        }
    }
}
