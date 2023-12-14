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

namespace InternGuide.Deans_Form.Requirements
{
    public partial class widgetprelim : UserControl
    {
        private string title;
        private string description;
        private string samplefiletitle;
        public widgetprelim()
        {
            InitializeComponent();
        }

        private void widgetprelim_Load(object sender, EventArgs e)
        {

        }

        [Category("Data")]
        public string Title
        {
            get { return title; }
            set { title = value; titletextbox.Text = "Title :"+value; }
        }


        [Category("Data")]
        public string Description
        {
            get { return description; }
            set { description = value; descriptiontextbox.Text = "Description :\n" + value; }
        }

        private void downloadsamplefilebtn_Click(object sender, EventArgs e)
        {

        }

        //[Category("Data")]
        //public string Samplefiletitle
        //{
        //    get { return samplefiletitle; }
        //    set { samplefiletitle = value; sampletitletextbox.Text = value; }
        //}
    }
}
