namespace FilmIzlemeArsivi
{
    partial class YeniFilmEkle
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtfilmad = new System.Windows.Forms.TextBox();
            this.txtkategori = new System.Windows.Forms.TextBox();
            this.txtlink = new System.Windows.Forms.TextBox();
            this.btnekle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Film Ad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kategori  :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Link :";
            // 
            // txtfilmad
            // 
            this.txtfilmad.Location = new System.Drawing.Point(124, 16);
            this.txtfilmad.Name = "txtfilmad";
            this.txtfilmad.Size = new System.Drawing.Size(206, 30);
            this.txtfilmad.TabIndex = 3;
            // 
            // txtkategori
            // 
            this.txtkategori.Location = new System.Drawing.Point(124, 56);
            this.txtkategori.Name = "txtkategori";
            this.txtkategori.Size = new System.Drawing.Size(206, 30);
            this.txtkategori.TabIndex = 4;
            // 
            // txtlink
            // 
            this.txtlink.Location = new System.Drawing.Point(124, 94);
            this.txtlink.Name = "txtlink";
            this.txtlink.Size = new System.Drawing.Size(206, 30);
            this.txtlink.TabIndex = 5;
            // 
            // btnekle
            // 
            this.btnekle.Location = new System.Drawing.Point(210, 130);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(120, 33);
            this.btnekle.TabIndex = 6;
            this.btnekle.Text = "Ekle";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // YeniFilmEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(404, 185);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.txtlink);
            this.Controls.Add(this.txtkategori);
            this.Controls.Add(this.txtfilmad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "YeniFilmEkle";
            this.Text = "YeniFilmEkle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtfilmad;
        private System.Windows.Forms.TextBox txtkategori;
        private System.Windows.Forms.TextBox txtlink;
        private System.Windows.Forms.Button btnekle;
    }
}