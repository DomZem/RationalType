using RationalLib;
using static System.Console;

namespace RationalConsoleAppDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            BigRational u = new(4, 4);

            WriteLine(u);   
        }
    }
}