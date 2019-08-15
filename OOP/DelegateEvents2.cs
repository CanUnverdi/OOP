using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Araba araba = new Araba(70, "BMW");
            araba.HizAsimi += new HizAsimiEventHandler(HizLimiti);

            for (int i = 0; i < 7; i++)
            {
                araba.Hiz += 10; 
                listBox1.Items.Add("Arabanın şuanki hızı: " + araba.Hiz);
            }
        }

        public void HizLimiti()
        {
            listBox1.Items.Add("Araç hız limiyini aştı");
        }

        private void Form2_Load(object sender, EventArgs e)
        {
    }
}
