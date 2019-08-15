using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP
{
    public class Enum2
    {

        InitializeComponent();
    }

  
    enum Sehirler : byte
    {
        İstanbu = 34, İzmir = 35, Ankara = 06, Bursa = 16, Adana = 01
    }

    private void button1_Click(object sender, EventArgs e)
    {
        byte seciliIndex = (byte)Enum.Parse(typeof(Sehirler), listBox1.Text);
        MessageBox.Show("Seçili index= " + seciliIndex);
    }

    private void Form2_Load(object sender, EventArgs e)
    {
        listBox1.Items.AddRange(Enum.GetNames(typeof(Sehirler)));
    }
}
