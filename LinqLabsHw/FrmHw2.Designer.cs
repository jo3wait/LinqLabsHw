
namespace LinqLabsHw
{
    partial class FrmHw2
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbProdYear = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbProdSeason = new System.Windows.Forms.ComboBox();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.btnProdTimeRange = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnProdYear = new System.Windows.Forms.Button();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.btnProdSeason = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnProdAll = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblMaster = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblDetail = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.awDataSet1 = new LinqLabsHw.awDataSet();
            this.productPhotoTableAdapter1 = new LinqLabsHw.awDataSetTableAdapters.ProductPhotoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.awDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label10);
            this.splitContainer1.Panel1.Controls.Add(this.cmbProdYear);
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            this.splitContainer1.Panel1.Controls.Add(this.cmbProdSeason);
            this.splitContainer1.Panel1.Controls.Add(this.dtpEnd);
            this.splitContainer1.Panel1.Controls.Add(this.btnProdTimeRange);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.btnProdYear);
            this.splitContainer1.Panel1.Controls.Add(this.dtpStart);
            this.splitContainer1.Panel1.Controls.Add(this.btnProdSeason);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.btnProdAll);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1104, 652);
            this.splitContainer1.SplitterDistance = 291;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.AutoScroll = true;
            this.splitContainer2.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.AutoScroll = true;
            this.splitContainer2.Panel2.Controls.Add(this.tableLayoutPanel2);
            this.splitContainer2.Size = new System.Drawing.Size(1104, 357);
            this.splitContainer2.SplitterDistance = 663;
            this.splitContainer2.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.ForeColor = System.Drawing.Color.Teal;
            this.label10.Location = new System.Drawing.Point(340, 186);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 17);
            this.label10.TabIndex = 149;
            this.label10.Text = "年:";
            // 
            // cmbProdYear
            // 
            this.cmbProdYear.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cmbProdYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cmbProdYear.FormattingEnabled = true;
            this.cmbProdYear.Location = new System.Drawing.Point(393, 183);
            this.cmbProdYear.Name = "cmbProdYear";
            this.cmbProdYear.Size = new System.Drawing.Size(119, 25);
            this.cmbProdYear.TabIndex = 148;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.ForeColor = System.Drawing.Color.Teal;
            this.label8.Location = new System.Drawing.Point(340, 234);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 17);
            this.label8.TabIndex = 147;
            this.label8.Text = "季:";
            // 
            // cmbProdSeason
            // 
            this.cmbProdSeason.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cmbProdSeason.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cmbProdSeason.FormattingEnabled = true;
            this.cmbProdSeason.Items.AddRange(new object[] {
            "第一季",
            "第二季",
            "第三季",
            "第四季"});
            this.cmbProdSeason.Location = new System.Drawing.Point(393, 231);
            this.cmbProdSeason.Name = "cmbProdSeason";
            this.cmbProdSeason.Size = new System.Drawing.Size(119, 25);
            this.cmbProdSeason.TabIndex = 146;
            // 
            // dtpEnd
            // 
            this.dtpEnd.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtpEnd.Location = new System.Drawing.Point(587, 132);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(164, 25);
            this.dtpEnd.TabIndex = 145;
            // 
            // btnProdTimeRange
            // 
            this.btnProdTimeRange.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnProdTimeRange.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnProdTimeRange.Location = new System.Drawing.Point(91, 128);
            this.btnProdTimeRange.Name = "btnProdTimeRange";
            this.btnProdTimeRange.Size = new System.Drawing.Size(239, 36);
            this.btnProdTimeRange.TabIndex = 137;
            this.btnProdTimeRange.Text = "     區間腳踏車 ";
            this.btnProdTimeRange.UseVisualStyleBackColor = false;
            this.btnProdTimeRange.Click += new System.EventHandler(this.btnProdTimeRange_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(563, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 17);
            this.label7.TabIndex = 144;
            this.label7.Text = "~";
            // 
            // btnProdYear
            // 
            this.btnProdYear.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnProdYear.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnProdYear.Location = new System.Drawing.Point(91, 176);
            this.btnProdYear.Name = "btnProdYear";
            this.btnProdYear.Size = new System.Drawing.Size(239, 36);
            this.btnProdYear.TabIndex = 138;
            this.btnProdYear.Text = "     某年腳踏車 ";
            this.btnProdYear.UseVisualStyleBackColor = false;
            this.btnProdYear.Click += new System.EventHandler(this.btnProdYear_Click);
            // 
            // dtpStart
            // 
            this.dtpStart.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtpStart.Location = new System.Drawing.Point(393, 132);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(164, 25);
            this.dtpStart.TabIndex = 143;
            // 
            // btnProdSeason
            // 
            this.btnProdSeason.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnProdSeason.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnProdSeason.ForeColor = System.Drawing.Color.Black;
            this.btnProdSeason.Location = new System.Drawing.Point(91, 224);
            this.btnProdSeason.Name = "btnProdSeason";
            this.btnProdSeason.Size = new System.Drawing.Size(239, 36);
            this.btnProdSeason.TabIndex = 139;
            this.btnProdSeason.Text = "     某季腳踏車  ? 有幾筆 ?";
            this.btnProdSeason.UseVisualStyleBackColor = false;
            this.btnProdSeason.Click += new System.EventHandler(this.btnProdSeason_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(337, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 142;
            this.label3.Text = "區間:";
            // 
            // btnProdAll
            // 
            this.btnProdAll.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnProdAll.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnProdAll.Location = new System.Drawing.Point(91, 80);
            this.btnProdAll.Name = "btnProdAll";
            this.btnProdAll.Size = new System.Drawing.Size(239, 36);
            this.btnProdAll.TabIndex = 140;
            this.btnProdAll.Text = "     All 腳踏車 ";
            this.btnProdAll.UseVisualStyleBackColor = false;
            this.btnProdAll.Click += new System.EventHandler(this.btnProdAll_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.ForeColor = System.Drawing.Color.Teal;
            this.label6.Location = new System.Drawing.Point(87, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(268, 21);
            this.label6.TabIndex = 141;
            this.label6.Text = "LINQ to AdventureWorks DataSet";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblMaster, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.683474F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.31653F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(663, 357);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblMaster
            // 
            this.lblMaster.AutoSize = true;
            this.lblMaster.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMaster.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblMaster.ForeColor = System.Drawing.Color.White;
            this.lblMaster.Location = new System.Drawing.Point(3, 0);
            this.lblMaster.Name = "lblMaster";
            this.lblMaster.Size = new System.Drawing.Size(657, 31);
            this.lblMaster.TabIndex = 0;
            this.lblMaster.Text = "Master";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.lblDetail, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox1, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.683474F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.31653F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(437, 357);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // lblDetail
            // 
            this.lblDetail.AutoSize = true;
            this.lblDetail.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDetail.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDetail.ForeColor = System.Drawing.Color.White;
            this.lblDetail.Location = new System.Drawing.Point(3, 0);
            this.lblDetail.Name = "lblDetail";
            this.lblDetail.Size = new System.Drawing.Size(431, 31);
            this.lblDetail.TabIndex = 1;
            this.lblDetail.Text = "Detail";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(657, 320);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(431, 320);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // awDataSet1
            // 
            this.awDataSet1.DataSetName = "awDataSet";
            this.awDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productPhotoTableAdapter1
            // 
            this.productPhotoTableAdapter1.ClearBeforeFill = true;
            // 
            // FrmHw2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 652);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FrmHw2";
            this.Text = "FrmHw2";
            this.Load += new System.EventHandler(this.FrmHw2_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.awDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbProdYear;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbProdSeason;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Button btnProdTimeRange;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnProdYear;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Button btnProdSeason;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnProdAll;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblMaster;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblDetail;
        private System.Windows.Forms.PictureBox pictureBox1;
        private awDataSet awDataSet1;
        private awDataSetTableAdapters.ProductPhotoTableAdapter productPhotoTableAdapter1;
    }
}