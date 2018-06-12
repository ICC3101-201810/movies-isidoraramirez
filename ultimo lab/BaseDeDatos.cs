using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ultimo_lab
{
    public class BaseDeDatos
    {
        public List<Persona> personas;
        public List<Pelicula> peliculas;
        public List<PeliculaActor> peliculasactores;
        public List<PeliculaProductor> peliculasproductores;
        public List<Estudio> estudios;

        public BaseDeDatos()
        {
            personas = new List<Persona>();
            peliculas = new List<Pelicula>();
            peliculasactores = new List<PeliculaActor>();
            peliculasproductores = new List<PeliculaProductor>();
            estudios = new List<Estudio>();
        }
        public void Seleccionar()
        {
            List<object> todo = new List<object>();
            IEnumerable<object> todos = 
                from cosa in (this.personas , this.peliculas, this.peliculasactores, this.peliculasproductores, this.estudios)
            for (int i = 0; i < 50; i++)
            {
                todo.Add(from personas );

            }
        }
    }
}
