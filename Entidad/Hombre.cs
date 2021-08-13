using System;
using System.Collections.Generic;
using System.Text;

namespace Entidad
{
    public class Hombre:Persona
    {

      



        public override string Escribir()
        {
            return $"{identificacion};{Nombre};{Apellido};{edad};{sexo};{numpulsaciones}";
        }

        public override void CalculoPulsaciones()
        {
            numpulsaciones = (220 - edad / 10);
        }
    }
}
