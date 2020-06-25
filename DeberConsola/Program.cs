using System;

namespace ConsolaDeber1
{
    class Program1
    {
        static void Main(string[] argumentos)
        {
            //Inicialización de Variables 
            string titulo = "Programa en Consola";
            string nombre = "";
            int primerNum = 0;
            int segundoNum = 0;


            Console.Title = titulo; //Cambiamos en Título de la Consola 
            Console.BackgroundColor = ConsoleColor.Blue; //Cambiamos el fonde de color de la consola
            Console.Clear(); //Con este método vamos a limpiar el color original
            Console.ForegroundColor = ConsoleColor.Black; //Cambiamos el color de la letra de la consola
            Console.WriteLine("La función 'WriteLine' sirve para imprimir todo en una sola Línea\n");


            Console.Write("La función 'Write' sirve para imprimir todo seguido ");
            Console.Write("EJEMPLO:");
            Console.Write("Esta es otra Línea \n \n");


            Console.WriteLine("Ingresa tú Nombre:");
            nombre = Console.ReadLine();
            Console.WriteLine($"{nombre}: tú nombre se compone de: {(nombre.Length - 1) + 1} letras \n");


            Console.WriteLine("Ahora vamos a sumar dos números");
            Console.WriteLine("Ingresar un número");
            primerNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresar otro número");
            segundoNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"El resultado de la suma es : " + (primerNum + segundoNum));


            Console.ReadKey(); //Toma una tecla terminar el programa6'	
        }



    }
}
