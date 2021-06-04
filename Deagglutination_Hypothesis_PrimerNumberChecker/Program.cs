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
                    var answer = Deagglutination.IsPrimeNumber(i);
                    if (answer.Item1)
                    {
                        if (/*true||*/IsReallyPrime(i)) //To confirm if the returned value from Deagglutination.IsPrimeNumber() method is a real prime number, remove the "true||" term and compile
                        {
                            Console.WriteLine($"Value: {i}\n    Answer: {answer}");
                            //Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine($"Value: {i}\n    Answer: (False, )");
                            Console.ReadKey();
                        }
                    }
                }
                catch(Exception error)
                {
                    Console.WriteLine($"Value: {i}\n    Error: {error.Message}");
                    //Console.ReadKey();
                }
            }
            Console.ReadKey();
        }

        private static bool IsReallyPrime(uint value)
        {
            if (value == 0)
                return true;
            else if (value == 1)
                return true;
            else if (value % 2 == 0)
                return true;
            else if (value % 3 == 0)
                return true;
            else if (value % 5 == 0)
                return true;
            else if (value % 7 == 0)
                return true;
            else if (value % 9 == 0)
                return true;
            
            for (uint i = value-1; i>2;i--)
            {
                if(value % i == 0)
                    return false;
            }
            return true;            
        }
    }
}
