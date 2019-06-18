using manageBooks.Controlador;
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
    public partial class actualizar : Form
    {
        private _2OptionDialog formDialog = null;
        public actualizar(Form callingForm)
        {
            InitializeComponent();
            formDialog = callingForm as _2OptionDialog;
        }

        int id = 0;
        BBDDLibros datos = new BBDDLibros();
        

        private void actualizar_Load(object sender, EventArgs e)
        {
            id = this.formDialog.enviarId;
            Libro libro = datos.mostrarPorId(id);
            txtId.Text = libro.id.ToString();
            txtTitulo.Text = libro.titulo;
            txtIdioma.Text = libro.idioma;
            txtFinalizado.Text = libro.finalizado.ToString();
            txtFecha.Text = libro.fecha.ToString();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Boolean finalizado = false;
            String titulo = txtTitulo.Text;
            String idioma = txtIdioma.Text;
            if (txtFinalizado.Text.Equals("true"))
            {
                finalizado = true;
            }  else
            {
                finalizado = false;
            }
            DateTime fecha = DateTime.Parse(txtFecha.Text);
            datos.actualizarLibro(id, titulo, idioma, finalizado, fecha);
        }
    }
}
