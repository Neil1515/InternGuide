using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InternGuide
{
    public partial class DeansDashboard : Form
    {
        public DeansDashboard()
        {
            InitializeComponent();
        }

        private void DeansDashboard_Load(object sender, EventArgs e)
        {

        }

        private void Logout1brn_Click(object sender, EventArgs e)
        {
            this.Hide();
            login login = new login();
            login.ShowDialog();
        }
    }
}
