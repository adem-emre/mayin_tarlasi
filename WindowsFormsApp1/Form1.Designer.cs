namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sureNumeric = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.mayinNumeric = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.lblsure = new System.Windows.Forms.Label();
            this.basla = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sureNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mayinNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.LightBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.MinimumSize = new System.Drawing.Size(200, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "SORU 1:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OldLace;
            this.panel1.Location = new System.Drawing.Point(12, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 196);
            this.panel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sureNumeric);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.mayinNumeric);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(12, 241);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 75);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parametreler";
            // 
            // sureNumeric
            // 
            this.sureNumeric.Location = new System.Drawing.Point(88, 42);
            this.sureNumeric.Name = "sureNumeric";
            this.sureNumeric.Size = new System.Drawing.Size(105, 20);
            this.sureNumeric.TabIndex = 1;
            this.sureNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sureNumeric.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.LightGray;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(7, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Süre (sn) =";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mayinNumeric
            // 
            this.mayinNumeric.Location = new System.Drawing.Point(88, 19);
            this.mayinNumeric.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.mayinNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.mayinNumeric.Name = "mayinNumeric";
            this.mayinNumeric.Size = new System.Drawing.Size(105, 20);
            this.mayinNumeric.TabIndex = 1;
            this.mayinNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mayinNumeric.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.LightGray;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(7, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mayın Sayısı =";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblsure
            // 
            this.lblsure.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblsure.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsure.ForeColor = System.Drawing.Color.Black;
            this.lblsure.Location = new System.Drawing.Point(12, 322);
            this.lblsure.Name = "lblsure";
            this.lblsure.Size = new System.Drawing.Size(128, 29);
            this.lblsure.TabIndex = 0;
            this.lblsure.Text = "Kalan Süre =__ ";
            this.lblsure.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // basla
            // 
            this.basla.BackColor = System.Drawing.SystemColors.HotTrack;
            this.basla.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.basla.ForeColor = System.Drawing.Color.White;
            this.basla.Location = new System.Drawing.Point(146, 322);
            this.basla.Name = "basla";
            this.basla.Size = new System.Drawing.Size(66, 29);
            this.basla.TabIndex = 3;
            this.basla.Text = "Başla";
            this.basla.UseVisualStyleBackColor = false;
            this.basla.Click += new System.EventHandler(this.basla_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 362);
            this.Controls.Add(this.basla);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblsure);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Vize";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sureNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mayinNumeric)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown mayinNumeric;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown sureNumeric;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblsure;
        private System.Windows.Forms.Button basla;
        private System.Windows.Forms.Timer timer1;
    }
}

