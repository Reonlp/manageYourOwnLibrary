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
            String finalizado = "";
            table.Rows.Clear();

            table.AllowUserToAddRows = true;

            for(int i = 0; i < todosLosLibros.Count; i++)
            {
                DataGridViewRow row = (DataGridViewRow)table.Rows[i].Clone();
                row.Cells[0].Value = todosLosLibros[i].id;
                row.Cells[1].Value = todosLosLibros[i].titulo;
                row.Cells[2].Value = todosLosLibros[i].idioma;
                if (todosLosLibros[i].finalizado)
                {
                    finalizado = "Sí";
                }
                else
                {
                    finalizado = "No";
                }
                row.Cells[3].Value = finalizado;
                row.Cells[4].Value = todosLosLibros[i].fecha;
                table.Rows.Add(row);
            }

            table.AllowUserToAddRows = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String idioma = comboBox1.Text;
            String finalizado = "";
            List<Libro> librosPorIdioma = datosLibros.mostrarPorIdioma(idioma);

            table.Rows.Clear();

            table.AllowUserToAddRows = true;

            for (int i = 0; i < librosPorIdioma.Count; i++)
            {
                DataGridViewRow row = (DataGridViewRow)table.Rows[i].Clone();
                row.Cells[0].Value = librosPorIdioma[i].id;
                row.Cells[1].Value = librosPorIdioma[i].titulo;
                row.Cells[2].Value = librosPorIdioma[i].idioma;
                if (librosPorIdioma[i].finalizado)
                {
                    finalizado = "Sí";
                } else
                {
                    finalizado = "No";
                }
                row.Cells[3].Value = finalizado;
                row.Cells[4].Value = librosPorIdioma[i].fecha;
                table.Rows.Add(row);
            }

            table.AllowUserToAddRows = false;

        }

        private void rbSi_CheckedChanged(object sender, EventArgs e)
        {
            String acabado = "";
            List<Libro> finalizados = new List<Libro>();
            String finalizado = "";
            if (rbSi.Checked)
            {
                acabado = "True";
                finalizados = datosLibros.mostrarPorFinalizados(acabado);
                table.Rows.Clear();

                table.AllowUserToAddRows = true;

                for (int i = 0; i < finalizados.Count; i++)
                {
                    DataGridViewRow row = (DataGridViewRow)table.Rows[i].Clone();
                    row.Cells[0].Value = finalizados[i].id;
                    row.Cells[1].Value = finalizados[i].titulo;
                    row.Cells[2].Value = finalizados[i].idioma;
                    if (finalizados[i].finalizado)
                    {
                        finalizado = "Sí";
                    }
                    else
                    {
                        finalizado = "No";
                    }
                    row.Cells[3].Value = finalizado;
                    row.Cells[4].Value = finalizados[i].fecha;
                    table.Rows.Add(row);
                }

                table.AllowUserToAddRows = false;
            }
            else if (rbNo.Checked)
            {
                acabado = "False";
                finalizados = datosLibros.mostrarPorFinalizados(acabado);
                table.Rows.Clear();

                table.AllowUserToAddRows = true;

                for (int i = 0; i < finalizados.Count; i++)
                {
                    DataGridViewRow row = (DataGridViewRow)table.Rows[i].Clone();
                    row.Cells[0].Value = finalizados[i].id;
                    row.Cells[1].Value = finalizados[i].titulo;
                    row.Cells[2].Value = finalizados[i].idioma;
                    if (finalizados[i].finalizado)
                    {
                        finalizado = "Sí";
                    }
                    else
                    {
                        finalizado = "No";
                    }
                    row.Cells[3].Value = finalizado;
                    row.Cells[4].Value = finalizados[i].fecha;
                    table.Rows.Add(row);
                }

                table.AllowUserToAddRows = false;
            }
        }
    }
}
