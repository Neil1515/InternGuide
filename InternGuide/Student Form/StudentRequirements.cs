using System;
using InternGuide.Student_Form.studRequirements;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InternGuide.Student_Form
{
    public partial class StudentRequirements : UserControl
    {
        public StudentRequirements()
        {
            InitializeComponent();
            RequirementsPrelim PrelimRequirements = new RequirementsPrelim();
            addUserControl(PrelimRequirements);
        }

        private void StudentRequirements_Load(object sender, EventArgs e)
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
            RequirementsPrelim PrelimRequirements = new RequirementsPrelim();
            addUserControl(PrelimRequirements);
        }

        private void midtermbtn_Click(object sender, EventArgs e)
        {
            // Use the correct class name and constructor parameters
            RequirementsMidterm RequirementsMidterm = new RequirementsMidterm();
            addUserControl(RequirementsMidterm);
        }

        private void semifinalbtn_Click(object sender, EventArgs e)
        {
            // Use the correct class name and constructor parameters
            RequirementsSemifinal RequirementsSemifinal = new RequirementsSemifinal();
            addUserControl(RequirementsSemifinal);
        }

        private void finalbtn_Click(object sender, EventArgs e)
        {
            // Use the correct class name and constructor parameters
            RequirementsFinal RequirementsFinal = new RequirementsFinal();
            addUserControl(RequirementsFinal);
        }
    }
}
