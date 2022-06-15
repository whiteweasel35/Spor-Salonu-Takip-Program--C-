using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Spor_Salonu_Takip
{
    public partial class Form1 : Form
    {
        public frmBilgiGüncelle frmbilgiGuncelle;
        public frmEkle frmEkle;
        public frmBilgi frmBilgi;
        public frmGuncelle frmGuncelle;
        public Urunler urunler;
        public Form1()
        {
            InitializeComponent();
            frmEkle = new frmEkle();
            frmbilgiGuncelle = new frmBilgiGüncelle();
            frmGuncelle=new frmGuncelle();
            frmBilgi = new frmBilgi();
            urunler = new Urunler();
            frmGuncelle.frm1 = this;
            frmbilgiGuncelle.frm1 = this;
            frmEkle.frm1 = this;
            frmBilgi.frm1 = this;
    
        }
        //connection string bağlantı bölümü // 
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ace.OleDb.12.0;Data source=data.accdb");
        public void yenile()
        {
            DataTable tablo = new DataTable();
            OleDbDataAdapter adaptör = new OleDbDataAdapter("select Kisi_no,Kisi_ad,Kisi_soyad,Kisi_telno,Kisi_cinsiyet,Kisi_adres,VKindex,BaslangicTarih,BitisTarih from Kisiler", baglanti);
            adaptör.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }
        //ana ekran yüklenirken 
        private void Form1_Load(object sender, EventArgs e)
        {
            yenile();
            dataGridView1.Columns[0].HeaderText = "No";
            dataGridView1.Columns[1].HeaderText="Adı";
            dataGridView1.Columns[2].HeaderText="Soyadı";
            dataGridView1.Columns[3].HeaderText="Tel No";
            dataGridView1.Columns[4].HeaderText="Cinsiyet";
            dataGridView1.Columns[5].HeaderText="Adres";
            dataGridView1.Columns[6].HeaderText = "Vücüt Kitle İndeksi";
            dataGridView1.Columns[7].HeaderText = "Başlangıç Tarihi";
            dataGridView1.Columns[8].HeaderText = "Bitiş Tarihi";
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        //ekle butonu
        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            frmEkle.ShowDialog();
        }
        //sil butonu
        private void btn_Sil_Click(object sender, EventArgs e)
        {
            DialogResult silsinmi = MessageBox.Show("Seçilen Kişi Silinsinmi ?","Uyarı",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (silsinmi == DialogResult.Yes)
            {
                OleDbCommand kmtSil = new OleDbCommand();
                baglanti.Open();
                kmtSil.Connection = baglanti;
                //silme sql komutu
                kmtSil.CommandText = "DELETE FROM Kisiler where Kisi_no=" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "";
                kmtSil.ExecuteNonQuery();
                baglanti.Close();
                yenile();
            }
        }
        //guncelle butonu
        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            frmGuncelle.txt_Ad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frmGuncelle.txt_Soyad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frmGuncelle.txt_Tel.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            frmGuncelle.cmb_Cinsiyet.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            frmGuncelle.txt_Adres.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            frmGuncelle.ShowDialog();
        }
        //ara butonu
        private void btn_Ara_Click(object sender, EventArgs e)
        {
            frmAra frmAra = new frmAra();
            frmAra.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmBilgi.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            urunler.ShowDialog();
        }
    }
}
