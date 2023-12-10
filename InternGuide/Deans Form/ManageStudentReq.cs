using InternGuide.Deans_Form.Requirements;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InternGuide.Deans_Form
{
    public partial class ManageStudentReq : UserControl
    {
        private int deansId;
        private string deanDepartment;
        public ManageStudentReq(int deansId, string deanDepartment)
        {
            InitializeComponent();
            this.deansId = deansId;
            this.deanDepartment = deanDepartment;

            // Use the correct class name and constructor parameters
            PrelimRequirements prelimRequirements = new PrelimRequirements(deansId, deanDepartment);
            addUserControl(prelimRequirements);
        }

        
        private void ManageStudentReq_Load(object sender, EventArgs e)
        {

        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            dashrequirementpanel.Controls.Clear();
            dashrequirementpanel.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void prelimbtn_Click(object sender, EventArgs e)
        {
            // Use the correct class name and constructor parameters
            PrelimRequirements prelimRequirements = new PrelimRequirements(deansId, deanDepartment);
            addUserControl(prelimRequirements);

        }

        private void midtermbtn_Click(object sender, EventArgs e)
        {
            MidtermRequirements MidtermRequirements = new MidtermRequirements();
            addUserControl(MidtermRequirements);
        }

        private void semifinalbtn_Click(object sender, EventArgs e)
        {
            SemifinalRequirements SemifinalRequirements = new SemifinalRequirements();
            addUserControl(SemifinalRequirements);
        }

        private void finalbtn_Click(object sender, EventArgs e)
        {
            FinalRequirements FinalRequirements = new FinalRequirements();
            addUserControl(FinalRequirements);
        }
    }
}
