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
                    //libro.fecha = dr.GetDateTime(4);

                    todosLosLibros.Add(libro);

                }
            }
               

            

            dr.Close();

            return todosLosLibros;
        }
    }
}
