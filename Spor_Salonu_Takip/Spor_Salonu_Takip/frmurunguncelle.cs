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
    public partial class frmurunguncelle : Form
    {
        public Urunler frm1;
        public frmurunguncelle()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ace.OleDb.12.0;Data source=data.accdb");

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            DialogResult guncellesinmi = MessageBox.Show("Kayıt Güncellensinmi ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (guncellesinmi == DialogResult.Yes)
            {
                OleDbCommand kmtGuncel = new OleDbCommand();
                baglanti.Open();
                kmtGuncel.Connection = baglanti;
                //ürün güncelleme
                //
                kmtGuncel.CommandText = "update Urunler set UrunAdi=@UrunAdi, Açıklama=@Açıklama,AlisUrunFiyati=@AlisUrunFiyati,SatisUrunFiyati=@SatisUrunFiyati,StokMiktar=@StokMiktar where UrunNo=@anahtar";
                kmtGuncel.Parameters.AddWithValue("@UrunAdi", txt_Ad.Text);
                kmtGuncel.Parameters.AddWithValue("@Açıklama", txt_Aciklama.Text);
                kmtGuncel.Parameters.AddWithValue("@AlisUrunFiyati", txt_Alisfiyati.Text);
                kmtGuncel.Parameters.AddWithValue("@SatisUrunFiyati", txt_satisfiyati.Text);
                kmtGuncel.Parameters.AddWithValue("@StokMiktar", txt_miktar.Text);
                kmtGuncel.Parameters.AddWithValue("@UrunNo", frm1.dataGridView1.CurrentRow.Cells[0].Value.ToString());
                kmtGuncel.ExecuteNonQuery();
                baglanti.Close();
                frm1.yenile();
            }
        }
    }
}
