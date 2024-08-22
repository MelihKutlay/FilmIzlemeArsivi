using Microsoft.Web.WebView2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmIzlemeArsivi
{
    public partial class YeniFilmEkle : Form
    {
        public YeniFilmEkle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=MELIH\\MELIH;Initial Catalog=FilmArsiviVeriTabani;Integrated Security=True");
        private async void btnekle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand ekle = new SqlCommand("INSERT INTO TBL_FILMLER (FilmAd,Kategori,Link) VALUES (@P1,@P2,@P3)", baglanti);
            ekle.Parameters.AddWithValue("@P1", txtfilmad.Text);
            ekle.Parameters.AddWithValue("@P2", txtkategori.Text);
            ekle.Parameters.AddWithValue("@P3", txtlink.Text);
            ekle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("YENİ BİR FİLM BAŞARILI BİR ŞEKİLDE EKLENMİŞTİR","BİLGİ",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
