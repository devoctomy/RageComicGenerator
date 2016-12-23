using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml.Linq;

namespace RageComicGenerator
{
    public partial class frmLayouts : Form
    {

        #region Public structure definitions

        public struct RowInfoStruct
        {
            public RowStyle Style;
            public int ColumnSpan;
        }

        public struct ColumnInfoStruct
        {
            public ColumnStyle Style;
            public int RowSpan;
        }

        public struct LayoutStruct
        {
            public List<RowInfoStruct> Rows;
            public List<ColumnInfoStruct> Columns;
        }

        #endregion

        #region Private object declarations

        private TableLayoutPanel cTLPSelectedLayout = null;
        private LayoutStruct cLStSelectedLayout;

        #endregion

        #region Property interface

        public LayoutStruct SelectedLayout
        {
            get { return (cLStSelectedLayout); }
        }

        #endregion

        #region Constructor / Destructor

        public frmLayouts()
        {
            InitializeComponent();
            EnumerateLayouts();
        }

        #endregion

        #region Public methods

        public static void ApplyLayoutToTable(LayoutStruct iLayout, TableLayoutPanel iTable, Boolean iPanels, out List<ComicPanel> oPanels)
        {
            oPanels = new List<ComicPanel>();
            iTable.RowStyles.Clear();
            iTable.ColumnStyles.Clear();

            iTable.RowCount = iLayout.Rows.Count;
            foreach (RowInfoStruct curRow in iLayout.Rows)
            {
                iTable.RowStyles.Add(new RowStyle(curRow.Style.SizeType, curRow.Style.Height));
            }

            iTable.ColumnCount = iLayout.Columns.Count;
            foreach (ColumnInfoStruct curCol in iLayout.Columns)
            {
                iTable.ColumnStyles.Add(new ColumnStyle(curCol.Style.SizeType, curCol.Style.Width));
            }

            if (iPanels)
            {
                int pIntCurRow = 0;
                for(pIntCurRow = 0; pIntCurRow < iTable.RowCount; pIntCurRow++)
                {
                    int pIntCurCol = 0;
                    for(pIntCurCol = 0; pIntCurCol < iTable.ColumnCount; pIntCurCol++)
                    {
                        Control pCtlPanel = new ComicPanel();
                        pCtlPanel.Dock = DockStyle.Fill;
                        pCtlPanel.Margin = new Padding(0, 0, 0, 0);
                        iTable.Controls.Add(pCtlPanel);
                        iTable.SetRow(pCtlPanel, pIntCurRow);
                        iTable.SetColumn(pCtlPanel, pIntCurCol);

                        if (iLayout.Columns[pIntCurCol].RowSpan > 0) iTable.SetRowSpan(pCtlPanel, iLayout.Columns[pIntCurCol].RowSpan);
                        if (iLayout.Rows[pIntCurRow].ColumnSpan > 0) iTable.SetColumnSpan(pCtlPanel, iLayout.Rows[pIntCurRow].ColumnSpan);

                        oPanels.Add((ComicPanel)pCtlPanel);

                        pCtlPanel.Show();
                    }
                }
            }
        }

        #endregion

        #region Private methods

