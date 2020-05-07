using System;
using System.Runtime.Serialization;
using System.Collections.Generic;
namespace EjemploSerializacion
{
    [Serializable]
    public class Persona
    {
        public string Nombre;
        public string Apellido;
        public int Edad;

        public Persona(string nombre, string apellido, int edad)
        {
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
        }


    }
}
