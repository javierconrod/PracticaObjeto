using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaración de variable
            Persona persona1;
            //Creación de instancia, alojamiento en memoria
            persona1 = new Persona();

            persona1.nombre = "Juan";
            persona1.apellidos = "Perez";
            persona1.edad = 20;
            persona1.altura = 1.5f;

            Console.WriteLine(persona1.nombre + " " + persona1.apellidos + " tiene " + persona1.edad + " años de edad" );

            persona1.cumplirAños();

            Console.WriteLine("Ahora " + persona1.nombre + " tiene " + persona1.edad + " años de edad");

            Console.WriteLine(persona1.nombre + " mide: " + persona1.altura + "m");

            persona1.crecimiento(0.12f);

            Console.WriteLine("Ahora " + persona1.nombre + " mide: " + persona1.altura + "m");

            Console.ReadLine();
        }
    }
}