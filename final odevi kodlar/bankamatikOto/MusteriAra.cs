using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; 

namespace bankamatikOto
{
    public partial class MusteriAra : Form
    {
        public MusteriAra()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(" server= DESKTOP-8FRVC6I\\SQLEXPRESS ; initial catalog= bankamatik2; integrated security = sspi");


        private void button1_Click(object sender, EventArgs e)
        {
            //textboxlara gereken bilgileri ontrol etmesini için form 1 deki parametlerı sqlden baglayıp tc girildigi diğer bilgileri girmesini saglıyoruz eger hata varsa hata mesajı verdiriyoruz
            SqlCommand komut = new SqlCommand("select * from  musteriler where ID= @p1 or tcNo= @p2  ", con);
            komut.Parameters.AddWithValue("@p1", mtxtID.Text);
            komut.Parameters.AddWithValue("@p2", mtxtID.Text);


            con.Open(); 
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                txtID.Text = dr["ID"].ToString();
                txtTc.Text = dr["tcNo"].ToString();
                txtAdS.Text = dr["adSoyad"].ToString();
                txtAdr.Text = dr["adres"].ToString();
                mtxtTel.Text = dr["telefon"].ToString();
                txtDurum.Text = dr["durum"].ToString();

                txtBakiye.Text = dr["bakiye"].ToString();
            }
            else
            {
                MessageBox.Show(mtxtID.Text + " Numaralı Kayıt Bulunamadı !", "Kayıt Arama", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mtxtID.Text = "";
                txtTc.Text = "";
                txtAdr.Text = "";
                txtAdS.Text = "";
                txtBakiye.Text = "";
                txtDurum.Text = "";

                mtxtTel.Text = "";
                txtID.Text = ""; 

            }
            con.Close();  
        }

        private void MusteriAra_Load(object sender, EventArgs e)
        {

        }
    }
}
