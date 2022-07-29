
namespace LinqLabsHw
{
    partial class FrmHw3
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnScoreAll = new System.Windows.Forms.Button();
            this.btnScoreStu = new System.Windows.Forms.Button();
            this.btnGroup = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.cmbScoreStu = new System.Windows.Forms.ComboBox();
            this.cmbScoreAll = new System.Windows.Forms.ComboBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnScoreAll
            // 
            this.btnScoreAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnScoreAll.Location = new System.Drawing.Point(40, 67);
            this.btnScoreAll.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnScoreAll.Name = "btnScoreAll";
            this.btnScoreAll.Size = new System.Drawing.Size(186, 71);
            this.btnScoreAll.TabIndex = 149;
            this.btnScoreAll.Text = "搜尋 班級學生成績";
            this.btnScoreAll.UseVisualStyleBackColor = false;
            this.btnScoreAll.Click += new System.EventHandler(this.btnScoreAll_Click);
            // 
            // btnScoreStu
            // 
            this.btnScoreStu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnScoreStu.Location = new System.Drawing.Point(40, 240);
            this.btnScoreStu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnScoreStu.Name = "btnScoreStu";
            this.btnScoreStu.Size = new System.Drawing.Size(186, 71);
            this.btnScoreStu.TabIndex = 148;
            this.btnScoreStu.Text = "學生個人成績";
            this.btnScoreStu.UseVisualStyleBackColor = false;
            this.btnScoreStu.Click += new System.EventHandler(this.btnScoreStu_Click);
            // 
            // btnGroup
            // 
            this.btnGroup.Location = new System.Drawing.Point(40, 521);
            this.btnGroup.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGroup.Name = "btnGroup";
            this.btnGroup.Size = new System.Drawing.Size(186, 71);
            this.btnGroup.TabIndex = 147;
            this.btnGroup.Text = "自己分群";
            this.btnGroup.UseVisualStyleBackColor = false;
            this.btnGroup.Click += new System.EventHandler(this.btnGroup_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Count";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(820, 301);
            this.chart1.TabIndex = 150;
            this.chart1.Text = "chart1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(820, 353);
            this.dataGridView1.TabIndex = 151;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.cmbScoreStu);
            this.splitContainer1.Panel1.Controls.Add(this.cmbScoreAll);
            this.splitContainer1.Panel1.Controls.Add(this.btnScoreAll);
            this.splitContainer1.Panel1.Controls.Add(this.btnScoreStu);
            this.splitContainer1.Panel1.Controls.Add(this.btnGroup);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1131, 659);
            this.splitContainer1.SplitterDistance = 305;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 152;
            // 
            // cmbScoreStu
            // 
            this.cmbScoreStu.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cmbScoreStu.FormattingEnabled = true;
            this.cmbScoreStu.Location = new System.Drawing.Point(40, 319);
            this.cmbScoreStu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbScoreStu.Name = "cmbScoreStu";
            this.cmbScoreStu.Size = new System.Drawing.Size(186, 25);
            this.cmbScoreStu.TabIndex = 151;
            // 
            // cmbScoreAll
            // 
            this.cmbScoreAll.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cmbScoreAll.FormattingEnabled = true;
            this.cmbScoreAll.Location = new System.Drawing.Point(40, 146);
            this.cmbScoreAll.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbScoreAll.Name = "cmbScoreAll";
            this.cmbScoreAll.Size = new System.Drawing.Size(186, 25);
            this.cmbScoreAll.TabIndex = 150;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.dataGridView1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.chart1);
            this.splitContainer2.Size = new System.Drawing.Size(820, 659);
            this.splitContainer2.SplitterDistance = 353;
            this.splitContainer2.SplitterWidth = 5;
            this.splitContainer2.TabIndex = 0;
            // 
            // FrmHw3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 659);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmHw3";
            this.Text = "FrmHw3";
            this.Load += new System.EventHandler(this.FrmHw3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnScoreAll;
        private System.Windows.Forms.Button btnScoreStu;
        private System.Windows.Forms.Button btnGroup;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ComboBox cmbScoreAll;
        private System.Windows.Forms.ComboBox cmbScoreStu;
    }
}