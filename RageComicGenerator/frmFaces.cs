using System;
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
    public partial class frmFaces : Form
    {

        #region Private object declarations

        private PictureBox cPBxSelectedFace = null;

        #endregion

        #region Property interface

        public Image SelectedFace
        {
            get { return (cPBxSelectedFace.Image); }
        }

        #endregion

        #region Constructor / Destructor

        public frmFaces()
        {
            InitializeComponent();
            EnumerateFaces();
        }

        #endregion

        #region Private methods

        private void EnumerateFaces()
        {
            String pStrPath = Path.GetDirectoryName(Application.ExecutablePath);
            pStrPath = Path.Combine(pStrPath, @"Configuration\Faces\");

            String[] pStrFaces = Directory.GetFiles(pStrPath, "*.jpg");
            foreach (String curFace in pStrFaces)
            {
                PictureBox pPBxFace = new PictureBox();
                pPBxFace.Width = 4 * 40;
                pPBxFace.Height = 3 * 40;
                pPBxFace.SizeMode = PictureBoxSizeMode.Zoom;
                pPBxFace.BackColor = Color.Blue;
                pPBxFace.Image = Image.FromFile(curFace);

                pPBxFace.Tag = curFace;
                pPBxFace.Click += new EventHandler(pPBxFace_Click);
                flpFaces.Controls.Add(pPBxFace);
                pPBxFace.Show();
            }
        }

        #endregion

        #region Object events

        void pPBxFace_Click(object sender, EventArgs e)
        {
            PictureBox pPBxSelected = (PictureBox)sender;

            if (cPBxSelectedFace != null)
                cPBxSelectedFace.BackColor = Color.Blue;

            cPBxSelectedFace = pPBxSelected;
            cPBxSelectedFace.BackColor = Color.Red;

            butOK.Enabled = true;
        }

        #endregion

    }
}
