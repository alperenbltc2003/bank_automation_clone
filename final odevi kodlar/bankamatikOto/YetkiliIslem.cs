using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bankamatikOto
{
    public partial class YetkiliIslem : Form
    {
        public YetkiliIslem()
        {
            InitializeComponent();
        }
          // formalrı baglyoruz
        private void btnCikis_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            this.Close();
            frm.Show();
        }

        private void YetkiliIslem_Load(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            MusteriEkle me = new MusteriEkle();
            me.Show();
            this.Hide();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            MusteriAra ma = new MusteriAra();
            ma.Show();

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            MusteriGuncelle mg = new MusteriGuncelle();
            mg.Show(); 
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            MusteriSil ms = new MusteriSil();
            ms.Show(); 


        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            MusteriListele ml = new MusteriListele();
            ml.Show(); 

        }
    }
}
