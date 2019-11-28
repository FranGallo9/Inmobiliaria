using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;

namespace Proyecto_final.Models
{
    public class Agentes
    {
        private int _id;
        private string _nombre;
        private string _apellido;
        private string _empresa;

        public Agentes(int id, string nombre, string apellido, string empresa)
        {
            _id = id;
            _nombre = nombre;
            _apellido = apellido;
            _empresa = empresa;
        }

        public int ID
        {
            get
            {
                return _id;
            }
        }

        public string Nombre
        {
            get
            {
                return _nombre;
            }
        }

        public string Apellido
        {
            get
            {
                return _apellido;
            }
        }

        public string Empresa
        {
            get
            {
                return _empresa;
            }
        }
    }
}