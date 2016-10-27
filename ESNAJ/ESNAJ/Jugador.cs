using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESNAJ
{
    class Jugador
    {
        private int id {get; set;}
        private int puntos { get; set; }
        private String escuela { get; set; }
        private String nombre { get; set; }
        private String trofeos { get; set; }
        private String categoria { get; set; }
        private String torneos { get; set; }

        public Jugador(int id, int puntos, String escuela, String nombre, String trofeos, String categoria, String torneos)
        {
            this.id = id;
            this.puntos = puntos;
            this.escuela = escuela;
            this.nombre = nombre;
            this.trofeos = trofeos;
            this.categoria = categoria;
            this.torneos = torneos;
        }

        public Jugador(int id, String cat, String nombre, String escuela)
        {
            this.id = id;
            this.categoria = cat;
            this.nombre = nombre;
            this.escuela = escuela;
        }

    }
}
