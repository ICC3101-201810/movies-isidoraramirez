using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ultimo_lab
{
    [Serializable]
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
        public List<string> SeleccionarTodo(string buscar)
        {
            List<string> todo = new List<string>();
            todo.Add(personas.Where(ingresado => ingresado.nombre.ToUpper().Contains(buscar.ToUpper()) || ingresado.apellido.ToUpper().Contains(buscar.ToUpper())).Select(ingresado => ingresado.nombre).ToString());
            todo.Add(peliculas.Where(ingresado => ingresado.nombre.ToUpper().Contains(buscar.ToUpper()) || ingresado.descripcion.ToUpper().Contains(buscar.ToUpper())).Select(ingresado => ingresado.nombre).ToString());
            todo.Add(estudios.Where(ingresado => ingresado.nombre.ToUpper().Contains(buscar.ToUpper()) || ingresado.direccion.ToUpper().Contains(buscar.ToUpper())).Select(ingresado => ingresado.nombre).ToString());
            return todo;
        }
        public List<Persona> SeleccionarProductores()
        {
            List<Persona> prod = new List<Persona>();
            foreach(Persona persona in personas)
            {
                if(persona is Productor)
                {
                    prod.Add(persona);
                }
            }
            return prod;
        }
        public List<Persona> SeleccionarActores()
        {
            List<Persona> act = new List<Persona>();
            foreach (Persona persona in personas)
            {
                if (persona is Productor)
                {
                    act.Add(persona);
                }
            }
            return act;
        }
        public List<Persona> SeleccionarDirectores()
        {
            List<Persona> dir = new List<Persona>();
            foreach (Persona persona in personas)
            {
                if (persona is Productor)
                {
                    dir.Add(persona);
                }
            }
            return dir;
        }
    }
}
 