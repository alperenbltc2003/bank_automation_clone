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



namespace bankamatikOto
{
    public partial class Havale : Form
    {
        public Havale()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(" server= DESKTOP-8FRVC6I\\SQLEXPRESS ; initial catalog= bankamatik2; integrated security = sspi");


        private void button1_Click(object sender, EventArgs e)
        {

            float sayi = float.Parse(msTxtHmiktar.Text);
            // eger girilen sayi bakiyeden büyük ise hata mesajı verilsin
            if (sayi > Form1.bakiye)
            {
                MessageBox.Show("Yetersiz Bakiye", "Pare Çekme İşlemi");
            }
            else
            {
                //1 ve 2 text boxa para atıcak kişinin bilgileri 3 ve 4 text boxlara ise alıcının bilgileri girilir 
                SqlCommand komut = new SqlCommand("update musteriler set bakiye= bakiye -  @p1 where ID= @p2  ", con);
                komut.Parameters.AddWithValue("@p1", sayi);
                komut.Parameters.AddWithValue("@p2", Form1.msID);

                SqlCommand komut2 = new SqlCommand("update musteriler set bakiye= bakiye +  @p3 where ID= @p4  ", con);
                komut2.Parameters.AddWithValue("@p3",  msTxtHmiktar.Text  );
                komut2.Parameters.AddWithValue("@p4",   msTxtAliciHspNo.Text );
                // girilen paranın 10 teleden buyuk olamsı gerektiğini yazdırıyoruz
                if (sayi < 10)
                {
                    MessageBox.Show("Lütfen 10 TL ve üzeri giriniz !", "Eksik Kayıt Hatası ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    con.Open();
                    //işlem başarılı ise atılan parayı yazıp onune işlemın oldugunu yazdık ve kaydetmesını için girilen sayiyi secip bağlıyouz
                    int sonuc1 = komut2.ExecuteNonQuery();
                    con.Close();
                    if (sonuc1 == 1)
                    {
                        con.Open();

                        komut.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Havale işlemi gerçekleştirildi ", "Havale / EFT ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Form1.bakiye -= sayi;

                       



                    }
                    else
                    {
                        MessageBox.Show("Alıcı Hesap No Hatalı !", "Havale/ EFT Hatası ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                }
            }


        }

        private void Havale_Load(object sender, EventArgs e)
        {

        }
    }
}
