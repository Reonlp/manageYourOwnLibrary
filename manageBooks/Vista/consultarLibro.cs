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
            int anioActual = DateTime.Now.Year;
            for(int i = 2005; i <= anioActual; i++)
            {
                cmbAnio.Items.Add(i.ToString());
            }
            
        }

        BBDDLibros datosLibros = new BBDDLibros();

        private int _idBorrar = 0;

        public int borrarPorId
        {
            get { return _idBorrar; }
            set { _idBorrar = value; }
        }


        private void button1_Click(object sender, EventArgs e)
        {
           List<Libro> todosLosLibros = datosLibros.getAllBooks();
            int numeroDeLibros = todosLosLibros.Count;
            int librosAcabados = 0;
            int librosSinAcabar = 0;
            int librosJapones = 0;
            int librosEspanol = 0;
            int librosIngles = 0;
            int librosFrances = 0;

            String finalizado = "";
            table.Rows.Clear();

            table.AllowUserToAddRows = true;

            for(int i = 0; i < todosLosLibros.Count; i++)
            {
                DataGridViewRow row = (DataGridViewRow)table.Rows[i].Clone();
                row.Cells[0].Value = todosLosLibros[i].id;
                row.Cells[1].Value = todosLosLibros[i].titulo;
                row.Cells[2].Value = todosLosLibros[i].idioma;
               
                if(todosLosLibros[i].idioma.Trim().Equals("Español"))
                {
                    librosEspanol++;
            
                } else if (todosLosLibros[i].idioma.Trim().Equals("Japonés"))
                {
                    librosJapones++;
                }
                else if(todosLosLibros[i].idioma.Trim().Equals("Inglés"))
                {
                    librosIngles++;
                }
                else if (todosLosLibros[i].idioma.Trim().Equals("Francés"))
                {
                    librosFrances++;
                }

                if (todosLosLibros[i].finalizado)
                {
                    finalizado = "Sí";
                    librosAcabados++;
                }
                else
                {
                    finalizado = "No";
                    librosSinAcabar++;
                }
                row.Cells[3].Value = finalizado;
                row.Cells[4].Value = todosLosLibros[i].fecha;
                
                table.Rows.Add(row);
            }

            table.AllowUserToAddRows = false;

            lbTotal.Text = numeroDeLibros.ToString() + " libros";
            lbAcabados.Text = librosAcabados.ToString() + " (leídos)";
            lbSinAcabar.Text = librosSinAcabar.ToString() + " (no terminados)";
            lbEspanol.Text = librosEspanol.ToString() + " (español)";
            lbIngles.Text = librosIngles.ToString() + " (inglés)";
            lbJapones.Text = librosJapones.ToString() + " (japonés)";
            lbFrances.Text = librosFrances.ToString() + " (francés)";
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

        private void table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = this.table.Rows[e.RowIndex];
                borrarPorId = (int) row.Cells[0].Value;
                
                _2OptionDialog dialogo = new _2OptionDialog("Elija una opcion", "Actualizar", "Borrar", this);
                dialogo.Show();

           

             
            }           
        }

        private void cmbAnio_SelectedIndexChanged(object sender, EventArgs e)
        {
         
            String finalizado = "";
            List<Libro> todosLosLibros = datosLibros.getAllBooks();
            List<Libro> librosPorAnio = new List<Libro>();
            int anio = Int32.Parse(cmbAnio.Text);
            int numeroDeLibros = 0;
            int librosAcabados = 0;
            int librosSinAcabar = 0;
            int librosJapones = 0;
            int librosEspanol = 0;
            int librosIngles = 0;
            int librosFrances = 0;



            for(int p = 0; p < todosLosLibros.Count; p++)
            {
                if(todosLosLibros[p].fecha.Year == anio)
                {
                    librosPorAnio.Add(todosLosLibros[p]);
                    
                }
            }

            numeroDeLibros = librosPorAnio.Count;


            table.AllowUserToAddRows = true;

            for (int i = 0; i < librosPorAnio.Count; i++)
            {
              
                    DataGridViewRow row = (DataGridViewRow)table.Rows[i].Clone();


                    row.Cells[0].Value = librosPorAnio[i].id;
                    row.Cells[1].Value = librosPorAnio[i].titulo;
                    row.Cells[2].Value = librosPorAnio[i].idioma;
                    if (librosPorAnio[i].idioma.Trim().Equals("Español"))
                    {
                        librosEspanol++;

                    }
                    else if (librosPorAnio[i].idioma.Trim().Equals("Japonés"))
                    {
                        librosJapones++;
                    }
                    else if (librosPorAnio[i].idioma.Trim().Equals("Inglés"))
                    {
                        librosIngles++;
                    }
                    else if (librosPorAnio[i].idioma.Trim().Equals("Francés"))
                    {
                        librosFrances++;
                    }

                if (librosPorAnio[i].finalizado)
                    {
                        finalizado = "Sí";
                        librosAcabados++;
                    }
                    else
                    {
                        finalizado = "No";
                        librosSinAcabar++;
                    }
                    row.Cells[3].Value = finalizado;
                    row.Cells[4].Value = librosPorAnio[i].fecha;
                    table.Rows.Add(row);

            }

            table.AllowUserToAddRows = false;

            lbInfoAnio.Text = "Año " + anio.ToString() + ": " + numeroDeLibros + " libros leídos.    " + librosEspanol + " (español) " + librosIngles + " (inglés) " + librosJapones + " (japonés) " + librosFrances + " (francés)";
        }
    }
}
