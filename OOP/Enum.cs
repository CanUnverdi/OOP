using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP
{
    public class Enum
    {
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Personel p = new Personel();
            p.AdSoyad = txtAd.Text;
            p.Departmanlar = (Departmanlar)Enum.Parse(typeof(Departmanlar), cmbDepartmanlar.Text);

            int seciliEnumIndexi = (int)Enum.Parse(typeof(Departmanlar), cmbDepartmanlar.Text);
            MessageBox.Show("Seçilen Departmanın Nosu: " + seciliEnumIndexi);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
            cmbDepartmanlar.Items.AddRange(Enum.GetNames(typeof(Departmanlar)));
          
            cmbDepartmanlar.SelectedIndex = 0;
        }
}
