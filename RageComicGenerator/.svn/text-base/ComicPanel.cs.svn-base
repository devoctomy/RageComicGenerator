using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RageComicGenerator
{
    public partial class ComicPanel : UserControl
    {

        #region Public event definitions

        public delegate void PanelChangedEventHandler(Object oSender);
        public event PanelChangedEventHandler PanelChanged;

        #endregion

        #region Private object declarations

        Boolean pBlnDragging = false;
        int cIntMouseX = 0;
        int cIntMouseY = 0;
        Object pObjRightClickedControl;
        

        #endregion

        #region Constructor / Destructor

        public ComicPanel()
        {
            InitializeComponent();
        }

        #endregion

        #region Public methods

        public void StartExport()
        {
            
        }

        public void EndExport()
        {

        }

        #endregion

        #region Object events

        private void rageFaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFaces pFrmFaces = new frmFaces();
            using (pFrmFaces)
            {
                if (pFrmFaces.ShowDialog() == DialogResult.OK)
                {
                    PictureBox pPBxFace = new PictureBox();
                    pPBxFace.Width = 4 * 70;
                    pPBxFace.Height = 3 * 70;
                    pPBxFace.BackColor = BackColor;
                    pPBxFace.Image = pFrmFaces.SelectedFace;
                    pPBxFace.MouseDown += new MouseEventHandler(pPBxFace_MouseDown);
                    pPBxFace.MouseUp += new MouseEventHandler(pPBxFace_MouseUp);
                    pPBxFace.MouseMove += new MouseEventHandler(pPBxFace_MouseMove);
                    pPBxFace.ContextMenuStrip = cmsPictureBoxOptions;
                    Controls.Add(pPBxFace);
                    pPBxFace.Show();
                    pPBxFace.BringToFront();

                    if (PanelChanged != null)
                        PanelChanged(this);
                }
            }
        }

        void pPBxFace_MouseMove(object sender, MouseEventArgs e)
        {
            PictureBox pPBxPicture = (PictureBox)sender;
            if (pBlnDragging)
            {
                Point pPntLocation = this.PointToClient(MousePosition);
                pPntLocation.Offset(cIntMouseX, cIntMouseY);
                pPBxPicture.Location = pPntLocation;
            }
        }

        void pPBxFace_MouseUp(object sender, MouseEventArgs e)
        {
            PictureBox pPBxPicture = (PictureBox)sender;
            if (pBlnDragging)
            {
                pBlnDragging = false;
                pPBxPicture.Invalidate();

                if (PanelChanged != null)
                    PanelChanged(this);
            }
        }

        void pPBxFace_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox pPBxPicture = (PictureBox)sender;
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                pBlnDragging = true;
                cIntMouseX = -e.X;
                cIntMouseY = -e.Y;
                pPBxPicture.Invalidate();
            }
            else if (e.Button == System.Windows.Forms.MouseButtons.Right)
                pObjRightClickedControl = pPBxPicture;
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PictureBox pPBxPicture = (PictureBox)pObjRightClickedControl;
            pPBxPicture.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
            pPBxPicture.Invalidate();

            if (PanelChanged != null)
                PanelChanged(this);
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PictureBox pPBxPicture = (PictureBox)pObjRightClickedControl;
            pPBxPicture.Image.RotateFlip(RotateFlipType.RotateNoneFlipY);
            pPBxPicture.Invalidate();

            if (PanelChanged != null)
                PanelChanged(this);
        }

        private void clockwiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PictureBox pPBxPicture = (PictureBox)pObjRightClickedControl;
            pPBxPicture.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pPBxPicture.Invalidate();

            if (PanelChanged != null)
                PanelChanged(this);
        }

        private void antiClockwiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PictureBox pPBxPicture = (PictureBox)pObjRightClickedControl;
            pPBxPicture.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
            pPBxPicture.Invalidate();

            if (PanelChanged != null)
                PanelChanged(this);
        }

        private void labelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLabel pFrmLabel = new frmLabel();
            using (pFrmLabel)
            {
                if (pFrmLabel.ShowDialog() == DialogResult.OK)
                {
                    if (!String.IsNullOrEmpty(pFrmLabel.LabelText))
                    {
                        Label pLblLabel = new Label();
                        pLblLabel.AutoSize = true;
                        pLblLabel.BackColor = Color.Transparent;
                        pLblLabel.Text = pFrmLabel.LabelText;
                        pLblLabel.Font = pFrmLabel.Style.Font;
                        pLblLabel.ForeColor = pFrmLabel.Style.ForeColour;
                        pLblLabel.Tag = pFrmLabel.Style;
                        pLblLabel.MouseDown += new MouseEventHandler(pLblLabel_MouseDown);
                        pLblLabel.MouseUp += new MouseEventHandler(pLblLabel_MouseUp);
                        pLblLabel.MouseMove += new MouseEventHandler(pLblLabel_MouseMove);
                        pLblLabel.ContextMenuStrip = cmsLabelOptions;
                        Controls.Add(pLblLabel);
                        pFrmLabel.Show();
                        Controls.SetChildIndex(pLblLabel, 0);

                        if (PanelChanged != null)
                            PanelChanged(this);
                    }
                }
            }
        }

        void pLblLabel_MouseMove(object sender, MouseEventArgs e)
        {
            Label pLblLabel = (Label)sender;
            if (pBlnDragging)
            {
                Point pPntLocation = this.PointToClient(MousePosition);
                pPntLocation.Offset(cIntMouseX, cIntMouseY);
                pLblLabel.Location = pPntLocation;
            }
        }

        void pLblLabel_MouseUp(object sender, MouseEventArgs e)
        {
            Label pLblLabel = (Label)sender;
            if (pBlnDragging)
            {
                pBlnDragging = false;
                pLblLabel.Invalidate();

                if (PanelChanged != null)
                    PanelChanged(this);
            }
        }

        void pLblLabel_MouseDown(object sender, MouseEventArgs e)
        {
            Label pLblLabel = (Label)sender;
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                pBlnDragging = true;
                cIntMouseX = -e.X;
                cIntMouseY = -e.Y;
                pLblLabel.Invalidate();
            }
            else if (e.Button == System.Windows.Forms.MouseButtons.Right)
                pObjRightClickedControl = pLblLabel;
        }

        private void changeFaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PictureBox pPBxPicture = (PictureBox)pObjRightClickedControl;
            frmFaces pFrmFaces = new frmFaces();
            using (pFrmFaces)
            {
                if (pFrmFaces.ShowDialog() == DialogResult.OK)
                {
                    pPBxPicture.Image = pFrmFaces.SelectedFace;

                    if (PanelChanged != null)
                        PanelChanged(this);
                }
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PictureBox pPBxPicture = (PictureBox)pObjRightClickedControl;
            Controls.Remove(pPBxPicture);

            if (PanelChanged != null)
                PanelChanged(this);
        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Label pLblLabel = (Label)pObjRightClickedControl;
            Controls.Remove(pLblLabel);

            if (PanelChanged != null)
                PanelChanged(this);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Label pLblLabel = (Label)pObjRightClickedControl;
            frmLabel pFrmLabel = new frmLabel();
            using (pFrmLabel)
            {
                pFrmLabel.LabelText = pLblLabel.Text;
                pFrmLabel.Style = (LabelStyle)((LabelStyle)pLblLabel.Tag).Clone();
                if (pFrmLabel.ShowDialog() == DialogResult.OK)
                {
                    if (String.IsNullOrEmpty(pFrmLabel.LabelText))
                    {
                        Controls.Remove(pLblLabel);
                    }
                    else
                    {
                        pLblLabel.Text = pFrmLabel.LabelText;
                        pLblLabel.Font = pFrmLabel.Style.Font;
                        pLblLabel.ForeColor = pFrmLabel.Style.ForeColour;
                        pLblLabel.Tag = pFrmLabel.Style;
                    }

                    if (PanelChanged != null)
                        PanelChanged(this);
                }
            }
        }

        private void sendToBackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PictureBox pPBxPicture = (PictureBox)pObjRightClickedControl;
            pPBxPicture.SendToBack();

            if (PanelChanged != null)
                PanelChanged(this);
        }

        private void bringToFrontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PictureBox pPBxPicture = (PictureBox)pObjRightClickedControl;
            pPBxPicture.BringToFront();

            if (PanelChanged != null)
                PanelChanged(this);
        }

        private void bringToFrontToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Label pLblLabel = (Label)pObjRightClickedControl;
            pLblLabel.BringToFront();

            if (PanelChanged != null)
                PanelChanged(this);
        }

        private void sendToBackToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Label pLblLabel = (Label)pObjRightClickedControl;
            pLblLabel.SendToBack();

            if (PanelChanged != null)
                PanelChanged(this);
        }

        private void ComicPanel_Click(object sender, EventArgs e)
        {
            if (Controls.Count.Equals(0))
            {
                Parent.Focus();
                Parent.Select();
            }
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?",
                "Clear Panel",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Controls.Clear();

                if (PanelChanged != null)
                    PanelChanged(this);
            }
        }

        private void setBackgroundColourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog pCDgColour = new ColorDialog();
            using (pCDgColour)
            {
                pCDgColour.Color = this.BackColor;
                if (pCDgColour.ShowDialog() == DialogResult.OK)
                {
                    this.BackColor = pCDgColour.Color;

                    if (PanelChanged != null)
                        PanelChanged(this);
                }
            }
        }

        #endregion

    }
}
