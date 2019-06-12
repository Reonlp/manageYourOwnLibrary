using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manageBooks.Modelo
{
    class Libro
    {
        private int _id;
        private String _titulo;
        private String _idioma;
        private Boolean _finalizado;
        private DateTime _fecha;


        public Libro()
        {
          
            _titulo = "";
            _idioma = "";
            _finalizado = false;
            _fecha = new DateTime();
        }

        public int id
        {
            get { return _id; }
            set { _id = value; }
        }

        public String titulo
        {
            get { return _titulo; }
            set { _titulo = value; }
        }


        public String idioma
        {
            get { return _idioma; }
            set { _idioma = value; }
        }

        public Boolean finalizado
        {
            get { return _finalizado; }
            set { _finalizado = value; }
        }

        public DateTime fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }
    }
}
