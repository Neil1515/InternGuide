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
    public partial class SemifinalRequirements : UserControl
    {
        public SemifinalRequirements()
        {
            InitializeComponent();
        }

        private void addsemifinalrequirements_Click(object sender, EventArgs e)
        {
            AddSemiFinalReqs AddSemiFinalReqs = new AddSemiFinalReqs();
            AddSemiFinalReqs.ShowDialog();
        }
    }
}
