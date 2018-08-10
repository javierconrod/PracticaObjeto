using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaObjetos
{
    class Persona
    {
        //Atributos
        //Definir a través de variables
        string nombre;
        string apellidos;
        string fechaNacimiento;
        int edad;
        float altura;

        //Métodos
        //Definidos a través de funciones
        void cumplirAños()
        {
            edad++; ;
        }

        void crecimiento(float cantidadCrecimiento)
        {
            altura += cantidadCrecimiento;
        }
    }
}
