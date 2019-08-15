using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        ArrayList dizi = new ArrayList();

        private void button2_Click(object sender, EventArgs e)
        {
         

            dizi.Add("İstanbul");
            dizi.Add("İzmir");
            dizi.Add("Ankara");
            dizi.Add("Bursa");
            dizi.Add("Eskişehir");
            dizi.Add("Edirne");
            dizi.Add("Antalya");
            dizi.Add("İzmir");
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            dizi.Sort();


            
            dizi.Remove("İzmir");

           
            dizi.Reverse();

            
            dizi.TrimToSize();

            
            dizi.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
}
