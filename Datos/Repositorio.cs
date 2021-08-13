using Entidad;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Datos
{
    public class Repositorio
    {
        string ruta = "Pulsaciones.txt";

        public void GuardarPersona(Persona persona)
        {

            FileStream archivo = new FileStream(ruta, FileMode.Append);
            StreamWriter escritor = new StreamWriter(archivo);

            escritor.WriteLine(persona.Escribir());

            escritor.Close();
            archivo.Close();


        }

        public List<Persona> consultar()
        {
            List<Persona> personas = new List<Persona>();

            FileStream archivo = new FileStream(ruta, FileMode.OpenOrCreate);
            StreamReader lector = new StreamReader(archivo);

            string linea = "";

            while ((linea = lector.ReadLine()) != null)
            {
                Persona persona = MappearPersona(linea);

                personas.Add(persona);

            }

            return personas;
        }

        private Persona MappearPersona(string linea)
        {
            string[] partepersona = linea.Split(";");

            if (partepersona[4].ToUpper().Equals("HOMBRE"))
            {
                Hombre hombre = new Hombre();

                hombre.identificacion = partepersona[0];
                hombre.Nombre = Convert.ToString(partepersona[1]);
                hombre.Apellido = Convert.ToString(partepersona[2]);
                hombre.edad = Convert.ToInt32(partepersona[3]);
                hombre.sexo = Convert.ToString(partepersona[4]);
                hombre.numpulsaciones = Convert.ToInt32(partepersona[5]);

                return hombre;



            }
            else
            {

                Mujer mujer = new Mujer();

                mujer.identificacion = partepersona[0];
                mujer.Nombre = Convert.ToString(partepersona[1]);
                mujer.Apellido = Convert.ToString(partepersona[2]);
                mujer.edad = Convert.ToInt32(partepersona[3]);
                mujer.sexo = Convert.ToString(partepersona[4]);
                mujer.numpulsaciones = Convert.ToInt32(partepersona[5]);

                return mujer;

            }
        }
        
        public  Persona Registro (string id)
        {
            List<Persona> personas = consultar();

            foreach(var i in personas)
            {

                if (i.identificacion.Equals(id))
                {

                    return i;
                }
                
            }
            return null;
        }
    }
}
