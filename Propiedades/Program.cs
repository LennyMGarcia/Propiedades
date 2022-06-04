using System;

namespace Propiedades
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado juan = new Empleado("juan");

            juan.SALARIO = 2000;

            juan.SALARIO += 14;

            Console.WriteLine("el salario del empleado  es " + juan.SALARIO);
        }
    }
    class Empleado
    {
        public Empleado(string nombre)
        {
            this.nombre = nombre;
        }
        private string nombre;

        private double evaluarSalario( double salario)
        {
            if (salario < 0)
            {
                return 0;
            }
            else return salario;
                    
            
        }
        //Creacion de propiedad
        //Las propiedades son como variables pero que tienen metodos y mas funciones
        /* public double SALARIO
         {
             get { return this.salario; }

             set { this.salario = evaluarSalario(value); }
         }*/
        private double salario;

        //otra forma de escribirlo
        //si solo pones el get es es de solo lectura
        // si solo pones el set es de solo escritura quizas es mejor para contrasenas
        public double SALARIO
        {
            get => this.salario;

            set => this.salario = evaluarSalario(value);
        }
    }
}
