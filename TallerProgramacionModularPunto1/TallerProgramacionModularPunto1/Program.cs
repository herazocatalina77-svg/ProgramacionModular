using System;
namespace TallerModulosPunto1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Modulos
            //Ingresa una palabra
            //Llevar la palabra, vector de caracteres
            //Contar la cantidad de consonantes y vocales de la palabra
            OrganizarPalabra();

        }
        static char[] OrganizarPalabra() //Funcion para la palabra
        {
            string palabra; //Variable de la palabra a ingresar
            Console.WriteLine("Ingrese una palabra");
            palabra = Console.ReadLine();
            //Array que tenga cada una de las letras de la palabra ingresada
            int contadorvocales = 0;
            int contadorconsonantes = 0;
            char[] arraypalabra = palabra.ToCharArray(); //Convertir el string en array de chars
            //Recorrer el array
            for (int i = 0; i < arraypalabra.Length;i++)
            {
                Console.WriteLine(arraypalabra[i]);
                //Condicional para las vocales y las consonantes
                //Contadores de las vocales y consonantes
                if (arraypalabra[i] == 'a' || arraypalabra[i] == 'e' || arraypalabra[i] == 'i'|| arraypalabra[i] == 'o' || arraypalabra[i] == 'u')
                {
                    contadorvocales++;
                }
                else
                {
                    contadorconsonantes++;
                }
                //Escribir la cantidad de vocales
            }
                Console.WriteLine($"La cantidad de vocales fueron {contadorvocales}");
                Console.WriteLine($"La cantidad de consonantes fueron {contadorconsonantes}");
            return arraypalabra;
        }
    }
}
