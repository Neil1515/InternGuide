﻿using System;
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
    public partial class FinalRequirements : UserControl
    {
        public FinalRequirements()
        {
            InitializeComponent();
        }

        private void FinalRequirements_Load(object sender, EventArgs e)
        {

        }

        private void addfinalreqs_Click(object sender, EventArgs e)
        {
            AddFinalReqs AddFinalReqs = new AddFinalReqs();
            AddFinalReqs.ShowDialog();
        }
    }
}
