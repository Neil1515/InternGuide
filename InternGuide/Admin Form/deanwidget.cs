using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace InternGuide.Admin_Form
{
    public partial class deanwidget : UserControl
    {
        public deanwidget()
        {
            InitializeComponent();
        }

        private void adminwidget_Load(object sender, EventArgs e)
        {

        }
        private int departmentdeansid;
        private string deansfullname;
        private string department;
        private Image picture;

        [Category("Data")]
        public int DeansID
        {
            get { return departmentdeansid; }
            set { departmentdeansid = value; idlabel.Text = value.ToString(); }
        }


        [Category("Data")]
        public string DeansName
        {
            get { return deansfullname; }
            set { deansfullname = value; namelabel.Text = value; }
        }

        [Category("Data")]
        public string Department
        {
            get { return department; }
            set { department = value; departmentlabel.Text = value; }
        }

        [Category("Data")]
        public Image DeansImage
        {
            get { return picture; }
            set { picture = value; deptadminpictureBox.Image = value; }
        }
    }
}
