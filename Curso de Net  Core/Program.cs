using System;
namespace Curso_de_Net__Core
{

    class Program
    {
        static void Main(string[] args)
        {
            int year = 10;
            Point point = new Point();

            point.x = 10;
            point.y = 15;

            Utilities.ColorfulWriteLine("Hola Cabrón",ConsoleColor.Red);
            Console.WriteLine("Hello World!" + year);
            Console.ReadLine();
        }
    }
}
