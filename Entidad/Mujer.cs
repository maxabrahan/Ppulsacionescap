using System;
using System.Collections.Generic;
using System.Text;

namespace Entidad
{
    public class Mujer:Persona
    {

      


        public override string Escribir()
        {
            return $"{identificacion};{Nombre};{edad};{Apellido};{edad};{sexo};{numpulsaciones}";
        }

        public override void CalculoPulsaciones()
        {
            numpulsaciones = (210 - edad) / 10;
        }
    }
}
