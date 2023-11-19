using InternGuide.Admin_Form;
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
using static InternGuide.Deans_Form.InsertInternStudent;

namespace InternGuide.Deans_Form
{
    
    public partial class StudentWidget : UserControl
    {
        public StudentWidget()
        {
            InitializeComponent();
        }

        private void StudentWidget_Load(object sender, EventArgs e)
        {

        }
        private int studentid;
        private string studentfullname;
        private string studemail;
        private string yrcourse;
        private Image picture;

        [Category("Data")]
        public int StudID
        {
            get { return studentid; }
            set { studentid = value; studidlabel.Text = value.ToString(); }
        }


        [Category("Data")]
        public string StudentName
        {
            get { return studentfullname; }
            set { studentfullname = value; studnamelabel.Text = value; }
        }

        [Category("Data")]
        public string Yrcourse
        {
            get { return yrcourse; }
            set { yrcourse = value; studyrcourselabel.Text = value; }
        }

        [Category("Data")]
        public string Studemail
        {
            get { return studemail; }
            set { studemail = value; studemaillabel.Text = value; }
        }


        [Category("Data")]
        public Image StudentImage
        {
            get { return picture; }
            set { picture = value; studentwidgetPictureBox.Image = value; }
        }
    }
}
