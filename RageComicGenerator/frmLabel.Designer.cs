﻿namespace RageComicGenerator
{
    partial class frmLabel
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
            this.txtText = new System.Windows.Forms.TextBox();
            this.pgdStyle = new System.Windows.Forms.PropertyGrid();
            this.panel1 = new System.Windows.Forms.Panel();
            this.butOK = new System.Windows.Forms.Button();
            this.butCancel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtText
            // 
            this.txtText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtText.Location = new System.Drawing.Point(0, 0);
            this.txtText.Multiline = true;
            this.txtText.Name = "txtText";
            this.txtText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtText.Size = new System.Drawing.Size(443, 423);
            this.txtText.TabIndex = 0;
            // 
            // pgdStyle
            // 
            this.pgdStyle.Dock = System.Windows.Forms.DockStyle.Right;
            this.pgdStyle.Location = new System.Drawing.Point(443, 0);
            this.pgdStyle.Name = "pgdStyle";
            this.pgdStyle.Size = new System.Drawing.Size(265, 423);
            this.pgdStyle.TabIndex = 1;
            this.pgdStyle.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.pgdStyle_PropertyValueChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.butOK);
            this.panel1.Controls.Add(this.butCancel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 423);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(708, 45);
            this.panel1.TabIndex = 3;
            // 
            // butOK
            // 
            this.butOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.butOK.Location = new System.Drawing.Point(520, 8);
            this.butOK.Name = "butOK";
            this.butOK.Size = new System.Drawing.Size(85, 29);
            this.butOK.TabIndex = 1;
            this.butOK.Text = "OK";
            this.butOK.UseVisualStyleBackColor = true;
            // 
            // butCancel
            // 
            this.butCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.butCancel.Location = new System.Drawing.Point(611, 9);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(85, 29);
            this.butCancel.TabIndex = 0;
            this.butCancel.Text = "Cancel";
            this.butCancel.UseVisualStyleBackColor = true;
            // 
            // frmLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 468);
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.pgdStyle);
            this.Controls.Add(this.panel1);
            this.Name = "frmLabel";
            this.ShowIcon = false;
            this.Text = "Configure Label";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.PropertyGrid pgdStyle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button butOK;
        private System.Windows.Forms.Button butCancel;
    }
}