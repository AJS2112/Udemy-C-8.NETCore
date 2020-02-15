using System;
using System.Collections.Generic;
using System.Text;

namespace Curso_de_Net__Core
{
    static class Utilities
    {
        public static void ColorfulWriteLine(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
