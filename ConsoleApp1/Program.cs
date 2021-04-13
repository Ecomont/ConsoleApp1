using System;

namespace metodosjeje
{
    class Program
    {
        /*
        static void main(string[] args)
        {
            mensajeEnPantalla();
            System.Console.WriteLine("Mensaje desde el main");
        }

        static void mensajeEnPantalla()
        {
        System.Console.WriteLine("Mensaje desde el método mensajeEnPantalla");
        //Primero sale el Mensaje desde el metodo
        //Porque busca desde mensajeEnPantalla(); que esta primero
        */

        /*
        static void main(string[] args)
        {
            sumaNumeros(7, 9);
            Console.WriteLine("Mensaje desde el main");
        }
       
        static void sumaNumeros(int num1, int num2)
        {
            Console.WriteLine($"La suma de los numeros es: {num1 + num2}");
        }
        */
        /*
        static void Main(string[] args)
        {
            Console.WriteLine(sumaNumeros(7, 9));
        }
        static int sumaNumeros(int num1, int num2)
        {
            return num1 + num2;


        }
        */
        static void Main(string[] args)
        {


        }
        
        static int Suma(int operador1, int operador2, int operador3);
        
        static int Suma(int numero1, double numero2) => numero1;

        static int Suma(int numero1, int numero2, int numero3, int numero4) => numero1 + numero2;
    }
}