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
    public partial class frmComicEditor : Form
    {

        #region Private object declarations

        private Dictionary<ComicPage, PictureBox> cDicPagesAndThumbs = new Dictionary<ComicPage, PictureBox>();
        private ComicPage cCPeSelectedPage;
        private PictureBox cPBxRightClickedThumb;

        #endregion

        #region Constructor / Destructor

        public frmComicEditor()
        {
            InitializeComponent();

            AddNewPage();
        }

        #endregion

        #region Public methods

        public void AddNewPage()
        {
            ComicPage pCPePage = new ComicPage();
            pCPePage.Location = new Point(0,0);
            pCPePage.Size = new Size(800,600);
            pCPePage.PageChanged += new ComicPage.PageChangedEventHandler(cpeComic_PageChanged);
            pCPePage.PageLayoutChanged += new ComicPage.PageLayoutChangedEventHandler(pCPePage_PageLayoutChanged);
            PictureBox pPBeThumb = new PictureBox();
            pPBeThumb.ContextMenuStrip = cmsComicPage;
            pPBeThumb.BorderStyle = BorderStyle.FixedSingle;
            pPBeThumb.Width = flpThumbs.Width - 24;
            pPBeThumb.Height = 96;
            pPBeThumb.Tag = pCPePage;
            pPBeThumb.Image = pCPePage.ExportToBitmap(pPBeThumb.Width, pPBeThumb.Height);
            pPBeThumb.Click += new EventHandler(pPBeThumb_Click);
            pPBeThumb.MouseDown += new MouseEventHandler(pPBeThumb_MouseDown);
            flpThumbs.Controls.Add(pPBeThumb);
            cDicPagesAndThumbs.Add(pCPePage, pPBeThumb);
            cCPeSelectedPage = pCPePage;
            foreach (Control curControl in tpeComicEditorEdit.Controls)
            {
                if (curControl != panTip)
                    if (curControl.Parent != panTip)
                        tpeComicEditorEdit.Controls.Remove(curControl);
            }
            tpeComicEditorEdit.Controls.Add(cCPeSelectedPage);
            CenterComic();
        }

        public Bitmap DrawToBitmap()
        {
            int pIntWidth = 0;
            int pIntHeight = 0;
            List<Bitmap> pLisBitmaps = new List<Bitmap>();
            int pIntCurPage = 0;
            for(pIntCurPage = 0; pIntCurPage < flpThumbs.Controls.Count; pIntCurPage ++)
            {
                PictureBox pPBxThumb = (PictureBox)flpThumbs.Controls[pIntCurPage];
                ComicPage pCPePage = (ComicPage)pPBxThumb.Tag;
                pLisBitmaps.Add(pCPePage.ExportToBitmap(pCPePage.Width, pCPePage.Height));

                if (pIntWidth < pCPePage.Width) pIntWidth = pCPePage.Width;
                pIntHeight += pCPePage.Height;
            }

            int pIntYPos = 0;
            Bitmap pBmpBitmap = new Bitmap(pIntWidth, pIntHeight);
            Graphics pGraGraphics = Graphics.FromImage(pBmpBitmap);
            using (pGraGraphics)
            {
                foreach (Bitmap curBitmap in pLisBitmaps)
                {
                    pGraGraphics.DrawImage(curBitmap, 0, pIntYPos, curBitmap.Width, curBitmap.Height);
                    pIntYPos += curBitmap.Height;
                }
            }
            return (pBmpBitmap);
        }

        #endregion

        #region Private methods

        private void DisplayTip(String iMessage)
        {
            lblTip.Text = iMessage;
            panTip.Visible = true;
            panTip.BringToFront();
        }

        private void CenterComic()
        {
            cCPeSelectedPage.Location = new Point((tpeComicEditorEdit.Width / 2) - (cCPeSelectedPage.Width / 2),
                            (tpeComicEditorEdit.Height / 2) - (cCPeSelectedPage.Height / 2));
        }

        private void CenterPreview()
        {
            if (picPreview.Height > tpeComicEditorPreview.Height)
            {
                picPreview.Location = new Point((tpeComicEditorPreview.Width / 2) - (picPreview.Width / 2),
                    0);
            }
            else
            {
                picPreview.Location = new Point((tpeComicEditorPreview.Width / 2) - (picPreview.Width / 2),
                    (tpeComicEditorPreview.Height / 2) - (picPreview.Height / 2));
            }
        }

        private void SelectPage(PictureBox iThumb)
        {
            PictureBox pPBxThumb = iThumb;
            ComicPage pCPePage = (ComicPage)pPBxThumb.Tag;
            tpeComicEditorEdit.Controls.Clear();
            foreach (Control curControl in tpeComicEditorEdit.Controls)
            {
                if (curControl != panTip)
                    if (curControl.Parent != panTip)
                        tpeComicEditorEdit.Controls.Remove(curControl);
            }
            tpeComicEditorEdit.Controls.Add(pCPePage);
            cCPeSelectedPage = pCPePage;
            CenterComic();
        }

        #endregion

        #region Object events

        void pCPePage_PageLayoutChanged(object oSender)
        {
            DisplayTip(Properties.Resources.AddContentTip);
        }

        void pPBeThumb_Click(object sender, EventArgs e)
        {
            SelectPage((PictureBox)sender);
        }

        private void tpeComicEditorEdit_Resize(object sender, EventArgs e)
        {
            CenterComic();
        }

        private void selectLayoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cCPeSelectedPage.SelectLayout();
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog pSFDSave = new SaveFileDialog();
            using (pSFDSave)
            {
                String pStrDefaultPath = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
                pStrDefaultPath = Path.Combine(pStrDefaultPath, "RageComics");
                if (!Directory.Exists(pStrDefaultPath))
                    Directory.CreateDirectory(pStrDefaultPath);

                DateTime pDTeNow = DateTime.Now;
                pSFDSave.AddExtension = true;
                pSFDSave.CheckPathExists = true;
                pSFDSave.FileName = "RCG_" + pDTeNow.DayOfYear + "_" + Environment.TickCount.ToString() + ".jpg";
                pSFDSave.Filter = @"jpg images (*.jpg)|*.jpg|All files (*.*)|*.*";
                pSFDSave.InitialDirectory = pStrDefaultPath;

                if (pSFDSave.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    Bitmap pBmpBitmap = DrawToBitmap();
                    using (pBmpBitmap)
                    {
                        pBmpBitmap.Save(pSFDSave.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                    }
                }
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void selectSizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSizeSelect pSStSize = new frmSizeSelect();
            using (pSStSize)
            {
                pSStSize.Width = cCPeSelectedPage.Width;
                pSStSize.Height = cCPeSelectedPage.Height;
                if (pSStSize.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    cCPeSelectedPage.Width = (int)pSStSize.Width;
                    cCPeSelectedPage.Height = (int)pSStSize.Height;
                    CenterComic();
                }
            }
        }

        private void addNewPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewPage();
        }

        private void cpeComic_PageChanged(object oSender)
        {
            if(cDicPagesAndThumbs.ContainsKey((ComicPage)oSender))
            {
                PictureBox pPBxThumb = cDicPagesAndThumbs[(ComicPage)oSender];
                Image pImgOld = pPBxThumb.Image;
                pPBxThumb.Image = null;
                pImgOld.Dispose();
                pPBxThumb.Image = ((ComicPage)oSender).ExportToBitmap(pPBxThumb.Width, pPBxThumb.Height);
            }
        }

        private void tclComicEditor_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tclComicEditor.SelectedIndex)
            {
                case (1):
                    {
                        picPreview.Image = DrawToBitmap();
                        CenterPreview();
                        break;
                    }
            }
        }

        void pPBeThumb_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                PictureBox pPBxThumb = (PictureBox)sender;
                cPBxRightClickedThumb = pPBxThumb;
            }
        }

        private void tpeComicEditorPreview_Resize(object sender, EventArgs e)
        {
            CenterPreview();
        }

        private void deletePageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ComicPage pCPePage = (ComicPage)cPBxRightClickedThumb.Tag;
            Boolean pBlnSelected = tpeComicEditorEdit.Controls.Contains(pCPePage);
            flpThumbs.Controls.Remove(cPBxRightClickedThumb);
            cDicPagesAndThumbs.Remove(pCPePage);
            if (pBlnSelected)
            {
                tpeComicEditorEdit.Controls.Clear();
                if(tpeComicEditorEdit.Controls.Count > 0)
                    SelectPage((PictureBox)tpeComicEditorEdit.Controls[0]);
            }
        }

        private void picCloseTip_Click(object sender, EventArgs e)
        {
            panTip.Visible = false;
        }

        private void picInfoTip_Click(object sender, EventArgs e)
        {
            panTip.Visible = false;
        }

        #endregion

    }
}
