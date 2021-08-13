using System;
using System.Collections.Generic;
using System.Text;

namespace Entidad
{
    public abstract class Persona
    {
        public string identificacion { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public int edad { get; set; }

        public float numpulsaciones { get; set; }

        public string sexo { get; set; }



        public abstract void CalculoPulsaciones();
        public abstract string Escribir();

    }
      
    }

