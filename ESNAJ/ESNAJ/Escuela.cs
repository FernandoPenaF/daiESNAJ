using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESNAJ
{
    class Escuela
    {
        private int id { get; set; }
        private String nombre { get; set; }

        public Escuela(int id, String nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }
    }
}
