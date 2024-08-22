namespace FilmIzlemeArsivi
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.webView1 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btncikis = new System.Windows.Forms.Button();
            this.btnlistele = new System.Windows.Forms.Button();
            this.btnyenifilm = new System.Windows.Forms.Button();
            this.btnhakkimizda = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.webView1);
            this.groupBox2.Location = new System.Drawing.Point(427, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1112, 641);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "EKRAN";
            // 
            // webView1
            // 
            this.webView1.AllowExternalDrop = true;
            this.webView1.CreationProperties = null;
            this.webView1.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webView1.Location = new System.Drawing.Point(3, 18);
            this.webView1.Name = "webView1";
            this.webView1.Size = new System.Drawing.Size(1106, 620);
            this.webView1.TabIndex = 1;
            this.webView1.ZoomFactor = 1D;
//            this.webView1.DoubleClick += new System.EventHandler(this.webView1_DoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(424, 184);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Film Listesi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1545, 634);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btncikis);
            this.groupBox3.Controls.Add(this.btnlistele);
            this.groupBox3.Controls.Add(this.btnyenifilm);
            this.groupBox3.Controls.Add(this.btnhakkimizda);
            this.groupBox3.Location = new System.Drawing.Point(3, 190);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(418, 462);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "İŞLEMLER";
            // 
            // btncikis
            // 
            this.btncikis.Location = new System.Drawing.Point(6, 248);
            this.btncikis.Name = "btncikis";
            this.btncikis.Size = new System.Drawing.Size(403, 65);
            this.btncikis.TabIndex = 3;
            this.btncikis.Text = "ÇIKIŞ";
            this.btncikis.UseVisualStyleBackColor = true;
            this.btncikis.Click += new System.EventHandler(this.btncikis_Click);
            // 
            // btnlistele
            // 
            this.btnlistele.Location = new System.Drawing.Point(6, 106);
            this.btnlistele.Name = "btnlistele";
            this.btnlistele.Size = new System.Drawing.Size(404, 65);
            this.btnlistele.TabIndex = 4;
            this.btnlistele.Text = "LİSTELE";
            this.btnlistele.UseVisualStyleBackColor = true;
            this.btnlistele.Click += new System.EventHandler(this.btnlistele_Click);
            // 
            // btnyenifilm
            // 
            this.btnyenifilm.Location = new System.Drawing.Point(6, 35);
            this.btnyenifilm.Name = "btnyenifilm";
            this.btnyenifilm.Size = new System.Drawing.Size(404, 65);
            this.btnyenifilm.TabIndex = 0;
            this.btnyenifilm.Text = "YENİ FİLM EKLE";
            this.btnyenifilm.UseVisualStyleBackColor = true;
            this.btnyenifilm.Click += new System.EventHandler(this.btnyenifilm_Click);
            // 
            // btnhakkimizda
            // 
            this.btnhakkimizda.Location = new System.Drawing.Point(7, 177);
            this.btnhakkimizda.Name = "btnhakkimizda";
            this.btnhakkimizda.Size = new System.Drawing.Size(403, 65);
            this.btnhakkimizda.TabIndex = 1;
            this.btnhakkimizda.Text = "HAKKIMIZDA";
            this.btnhakkimizda.UseVisualStyleBackColor = true;
            this.btnhakkimizda.Click += new System.EventHandler(this.btnhakkimizda_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1551, 655);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.webView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btncikis;
        private System.Windows.Forms.Button btnhakkimizda;
        private System.Windows.Forms.Button btnyenifilm;
        private System.Windows.Forms.Button btnlistele;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView1;
    }
}

