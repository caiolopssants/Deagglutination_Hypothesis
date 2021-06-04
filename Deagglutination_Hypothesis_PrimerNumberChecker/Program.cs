using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Deagglutination_Class;

namespace Deagglutination_Hypothesis
{
    class Program
    {
        static Random rnd = new Random();
        static int max = (int)(uint.MaxValue / 850);
        static void Main(string[] args)
        {
            for (uint i = 0; i<uint.MaxValue; i++/*i+= (uint)rnd.Next(0, max)*/)
            {
                try
                {
                    Console.WriteLine($"Value: {i}\n    Answer: {Deagglutination.IsPrimeNumber(i)}");
                    //Console.ReadKey();
                }
                catch(Exception error)
                {
                    Console.WriteLine($"Value: {i}\n    Error: {error.Message}");
                    //Console.ReadKey();
                }
            }
            Console.ReadKey();
        }
    }
}
