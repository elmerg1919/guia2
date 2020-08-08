using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace guia2_sg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 DESVIACION = new Form2();
            DESVIACION.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num;
            num = Convert.ToInt32(textBox1.Text);


            int i, x1 = 1, x2 = 1, x3 = 0;
            listBox1.Items.Add(x1);
            listBox1.Items.Add(x2);
           // do
           // {
                //abre el ciclo y lo repite la cantidad de veces solicitada por el usuario

                for (i = 3; i <= num; i++)
                {
                    x3 = x1 + x2;
                    listBox1.Items.Add(x3);
                    x1 = x2;
                    x2 = x3;

                    //if(i==num)
                    //{
                    //    break;
                    //}


                }
              
         //   }

          //  while ("");
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
