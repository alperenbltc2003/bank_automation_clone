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
    public partial class ParaYatir : Form
    {
        public ParaYatir()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(" server= DESKTOP-8FRVC6I\\SQLEXPRESS ; initial catalog= bankamatik2; integrated security = sspi");

        private void button1_Click(object sender, EventArgs e)
        {

            float sayi = float.Parse(maskedTextBox1.Text);

            SqlCommand komut = new SqlCommand("update musteriler set bakiye= bakiye +  @p1 where ID= @p2  ", con);
            komut.Parameters.AddWithValue("@p1", sayi);
            komut.Parameters.AddWithValue("@p2", Form1.msID);
            //10tl uzerı para yatırmasını soyluyoruz
            if (sayi < 10)
            {
                MessageBox.Show("Lütfen 10 TL ve üzeri giriniz !", "Eksik Kayıt Hatası ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //girilen sayının bakiyeeye eklenmesını saglıyoruz
                con.Open();

                komut.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Para yatırma işlemi gerçekleştirildi ", "Para Yatırma", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form1.bakiye += sayi;
                

            }
        }

        private void ParaYatir_Load(object sender, EventArgs e)
        {

        }
    }
}
