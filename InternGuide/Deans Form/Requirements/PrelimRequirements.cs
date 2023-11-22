using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InternGuide.Deans_Form.Requirements
{
    public partial class PrelimRequirements : UserControl
    {
        public PrelimRequirements()
        {
            InitializeComponent();
        }

        private void PrelimRequirements_Load(object sender, EventArgs e)
        {

        }

        private void addprelimrequirements_Click(object sender, EventArgs e)
        {
            AddPrelimReqs AddPrelimReqs = new AddPrelimReqs();
            AddPrelimReqs.ShowDialog();
        }
    }
}
