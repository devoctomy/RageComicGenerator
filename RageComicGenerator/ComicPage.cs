﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RageComicGenerator
{
    public partial class ComicPage : UserControl
    {

        #region Public event definitions

        public delegate void PageChangedEventHandler(Object oSender);
        public event PageChangedEventHandler PageChanged;

        public delegate void PageLayoutChangedEventHandler(Object oSender);
        public event PageLayoutChangedEventHandler PageLayoutChanged;

        #endregion

        #region Private Object declarations

        Boolean cBlnLayoutSelected = false;

        #endregion

        #region Constructor / Destructor

        public ComicPage()
        {
            InitializeComponent();
        }

        #endregion

        #region Private methods

        private void ReverseControls(Control iControl)
        {
            if (iControl.Controls.Count > 0)
            {
                foreach (Control curControl in iControl.Controls)
                {
                    ReverseControls(curControl);
                }
            }
            int pIntMax = iControl.Controls.Count - 1;
            int pIntIndex = 0;
            for (pIntIndex = pIntMax; pIntIndex >= 0; pIntIndex--)
            {
                iControl.Controls.SetChildIndex(iControl.Controls[pIntMax], pIntMax - pIntIndex);
            }
        }

        private void AddPanelHandlers(List<ComicPanel> iPanels)
        {
            foreach(ComicPanel curPanel in iPanels)
            {
                curPanel.PanelChanged += new ComicPanel.PanelChangedEventHandler(curPanel_PanelChanged);
            }
        }

        #endregion

        #region Public methods

        public void SelectLayout()
        {
            frmLayouts pFrmLayouts = new frmLayouts();
            using (pFrmLayouts)
            {
                if (pFrmLayouts.ShowDialog() == DialogResult.OK)
                {
                    cBlnLayoutSelected = true;
                    lblSelectLayout.Visible = false;

                    List<ComicPanel> pLisPanels;
                    frmLayouts.ApplyLayoutToTable(pFrmLayouts.SelectedLayout, tlpLayout, true, out pLisPanels);
                    AddPanelHandlers(pLisPanels);

                    if (PageLayoutChanged != null)
                        PageLayoutChanged(this);

                    if (PageChanged != null)
                        PageChanged(this);
                }
            }
        }

        public void ReverseControls()
        {
            ReverseControls(this);
        }

        public Bitmap ExportToBitmap(int iWidth, int iHeight)
        {
            lblSelectLayout.Visible = false;
            Bitmap pBmpBitmap = new Bitmap(Width, Height);
            Bitmap pBmpResized = new Bitmap(iWidth, iHeight);
            using (pBmpBitmap)
            {
                ReverseControls();
                Invalidate();
                DrawToBitmap(pBmpBitmap, new Rectangle(0, 0, Width, Height));
                ReverseControls();
                Invalidate();
                
                Graphics pGraResized = Graphics.FromImage(pBmpResized);
                using (pGraResized)
                {
                    pGraResized.DrawImage(pBmpBitmap, 0, 0, pBmpResized.Width, pBmpResized.Height);
                }
            }
            lblSelectLayout.Visible = (!cBlnLayoutSelected);
            return (pBmpResized);
        }

        #endregion

        #region Object events

        void curPanel_PanelChanged(object oSender)
        {
            if (PageChanged != null)
                PageChanged(this);
        }

        private void lblSelectLayout_Click(object sender, EventArgs e)
        {
            SelectLayout();
        }

        #endregion

    }
}
