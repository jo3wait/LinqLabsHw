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
    public partial class FrmHw1 : Form
    {
        public FrmHw1()
        {
            InitializeComponent();

            this.productsTableAdapter1.Fill(this.nwDataSet1.Products);
            this.ordersTableAdapter1.Fill(this.nwDataSet1.Orders);
            this.order_DetailsTableAdapter1.Fill(this.nwDataSet1.Order_Details);

        }

        internal System.IO.FileInfo[] getFiles()
        {
            lblMaster.Text = "File Info";
            System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(@"c:\windows");

            System.IO.FileInfo[] files = dir.GetFiles();
            return files;            
        }

        private void btnFileInfo_Click(object sender, EventArgs e)
        {
            System.IO.FileInfo[] files = getFiles();
            this.dataGridView1.DataSource = files;            
        }

        private void btnFileInfo_log_Click(object sender, EventArgs e)
        {
            System.IO.FileInfo[] files = getFiles();

            var q = from f in files
                    where f.Extension == ".log"
                    select f;

            this.dataGridView1.DataSource = q.ToList();
        }

        private void btnFileInfoCreated_Click(object sender, EventArgs e)
        {
            if (cmbFileCreatedYear.SelectedItem == null)
                return;

            System.IO.FileInfo[] files = getFiles();

            var q = from f in files
                    where f.CreationTime.Year == int.Parse(cmbFileCreatedYear.Text)
                    orderby f.CreationTime
                    select f;

            this.dataGridView1.DataSource = q.ToList();
        }

        private void btnFileInfoBig_Click(object sender, EventArgs e)
        {
            System.IO.FileInfo[] files = getFiles();

            var q = from f in files
                    where f.Length >= 100000
                    orderby f.Length
                    select f;

            this.dataGridView1.DataSource = q.ToList();
        }


        int btnClick = 0;
        int nextOrder = 0;

        private void btnOrderAll_Click(object sender, EventArgs e)
        {
            btnClick = 1;
            nextOrder = 0;

            lblMaster.Text = "Orders";
            lblDetails.Text = "Orders Details";
            int n = int.Parse(txtOrderRows.Text);
            this.dataGridView1.DataSource = null;
            this.dataGridView2.DataSource = null;

            var q1 = from o in this.nwDataSet1.Orders
                         //DBNull                    
                     select new
                     {
                         o.OrderID,
                         o.CustomerID,
                         o.EmployeeID,
                         o.OrderDate,
                         o.RequiredDate,
                         //o.ShippedDate,
                         o.ShipVia,
                         o.Freight,
                         o.ShipName,
                         o.ShipAddress,
                         o.ShipCity,
                         //o.ShipRegion,
                         //o.ShipPostalCode,
                         o.ShipCountry
                     };
            this.dataGridView1.DataSource = q1.Take(n).ToList();

            //==============================
            var q2 = from d in this.nwDataSet1.Order_Details
                     join o in this.nwDataSet1.Orders on d.OrderID equals o.OrderID
                     //join pet in pets on person equals pet.Owner
                     select new
                     {
                         o.OrderID,
                         o.CustomerID,
                         o.EmployeeID,
                         o.OrderDate,
                         o.RequiredDate,
                         d.ProductID,
                         d.UnitPrice,
                         d.Quantity,
                         d.Discount,
                         //o.ShippedDate,
                         o.ShipVia,
                         o.Freight,
                         o.ShipName,
                         o.ShipAddress,
                         o.ShipCity,
                         //o.ShipRegion,
                         //o.ShipPostalCode,
                         o.ShipCountry,                         
                     };
            this.dataGridView2.DataSource = q2.ToList();
        }

        private void btnOrderYear_Click(object sender, EventArgs e)
        {
            if (cmbOrderYear.SelectedItem == null)
                return;

            btnClick = 2;
            nextOrder = 0;

            lblMaster.Text = "Orders";
            lblDetails.Text = "Orders Details";
            int n = int.Parse(txtOrderRows.Text);
            this.dataGridView1.DataSource = null;
            this.dataGridView2.DataSource = null;

            var q1 = from o in this.nwDataSet1.Orders
                     where o.OrderDate.Year == int.Parse(cmbOrderYear.Text)
                     select new
                     {
                         o.OrderID,
                         o.CustomerID,
                         o.EmployeeID,
                         o.OrderDate,
                         o.RequiredDate,
                         //o.ShippedDate,
                         o.ShipVia,
                         o.Freight,
                         o.ShipName,
                         o.ShipAddress,
                         o.ShipCity,
                         //o.ShipRegion,
                         //o.ShipPostalCode,
                         o.ShipCountry
                     };
            this.dataGridView1.DataSource = q1.Take(n).ToList();

            //=================================
            var q2 = from d in this.nwDataSet1.Order_Details
                     join o in q1 on d.OrderID equals o.OrderID
                     select new
                     {
                         o.OrderID,
                         o.CustomerID,
                         o.EmployeeID,
                         o.OrderDate,
                         o.RequiredDate,
                         d.ProductID,
                         d.UnitPrice,
                         d.Quantity,
                         d.Discount,
                         //o.ShippedDate,
                         o.ShipVia,
                         o.Freight,
                         o.ShipName,
                         o.ShipAddress,
                         o.ShipCity,
                         //o.ShipRegion,
                         //o.ShipPostalCode,
                         o.ShipCountry,
                     };
            this.dataGridView2.DataSource = q2.ToList();
        }

        private void btnOrderPre_Click(object sender, EventArgs e)
        {
            if (btnClick == 0  || nextOrder <= 0)
                return;
            
            lblMaster.Text = "Orders";
            int n = int.Parse(txtOrderRows.Text);
            this.dataGridView1.DataSource = null;            

            if (btnClick == 1)
            {
                nextOrder -= n;

                var q = from o in this.nwDataSet1.Orders
                        select new
                        {
                            o.OrderID,
                            o.CustomerID,
                            o.EmployeeID,
                            o.OrderDate,
                            o.RequiredDate,
                            //o.ShippedDate,
                            o.ShipVia,
                            o.Freight,
                            o.ShipName,
                            o.ShipAddress,
                            o.ShipCity,
                            //o.ShipRegion,
                            //o.ShipPostalCode,
                            o.ShipCountry
                        };
                this.dataGridView1.DataSource = q.Take(n + nextOrder).Skip(nextOrder).ToList();
            }
            if (btnClick == 2)
            {               
                nextOrder -= n;

                var q = from o in this.nwDataSet1.Orders
                        where o.OrderDate.Year == int.Parse(cmbOrderYear.SelectedItem.ToString())
                        select new
                        {
                            o.OrderID,
                            o.CustomerID,
                            o.EmployeeID,
                            o.OrderDate,
                            o.RequiredDate,
                            //o.ShippedDate,
                            o.ShipVia,
                            o.Freight,
                            o.ShipName,
                            o.ShipAddress,
                            o.ShipCity,
                            //o.ShipRegion,
                            //o.ShipPostalCode,
                            o.ShipCountry
                        };
                this.dataGridView1.DataSource = q.Take(n + nextOrder).Skip(nextOrder).ToList();
            }
        }

        private void btnOrderNext_Click(object sender, EventArgs e)
        {  
            if (btnClick == 0)
                return;

            lblMaster.Text = "Orders";
            int n = int.Parse(txtOrderRows.Text);
            this.dataGridView1.DataSource = null;

            if (btnClick == 1)
            {                
                if (this.nwDataSet1.Orders.Count < nextOrder)
                    return;

                var q1 = from o in this.nwDataSet1.Orders
                         select new
                         {
                             o.OrderID,
                             o.CustomerID,
                             o.EmployeeID,
                             o.OrderDate,
                             o.RequiredDate,
                             //o.ShippedDate,
                             o.ShipVia,
                             o.Freight,
                             o.ShipName,
                             o.ShipAddress,
                             o.ShipCity,
                             //o.ShipRegion,
                             //o.ShipPostalCode,
                             o.ShipCountry
                         };                
                nextOrder += n;
                this.dataGridView1.DataSource = q1.Take(n + nextOrder).Skip(nextOrder).ToList();
     
            }
            if (btnClick == 2)
            {                
                var q = from o in this.nwDataSet1.Orders
                        where o.OrderDate.Year == int.Parse(cmbOrderYear.SelectedItem.ToString())
                        select new
                        {
                            o.OrderID,
                            o.CustomerID,
                            o.EmployeeID,
                            o.OrderDate,
                            o.RequiredDate,
                            //o.ShippedDate,
                            o.ShipVia,
                            o.Freight,
                            o.ShipName,
                            o.ShipAddress,
                            o.ShipCity,
                            //o.ShipRegion,
                            //o.ShipPostalCode,
                            o.ShipCountry
                        };
                if (q.Count() < nextOrder)
                    return;

                nextOrder += n;
                this.dataGridView1.DataSource = q.Take(n + nextOrder).Skip(nextOrder).ToList();
            }
        }


        int countP = -1;
        private void btnProdPre_Click(object sender, EventArgs e)
        {
            if (countP <= 0)
                return;
            
            lblMaster.Text = "Products";    
            int n = int.Parse(txtProdRows.Text);

            countP--;
            var q = from p in this.nwDataSet1.Products
                    select p;
            this.dataGridView1.DataSource = q.Take(n + countP * n).Skip(countP * n).ToList();
        }

        private void btnProdNext_Click(object sender, EventArgs e)
        {            
            int n = int.Parse(txtProdRows.Text);

            if (this.nwDataSet1.Products.Count < countP * n)
                return;
            lblMaster.Text = "Products";

            countP++;
            var q = from p in this.nwDataSet1.Products.Take(n + countP * n).Skip(countP * n)
                    select p;
            this.dataGridView1.DataSource = q.ToList();
        }

        private void FrmHw1_Load(object sender, EventArgs e)
        {
            System.IO.FileInfo[] files = getFiles();
            
            cmbFileCreatedYear.Items.Clear();
            var q1 = files.Select(f => f.CreationTime.Year).Distinct();
            
            foreach (int n in q1)
                cmbFileCreatedYear.Items.Add(n);

            //===================================
            cmbOrderYear.Items.Clear();
            var q2 = this.nwDataSet1.Orders.Select(o => o.OrderDate.Year).Distinct();

            foreach (int n in q2)
                cmbOrderYear.Items.Add(n);
        }

       
    }
}
