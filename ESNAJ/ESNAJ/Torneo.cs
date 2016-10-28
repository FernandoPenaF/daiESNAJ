using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESNAJ
{
    class Torneo
    {
        public String nombre;
        public int ID;
        public String fecha;
        public int idEscuela;

        public Torneo(int id, String nombre, String fecha, int idEscuela)
        {
            this.nombre = nombre;
            this.ID = id;
            this.fecha = fecha;
            this.idEscuela = idEscuela;

        }
    }
}
