using manageBooks.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace manageBooks.Controlador
{
    class BBDDLibros
    {
        public List<Libro> getAllBooks()
        {
            List<Libro> todosLosLibros = new List<Libro>();
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\leons\\OneDrive\\Bureau\\gestionarLibrosApp2\\manageBooks\\manageBooks\\Database.mdf;Integrated Security=True");
            SqlCommand cmd;
            SqlDataReader dr;

            con.Open();
            String sintax = "SELECT * FROM Libros";
            cmd = new SqlCommand(sintax, con);
            using (dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    Libro libro = new Libro();
                    libro.id = dr.GetInt32(0);
                    libro.titulo = dr.GetString(1);
                    libro.idioma = dr.GetString(2);
                    libro.finalizado = dr.GetBoolean(3);
                    libro.fecha = dr.GetDateTime(4);

                    todosLosLibros.Add(libro);

                }
            }
               

            

            dr.Close();

            return todosLosLibros;
        }

        public List<Libro> mostrarPorIdioma(String idioma)
        {
            List<Libro> librosPorIdioma = new List<Libro>();
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\leons\\OneDrive\\Bureau\\gestionarLibrosApp2\\manageBooks\\manageBooks\\Database.mdf;Integrated Security=True");
            SqlCommand cmd;
            SqlDataReader dr;

            con.Open();
            String sintax = "SELECT * FROM Libros WHERE Idioma = " + "'" + idioma + "'";
            cmd = new SqlCommand(sintax, con);
            using (dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    Libro libro = new Libro();
                    libro.id = dr.GetInt32(0);
                    libro.titulo = dr.GetString(1);
                    libro.idioma = dr.GetString(2);
                    libro.finalizado = dr.GetBoolean(3);
                    libro.fecha = dr.GetDateTime(4);

                    librosPorIdioma.Add(libro);

                }
            }

            return librosPorIdioma;
        }

        public List<Libro> mostrarPorFinalizados(String acabado)
        {
            List<Libro> librosFinalizados = new List<Libro>();
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\leons\\OneDrive\\Bureau\\gestionarLibrosApp2\\manageBooks\\manageBooks\\Database.mdf;Integrated Security=True");
            SqlCommand cmd;
            SqlDataReader dr;

            con.Open();
            String sintax = "SELECT * FROM Libros WHERE Finalizado = " + "'" + acabado + "'";
            cmd = new SqlCommand(sintax, con);
            using (dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    Libro libro = new Libro();
                    libro.id = dr.GetInt32(0);
                    libro.titulo = dr.GetString(1);
                    libro.idioma = dr.GetString(2);
                    libro.finalizado = dr.GetBoolean(3);
                    libro.fecha = dr.GetDateTime(4);

                    librosFinalizados.Add(libro);

                }
            }

            return librosFinalizados;
        }

        public List<Libro> mostrarPor()
        {
            List<Libro> todosLosLibros = new List<Libro>();
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\leons\\OneDrive\\Bureau\\gestionarLibrosApp2\\manageBooks\\manageBooks\\Database.mdf;Integrated Security=True");
            SqlCommand cmd;
            SqlDataReader dr;

            con.Open();
            String sintax = "SELECT * FROM Libros";
            cmd = new SqlCommand(sintax, con);
            using (dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    Libro libro = new Libro();
                    libro.id = dr.GetInt32(0);
                    libro.titulo = dr.GetString(1);
                    libro.idioma = dr.GetString(2);
                    libro.finalizado = dr.GetBoolean(3);
                    libro.fecha = dr.GetDateTime(4);

                    todosLosLibros.Add(libro);

                }
            }




            dr.Close();

            return todosLosLibros;
        }

        public void insertarLibro(Libro libro)
        {
            String sintax = "";
            try
            {
                SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\leons\\OneDrive\\Bureau\\gestionarLibrosApp2\\manageBooks\\manageBooks\\Database.mdf;Integrated Security=True");
                SqlCommand cmd;
                //SqlDataReader dr;

                con.Open();
                if(libro.finalizado == true)
                {
                    sintax = "INSERT INTO Libros (Titulo, Idioma, Finalizado, Fecha) VALUES ('" + libro.titulo + "', '" + libro.idioma + "', '" + libro.finalizado + "', '" + libro.fecha + "');";
                } else
                {
                    sintax = "INSERT INTO Libros (Titulo, Idioma, Finalizado, Fecha) VALUES ('" + libro.titulo + "', '" + libro.idioma + "', '" + libro.finalizado + "', '" + DateTime.MinValue + "');";
                }
                
                cmd = new SqlCommand(sintax, con);
                int result = cmd.ExecuteNonQuery();

                con.Close();

                if (result == 1)
                {
                    MessageBox.Show("Libro añadido con éxito");
                }
                else
                {
                    MessageBox.Show("Se ha producido un error");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Se ha producido un error");
            }

        }
    }
}
