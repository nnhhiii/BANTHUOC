﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BANTHUOC
{
    public partial class fEditStaff : Form
    {
        public fEditStaff(long v)
        {
            InitializeComponent();
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
