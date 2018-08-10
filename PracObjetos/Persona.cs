using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaObjetos
{
    class Persona
    {
        //modificadores de acceso
        //public y private
        //Atributos
        //Definir a través de variables
        public string nombre;
        public string apellidos;
        public string fechaNacimiento;
        public int edad;
        public float altura;

        //Métodos
        //Definidos a través de funciones
        public void cumplirAños()
        {
            edad++; ;
        }

        public void crecimiento(float cantidadCrecimiento)
        {
            altura += cantidadCrecimiento;
        }
    }
}
