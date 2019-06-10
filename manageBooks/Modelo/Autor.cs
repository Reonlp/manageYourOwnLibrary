using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manageBooks.Modelo
{
    class Autor
    {
        private int _id;
        private String _nombre;
        private DateTime _nacimiento;
        private String _pais;

        public int id
        {
            get { return _id; }
            set { _id = value; }
        }

        public String nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public String pais
        {
            get { return _pais; }
            set { _pais = value; }
        }

        public DateTime nacimiento
        {
            get { return _nacimiento; }
            set { _nacimiento = value; }
        }
    }
}
