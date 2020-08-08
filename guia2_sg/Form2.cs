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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double X1, X2, X3, X4, R, RR;
            X1 = Convert.ToDouble(TXTX1.Text);
            TXTX1.Focus();
            X2 = Convert.ToDouble(TXTX2.Text);
            TXTX2.Focus();
            X3 = Convert.ToDouble(TXTX3.Text);
            TXTX3.Focus();
            X4 = Convert.ToDouble(TXTX4.Text);
            TXTX4.Focus();
            R = (X1 + X2 + X3 + X4) / 4;
            RR = Math.Sqrt(((Math.Pow(X1 - R,2))+ (Math.Pow(X2 - R, 2))+ (Math.Pow(X3 - R, 2))+ (Math.Pow(X4 - R, 2)))/4);

            RESPUESTA.Text = RR.ToString();

        }
    }
}
