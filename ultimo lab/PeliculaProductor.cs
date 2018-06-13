using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ultimo_lab
{
    [Serializable]
    public class PeliculaProductor
    {
        public string pelicula;
        public Productor productor;

        public PeliculaProductor(string pelicula, Productor productor)
        {
            this.pelicula = pelicula;
            this.productor = productor;
        }
    }
}
