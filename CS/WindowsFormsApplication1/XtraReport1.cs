using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;

namespace WindowsFormsApplication1
{
    public partial class XtraReport1 : DevExpress.XtraReports.UI.XtraReport
    {
        List<Data> source;

        public XtraReport1(List<Data> source, int detailPrintCount)
        {
            InitializeComponent();
            this.source = source;
            this.ReportPrintOptions.DetailCountOnEmptyDataSource = detailPrintCount;
        }

        int printCount = -1;

        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            printCount++;
            Data data = null;

            if (printCount < source.Count) {
                data = source[printCount];
            }

            xrTableCell1.Text = data == null ? string.Empty : data.Name;
            xrTableCell2.Text = data == null ? string.Empty : data.Category;
            xrTableCell3.Text = data == null ? string.Empty : string.Format("{0:c2}", data.Price);
        }

    }
}
