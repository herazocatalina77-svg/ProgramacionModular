using System;
namespace ProgramacionModular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MostrarMensaje();
            MostrarMensajes("Mi nombre es Catalina");
            MostrarMensajes("Tengo 18 años");
            //Console.WriteLine($"Edad calculada: {Calcularedad()}");
            MostrarMensajes($"Tengo {CalcularEdad(2025, 2006)}");
        }
            //Modulo1- Procedimiento sin parámetros
        static void MostrarMensaje()
        {
          Console.WriteLine("Bienvenidos a la clase de programación modular");
            MostrarMensajes("Estoy desde procedimiento sin parámetros");
        }
        //Módulo 2 - Procedimiento con parámetros
        static void MostrarMensajes(string mensaje)
        {
            Console.WriteLine(mensaje);
        }
        //Módulo 3 - Funciones
        static int Calcularedad()
        {
            int edad;
            edad = 2025 - 2006;
            return edad;
        }
        //Módulo 4 - Función con parámetros
         static int CalcularEdad(int añoActual, int añoNacimiento)
         {
            return añoActual - añoNacimiento;
         }
    }
}