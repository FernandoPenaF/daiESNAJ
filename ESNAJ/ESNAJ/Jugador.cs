using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESNAJ
{
    class Jugador
    {
        public int id { get; set; }
        public String nombre { get; set; }
        public String correo { get; set; }
        public String contra { get; set; }
        public double puntos { get; set; }
        public int escuela { get; set; }
        public String categoria { get; set; }
        public int torneo;
        public int posicion;

        public Jugador(int id, String nombre, String correo, String contra, double puntos, int escuela, String categoria)
        {
            this.id = id;
            this.nombre = nombre;
            this.correo = correo;
            this.contra = contra;
            this.puntos = puntos;
            this.escuela = escuela;
            this.categoria = categoria;
        }

        public Jugador(int id, String cat, String nombre, double puntos, int escuela, int torneo, int pos)
        {
            this.id = id;
            this.categoria = cat;
            this.nombre = nombre;
            this.escuela = escuela;
            this.torneo = torneo;
            this.posicion = pos;
            this.puntos = puntos;
        }
    }
}
