﻿
namespace Spor_Salonu_Takip
{
    partial class Urunler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Urunler));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_Guncelle = new System.Windows.Forms.Button();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.btn_Ekle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 115);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(551, 282);
            this.dataGridView1.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Image = global::Spor_Salonu_Takip.Properties.Resources.sil;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(305, 14);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 86);
            this.button2.TabIndex = 12;
            this.button2.Text = "Üründen Azalt";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_Guncelle
            // 
            this.btn_Guncelle.Image = global::Spor_Salonu_Takip.Properties.Resources.guncelle;
            this.btn_Guncelle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Guncelle.Location = new System.Drawing.Point(458, 14);
            this.btn_Guncelle.Name = "btn_Guncelle";
            this.btn_Guncelle.Size = new System.Drawing.Size(105, 86);
            this.btn_Guncelle.TabIndex = 9;
            this.btn_Guncelle.Text = "Seçili Ürün Güncelle";
            this.btn_Guncelle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Guncelle.UseVisualStyleBackColor = true;
            this.btn_Guncelle.Click += new System.EventHandler(this.btn_Guncelle_Click);
            // 
            // btn_Sil
            // 
            this.btn_Sil.Image = global::Spor_Salonu_Takip.Properties.Resources.sil;
            this.btn_Sil.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Sil.Location = new System.Drawing.Point(163, 14);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(105, 86);
            this.btn_Sil.TabIndex = 8;
            this.btn_Sil.Text = "Ürünü Sil";
            this.btn_Sil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Sil.UseVisualStyleBackColor = true;
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.Image = global::Spor_Salonu_Takip.Properties.Resources.ekle1;
            this.btn_Ekle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Ekle.Location = new System.Drawing.Point(12, 14);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.Size = new System.Drawing.Size(106, 86);
            this.btn_Ekle.TabIndex = 7;
            this.btn_Ekle.Text = "Yeni Ürün Ekle";
            this.btn_Ekle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Ekle.UseVisualStyleBackColor = true;
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
            // 
            // Urunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Spor_Salonu_Takip.Properties.Resources._61soLc8_SCL__AC_SL1050_;
            this.ClientSize = new System.Drawing.Size(785, 454);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_Guncelle);
            this.Controls.Add(this.btn_Sil);
            this.Controls.Add(this.btn_Ekle);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Urunler";
            this.Text = "Urunler";
            this.Load += new System.EventHandler(this.Urunler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Guncelle;
        private System.Windows.Forms.Button btn_Sil;
        private System.Windows.Forms.Button btn_Ekle;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
    }
}