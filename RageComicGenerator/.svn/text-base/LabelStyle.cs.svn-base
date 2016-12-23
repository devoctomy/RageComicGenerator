using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace RageComicGenerator
{
    public class LabelStyle : ICloneable
    {

        #region Private object declarations

        private Font cFonFont = new Font("Courier New", 18);
        private Color cColForeColour = Color.Black;

        #endregion

        #region Property interface

        public Font Font
        {
            get { return (cFonFont); }
            set { cFonFont = value; }
        }

        public Color ForeColour
        {
            get { return (cColForeColour); }
            set { cColForeColour = value; }
        }

        #endregion

        #region Public methods

        public object Clone()
        {
            return(this.MemberwiseClone());
        }

        #endregion

    }
}
