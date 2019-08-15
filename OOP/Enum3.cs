using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP
{
    public class Enum3
    {
        InitializeComponent();
    }

    enum Sehirler
    {
        İstanbul = 34,
        Ankara = 6,
        Adana = 1,
        Karabük = 78,
        Ordu = 52,
        Antalya = 7
    }



    private void button1_Click(object sender, EventArgs e)
    {
        int enumDegeri = int.Parse(textBox1.Text);
        Sehirler secilenSehir = (Sehirler)enumDegeri;
        MessageBox.Show(secilenSehir.ToString());
    }

    private void Form3_Load(object sender, EventArgs e)
    {
        foreach (var item in Enum.GetNames(typeof(Sehirler)))
        {
            listBox1.Items.Add(item + " - " + Convert.ToInt32(Enum.Parse(typeof(Sehirler), item)));
        }
    }

    private void button2_Click(object sender, EventArgs e)
    {
        //Enum içeriisnde var olan değerin kontorlünü sağlamak için "isDefined" metodu kullanılır.

        int enumDegeri = int.Parse(textBox1.Text);

        if (Enum.IsDefined(typeof(Sehirler), enumDegeri))
        {
            Sehirler secilenSehir = (Sehirler)enumDegeri;
            MessageBox.Show(secilenSehir.ToString());
        }
        else
        {
            MessageBox.Show("Gİrdiğiniz index numarasıa iat bir şehir bulunmamktadır");
        }
    }
}
}
