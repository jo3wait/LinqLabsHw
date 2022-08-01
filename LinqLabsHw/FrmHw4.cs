using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
                    group f by myKeySize(f)
                    into g  
                    select new
                    {
                        KeySize = g.Key,
                        MyCount = g.Count(),
                        MyGroup = g  
                    };

            this.dataGridView1.DataSource = q.ToList();

            //============================
            this.treeView1.Nodes.Clear(); 
            
            foreach (var group in q)
            {
                string s = $"{group.KeySize} ({group.MyCount})";
                TreeNode x = this.treeView1.Nodes.Add(s);

                foreach (var item in group.MyGroup)
                {
                    x.Nodes.Add(item.ToString());
                }
            }

            //=============================
            this.chart1.DataSource = null;
            this.chart1.DataSource = q.ToList();
            this.chart1.Series[0].XValueMember = "KeySize";
            this.chart1.Series[0].YValueMembers = "MyCount";
            this.chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

        }

        private string myKeySize(FileInfo f)
        {
            if (f.Length <= 16)
                return "小(16KB)";
            else if (f.Length <= 1000)
                return "中(16KB-1MB)";
            else
                return "大(1MB-)";
        }

        private void btnFilesByYear_Click(object sender, EventArgs e)
        {
            System.IO.FileInfo[] files = frmHw1.getFiles();
            var q = from f in files
                    group f by f.CreationTime.Year
                    into g
                    select new
                    {
                        CeationYear = g.Key,
                        MyCount = g.Count(),
                        MyGroup = g
                    };

            this.dataGridView1.DataSource = q.ToList();

            //============================
            this.treeView1.Nodes.Clear();
            foreach (var group in q)
            {
                string s = $"{group.CeationYear} ({group.MyCount})";
                TreeNode x = this.treeView1.Nodes.Add(s);

                foreach (var item in group.MyGroup)
                {
                    x.Nodes.Add(item.ToString());
                }
            }
            //=============================
            this.chart1.DataSource = null;
            this.chart1.DataSource = q.ToList();
            this.chart1.Series[0].XValueMember = "CeationYear";
            this.chart1.Series[0].YValueMembers = "MyCount";
            this.chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

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
            this.chart1.DataSource = null;
            
            string s="";
            foreach(int n in nums)
                s+= n.ToString()+", ";
            this.chart1.Titles.Add(s);            
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

        //In-Memory DB
        NorthwindEntities dbContext = new NorthwindEntities();

        private void btnProdByPrice_Click(object sender, EventArgs e)
        {
            var q = from p in this.dbContext.Products.AsEnumerable()
                    group p by myKeyPrice(p)
                    into g
                    select new
                    {
                        KeyPrice = g.Key,
                        MyCount = g.Count(),
                        MyGroup = g
                    };
            this.dataGridView1.DataSource = q.ToList();

            //============================
            this.treeView1.Nodes.Clear();
            foreach (var group in q)
            {
                string s = $"{group.KeyPrice} ({group.MyCount})";
                TreeNode x = this.treeView1.Nodes.Add(s);

                foreach (var item in group.MyGroup)
                {
                    x.Nodes.Add(item.ToString());
                }
            }
            //=============================
            this.chart1.DataSource = null;
            this.chart1.DataSource = q.ToList();
            this.chart1.Series[0].XValueMember = "KeyPrice";
            this.chart1.Series[0].YValueMembers = "MyCount";
            this.chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

        }

        private object myKeyPrice(Product p)
        {
            if (p.UnitPrice <= 30)
                return "低價位($0-$30)";
            else if (p.UnitPrice <= 60)
                return "中價位($30-$60)";
            else
                return "高價位($60-)";
        }

        private void btnOrdersByYear_Click(object sender, EventArgs e)
        {
            var q = from o in this.dbContext.Orders.AsEnumerable()
                    orderby o.OrderDate.Value
                    group o by o.OrderDate.Value.Year
                    into g
                    select new
                    {
                        KeyYear = g.Key,
                        MyCount = g.Count(),
                        MyGroup = g
                    };
            this.dataGridView1.DataSource = q.ToList();

            //============================
            this.treeView1.Nodes.Clear();
            foreach (var group in q)
            {
                string s = $"{group.KeyYear} ({group.MyCount})";
                TreeNode x = this.treeView1.Nodes.Add(s);

                foreach (var item in group.MyGroup)
                {
                    x.Nodes.Add(item.ToString());
                }
            }
            //=============================
            this.chart1.DataSource = null;
            this.chart1.DataSource = q.ToList();
            this.chart1.Series[0].XValueMember = "KeyYear";
            this.chart1.Series[0].YValueMembers = "MyCount";
            this.chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            this.chart1.Series[0].BorderWidth = 3;
            this.chart1.Series[0].Color = Color.Green;
        }

        private void btnOrdersByMon_Click(object sender, EventArgs e)
        {
            var q = from o in this.dbContext.Orders.AsEnumerable()
                     orderby o.OrderDate.Value
                     group o by o.OrderDate.Value.Year into y
                     select new
                     {
                         KeyYear = y.Key,
                         MyCountY = y.Count(),
                         KeyMonth = y.GroupBy(m => m.OrderDate.Value.Month).Select(x => new { KeyMonth = x.Key, MyCountM = x.Count(), MyGroup = x}),

                     };
            
            this.dataGridView1.DataSource = q.ToList();

            //============================
            this.treeView1.Nodes.Clear();
            foreach(var y in q)
            {
                string s1 = $"{y.KeyYear} ({y.MyCountY})";
                TreeNode x1 = this.treeView1.Nodes.Add(s1);

                foreach (var m in y.KeyMonth)
                {
                    string s2 = $"{m.KeyMonth} ({m.MyCountM})";
                    TreeNode x2 = x1.Nodes.Add(s2);
                    
                    foreach (var item in m.MyGroup)
                        x2.Nodes.Add(item.ToString());
                }

            }

        }

        private void btnTotalSales_Click(object sender, EventArgs e)
        {
            var q = this.dbContext.Order_Details.AsEnumerable().Sum(od => Convert.ToDouble(od.UnitPrice) * od.Quantity * (1 - Convert.ToDouble(od.Discount)) );
            
            MessageBox.Show($"Total Sales: {q:c2}");
        }

        private void btnTopSales_Click(object sender, EventArgs e)
        {
            var q = from od in this.dbContext.Order_Details.AsEnumerable()
                    group od by new { od.Order.Employee.EmployeeID, od.Order.Employee.FirstName, od.Order.Employee.LastName}
                    into g
                    orderby g.Sum(od => Convert.ToDouble(od.UnitPrice) * od.Quantity * (1 - Convert.ToDouble(od.Discount))) descending
                    select new { EmployeeID = g.Key.EmployeeID, FirstName = g.Key.FirstName, LastName = g.Key.LastName, TotalSales = $"{g.Sum(od => Convert.ToDouble(od.UnitPrice) * od.Quantity * (1 - Convert.ToDouble(od.Discount))):c2}"};
            
            this.dataGridView1.DataSource = q.Take(5).ToList();
        }

        private void btnTopUnitPrice_Click(object sender, EventArgs e)
        {
            var q = this.dbContext.Products.AsEnumerable().
                OrderByDescending(p => p.UnitPrice).
                Select(p => new 
                { 
                    p.ProductID, 
                    p.ProductName, 
                    UnitPrice = $"{p.UnitPrice:c2}", p.Category.CategoryName 
                });
            this.dataGridView1.DataSource = q.Take(5).ToList();
        }

        private void btnUnitPrice300_Click(object sender, EventArgs e)
        {
            var q = from p in this.dbContext.Products
                    where p.UnitPrice >= 300
                    select p;
            this.dataGridView1.DataSource = q.ToList();
            if (q.ToList().Count == 0)
                MessageBox.Show("NW 產品無單價大於300的產品");
        }

        private void btnSalesByYear_Click(object sender, EventArgs e)
        {
            var q = from od in this.dbContext.Order_Details.AsEnumerable()
                    group od by od.Order.OrderDate.Value.Year into g
                    select new
                    {
                        Year = g.Key,
                        Sales = $"{g.Sum(od => Convert.ToDouble(od.UnitPrice) * od.Quantity * (1 - Convert.ToDouble(od.Discount))):c2}",
                    };
            this.dataGridView1.DataSource = q.ToList();

            //=================
            this.chart1.DataSource = null;
            this.chart1.DataSource = q.ToList();
            this.chart1.Series[0].XValueMember = "Year";
            this.chart1.Series[0].YValueMembers = "Sales";
            this.chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            
            this.chart1.Series[0].BorderWidth = 3;
            this.chart1.Series[0].Color = Color.Red;
        }

        private void btnSaleRate_Click(object sender, EventArgs e)
        {
            var q = from od in this.dbContext.Order_Details.AsEnumerable()
                    group od by od.Order.OrderDate.Value.Year into g
                    select new
                    {
                        year = g.Key,
                        sales =g.Sum(od => Convert.ToDouble(od.UnitPrice) * od.Quantity * (1 - Convert.ToDouble(od.Discount))),
                    };
            //this.dataGridView1.DataSource = q.ToList();

            List<clsGrowthRate> lstGrowthRate = new List<clsGrowthRate>();
            foreach (var n in q) 
            {
               lstGrowthRate.Add(new clsGrowthRate { year = n.year, sales = n.sales, rate="" });
            }

            
            for (int i = 1; i < lstGrowthRate.Count(); i++)
            {
                lstGrowthRate[i].rate = $"{((lstGrowthRate[i].sales - lstGrowthRate[i-1].sales) / lstGrowthRate[i].sales):F2}";
            }
            this.dataGridView1.DataSource = lstGrowthRate;

            //=================
            this.chart1.DataSource = null;
            this.chart1.DataSource = lstGrowthRate;
            
            this.chart1.Series[0].XValueMember = "year";
            this.chart1.Series[0].YValueMembers = "rate";
            this.chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            this.chart1.Series[0].BorderWidth = 3;
            this.chart1.Series[0].Color = Color.Blue;

            //this.chart1.Series.Add("Series2");
            //this.chart1.Series[1].XValueMember = "year";
            //this.chart1.Series[1].YValueMembers = "sales";
            //this.chart1.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            //this.chart1.Series[1].BorderWidth = 3;
            //this.chart1.Series[1].Color = Color.Red;

        }               
        

        public class clsGrowthRate
        {
            public int year { get; set; }
            public double sales { get; set; }
            public string rate { get; set; }
        }
    }
}
