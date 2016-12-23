namespace RageComicGenerator
{
    partial class frmComicEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mspComicEditor = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.closeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.comicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.selectSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectLayoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tclComicEditor = new System.Windows.Forms.TabControl();
            this.tpeComicEditorEdit = new System.Windows.Forms.TabPage();
            this.tpeComicEditorPreview = new System.Windows.Forms.TabPage();
            this.flpThumbs = new System.Windows.Forms.FlowLayoutPanel();
            this.cmsComicPage = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deletePageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panTip = new System.Windows.Forms.Panel();
            this.lblTip = new System.Windows.Forms.Label();
            this.picCloseTip = new System.Windows.Forms.PictureBox();
            this.picInfoTip = new System.Windows.Forms.PictureBox();
            this.picPreview = new System.Windows.Forms.PictureBox();
            this.mspComicEditor.SuspendLayout();
            this.tclComicEditor.SuspendLayout();
            this.tpeComicEditorEdit.SuspendLayout();
            this.tpeComicEditorPreview.SuspendLayout();
            this.cmsComicPage.SuspendLayout();
            this.panTip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCloseTip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInfoTip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // mspComicEditor
            // 
            this.mspComicEditor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.comicToolStripMenuItem});
            this.mspComicEditor.Location = new System.Drawing.Point(176, 0);
            this.mspComicEditor.Name = "mspComicEditor";
            this.mspComicEditor.Size = new System.Drawing.Size(789, 24);
            this.mspComicEditor.TabIndex = 0;
            this.mspComicEditor.Visible = false;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToolStripMenuItem1,
            this.toolStripMenuItem3,
            this.closeToolStripMenuItem1});
            this.fileToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exportToolStripMenuItem1
            // 
            this.exportToolStripMenuItem1.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.exportToolStripMenuItem1.MergeIndex = 1;
            this.exportToolStripMenuItem1.Name = "exportToolStripMenuItem1";
            this.exportToolStripMenuItem1.Size = new System.Drawing.Size(116, 22);
            this.exportToolStripMenuItem1.Text = "Export...";
            this.exportToolStripMenuItem1.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.toolStripMenuItem3.MergeIndex = 2;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(113, 6);
            // 
            // closeToolStripMenuItem1
            // 
            this.closeToolStripMenuItem1.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.closeToolStripMenuItem1.MergeIndex = 3;
            this.closeToolStripMenuItem1.Name = "closeToolStripMenuItem1";
            this.closeToolStripMenuItem1.Size = new System.Drawing.Size(116, 22);
            this.closeToolStripMenuItem1.Text = "Close";
            this.closeToolStripMenuItem1.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // comicToolStripMenuItem
            // 
            this.comicToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewPageToolStripMenuItem,
            this.toolStripMenuItem1,
            this.selectSizeToolStripMenuItem,
            this.selectLayoutToolStripMenuItem});
            this.comicToolStripMenuItem.MergeIndex = 20;
            this.comicToolStripMenuItem.Name = "comicToolStripMenuItem";
            this.comicToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.comicToolStripMenuItem.Text = "Comic";
            // 
            // addNewPageToolStripMenuItem
            // 
            this.addNewPageToolStripMenuItem.Name = "addNewPageToolStripMenuItem";
            this.addNewPageToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.addNewPageToolStripMenuItem.Text = "Add New Page";
            this.addNewPageToolStripMenuItem.Click += new System.EventHandler(this.addNewPageToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(150, 6);
            // 
            // selectSizeToolStripMenuItem
            // 
            this.selectSizeToolStripMenuItem.Name = "selectSizeToolStripMenuItem";
            this.selectSizeToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.selectSizeToolStripMenuItem.Text = "Select Size...";
            this.selectSizeToolStripMenuItem.Click += new System.EventHandler(this.selectSizeToolStripMenuItem_Click);
            // 
            // selectLayoutToolStripMenuItem
            // 
            this.selectLayoutToolStripMenuItem.Name = "selectLayoutToolStripMenuItem";
            this.selectLayoutToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.selectLayoutToolStripMenuItem.Text = "Select Layout...";
            this.selectLayoutToolStripMenuItem.Click += new System.EventHandler(this.selectLayoutToolStripMenuItem_Click);
            // 
            // tclComicEditor
            // 
            this.tclComicEditor.Controls.Add(this.tpeComicEditorEdit);
            this.tclComicEditor.Controls.Add(this.tpeComicEditorPreview);
            this.tclComicEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tclComicEditor.Location = new System.Drawing.Point(176, 0);
            this.tclComicEditor.Name = "tclComicEditor";
            this.tclComicEditor.SelectedIndex = 0;
            this.tclComicEditor.Size = new System.Drawing.Size(515, 446);
            this.tclComicEditor.TabIndex = 2;
            this.tclComicEditor.SelectedIndexChanged += new System.EventHandler(this.tclComicEditor_SelectedIndexChanged);
            // 
            // tpeComicEditorEdit
            // 
            this.tpeComicEditorEdit.AutoScroll = true;
            this.tpeComicEditorEdit.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.tpeComicEditorEdit.Controls.Add(this.panTip);
            this.tpeComicEditorEdit.Location = new System.Drawing.Point(4, 22);
            this.tpeComicEditorEdit.Name = "tpeComicEditorEdit";
            this.tpeComicEditorEdit.Padding = new System.Windows.Forms.Padding(3);
            this.tpeComicEditorEdit.Size = new System.Drawing.Size(507, 420);
            this.tpeComicEditorEdit.TabIndex = 0;
            this.tpeComicEditorEdit.Text = "Edit";
            this.tpeComicEditorEdit.Resize += new System.EventHandler(this.tpeComicEditorEdit_Resize);
            // 
            // tpeComicEditorPreview
            // 
            this.tpeComicEditorPreview.AutoScroll = true;
            this.tpeComicEditorPreview.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.tpeComicEditorPreview.Controls.Add(this.picPreview);
            this.tpeComicEditorPreview.Location = new System.Drawing.Point(4, 22);
            this.tpeComicEditorPreview.Name = "tpeComicEditorPreview";
            this.tpeComicEditorPreview.Padding = new System.Windows.Forms.Padding(3);
            this.tpeComicEditorPreview.Size = new System.Drawing.Size(500, 345);
            this.tpeComicEditorPreview.TabIndex = 1;
            this.tpeComicEditorPreview.Text = "Preview";
            this.tpeComicEditorPreview.Resize += new System.EventHandler(this.tpeComicEditorPreview_Resize);
            // 
            // flpThumbs
            // 
            this.flpThumbs.AutoScroll = true;
            this.flpThumbs.Dock = System.Windows.Forms.DockStyle.Left;
            this.flpThumbs.Location = new System.Drawing.Point(0, 0);
            this.flpThumbs.Name = "flpThumbs";
            this.flpThumbs.Size = new System.Drawing.Size(176, 446);
            this.flpThumbs.TabIndex = 4;
            // 
            // cmsComicPage
            // 
            this.cmsComicPage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deletePageToolStripMenuItem});
            this.cmsComicPage.Name = "cmsComicPage";
            this.cmsComicPage.Size = new System.Drawing.Size(137, 26);
            // 
            // deletePageToolStripMenuItem
            // 
            this.deletePageToolStripMenuItem.Name = "deletePageToolStripMenuItem";
            this.deletePageToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.deletePageToolStripMenuItem.Text = "Delete Page";
            this.deletePageToolStripMenuItem.Click += new System.EventHandler(this.deletePageToolStripMenuItem_Click);
            // 
            // panTip
            // 
            this.panTip.BackColor = System.Drawing.SystemColors.Info;
            this.panTip.Controls.Add(this.picCloseTip);
            this.panTip.Controls.Add(this.lblTip);
            this.panTip.Controls.Add(this.picInfoTip);
            this.panTip.Dock = System.Windows.Forms.DockStyle.Top;
            this.panTip.Location = new System.Drawing.Point(3, 3);
            this.panTip.Name = "panTip";
            this.panTip.Size = new System.Drawing.Size(501, 23);
            this.panTip.TabIndex = 0;
            this.panTip.Visible = false;
            // 
            // lblTip
            // 
            this.lblTip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTip.AutoEllipsis = true;
            this.lblTip.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblTip.Location = new System.Drawing.Point(26, 3);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(448, 16);
            this.lblTip.TabIndex = 1;
            this.lblTip.Text = "...";
            this.lblTip.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picCloseTip
            // 
            this.picCloseTip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picCloseTip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCloseTip.Image = global::RageComicGenerator.Properties.Resources.Symbol_Delete_2_enabled;
            this.picCloseTip.Location = new System.Drawing.Point(480, 3);
            this.picCloseTip.Name = "picCloseTip";
            this.picCloseTip.Size = new System.Drawing.Size(16, 16);
            this.picCloseTip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picCloseTip.TabIndex = 2;
            this.picCloseTip.TabStop = false;
            this.picCloseTip.Click += new System.EventHandler(this.picCloseTip_Click);
            // 
            // picInfoTip
            // 
            this.picInfoTip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picInfoTip.Image = global::RageComicGenerator.Properties.Resources.Symbol_Information_2;
            this.picInfoTip.Location = new System.Drawing.Point(3, 3);
            this.picInfoTip.Name = "picInfoTip";
            this.picInfoTip.Size = new System.Drawing.Size(16, 16);
            this.picInfoTip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picInfoTip.TabIndex = 0;
            this.picInfoTip.TabStop = false;
            this.picInfoTip.Click += new System.EventHandler(this.picInfoTip_Click);
            // 
            // picPreview
            // 
            this.picPreview.BackColor = System.Drawing.Color.White;
            this.picPreview.Location = new System.Drawing.Point(64, 46);
            this.picPreview.Name = "picPreview";
            this.picPreview.Size = new System.Drawing.Size(173, 163);
            this.picPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picPreview.TabIndex = 0;
            this.picPreview.TabStop = false;
            // 
            // frmComicEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 446);
            this.Controls.Add(this.tclComicEditor);
            this.Controls.Add(this.mspComicEditor);
            this.Controls.Add(this.flpThumbs);
            this.MainMenuStrip = this.mspComicEditor;
            this.Name = "frmComicEditor";
            this.Text = "New Comic";
            this.mspComicEditor.ResumeLayout(false);
            this.mspComicEditor.PerformLayout();
            this.tclComicEditor.ResumeLayout(false);
            this.tpeComicEditorEdit.ResumeLayout(false);
            this.tpeComicEditorPreview.ResumeLayout(false);
            this.tpeComicEditorPreview.PerformLayout();
            this.cmsComicPage.ResumeLayout(false);
            this.panTip.ResumeLayout(false);
            this.panTip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCloseTip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInfoTip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mspComicEditor;
        private System.Windows.Forms.ToolStripMenuItem comicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectLayoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectSizeToolStripMenuItem;
        private System.Windows.Forms.TabControl tclComicEditor;
        private System.Windows.Forms.TabPage tpeComicEditorEdit;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem1;
        private System.Windows.Forms.FlowLayoutPanel flpThumbs;
        private System.Windows.Forms.ToolStripMenuItem addNewPageToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.TabPage tpeComicEditorPreview;
        private System.Windows.Forms.PictureBox picPreview;
        private System.Windows.Forms.ContextMenuStrip cmsComicPage;
        private System.Windows.Forms.ToolStripMenuItem deletePageToolStripMenuItem;
        private System.Windows.Forms.Panel panTip;
        private System.Windows.Forms.PictureBox picInfoTip;
        private System.Windows.Forms.PictureBox picCloseTip;
        private System.Windows.Forms.Label lblTip;
    }
}