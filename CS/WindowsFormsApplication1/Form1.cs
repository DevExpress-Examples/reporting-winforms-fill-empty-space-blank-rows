using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            List<Data> list = new List<Data>();
            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                Data data = new Data(string.Format("Name {0}", i), string.Format("Category {0}", random.Next(4)), random.Next(1000));
                list.Add(data);
            }

            XtraReport1 report = new XtraReport1(list, Convert.ToInt32(spinEdit1.EditValue));
            report.ShowPreviewDialog();
        }
    }
}
