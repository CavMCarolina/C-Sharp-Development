using System; //biblioteca do sistema

// Separa os blocos
namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            Console.WriteLine("Hello World!");

            Console.WriteLine("teste teste");

            // Escreve sem enter
            Console.Write("aaaaaaaaaaaaaaaaaaaaaaaaaaa");

            Console.Write("adadasdadsa");

            // Sonzinho
            Console.Beep(000, 1);
        }
    }
}