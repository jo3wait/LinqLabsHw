
namespace LinqLabsHw
{
    partial class FrmHw4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnSaleRate = new System.Windows.Forms.Button();
            this.btnSalesByYear = new System.Windows.Forms.Button();
            this.btnUnitPrice30 = new System.Windows.Forms.Button();
            this.btnTopUnitPrice = new System.Windows.Forms.Button();
            this.btnTotalSales = new System.Windows.Forms.Button();
            this.btnTopSales = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOrdersByMon = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnIntGroup = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFilesByYear = new System.Windows.Forms.Button();
            this.btnProdByPrice = new System.Windows.Forms.Button();
            this.btnFilesBySize = new System.Windows.Forms.Button();
            this.btnOrdersByYear = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnSaleRate);
            this.splitContainer1.Panel1.Controls.Add(this.btnSalesByYear);
            this.splitContainer1.Panel1.Controls.Add(this.btnUnitPrice30);
            this.splitContainer1.Panel1.Controls.Add(this.btnTopUnitPrice);
            this.splitContainer1.Panel1.Controls.Add(this.btnTotalSales);
            this.splitContainer1.Panel1.Controls.Add(this.btnTopSales);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.btnOrdersByMon);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.btnIntGroup);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.btnFilesByYear);
            this.splitContainer1.Panel1.Controls.Add(this.btnProdByPrice);
            this.splitContainer1.Panel1.Controls.Add(this.btnFilesBySize);
            this.splitContainer1.Panel1.Controls.Add(this.btnOrdersByYear);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1810, 1011);
            this.splitContainer1.SplitterDistance = 469;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnSaleRate
            // 
            this.btnSaleRate.ForeColor = System.Drawing.Color.Black;
            this.btnSaleRate.Location = new System.Drawing.Point(32, 922);
            this.btnSaleRate.Margin = new System.Windows.Forms.Padding(6);
            this.btnSaleRate.Name = "btnSaleRate";
            this.btnSaleRate.Size = new System.Drawing.Size(250, 45);
            this.btnSaleRate.TabIndex = 148;
            this.btnSaleRate.Text = "年 銷售成長率";
            this.btnSaleRate.UseVisualStyleBackColor = false;
            // 
            // btnSalesByYear
            // 
            this.btnSalesByYear.ForeColor = System.Drawing.Color.Black;
            this.btnSalesByYear.Location = new System.Drawing.Point(32, 866);
            this.btnSalesByYear.Margin = new System.Windows.Forms.Padding(6);
            this.btnSalesByYear.Name = "btnSalesByYear";
            this.btnSalesByYear.Size = new System.Drawing.Size(250, 45);
            this.btnSalesByYear.TabIndex = 149;
            this.btnSalesByYear.Text = "每年 銷售分析 &&　plot";
            this.btnSalesByYear.UseVisualStyleBackColor = false;
            // 
            // btnUnitPrice30
            // 
            this.btnUnitPrice30.BackColor = System.Drawing.Color.LightGreen;
            this.btnUnitPrice30.Location = new System.Drawing.Point(32, 794);
            this.btnUnitPrice30.Margin = new System.Windows.Forms.Padding(8);
            this.btnUnitPrice30.Name = "btnUnitPrice30";
            this.btnUnitPrice30.Size = new System.Drawing.Size(408, 63);
            this.btnUnitPrice30.TabIndex = 147;
            this.btnUnitPrice30.Text = "     NW 產品有任何一筆單價大於300 ?";
            this.btnUnitPrice30.UseVisualStyleBackColor = false;
            // 
            // btnTopUnitPrice
            // 
            this.btnTopUnitPrice.BackColor = System.Drawing.Color.LightGreen;
            this.btnTopUnitPrice.Location = new System.Drawing.Point(32, 716);
            this.btnTopUnitPrice.Margin = new System.Windows.Forms.Padding(9);
            this.btnTopUnitPrice.Name = "btnTopUnitPrice";
            this.btnTopUnitPrice.Size = new System.Drawing.Size(410, 62);
            this.btnTopUnitPrice.TabIndex = 144;
            this.btnTopUnitPrice.Text = "     NW 產品最高單價前 5 筆 (包括類別名稱)";
            this.btnTopUnitPrice.UseVisualStyleBackColor = false;
            // 
            // btnTotalSales
            // 
            this.btnTotalSales.BackColor = System.Drawing.Color.LightGreen;
            this.btnTotalSales.Location = new System.Drawing.Point(30, 556);
            this.btnTotalSales.Margin = new System.Windows.Forms.Padding(8);
            this.btnTotalSales.Name = "btnTotalSales";
            this.btnTotalSales.Size = new System.Drawing.Size(410, 66);
            this.btnTotalSales.TabIndex = 146;
            this.btnTotalSales.Text = "總銷售金額";
            this.btnTotalSales.UseVisualStyleBackColor = false;
            // 
            // btnTopSales
            // 
            this.btnTopSales.BackColor = System.Drawing.Color.LightGreen;
            this.btnTopSales.Location = new System.Drawing.Point(30, 638);
            this.btnTopSales.Margin = new System.Windows.Forms.Padding(8);
            this.btnTopSales.Name = "btnTopSales";
            this.btnTopSales.Size = new System.Drawing.Size(410, 62);
            this.btnTopSales.TabIndex = 145;
            this.btnTopSales.Text = "銷售最好的top 5業務員";
            this.btnTopSales.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 296);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 18);
            this.label3.TabIndex = 143;
            this.label3.Text = "LINQ to Northwind Entity";
            // 
            // btnOrdersByMon
            // 
            this.btnOrdersByMon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnOrdersByMon.Location = new System.Drawing.Point(38, 446);
            this.btnOrdersByMon.Margin = new System.Windows.Forms.Padding(9);
            this.btnOrdersByMon.Name = "btnOrdersByMon";
            this.btnOrdersByMon.Size = new System.Drawing.Size(402, 57);
            this.btnOrdersByMon.TabIndex = 142;
            this.btnOrdersByMon.Text = " Orders -  Group by 年 / 月";
            this.btnOrdersByMon.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 27);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 18);
            this.label4.TabIndex = 140;
            this.label4.Text = "LINQ - GroupBy";
            // 
            // btnIntGroup
            // 
            this.btnIntGroup.BackColor = System.Drawing.Color.Blue;
            this.btnIntGroup.ForeColor = System.Drawing.Color.White;
            this.btnIntGroup.Location = new System.Drawing.Point(38, 54);
            this.btnIntGroup.Margin = new System.Windows.Forms.Padding(9);
            this.btnIntGroup.Name = "btnIntGroup";
            this.btnIntGroup.Size = new System.Drawing.Size(402, 57);
            this.btnIntGroup.TabIndex = 135;
            this.btnIntGroup.Text = "int[]  分三群 - No LINQ";
            this.btnIntGroup.UseVisualStyleBackColor = false;
            this.btnIntGroup.Click += new System.EventHandler(this.btnIntGroup_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 135);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 18);
            this.label1.TabIndex = 141;
            this.label1.Text = "LINQ to FileInfo[]";
            // 
            // btnFilesByYear
            // 
            this.btnFilesByYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnFilesByYear.ForeColor = System.Drawing.Color.Black;
            this.btnFilesByYear.Location = new System.Drawing.Point(40, 224);
            this.btnFilesByYear.Margin = new System.Windows.Forms.Padding(9);
            this.btnFilesByYear.Name = "btnFilesByYear";
            this.btnFilesByYear.Size = new System.Drawing.Size(400, 57);
            this.btnFilesByYear.TabIndex = 136;
            this.btnFilesByYear.Text = "  依 年 分組檔案 (大=>小)";
            this.btnFilesByYear.UseVisualStyleBackColor = false;
            this.btnFilesByYear.Click += new System.EventHandler(this.btnFilesByYear_Click);
            // 
            // btnProdByPrice
            // 
            this.btnProdByPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnProdByPrice.ForeColor = System.Drawing.Color.Black;
            this.btnProdByPrice.Location = new System.Drawing.Point(38, 322);
            this.btnProdByPrice.Margin = new System.Windows.Forms.Padding(9);
            this.btnProdByPrice.Name = "btnProdByPrice";
            this.btnProdByPrice.Size = new System.Drawing.Size(402, 57);
            this.btnProdByPrice.TabIndex = 137;
            this.btnProdByPrice.Text = "NW Products 低中高 價產品 ";
            this.btnProdByPrice.UseVisualStyleBackColor = false;
            // 
            // btnFilesBySize
            // 
            this.btnFilesBySize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnFilesBySize.ForeColor = System.Drawing.Color.Black;
            this.btnFilesBySize.Location = new System.Drawing.Point(40, 162);
            this.btnFilesBySize.Margin = new System.Windows.Forms.Padding(9);
            this.btnFilesBySize.Name = "btnFilesBySize";
            this.btnFilesBySize.Size = new System.Drawing.Size(400, 57);
            this.btnFilesBySize.TabIndex = 138;
            this.btnFilesBySize.Text = "依 檔案大小 分組檔案 (大=>小)";
            this.btnFilesBySize.UseVisualStyleBackColor = false;
            this.btnFilesBySize.Click += new System.EventHandler(this.btnFilesBySize_Click);
            // 
            // btnOrdersByYear
            // 
            this.btnOrdersByYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnOrdersByYear.Location = new System.Drawing.Point(38, 384);
            this.btnOrdersByYear.Margin = new System.Windows.Forms.Padding(9);
            this.btnOrdersByYear.Name = "btnOrdersByYear";
            this.btnOrdersByYear.Size = new System.Drawing.Size(402, 57);
            this.btnOrdersByYear.TabIndex = 139;
            this.btnOrdersByYear.Text = " Orders -  Group by 年";
            this.btnOrdersByYear.UseVisualStyleBackColor = false;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer4);
            this.splitContainer2.Size = new System.Drawing.Size(1335, 1011);
            this.splitContainer2.SplitterDistance = 401;
            this.splitContainer2.SplitterWidth = 6;
            this.splitContainer2.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.tableLayoutPanel2);
            this.splitContainer3.Size = new System.Drawing.Size(1335, 401);
            this.splitContainer3.SplitterDistance = 513;
            this.splitContainer3.SplitterWidth = 6;
            this.splitContainer3.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.74298F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.25702F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(513, 401);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(4, 55);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(505, 342);
            this.dataGridView1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.dataGridView2, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.74298F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.25702F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(816, 401);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(4, 55);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(808, 342);
            this.dataGridView2.TabIndex = 0;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.treeView1);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.chart1);
            this.splitContainer4.Size = new System.Drawing.Size(1335, 604);
            this.splitContainer4.SplitterDistance = 188;
            this.splitContainer4.SplitterWidth = 6;
            this.splitContainer4.TabIndex = 0;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Margin = new System.Windows.Forms.Padding(4);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(1335, 188);
            this.treeView1.TabIndex = 0;
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(84, 37);
            this.chart1.Margin = new System.Windows.Forms.Padding(4);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(743, 329);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // FrmHw4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1810, 1011);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmHw4";
            this.Text = "FrmHw4";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnSaleRate;
        private System.Windows.Forms.Button btnSalesByYear;
        private System.Windows.Forms.Button btnUnitPrice30;
        private System.Windows.Forms.Button btnTopUnitPrice;
        private System.Windows.Forms.Button btnTotalSales;
        private System.Windows.Forms.Button btnTopSales;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOrdersByMon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnIntGroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFilesByYear;
        private System.Windows.Forms.Button btnProdByPrice;
        private System.Windows.Forms.Button btnFilesBySize;
        private System.Windows.Forms.Button btnOrdersByYear;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}