using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinqLabsHw
{
    public partial class FrmHw4 : Form
    {
        public FrmHw4()
        {
            InitializeComponent();
        }

        FrmHw1 frmHw1 = new FrmHw1();
        private void btnFilesBySize_Click(object sender, EventArgs e)
        {
            System.IO.FileInfo[] files = frmHw1.getFiles();
            var q = from f in files
                    group f by f.Extension into g
                    select g;

            this.dataGridView1.DataSource = q.ToList();
        }

        private void btnFilesByYear_Click(object sender, EventArgs e)
        {
            System.IO.FileInfo[] files = frmHw1.getFiles();
        }

        private void btnIntGroup_Click(object sender, EventArgs e)
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            List<int> numsS = new List<int>();
            List<int> numsM = new List<int>();
            List<int> numsL = new List<int>();


            foreach (int n in nums)
            {
                if (n <= 5)
                    numsS.Add(n);
                else if (n <= 10)
                    numsM.Add(n);
                else
                    numsL.Add(n);
            }

            List<clsNums> lstNums = new List<clsNums>()
            {
                new clsNums { numsGroup="Small", count=numsS.Count()},
                new clsNums { numsGroup="Medium", count=numsM.Count()},
                new clsNums { numsGroup="Large", count=numsL.Count()},
            };

            //chart
            this.chart1.DataSource = lstNums;
            this.chart1.Series[0].XValueMember = "numsGroup";
            this.chart1.Series[0].YValueMembers = "count";
            this.chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

        }
        

        public class clsNums
        {
            public string numsGroup { get; set; }
            public int count { get; set; }
        }
    }
}
