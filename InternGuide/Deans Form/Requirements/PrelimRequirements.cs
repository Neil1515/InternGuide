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
        private int deansId;
        private string deanDepartment;
        public PrelimRequirements(int deansId, string deanDepartment)
        {
            InitializeComponent();
            this.deansId = deansId;
            this.deanDepartment = deanDepartment;
        }

        private void PrelimRequirements_Load(object sender, EventArgs e)
        {

        }

        private void addprelimrequirements_Click(object sender, EventArgs e)
        {
            AddPrelimReqs addPrelimReqsForm = new AddPrelimReqs(deansId, deanDepartment);
            addPrelimReqsForm.ShowDialog();
        }
    }
}
