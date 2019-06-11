using manageBooks.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace manageBooks.Vista
{
    public partial class agregarLibro : Form
    {
        public agregarLibro()
        {
            InitializeComponent();
        }

        private void agregarLibro_Load(object sender, EventArgs e)
        {
            dtpFecha.Enabled = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Boolean acabado = false;
            
            if (rbSi.Checked)
            {
                acabado = true;
                dtpFecha.Enabled = true;
            }
            else if (rbNo.Checked)
            {
                acabado = false;
            };


            Libro libro = new Libro();
            libro.titulo = txtTitulo.Text;
            libro.idioma = cmbIdioma.Text;
            libro.finalizado = acabado;
            libro.fecha = dtpFecha.Value;

        }

        private void rbSi_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSi.Checked)
            {
                dtpFecha.Enabled = true;
            } else if (rbNo.Checked)
            {
                dtpFecha.Enabled = false;
            }
        }
    }
}
