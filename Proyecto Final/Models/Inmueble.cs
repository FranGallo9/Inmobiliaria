using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;

namespace Proyecto_final.Models
{
    public class Inmueble
    {
        private int _precio;
        private int _id;
        private int _superficie;
        private int _ambientes;
        private bool _patio;
        private bool _terraza;
        private string _direccion;
        private int _baños;
        private int _habitaciones;
        private string _imagen;


        public Inmueble() { }

        public Inmueble(int precio, int id, int superficie, int ambientes, bool patio, bool terraza, string direccion, int baños, int habitaciones, string imagen)
        {
            _precio = precio;
            _id = id;
            _superficie = superficie;
            _ambientes = ambientes;
            _patio = patio;
            _terraza = terraza;
            _direccion = direccion;
            _baños = baños;
            _habitaciones = habitaciones;
            _imagen = imagen;
        }

        public int Precio
        {
            get
            {
                return _precio;
            }
            set
            {
                _precio = value;
            }
        }

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



        public int Superficie
        {
            get
            {
                return _superficie;
            }
            set
            {
                _superficie = value;
            }
        }

        public int Ambientes
        {
            get
            {
                return _ambientes;
            }
            set
            {
                _ambientes = value;
            }
        }

        public bool Patio
        {
            get
            {
                return _patio;
            }
            set
            {
                _patio = value;
            }
        }

        public bool Terraza
        {
            get
            {
                return _terraza;
            }
            set
            {
                _terraza = value;
            }
        }


        public string Direccion
        {
            get
            {
                return _direccion;
            }
            set
            {
                _direccion = value;
            }
        }

        public int Baños
        {
            get
            {
                return _baños;
            }
            set
            {
                _baños = value;
            }
        }

        public int Habitaciones
        {
            get
            {
                return _habitaciones;
            }
            set
            {
                _habitaciones = value;
            }
        }

        public string Imagen
        {
            get
            {
                return _imagen;
            }
            set
            {
                _imagen = value;
            }
        }
    }
}