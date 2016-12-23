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
    public partial class frmSizeSelect : Form
    {

        #region Property interface

        public decimal Width
        {
            get { return (nudWidth.Value); }
            set { nudWidth.Value = value; }
        }

        public decimal Height
        {
            get { return (nudHeight.Value); }
            set { nudHeight.Value = value; }
        }

        #endregion

        #region Constructor / Destructor

        public frmSizeSelect()
        {
            InitializeComponent();
        }

        #endregion

    }
}
