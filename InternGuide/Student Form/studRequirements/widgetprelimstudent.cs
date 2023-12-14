using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InternGuide.Student_Form.studRequirements
{
    public partial class widgetprelimstudent : UserControl
    {
        private string title;
        private string description;
        public widgetprelimstudent()
        {
            InitializeComponent();
        }
        [Category("Data")]
        public string Title
        {
            get { return title; }
            set { title = value; titletextbox.Text = "Title :" + value; }
        }


        [Category("Data")]
        public string Description
        {
            get { return description; }
            set { description = value; descriptiontextbox.Text = "Description :\n" + value; }
        }
    }

}
