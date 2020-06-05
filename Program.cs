using System;
using Figgle;

namespace NomeASCIIArt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Figgle: Criando textos em ASCII Art\n");

            Console.WriteLine("--- Digite seu Nome ---");
            string textao = FiggleFonts.Standard.Render(Console.ReadLine());

            Console.WriteLine($"{textao}");
        }
    }
}
