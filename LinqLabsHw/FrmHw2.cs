using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LinqLabsHw
{
    public partial class FrmHw2 : Form
    {
        public FrmHw2()
        {
            InitializeComponent();

            this.productPhotoTableAdapter1.Fill(this.awDataSet1.ProductPhoto);
        }

        int _position = -1;

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            _position = e.RowIndex;

            if (_position < 0)
                return;

            var q = awDataSet1.ProductPhoto.Select(p => p.LargePhoto);

            this.pictureBox1.Image = Image.FromStream(new MemoryStream(q.ToList()[_position]));
            //using System.IO;
            //byte[] img = File.ReadAllBytes(openFileDialog1.FileName);
            //MemoryStream ms = new MemoryStream(img);
            //pictureBox1.Image = Image.FromStream(ms);
        }

        private void btnProdAll_Click(object sender, EventArgs e)
        {
            var q1 = awDataSet1.ProductPhoto.Select(p => p);                     
            this.dataGridView1.DataSource = q1.ToList();
        }

        private void btnProdTimeRange_Click(object sender, EventArgs e)
        {
            DateTime timeStart = dtpStart.Value;
            DateTime timeEnd = dtpEnd.Value;

            var q1 = awDataSet1.ProductPhoto
                .Where(p => p.ModifiedDate >= timeStart && p.ModifiedDate <= timeEnd)
                .OrderBy(p => p.ModifiedDate);

            this.dataGridView1.DataSource = q1.ToList();
        }

        private void FrmHw2_Load(object sender, EventArgs e)
        {
            cmbProdYear.Items.Clear();
            var q1 = this.awDataSet1.ProductPhoto.OrderBy(p => p.ModifiedDate).Select(p => p.ModifiedDate.Year).Distinct();

            foreach (int n in q1)
                cmbProdYear.Items.Add(n);

            //=========================================
            cmbProdSeason.Items.Clear();
            string[] seasons = { "1st Spring", "2nd Summer", "3rd Autumn", "4th Winter" };
            foreach (string s in seasons) 
                cmbProdSeason.Items.Add(s);
        }

        private void btnProdYear_Click(object sender, EventArgs e)
        {
            if (cmbProdYear.SelectedItem == null)
                return; 
            
            var q1 = awDataSet1.ProductPhoto
                .Where(p => p.ModifiedDate.Year == int.Parse(cmbProdYear.Text))
                .OrderBy(p => p.ModifiedDate);

            this.dataGridView1.DataSource = q1.ToList();
        }

        private void btnProdSeason_Click(object sender, EventArgs e)
        {
            if (cmbProdYear.SelectedItem == null || cmbProdSeason.SelectedItem == null)
                return;

            int monthStart = 0;  //monthEnd = monthStart + 2

            if (cmbProdSeason.Text.Contains("1"))
                monthStart = 1;

            else if (cmbProdSeason.Text.Contains("2"))
                monthStart = 4;

            else if (cmbProdSeason.Text.Contains("3"))
                monthStart = 7;

            else if (cmbProdSeason.Text.Contains("4"))
                monthStart = 10;

            var q1 = awDataSet1.ProductPhoto
                            .Where(p => p.ModifiedDate.Year == int.Parse(cmbProdYear.Text)
                            && p.ModifiedDate.Month >= monthStart
                            && p.ModifiedDate.Month <= monthStart + 2)
                            .OrderBy(p => p.ModifiedDate);

            this.dataGridView1.DataSource = q1.ToList();
        }
    }
}
