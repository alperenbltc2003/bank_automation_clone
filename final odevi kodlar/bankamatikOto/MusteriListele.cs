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
    public partial class MusteriListele : Form
    {
        public MusteriListele()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(" server= DESKTOP-8FRVC6I\\SQLEXPRESS ; initial catalog= bankamatik2; integrated security = sspi");

        private void MusteriListele_Load(object sender, EventArgs e)
        {
            //musteri bilgilerini sqlden cekıyoruz ve tabloya gosteriyoruz
            SqlDataAdapter dr = new SqlDataAdapter(" select ID as 'NO/ID', tcNo as 'TC.NO', adSoyad as 'AD-SOYAD', adres as 'ADRES', telefon as 'TELEFON', bakiye as 'BAKİYE', durum as 'DURUM' from Musteriler ", con);
            DataTable tablo = new DataTable();
            dr.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //textboxa musterinin adini yazıp sadece onun bilgilerini getiriyoruz
            SqlDataAdapter dr = new SqlDataAdapter(" select ID as 'NO/ID', tcNo as 'TC.NO', adSoyad as 'AD-SOYAD', adres as 'ADRES', telefon as 'TELEFON', bakiye as 'BAKİYE', durum as 'DURUM' from Musteriler where adSoyad like  '"+textBox1.Text+"%'", con);
            DataTable tablo = new DataTable();
            dr.Fill(tablo);
            dataGridView1.DataSource = tablo;


        }
    }
}
