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
        static void Main(string[] args)
        {
            byte optionIndex = 0;

        OPTIONS:
            try
            {
                Console.WriteLine("Choice one option: " +
                    "\n 1 - Show all number (red - Prime number || white - non prime number)" +
                    "\n 2 - Show prime numbers only" +
                    "\n 3 - Verify value" +
                    "\n");
                Console.Write("Option: ");
                optionIndex = Convert.ToByte(Console.ReadLine());

            }
            catch
            {
                Console.WriteLine("Invalid Value!");
                Console.ReadKey();
                Console.Clear();
                goto OPTIONS;
            }



            switch (optionIndex)
            {
                case 1:
                    string emptySpace = string.Empty;
                    ulong emptySpaceCount = 1;
                    for (ulong i = 0; i < ulong.MaxValue; i++)
                    {
                        try
                        {
                            var answer = Deagglutination.IsPrimeNumber(i);
                            if (answer.Item1)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine(i);
                                Console.ForegroundColor = ConsoleColor.White;
                                emptySpace = string.Empty;
                                emptySpaceCount = 1;
                            }
                            else
                            {
                                for (ulong j = 0; j < emptySpaceCount; j++)
                                    emptySpace += ".";
                                Console.WriteLine($"{emptySpace}{i}");
                            }
                            //Console.ReadKey();
                            System.Threading.Thread.Sleep(41);
                        }
                        catch (Exception error)
                        {
                            Console.WriteLine($"Value: {i}\n    Error: {error.Message}");
                            //Console.ReadKey();
                        }
                    }
                    break;
                case 2:
                    for (ulong i = 0; i < ulong.MaxValue; i++)
                    {
                        try
                        {
                            var answer = Deagglutination.IsPrimeNumber(i);
                            if (answer.Item1)
                            {                                
                                Console.WriteLine(
                                    answer.Item1 /*&& IsReallyPrime(i)*/ ? 
                                    $"Value: {i}\n    Is prime number: {answer.Item1}" : 
                                    $"Value: {i}\n    Is prime number: {answer.Item1}\n    Divisor value: {answer.Item2}"
                                    );
                                //Console.ReadKey();
                            }

                        }
                        catch (Exception error)
                        {
                            Console.WriteLine($"Value: {i}\n    Error: {error.Message}");
                            //Console.ReadKey();
                        }
                    }
                    break;
                case 3:
                VERIFY:
                    try
                    {
                        Console.Clear();
                        Console.Write("Value (Max: 18.446.744.073.709.551.615): ");
                        var answer = Deagglutination.IsPrimeNumber(Convert.ToUInt64(Console.ReadLine()));
                        Console.WriteLine(
                            answer.Item1 /*&& IsReallyPrime(i)*/ ?
                            $"Is prime number: {answer.Item1}" : 
                            $"Is prime number: {answer.Item1}\nDivisor value: {answer.Item2}"
                            );                        
                    }
                    catch
                    {
                        Console.WriteLine("Invalid Value!");
                        
                        goto VERIFY;
                    }
                    break;
                default:
                    goto OPTIONS;

            }
            Console.ReadKey();
            Console.Clear();
            goto OPTIONS;
        }

        private static bool IsReallyPrime(ulong value)
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

            for (ulong i = value - 1; i > 2; i--)
            {
                if (value % i == 0)
                    return false;
            }
            return true;
        }
    }
}

