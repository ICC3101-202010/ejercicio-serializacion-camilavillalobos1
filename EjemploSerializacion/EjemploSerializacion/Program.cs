using System;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace EjemploSerializacion
{
    class MainClass
    {
        List<Persona> ListaPersona = new List<Persona>();

        public void Almacenar()
        {
            Console.WriteLine(ListaPersona);
        }

        public void Cargar()
        {
            Console.WriteLine("Nombre: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Apellido: ");
            string apellido = Console.ReadLine();
            Console.WriteLine("Edad: ");
            int edad = Convert.ToInt32(Console.ReadLine());
            Persona persona1 = new Persona(nombre, apellido, edad);
            
            //Persona persona1 = new Persona(nombre, apellido, edad);
            //ListaPersona.Add(persona1);

            Console.WriteLine(ListaPersona);
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("MyFile.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, ListaPersona);
            stream.Close();
            //return "";

        }

        public static void Main(string[] args)
        {
            List<Persona> ListaPersona = new List<Persona>();
            Console.WriteLine("1.Entrar al programa \n2. Salir");
            int hacer = Convert.ToInt32(Console.ReadLine());

            while (hacer != 2)
            {
                Console.WriteLine("1.Crear Persona \n2.Ver Personas \n3.Cargar Datos");
                int resp = Convert.ToInt32(Console.ReadLine());

                if (resp == 1)
                {
                    Console.WriteLine("Nombre: ");
                    string nombre = Console.ReadLine();
                    Console.WriteLine("Apellido: ");
                    string apellido = Console.ReadLine();
                    Console.WriteLine("Edad: ");
                    int edad = Convert.ToInt32(Console.ReadLine());
                    Persona persona1 = new Persona(nombre, apellido, edad);
                    ListaPersona.Add(persona1);
                }
                else if (resp == 2)
                {
                    int i = 1;

                    foreach (var item in ListaPersona)
                    {
                        Console.WriteLine(ListaPersona);
                        i += 1;
                    }
                }

                else if (resp == 3)
                {
                    IFormatter formatter = new BinaryFormatter();
                    Stream str = new FileStream("ListaPersona.bin", FileMode.Create, FileAccess.Read, FileShare.None);
                    foreach (var item in ListaPersona)
                    {
                        formatter.Serialize(str, item);
                    }
                    str.Close();
                    Console.WriteLine("Serializado");

                }
            }

        }
    }
}
