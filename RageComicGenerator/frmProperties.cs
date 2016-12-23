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
    public partial class frmProperties : Form
    {

        #region Constructor / Destructor

        public frmProperties()
        {
            InitializeComponent();
        }

        #endregion

        #region Property interface

        public Object Value
        {
            get { return (pgdProperty.SelectedObject); }
            set { pgdProperty.SelectedObject = value; }
        }

        #endregion

    }
}
