using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;

namespace Proyecto_final.Models
{
    public class Barrios
    {
        private int _idBarrio;
        private string _barrio;

        public Barrios(int idBarrio, string barrio)
        {
            _idBarrio = idBarrio;
            _barrio = barrio;
        }

        public int IDbarrio
        {
            get
            {
                return _idBarrio;
            }
            set
            {
                _idBarrio = value;
            }
        }
        public string Barrio
        {
            get
            {
                return _barrio;
            }
            set
            {
                _barrio = value;
            }
        }
    }
}