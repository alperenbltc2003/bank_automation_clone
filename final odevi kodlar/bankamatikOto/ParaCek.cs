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
    public partial class ParaCek : Form
    {
        public ParaCek()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(" server= DESKTOP-8FRVC6I\\SQLEXPRESS ; initial catalog= bankamatik2; integrated security = sspi");

        private void button1_Click(object sender, EventArgs e)
        {
            float sayi = float.Parse(maskedTextBox1.Text);
            // para cekılıcek mıktar bakıyeden fazla ise hata mesajı verıyoruz
            if (sayi > Form1.bakiye)
            {
                MessageBox.Show("Yetersiz Bakiye", "Pare Çekme İşlemi");
            }
            else
            {
                //cekılıcek paranın en az 10 tl olmasını belırlıyoruz ve bakıyeden girilen miktarı sılmesını saglıyoruz
               
                SqlCommand komut = new SqlCommand("update musteriler set bakiye= bakiye -  @p1 where ID= @p2  ", con);
                komut.Parameters.AddWithValue("@p1", sayi);
                komut.Parameters.AddWithValue("@p2", Form1.msID);

                if ( sayi <10 )
                {
                    MessageBox.Show("Lütfen 10 TL ve üzeri giriniz !", "Eksik Kayıt Hatası ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    con.Open();

                    komut.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Para çekme işlemi gerçekleştirildi ", "Para Çekme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form1.bakiye -= sayi;

                   


                }
            }






        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ParaCek_Load(object sender, EventArgs e)
        {

        }
    }
}
