using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;


namespace Proyecto_final.Models
{
    public class Tipos
    {
        private int _id;
        private string _tipo;

        public Tipos(int id, string tipo)
        {
            _id = id;
            _tipo = tipo;
        }

        public int ID
        {
            get
            {
                return _id;
            }
        }

        public string Tipo
        {
            get
            {
                return _tipo;
            }
        }
    }
}