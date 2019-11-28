using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;

namespace Proyecto_final.Models
{
    public class BusquedaXD
    {
        private int _precioMax;
        private int _ambientes;
        private bool _patio;
        private bool _terraza;


        public BusquedaXD(int precioMax, int ambientes, bool patio, bool terraza)
        {
            _precioMax = precioMax;
            _ambientes = ambientes;
            _patio = patio;
            _terraza = terraza;
        }

        public BusquedaXD()
        {

        }

        public int PrecioMax
        {
            get
            {
                return _precioMax;
            }
            set
            {
                _precioMax = value;
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
    }
}