        private void EnumerateLayouts()
        {
            String pStrPath = Path.GetDirectoryName(Application.ExecutablePath);
            pStrPath = Path.Combine(pStrPath, @"Configuration\Layouts.xml");

            Stream pStmLayouts = File.OpenRead(pStrPath);
            using (pStmLayouts)
            {
                XDocument pXDtDocument = XDocument.Load(pStmLayouts);
                IEnumerable<XElement> pIEeLayouts = pXDtDocument.Root.Elements("Layout");
                foreach (XElement curLayout in pIEeLayouts)
                {
                    LayoutStruct pLStLayout = new LayoutStruct();

                    pLStLayout.Rows = new List<RowInfoStruct>();
                    IEnumerable<XElement> pIEeRows = curLayout.Element("Rows").Elements("Row");
                    foreach (XElement curRow in pIEeRows)
                    {
                        String pStrHeight = curRow.Attribute("height").Value;

                        RowStyle pRSeRow = new RowStyle();
                        if (pStrHeight.Contains('%'))
                        {
                            pRSeRow.Height = int.Parse(pStrHeight.Replace("%", ""));
                            pRSeRow.SizeType = SizeType.Percent;
                        }
                        else
                        {
                            pRSeRow.Height = int.Parse(pStrHeight);
                            pRSeRow.SizeType = SizeType.Absolute;
                        }

                        int pIntColSpan = 0;
                        XAttribute pXAeColSpan = curRow.Attribute("colspan");
                        if (pXAeColSpan != null) pIntColSpan = int.Parse(pXAeColSpan.Value);

                        RowInfoStruct pRISRow = new RowInfoStruct();
                        pRISRow.Style = pRSeRow;
                        pRISRow.ColumnSpan = pIntColSpan;

                        pLStLayout.Rows.Add(pRISRow);
                    }

                    pLStLayout.Columns = new List<ColumnInfoStruct>();
                    IEnumerable<XElement> pIEeColumns = curLayout.Element("Columns").Elements("Column");
                    foreach (XElement curColumn in pIEeColumns)
                    {
                        String pStrWidth = curColumn.Attribute("width").Value;

                        ColumnStyle pCSeColumn = new ColumnStyle();
                        if (pStrWidth.Contains('%'))
                        {
                            pCSeColumn.Width = int.Parse(pStrWidth.Replace("%", ""));
                            pCSeColumn.SizeType = SizeType.Percent;
                        }
                        else
                        {
                            pCSeColumn.Width = int.Parse(pStrWidth);
                            pCSeColumn.SizeType = SizeType.Absolute;
                        }

                        int pIntRowSpan = 0;
                        XAttribute pXAeRowSpan = curColumn.Attribute("rowspan");
                        if (pXAeRowSpan != null) pIntRowSpan = int.Parse(pXAeRowSpan.Value);

                        ColumnInfoStruct pCISColumn = new ColumnInfoStruct();
                        pCISColumn.Style = pCSeColumn;
                        pCISColumn.RowSpan = pIntRowSpan;

                        pLStLayout.Columns.Add(pCISColumn);
                    }

                    AddLayout(pLStLayout);
                }
            }
        }

        private void AddLayout(LayoutStruct iLayout)
        {
            TableLayoutPanel pTLPLayout = new TableLayoutPanel();
            pTLPLayout.Width = 4 * 40;
            pTLPLayout.Height = 3 * 40;
            pTLPLayout.BackColor = Color.Blue;
            pTLPLayout.ForeColor = Color.Yellow;
            pTLPLayout.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;

            List<ComicPanel> pLisPanels;
            ApplyLayoutToTable(iLayout, pTLPLayout, true, out pLisPanels);

            pTLPLayout.Tag = iLayout;
            pTLPLayout.Click += new EventHandler(pTLPLayout_Click);
            pTLPLayout.GotFocus += new EventHandler(pTLPLayout_GotFocus);
            flpLayouts.Controls.Add(pTLPLayout);
            pTLPLayout.Show();
        }

        #endregion

        #region Object events

        void pTLPLayout_GotFocus(object sender, EventArgs e)
        {
            pTLPLayout_Click(sender, e);
        }

        void pTLPLayout_Click(object sender, EventArgs e)
        {
            TableLayoutPanel pTLPLayout = (TableLayoutPanel)sender;
            if (cTLPSelectedLayout != null)
            {
                if (cTLPSelectedLayout != pTLPLayout)
                    cTLPSelectedLayout.BackColor = Color.Blue;
            }

            cLStSelectedLayout = (LayoutStruct)pTLPLayout.Tag;
            cTLPSelectedLayout = pTLPLayout;
            cTLPSelectedLayout.BackColor = Color.Red;

            butOK.Enabled = true;
        }

        #endregion

    }
}
