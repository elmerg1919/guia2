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
    public partial class ejercicio_1_g3 : Form
    {
        int i=1;
        int cell;
        public ejercicio_1_g3()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            String nom;
            nom = txtdato.Text;
            //solicita y agrega los datos
            dataGridView1.Rows.Add(i + "", nom);
            //bloque los botones eliminar y modificar
            btneliminar.Enabled = false;
            btnmodificar.Enabled=false;
            txtdato.Focus();

            i =i + 1;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //selecciona la celda enviando el dato a modificar al texbox
            cell = dataGridView1.CurrentRow.Index;
            txtdato.Text = dataGridView1[1, cell].Value.ToString();
            //desbloquea los botones eliminar y modificar
            btneliminar.Enabled = true;
            btnmodificar.Enabled = true;
            btnAgregar.Enabled = false;
                



        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {//remplaza el dato seleccionado
            String nom;
            nom = txtdato.Text;

            dataGridView1[1, cell].Value = txtdato.Text;
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            //elimina el dato seleccionado
            dataGridView1.Rows.RemoveAt(cell);
            
        }

        private void Reiniciar(object sender, EventArgs e)
        {
            //restablece el uso de los botones 
            btneliminar.Enabled = true;
            btnmodificar.Enabled = true;
            btnAgregar.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //aqui si quieren usar el boton para ir al siguiente ejercicio, buenas noches.
        }
    }
}
