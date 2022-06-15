using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spor_Salonu_Takip
{
    public partial class frmUrunEkle : Form
    {
        public Urunler frm1;
        public frmUrunEkle()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ace.OleDb.12.0;Data source=data.accdb");
        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            if (txt_Ad.Text.TrimEnd() == "" || txt_aciklama.Text.TrimEnd() == "" || txt_af.Text.TrimEnd() == "" || txt_sf.Text.TrimEnd() == "" || txt_stkmiktar.Text.TrimEnd() == "")
                MessageBox.Show("Lütfen Boş Yerleri Doldurunuz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            else
            {

                OleDbCommand komut = new OleDbCommand();
                baglanti.Open();
                komut.Connection = baglanti;
                //urun ekleme sql komutu
                komut.CommandText = "INSERT INTO Urunler(UrunAdi,Açıklama,AlisUrunFiyati,SatisUrunFiyati,StokMiktar) values('" + txt_Ad.Text + "','" + txt_aciklama.Text + "','" + txt_af.Text + "','" + txt_sf.Text + "','" + txt_stkmiktar.Text + "')";
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Yeni Ürün Eklendi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
                txt_Ad.Clear();
                txt_aciklama.Clear();
                txt_af.Clear();
            
                txt_sf.Clear();
                txt_af.Clear();
                txt_stkmiktar.Clear();
                frm1.yenile();
            }


        }
    }
}
