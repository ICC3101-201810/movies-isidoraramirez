using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ultimo_lab
{
    [Serializable]
    public abstract class Persona
    {
        public string nombre, apellido, fecha_nacimiento, biografia;

        public Persona(string nombre, string apellido, string fecha_nacimiento, string biografia)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.fecha_nacimiento = fecha_nacimiento;
            this.biografia = biografia;
        }
    }
}
