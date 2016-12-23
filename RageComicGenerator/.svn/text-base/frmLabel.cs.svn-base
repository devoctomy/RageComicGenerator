using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RageComicGenerator
{
    public partial class frmLabel : Form
    {

        #region Private object declarations

        private LabelStyle cLSeStyle = new LabelStyle();

        #endregion

        #region Constructor / Destructor

        public frmLabel()
        {
            InitializeComponent();
            pgdStyle.SelectedObject = cLSeStyle;
            ReflectStyle();
        }

        #endregion

        #region Property interface

        public String LabelText
        {
            get { return (txtText.Text); }
            set { txtText.Text = value; }
        }

        public LabelStyle Style
        {
            get { return (cLSeStyle); }
            set
            {
                cLSeStyle = value;
                pgdStyle.SelectedObject = cLSeStyle;
                ReflectStyle();
            }
        }

        #endregion

        #region Private methods

        private void ReflectStyle()
        {
            txtText.Font = Style.Font;
            txtText.ForeColor = Style.ForeColour;
        }

        #endregion

        #region Object events

        private void pgdStyle_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            ReflectStyle();
        }

        #endregion

    }
}
