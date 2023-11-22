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
        public ManageStudentReq()
        {
            InitializeComponent();
            PrelimRequirements PrelimRequirements = new PrelimRequirements();
            addUserControl(PrelimRequirements);
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
            PrelimRequirements PrelimRequirements = new PrelimRequirements();
            addUserControl(PrelimRequirements);
            
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
