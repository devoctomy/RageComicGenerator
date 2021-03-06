﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace RageComicGenerator
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmComicEditor pCErComic = new frmComicEditor();
            pCErComic.MdiParent = this;
            pCErComic.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void changeLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangeLog pCLgLog = new frmChangeLog();
            using (pCLgLog)
            {
                pCLgLog.ShowDialog();
            }
        }

    }
}
