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
    public partial class Urunler : Form
    {
        public frmurunguncelle frmbGuncelle;
        public frmUrunEkle frmEkle;
 
        //data connection
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ace.OleDb.12.0;Data source=data.accdb");
        public void yenile()
        {
            DataTable tablo = new DataTable();
            OleDbDataAdapter adaptör = new OleDbDataAdapter("select UrunNo,UrunAdi,Açıklama,AlisUrunFiyati,SatisUrunFiyati,StokMiktar from Urunler", baglanti);
            adaptör.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }
   
        public Urunler()
        {
            InitializeComponent();
            frmEkle = new frmUrunEkle();
            frmbGuncelle = new frmurunguncelle();

            frmbGuncelle.frm1 = this;
            frmEkle.frm1 = this;
           

        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            frmEkle.ShowDialog();
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            frmbGuncelle.txt_Ad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frmbGuncelle.txt_Aciklama.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frmbGuncelle.txt_Alisfiyati.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            frmbGuncelle.txt_satisfiyati.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            frmbGuncelle.txt_miktar.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            frmbGuncelle.ShowDialog();
        }

        private void Urunler_Load(object sender, EventArgs e)
        {
            yenile();
            dataGridView1.Columns[0].HeaderText = "Urun No";
            dataGridView1.Columns[1].HeaderText = "Adı";
            dataGridView1.Columns[2].HeaderText = "Açıklama";
            dataGridView1.Columns[3].HeaderText = "Alış Fiyatı";
            dataGridView1.Columns[4].HeaderText = "Satış Fiyatı";
            dataGridView1.Columns[5].HeaderText = "Stok Miktarı";
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult guncellesinmi = MessageBox.Show("Kayıt Güncellensinmi ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (guncellesinmi == DialogResult.Yes)
            {
                OleDbCommand kmtGuncel = new OleDbCommand();
                baglanti.Open();
                kmtGuncel.Connection = baglanti;
                //ürün miktar azaltma sql komutu
                kmtGuncel.CommandText = "update Urunler set  StokMiktar=@StokMiktar where UrunNo=" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "";

                var sayi=int.Parse(dataGridView1.CurrentRow.Cells[5].Value.ToString())-1;
                kmtGuncel.Parameters.AddWithValue("@Stokmiktar", sayi);
                kmtGuncel.ExecuteNonQuery();
                baglanti.Close();
                this.yenile();
            }
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {

            DialogResult silsinmi = MessageBox.Show("Seçilen Kişi Silinsinmi ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (silsinmi == DialogResult.Yes)
            {
                OleDbCommand kmtSil = new OleDbCommand();
                baglanti.Open();
                kmtSil.Connection = baglanti;
                //ürün silme sql komutu
                kmtSil.CommandText = "DELETE FROM Urunler where UrunNo=" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "";
                kmtSil.ExecuteNonQuery();
                baglanti.Close();
                yenile();
            }
        }
    }
}
