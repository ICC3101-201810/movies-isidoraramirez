﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ultimo_lab
{
    public class Actor : Persona
    {
        public Actor(string nombre, string apellido, string fecha_nacimiento, string biografia) : base(nombre, apellido, fecha_nacimiento, biografia)
        {
        }
    }
}
