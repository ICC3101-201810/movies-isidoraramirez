using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ultimo_lab
{
    [Serializable]
    public class Pelicula
    {
        public string nombre, fecha, descripcion;
        public int presupuesto;
        public Estudio estudio;
        public Persona director;
        public Pelicula(string nombre, Persona director, string fecha, string descripcion, int presupuesto, Estudio estudio)
        {
            this.nombre = nombre;
            this.director = director;
            this.fecha = fecha;
            this.descripcion = descripcion;
            this.presupuesto = presupuesto;
            this.estudio = estudio;
        }

    }
}
