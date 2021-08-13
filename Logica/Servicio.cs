using Datos;
using Entidad;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logica
{
    public class Servicio
    {
        Repositorio repositorio = new Repositorio();

        public string GuardarPersona(Persona persona)
        {
            try
            {
                if (repositorio.Registro(persona.identificacion) == null)
                {
                    repositorio.GuardarPersona(persona);

                    return "Datos guardados exitosamente";

                }
                else
                {
                    return "El registro ya se encontro";

                }

            }
            catch (Exception e)
            {

                return $"Se presento el siguiente error{e.Message}";
            }



        }

        public ConsultaResponde ConsultarPersona()
        {

            try
            {

                return new ConsultaResponde(repositorio.consultar());

            }
            catch (Exception e)
            {

                return new ConsultaResponde($"se presento el siguiente error {e.Message}");

            }
        }
    }

    public class ConsultaResponde
    {

        public List<Persona> Personas { get; set; }

        public string Mensaje { get; set; }

        public bool Error { get; set; }

        public ConsultaResponde(string mensaje)
        {
            Error = true;
            Mensaje = mensaje;

        }

        public ConsultaResponde(List<Persona> personas)
        {
            Error = false;
            Personas = personas;

        }

       
    }


    public RegistroRespuesta Registro (string id)
    {

        try
        {
            return new RegistroRespuesta(repositorio.Registro(id));
            
        }catch(Exception e)
        {
            return new RegistroRespuesta(e.Message);

        }

    }

    public class RegistroRespuesta
    {

        public Persona Persona { get; set; }

        public bool Error { get; set; }

        public string Mensaje { get; set; }


        public RegistroRespuesta(string mensaje)
        {
            Error = true;
            Mensaje = mensaje;

        }

        public RegistroRespuesta(Persona persona)
        {
            Error = false;
            Persona = persona;

        }


    }



}



   


