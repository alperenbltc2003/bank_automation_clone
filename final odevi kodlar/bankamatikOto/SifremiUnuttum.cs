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
    public partial class SifremiUnuttum : Form
    {
        public SifremiUnuttum()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(" server= DESKTOP-8FRVC6I\\SQLEXPRESS ; initial catalog= bankamatik2; integrated security = sspi");

        private void button1_Click(object sender, EventArgs e)
        {
            //textbosları baglıyoruz ve buttona basılıdıgnda sqlde degisiklik yapmasını saglıyoruz
            SqlCommand komut = new SqlCommand("update musteriler set sifre=  @p1 where tcNo= @p2 and telefon= @p3  ", con);
            komut.Parameters.AddWithValue("@p1", txtYsifre.Text);
            komut.Parameters.AddWithValue("@p2", txtTcNo.Text);
            komut.Parameters.AddWithValue("@p3", txtTelefon.Text);


            if (txtYsifre.Text.Length < 5)
            {
                //en az 5 karakter  baglıuouz
                MessageBox.Show("Lütfen yeni şifreniz en az 5 karakter uzunluğunda olsun!", "Şifre Değiştirme Hatası ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                con.Open();
                //basalı ise basarlı mesajı verıoyruz balarısız ise tc no veya telefon numarası hatası mesajı verıyoruz
                int sonuc = komut.ExecuteNonQuery();
                con.Close();
                if (sonuc == 1)
                {
                    MessageBox.Show("Yeni Şifreniz üretilmiştir ", "Şifre üretme işlemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                else
                    MessageBox.Show("TcNo/Telefon No uyuşmadı !", "Şifre üretme hatası ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }


        }

        private void SifremiUnuttum_Load(object sender, EventArgs e)
        {

        }
    }
}
