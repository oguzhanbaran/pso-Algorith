namespace _163311052_pso
{
    partial class pso_Form
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pso_Form));
            this.label1 = new System.Windows.Forms.Label();
            this.numericParcaSayisi = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericISayisi = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numericOFaktor = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numericPUst = new System.Windows.Forms.NumericUpDown();
            this.numericPAlt = new System.Windows.Forms.NumericUpDown();
            this.btnBasla = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label6 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericParcaSayisi)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericISayisi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericOFaktor)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPUst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPAlt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Parçacık sayısı:";
            // 
            // numericParcaSayisi
            // 
            this.numericParcaSayisi.Location = new System.Drawing.Point(153, 27);
            this.numericParcaSayisi.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericParcaSayisi.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericParcaSayisi.Name = "numericParcaSayisi";
            this.numericParcaSayisi.Size = new System.Drawing.Size(193, 22);
            this.numericParcaSayisi.TabIndex = 2;
            this.numericParcaSayisi.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericISayisi);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.numericOFaktor);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.numericParcaSayisi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(372, 251);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parametreler";
            // 
            // numericISayisi
            // 
            this.numericISayisi.Location = new System.Drawing.Point(161, 206);
            this.numericISayisi.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericISayisi.Name = "numericISayisi";
            this.numericISayisi.Size = new System.Drawing.Size(193, 22);
            this.numericISayisi.TabIndex = 9;
            this.numericISayisi.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "İterasyon sayısı:";
            // 
            // numericOFaktor
            // 
            this.numericOFaktor.Location = new System.Drawing.Point(161, 169);
            this.numericOFaktor.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericOFaktor.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericOFaktor.Name = "numericOFaktor";
            this.numericOFaktor.Size = new System.Drawing.Size(193, 22);
            this.numericOFaktor.TabIndex = 7;
            this.numericOFaktor.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Öğrenme faktörü:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.numericPUst);
            this.groupBox2.Controls.Add(this.numericPAlt);
            this.groupBox2.Location = new System.Drawing.Point(19, 75);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(340, 73);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Parçacık Aralığı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(166, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "-";
            // 
            // numericPUst
            // 
            this.numericPUst.Location = new System.Drawing.Point(214, 29);
            this.numericPUst.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericPUst.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericPUst.Name = "numericPUst";
            this.numericPUst.Size = new System.Drawing.Size(120, 22);
            this.numericPUst.TabIndex = 6;
            this.numericPUst.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericPUst.ValueChanged += new System.EventHandler(this.NumericPUst_ValueChanged);
            // 
            // numericPAlt
            // 
            this.numericPAlt.Location = new System.Drawing.Point(10, 31);
            this.numericPAlt.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numericPAlt.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            -2147483648});
            this.numericPAlt.Name = "numericPAlt";
            this.numericPAlt.Size = new System.Drawing.Size(120, 22);
            this.numericPAlt.TabIndex = 3;
            this.numericPAlt.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numericPAlt.ValueChanged += new System.EventHandler(this.NumericPAlt_ValueChanged);
            // 
            // btnBasla
            // 
            this.btnBasla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBasla.Location = new System.Drawing.Point(12, 269);
            this.btnBasla.Name = "btnBasla";
            this.btnBasla.Size = new System.Drawing.Size(372, 48);
            this.btnBasla.TabIndex = 1;
            this.btnBasla.Text = "Başla";
            this.btnBasla.UseVisualStyleBackColor = true;
            this.btnBasla.Click += new System.EventHandler(this.BtnBasla_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(6, 6);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(604, 469);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(396, 538);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 20);
            this.label6.TabIndex = 3;
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(6, 5);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(604, 471);
            this.chart1.TabIndex = 4;
            this.chart1.Text = "chart1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(390, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(624, 508);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(616, 482);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Konum Bilgileri";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chart1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(616, 482);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Yakınsama Grafiği";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 324);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(372, 234);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pso_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1021, 576);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnBasla);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "pso_Form";
            this.Text = "Parçacık Sürü Optimizasyonu";
            this.Load += new System.EventHandler(this.Pso_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericParcaSayisi)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericISayisi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericOFaktor)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPUst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPAlt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericParcaSayisi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericISayisi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericOFaktor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown numericPUst;
        private System.Windows.Forms.NumericUpDown numericPAlt;
        private System.Windows.Forms.Button btnBasla;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

