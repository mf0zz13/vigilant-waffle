using System;

namespace Week5GroupProject
{
    class Project_2
    {
        static string TrimZeros(string num)
        {
            return num.Trim('0');
        }

        static void Main(string[] args)
        {
            Console.WriteLine(TrimZeros("51230100"));
            Console.ReadKey();
        }
    }
}