using manageBooks.Controlador;
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
    public partial class _2OptionDialog : Form
    {
        //This is one way of having access from one form to the data of another
        //A channel of comunication
        private consultarLibro mainForm = null;
        BBDDLibros datos = new BBDDLibros();

        //Constructor of the panel I created. In c# .net we don't have the kind of optionPanes
        //we had in Java, so one way of getting the same result is creating your own panels.
        //This panel allows me to create multiple personalized passing different strings as
        //parameters.
        public _2OptionDialog(String mensaje, String boton1, String boton2, Form callingForm)
        {
            InitializeComponent();
            lbMensaje.Text = mensaje;
            bt1.Text = boton1;
            bt2.Text = boton2;
            mainForm = callingForm as consultarLibro;
            
            
        }

        int id = 0;
        public int enviarId
        {
            get { return id; }
            set { id = value; }
        }


        private void _2OptionDialog_Load(object sender, EventArgs e)
        {
           
        }

        //Yes option
        private void bt1_Click(object sender, EventArgs e)
        {


            id = this.mainForm.borrarPorId;
            actualizar actualizarLibro = new actualizar(this);
            actualizarLibro.Show();
            this.Close();
            
        }

        //No option
        private void bt2_Click(object sender, EventArgs e)
        {
            id = this.mainForm.borrarPorId;
            datos.borrarLibro(id);
            this.Close();
        }

       

       
    }
}
