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
    public partial class MidtermRequirements : UserControl
    {
        public MidtermRequirements()
        {
            InitializeComponent();
        }

        private void addmidtermrequirements_Click(object sender, EventArgs e)
        {
            AddMidtermReqs AddMidtermReqs = new AddMidtermReqs();
            AddMidtermReqs.ShowDialog();
        }
    }
}
