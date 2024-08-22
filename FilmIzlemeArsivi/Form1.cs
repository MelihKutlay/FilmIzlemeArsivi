using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;

namespace FilmIzlemeArsivi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=MELIH\\MELIH;Initial Catalog=FilmArsiviVeriTabani;Integrated Security=True");

        void listele()
        {
            SqlCommand getir = new SqlCommand("SELECT FilmAd,Link FROM TBL_FILMLER ", baglanti);
            SqlDataAdapter dt = new SqlDataAdapter(getir);
            DataTable da = new DataTable();
            dt.Fill(da);
            dataGridView1.DataSource = da;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void btnyenifilm_Click(object sender, EventArgs e)
        {
            YeniFilmEkle yeni = new YeniFilmEkle();
            yeni.Show();
        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            listele();
        }

        private async void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            string link = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            await webView1.EnsureCoreWebView2Async(null);
            webView1.CoreWebView2.Navigate(link);
           
        }

        private void btnhakkimizda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("BU PROJE MELİH KUTLAY TARAFINDAN GELİŞTİRİLMİŞTİR","HAKKIMDA",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        private void btncikis_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}

