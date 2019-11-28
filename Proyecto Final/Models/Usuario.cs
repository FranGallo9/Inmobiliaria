using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;

namespace Proyecto_final.Models
{
    public class Usuario
    {
        private int _id;
        private string _nombreDeUsuario;
        private string _nombre;
        private string _apellido;
        private string _contraseña;

        public Usuario(int id, string nombreDeUsuario, string nombre, string apellido, string contraseña)
        {
            _id = id;
            _nombreDeUsuario = nombreDeUsuario;
            _nombre = nombre;
            _apellido = apellido;
            _contraseña = contraseña;
        }
        public Usuario() { }
        public int ID
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }

        public string NombreDeUsuario
        {
            get
            {
                return _nombreDeUsuario;
            }
            set
            {
                _nombreDeUsuario = value;
            }
        }

        public string Nombre
        {
            get
            {
                return _nombre;
            }
            set
            {
                _nombre = value;
            }
        }

        public string Apellido
        {
            get
            {
                return _apellido;
            }
            set
            {
                _apellido = value;
            }
        }


        public string Contraseña
        {
            get
            {
                return _contraseña;
            }
            set
            {
                _contraseña = value;
            }
        }
    }
}