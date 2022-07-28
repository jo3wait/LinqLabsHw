
namespace LinqLabsHw
{
    partial class FrmHw1
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
            this.components = new System.ComponentModel.Container();
            this.btnScoreStu = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnProdNext = new System.Windows.Forms.Button();
            this.btnProdPre = new System.Windows.Forms.Button();
            this.txtProdRows = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnFileInfo = new System.Windows.Forms.Button();
            this.btnScoreAll = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblDetails = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnOrderAll = new System.Windows.Forms.Button();
            this.btnFileInfo_log = new System.Windows.Forms.Button();
            this.btnOrderYear = new System.Windows.Forms.Button();
            this.btnFileInfoCreated = new System.Windows.Forms.Button();
            this.btnOrderNext = new System.Windows.Forms.Button();
            this.cmbOrderYear = new System.Windows.Forms.ComboBox();
            this.btnOrderPre = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblMaster = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnFileInfoBig = new System.Windows.Forms.Button();
            this.txtOrderRows = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.cmbFileCreatedYear = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nwDataSet1 = new LinqLabsHw.nwDataSet();
            this.productsTableAdapter1 = new LinqLabsHw.nwDataSetTableAdapters.ProductsTableAdapter();
            this.ordersTableAdapter1 = new LinqLabsHw.nwDataSetTableAdapters.OrdersTableAdapter();
            this.order_DetailsTableAdapter1 = new LinqLabsHw.nwDataSetTableAdapters.Order_DetailsTableAdapter();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nwDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnScoreStu
            // 
            this.btnScoreStu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnScoreStu.Location = new System.Drawing.Point(79, 341);
            this.btnScoreStu.Margin = new System.Windows.Forms.Padding(6);
            this.btnScoreStu.Name = "btnScoreStu";
            this.btnScoreStu.Size = new System.Drawing.Size(309, 50);
            this.btnScoreStu.TabIndex = 154;
            this.btnScoreStu.Text = "學生個人成績";
            this.btnScoreStu.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(589, 310);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(302, 21);
            this.label6.TabIndex = 153;
            this.label6.Text = "LINQ to Northwind DataSet - Products";
            // 
            // btnProdNext
            // 
            this.btnProdNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnProdNext.ForeColor = System.Drawing.Color.Black;
            this.btnProdNext.Location = new System.Drawing.Point(893, 341);
            this.btnProdNext.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnProdNext.Name = "btnProdNext";
            this.btnProdNext.Size = new System.Drawing.Size(87, 46);
            this.btnProdNext.TabIndex = 149;
            this.btnProdNext.Text = "下一頁";
            this.btnProdNext.UseVisualStyleBackColor = false;
            this.btnProdNext.Click += new System.EventHandler(this.btnProdNext_Click);
            // 
            // btnProdPre
            // 
            this.btnProdPre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnProdPre.ForeColor = System.Drawing.Color.Black;
            this.btnProdPre.Location = new System.Drawing.Point(792, 341);
            this.btnProdPre.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnProdPre.Name = "btnProdPre";
            this.btnProdPre.Size = new System.Drawing.Size(87, 46);
            this.btnProdPre.TabIndex = 150;
            this.btnProdPre.Text = "上一頁";
            this.btnProdPre.UseVisualStyleBackColor = false;
            this.btnProdPre.Click += new System.EventHandler(this.btnProdPre_Click);
            // 
            // txtProdRows
            // 
            this.txtProdRows.Font = new System.Drawing.Font("微軟正黑體", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtProdRows.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtProdRows.Location = new System.Drawing.Point(672, 353);
            this.txtProdRows.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtProdRows.Name = "txtProdRows";
            this.txtProdRows.Size = new System.Drawing.Size(97, 25);
            this.txtProdRows.TabIndex = 151;
            this.txtProdRows.Text = "10";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(598, 356);
            this.label7.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 17);
            this.label7.TabIndex = 152;
            this.label7.Text = "一頁幾筆";
            // 
            // btnFileInfo
            // 
            this.btnFileInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnFileInfo.Location = new System.Drawing.Point(79, 57);
            this.btnFileInfo.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnFileInfo.Name = "btnFileInfo";
            this.btnFileInfo.Size = new System.Drawing.Size(309, 46);
            this.btnFileInfo.TabIndex = 148;
            this.btnFileInfo.Text = "     FileInfo[] ";
            this.btnFileInfo.UseVisualStyleBackColor = false;
            this.btnFileInfo.Click += new System.EventHandler(this.btnFileInfo_Click);
            // 
            // btnScoreAll
            // 
            this.btnScoreAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnScoreAll.Location = new System.Drawing.Point(79, 281);
            this.btnScoreAll.Margin = new System.Windows.Forms.Padding(6);
            this.btnScoreAll.Name = "btnScoreAll";
            this.btnScoreAll.Size = new System.Drawing.Size(309, 50);
            this.btnScoreAll.TabIndex = 147;
            this.btnScoreAll.Text = "搜尋 班級學生成績";
            this.btnScoreAll.UseVisualStyleBackColor = false;
            this.btnScoreAll.Click += new System.EventHandler(this.btnScoreAll_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(634, 128);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 17);
            this.label9.TabIndex = 134;
            this.label9.Text = "年:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.Color.Olive;
            this.label4.Location = new System.Drawing.Point(76, 25);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 21);
            this.label4.TabIndex = 103;
            this.label4.Text = "LINQ to FileInfo[]";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.lblDetails, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.dataGridView2, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(646, 443);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // lblDetails
            // 
            this.lblDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDetails.Font = new System.Drawing.Font("微軟正黑體", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDetails.ForeColor = System.Drawing.Color.White;
            this.lblDetails.Location = new System.Drawing.Point(6, 0);
            this.lblDetails.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(634, 57);
            this.lblDetails.TabIndex = 102;
            this.lblDetails.Text = "訂單明細";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(7, 63);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(632, 374);
            this.dataGridView2.TabIndex = 100;
            // 
            // btnOrderAll
            // 
            this.btnOrderAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnOrderAll.Location = new System.Drawing.Point(592, 57);
            this.btnOrderAll.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnOrderAll.Name = "btnOrderAll";
            this.btnOrderAll.Size = new System.Drawing.Size(388, 46);
            this.btnOrderAll.TabIndex = 133;
            this.btnOrderAll.Text = "All 訂單 ";
            this.btnOrderAll.UseVisualStyleBackColor = false;
            this.btnOrderAll.Click += new System.EventHandler(this.btnOrderAll_Click);
            // 
            // btnFileInfo_log
            // 
            this.btnFileInfo_log.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnFileInfo_log.Location = new System.Drawing.Point(79, 113);
            this.btnFileInfo_log.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnFileInfo_log.Name = "btnFileInfo_log";
            this.btnFileInfo_log.Size = new System.Drawing.Size(309, 46);
            this.btnFileInfo_log.TabIndex = 69;
            this.btnFileInfo_log.Text = "     FileInfo[]  .Log  檔";
            this.btnFileInfo_log.UseVisualStyleBackColor = false;
            this.btnFileInfo_log.Click += new System.EventHandler(this.btnFileInfo_log_Click);
            // 
            // btnOrderYear
            // 
            this.btnOrderYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnOrderYear.Location = new System.Drawing.Point(792, 115);
            this.btnOrderYear.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnOrderYear.Name = "btnOrderYear";
            this.btnOrderYear.Size = new System.Drawing.Size(188, 46);
            this.btnOrderYear.TabIndex = 70;
            this.btnOrderYear.Text = "     某年訂單 / 訂單明細";
            this.btnOrderYear.UseVisualStyleBackColor = false;
            this.btnOrderYear.Click += new System.EventHandler(this.btnOrderYear_Click);
            // 
            // btnFileInfoCreated
            // 
            this.btnFileInfoCreated.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnFileInfoCreated.Location = new System.Drawing.Point(79, 169);
            this.btnFileInfoCreated.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnFileInfoCreated.Name = "btnFileInfoCreated";
            this.btnFileInfoCreated.Size = new System.Drawing.Size(309, 46);
            this.btnFileInfoCreated.TabIndex = 72;
            this.btnFileInfoCreated.Text = "     FileInfo[]   - year Created - order ";
            this.btnFileInfoCreated.UseVisualStyleBackColor = false;
            this.btnFileInfoCreated.Click += new System.EventHandler(this.btnFileInfoCreated_Click);
            // 
            // btnOrderNext
            // 
            this.btnOrderNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnOrderNext.ForeColor = System.Drawing.Color.Black;
            this.btnOrderNext.Location = new System.Drawing.Point(893, 205);
            this.btnOrderNext.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnOrderNext.Name = "btnOrderNext";
            this.btnOrderNext.Size = new System.Drawing.Size(87, 46);
            this.btnOrderNext.TabIndex = 96;
            this.btnOrderNext.Text = "下一頁";
            this.btnOrderNext.UseVisualStyleBackColor = false;
            this.btnOrderNext.Click += new System.EventHandler(this.btnOrderNext_Click);
            // 
            // cmbOrderYear
            // 
            this.cmbOrderYear.Font = new System.Drawing.Font("微軟正黑體", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cmbOrderYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cmbOrderYear.FormattingEnabled = true;
            this.cmbOrderYear.Location = new System.Drawing.Point(672, 125);
            this.cmbOrderYear.Margin = new System.Windows.Forms.Padding(6);
            this.cmbOrderYear.Name = "cmbOrderYear";
            this.cmbOrderYear.Size = new System.Drawing.Size(97, 25);
            this.cmbOrderYear.TabIndex = 125;
            // 
            // btnOrderPre
            // 
            this.btnOrderPre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnOrderPre.ForeColor = System.Drawing.Color.Black;
            this.btnOrderPre.Location = new System.Drawing.Point(792, 205);
            this.btnOrderPre.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnOrderPre.Name = "btnOrderPre";
            this.btnOrderPre.Size = new System.Drawing.Size(87, 46);
            this.btnOrderPre.TabIndex = 97;
            this.btnOrderPre.Text = "上一頁";
            this.btnOrderPre.UseVisualStyleBackColor = false;
            this.btnOrderPre.Click += new System.EventHandler(this.btnOrderPre_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(6);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tableLayoutPanel2);
            this.splitContainer2.Size = new System.Drawing.Size(1213, 447);
            this.splitContainer2.SplitterDistance = 556;
            this.splitContainer2.SplitterWidth = 7;
            this.splitContainer2.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lblMaster, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(552, 443);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblMaster
            // 
            this.lblMaster.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMaster.Font = new System.Drawing.Font("微軟正黑體", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblMaster.ForeColor = System.Drawing.Color.White;
            this.lblMaster.Location = new System.Drawing.Point(6, 0);
            this.lblMaster.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblMaster.Name = "lblMaster";
            this.lblMaster.Size = new System.Drawing.Size(540, 57);
            this.lblMaster.TabIndex = 101;
            this.lblMaster.Text = "訂單";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(7, 63);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(538, 374);
            this.dataGridView1.TabIndex = 71;
            // 
            // btnFileInfoBig
            // 
            this.btnFileInfoBig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnFileInfoBig.Location = new System.Drawing.Point(79, 225);
            this.btnFileInfoBig.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnFileInfoBig.Name = "btnFileInfoBig";
            this.btnFileInfoBig.Size = new System.Drawing.Size(309, 46);
            this.btnFileInfoBig.TabIndex = 124;
            this.btnFileInfoBig.Text = "     FileInfo[]   - 大檔案";
            this.btnFileInfoBig.UseVisualStyleBackColor = false;
            this.btnFileInfoBig.Click += new System.EventHandler(this.btnFileInfoBig_Click);
            // 
            // txtOrderRows
            // 
            this.txtOrderRows.Font = new System.Drawing.Font("微軟正黑體", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtOrderRows.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtOrderRows.Location = new System.Drawing.Point(672, 205);
            this.txtOrderRows.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtOrderRows.Name = "txtOrderRows";
            this.txtOrderRows.Size = new System.Drawing.Size(97, 25);
            this.txtOrderRows.TabIndex = 98;
            this.txtOrderRows.Text = "10";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(598, 208);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 99;
            this.label1.Text = "一頁幾筆";
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(6);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.cmbFileCreatedYear);
            this.splitContainer1.Panel1.Controls.Add(this.btnScoreStu);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.btnProdNext);
            this.splitContainer1.Panel1.Controls.Add(this.btnProdPre);
            this.splitContainer1.Panel1.Controls.Add(this.txtProdRows);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.btnFileInfo);
            this.splitContainer1.Panel1.Controls.Add(this.btnScoreAll);
            this.splitContainer1.Panel1.Controls.Add(this.label9);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.btnOrderAll);
            this.splitContainer1.Panel1.Controls.Add(this.btnFileInfo_log);
            this.splitContainer1.Panel1.Controls.Add(this.btnOrderYear);
            this.splitContainer1.Panel1.Controls.Add(this.btnFileInfoCreated);
            this.splitContainer1.Panel1.Controls.Add(this.btnOrderNext);
            this.splitContainer1.Panel1.Controls.Add(this.cmbOrderYear);
            this.splitContainer1.Panel1.Controls.Add(this.btnOrderPre);
            this.splitContainer1.Panel1.Controls.Add(this.btnFileInfoBig);
            this.splitContainer1.Panel1.Controls.Add(this.txtOrderRows);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1213, 871);
            this.splitContainer1.SplitterDistance = 418;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 138;
            // 
            // cmbFileCreatedYear
            // 
            this.cmbFileCreatedYear.Font = new System.Drawing.Font("微軟正黑體", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cmbFileCreatedYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cmbFileCreatedYear.FormattingEnabled = true;
            this.cmbFileCreatedYear.Location = new System.Drawing.Point(392, 190);
            this.cmbFileCreatedYear.Margin = new System.Windows.Forms.Padding(6);
            this.cmbFileCreatedYear.Name = "cmbFileCreatedYear";
            this.cmbFileCreatedYear.Size = new System.Drawing.Size(105, 25);
            this.cmbFileCreatedYear.TabIndex = 155;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(589, 25);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(286, 21);
            this.label5.TabIndex = 104;
            this.label5.Text = "LINQ to Northwind DataSet - Orders";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(389, 169);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 17);
            this.label2.TabIndex = 156;
            this.label2.Text = "年:";
            // 
            // nwDataSet1
            // 
            this.nwDataSet1.DataSetName = "nwDataSet";
            this.nwDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsTableAdapter1
            // 
            this.productsTableAdapter1.ClearBeforeFill = true;
            // 
            // ordersTableAdapter1
            // 
            this.ordersTableAdapter1.ClearBeforeFill = true;
            // 
            // order_DetailsTableAdapter1
            // 
            this.order_DetailsTableAdapter1.ClearBeforeFill = true;
            // 
            // FrmHw1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 871);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "FrmHw1";
            this.Text = "FrmHw1";
            this.Load += new System.EventHandler(this.FrmHw1_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nwDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button btnScoreStu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnProdNext;
        private System.Windows.Forms.Button btnProdPre;
        private System.Windows.Forms.TextBox txtProdRows;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnFileInfo;
        private System.Windows.Forms.Button btnScoreAll;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnOrderAll;
        private System.Windows.Forms.Button btnFileInfo_log;
        private System.Windows.Forms.Button btnOrderYear;
        private System.Windows.Forms.Button btnFileInfoCreated;
        private System.Windows.Forms.Button btnOrderNext;
        private System.Windows.Forms.ComboBox cmbOrderYear;
        private System.Windows.Forms.Button btnOrderPre;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblMaster;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnFileInfoBig;
        private System.Windows.Forms.TextBox txtOrderRows;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label5;
        private nwDataSet nwDataSet1;
        private nwDataSetTableAdapters.ProductsTableAdapter productsTableAdapter1;
        private nwDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter1;
        private nwDataSetTableAdapters.Order_DetailsTableAdapter order_DetailsTableAdapter1;
        private System.Windows.Forms.ComboBox cmbFileCreatedYear;
        private System.Windows.Forms.Label label2;
    }
}