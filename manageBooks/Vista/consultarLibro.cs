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
    public partial class consultarLibro : Form
    {
        public consultarLibro()
        {
            InitializeComponent();
        }

        BBDDLibros datosLibros = new BBDDLibros();

        private void button1_Click(object sender, EventArgs e)
        {
           List<Libro> todosLosLibros = datosLibros.getAllBooks();


            table.AllowUserToAddRows = true;
            for(int i = 0; i < todosLosLibros.Count; i++)
            {
                DataGridViewRow row = (DataGridViewRow)table.Rows[i].Clone();
                row.Cells[0].Value = todosLosLibros[i].id;
                row.Cells[1].Value = todosLosLibros[i].titulo;
                row.Cells[2].Value = todosLosLibros[i].idioma;
                row.Cells[3].Value = todosLosLibros[i].finalizado;
               // row.Cells[4].Value = todosLosLibros[i].fecha;
                table.Rows.Add(row);
            }

            table.AllowUserToAddRows = false;
        }
    }
}
