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
        public void getAllBooks()
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\leons\\OneDrive\\Bureau\\gestionarLibrosApp2\\manageBooks\\manageBooks\\Database.mdf;Integrated Security=True");
            SqlCommand cmd;
            SqlDataReader dr;

            con.Open();
            String sintax = "SELECT Titulo FROM Libros WHERE Id = 1";
            cmd = new SqlCommand(sintax, con);
            dr = cmd.ExecuteReader();
            dr.Read();

            MessageBox.Show("" + dr.GetString(0));

            dr.Close();

        }
    }
}
