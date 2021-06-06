using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deagglutination_Class
{
    public class Deagglutination
    {
        public static Tuple<bool, string> IsPrimeNumber(ulong number)
        {
            if (number == 1 || number == 2 || number == 3 || number == 5 || number == 7 || number == 9)
                return new Tuple<bool, string>(true, null);

            if (number == 0)
                return new Tuple<bool, string>(false, "infinite");
            else if (number == 1)
                return new Tuple<bool, string>(false, 1.ToString());
            else if (number % 2 == 0)
                return new Tuple<bool, string>(false, 2.ToString());
            else if (number % 3 == 0)
                return new Tuple<bool, string>(false, 3.ToString());
            else if (number % 5 == 0)
                return new Tuple<bool, string>(false, 5.ToString());
            else if (number % 7 == 0)
                return new Tuple<bool, string>(false, 7.ToString());
            else if (number % 9 == 0)
                return new Tuple<bool, string>(false, 9.ToString());


            

            string value = number.ToString();
            ulong a = Convert.ToUInt64(value.Substring(0, value.Length - 1));//converter os algarismo, até o penúltimo algarismo
            ulong b = Convert.ToUInt64(value[value.Length - 1].ToString());//converte o último algarismo     
            ulong initalA = a;//Consersvando argumento 'a' original
            ulong initialB = b;//Consersvando argumento 'b' original
            Tuple<bool, string> answer = null;

            if (b == 1)//caso b seja igual a 1, deverá ser incrementado 10 para evitar falso positivo, quando chamado o método IsPrimeNumber
                answer = ApplyDeagglutination(a - 1, b + 10);//verifica se o valor é primo
            else//caso contrário
                answer = ApplyDeagglutination(a, b);//verifica se o valor é primo

            if (!answer.Item1)//caso não seja primo
                return answer;                
            else//caso conste como um possível número primo
            {
                string newValue = string.Empty;
                if (initialB != 1)//verificação se o último algarismo inicial ('b') seja diferente de 1, dessa forma, evita-se duplicação de uma chamada de método, com o mesmo argumento
                {
                    newValue = (Convert.ToUInt32(value) * b).ToString();//novo valor, multiplicado pelo último algarismo
                    a = Convert.ToUInt32(newValue.Substring(0, newValue.Length - 1));//converter os algarismo, até o penúltimo algarismo
                    b = Convert.ToUInt32(newValue[newValue.Length - 1].ToString());//converte o último algarismo
                    if (b == 1)//caso b seja igual a 1, deverá ser incrementado 10 para evitar falso positivo, quando chamado o método IsPrimeNumber
                        answer = ApplyDeagglutination(a - 1, b + 10);//verifica se o valor é primo
                    else//caso contrário
                        answer = ApplyDeagglutination(a, b);//verifica se o valor é primo
                }

                if (!answer.Item1)//caso não seja primo
                    return answer;
                else//caso conste como um possível número primo
                {                    
                    if (initialB == 9)//verificação se o último algarismo inicial é o número 3
                    {
                        newValue = (Convert.ToUInt32(value) * 3).ToString();//novo valor, multiplicado por 3
                        a = Convert.ToUInt32(newValue.Substring(0, newValue.Length - 1));//converter os algarismo, até o penúltimo algarismo
                        b = Convert.ToUInt32(newValue[newValue.Length - 1].ToString());//converte o último algarismo
                        if (b == 1)//caso b seja igual a 1, deverá ser incrementado 10 para evitar falso positivo, quando chamado o método IsPrimeNumber
                            answer = ApplyDeagglutination(a - 1, b + 10);//verifica se o valor é primo
                        else//caso contrário
                            answer = ApplyDeagglutination(a, b);//verifica se o valor é primo

                        if (!answer.Item1)//caso não seja primo
                            return answer;
                        else//caso conste como um possível número primo
                        {
                            newValue = (Convert.ToUInt32(value) * 7).ToString();//novo valor, multiplicado por 7
                            a = Convert.ToUInt32(newValue.Substring(0, newValue.Length - 1));//converter os algarismo, até o penúltimo algarismo
                            b = Convert.ToUInt32(newValue[newValue.Length - 1].ToString());//converte o último algarismo
                            if (b == 1)//caso b seja igual a 1, deverá ser incrementado 10 para evitar falso positivo, quando chamado o método IsPrimeNumber
                                answer = ApplyDeagglutination(a - 1, b + 10);//verifica se o valor é primo
                            else//caso contrário
                                answer = ApplyDeagglutination(a, b);//verifica se o valor é primo

                            return answer;
                        }
                    }
                    else//caso contrário
                    {
                        if (initialB == 1)//verificação se o último algarismo inicial é o número 3
                        {
                            newValue = (Convert.ToUInt32(value) * 3).ToString();//novo valor, multiplicado por 3
                            a = Convert.ToUInt32(newValue.Substring(0, newValue.Length - 1));//converter os algarismo, até o penúltimo algarismo
                            b = Convert.ToUInt32(newValue[newValue.Length - 1].ToString());//converte o último algarismo
                            answer = ApplyDeagglutination(a - 1, b + 10);//verifica se o valor é primo
                            if (!answer.Item1)//caso não seja primo
                                return answer;
                            else//caso conste como um possível número primo
                            {
                                newValue = (Convert.ToUInt32(value) * 9).ToString();//novo valor, multiplicado por 9
                                a = Convert.ToUInt32(newValue.Substring(0, newValue.Length - 1));//converter os algarismo, até o penúltimo algarismo
                                b = Convert.ToUInt32(newValue[newValue.Length - 1].ToString());//converte o último algarismo
                                answer = ApplyDeagglutination(a - 1, b + 10);//verifica se o valor é primo
                                return answer;                                
                            }
                        }
                        else //caso seja primo
                            return answer;                            
                    }
                }
            }
        }

        static Tuple<bool, string> ApplyDeagglutination(ulong a, ulong b)//método para verificar se trata de um numero primo de acordo com a hipótese da desaglutinação
        {
            ulong initalA = a;//Consersvando argumento 'a' original
            ulong initialB = b;//Consersvando argumento 'b' original
            //Console.WriteLine($"{a}   {b}");
            while (a != 0 && a % b != 0 && a > b)//caso 'a' seja diferente de 0, a divisão entre 'a' e 'b' *GERE* 'restos' *E* 'a', seja maior que 'b'. Faça:
            {
                a--;//decremento de uma unidade
                b += 10;//incremento de uma dezena de unidade
                //Console.WriteLine($"{a}   {b}");
            }
            if (a != 0 && a % b == 0 && b != 1)//caso 'a' seja diferente de 0, a divisão entre 'a' e 'b' *NÃO GERE* 'restos' e 'b' seja diferente de 1
                return new Tuple<bool, string>(false, b.ToString());//valor não é um número impar e possui divisor 'b'
            else
                return new Tuple<bool, string>(true, null);//valor é um número impar e não retornará divisores, pois, por regra, seus divisores serão 1 e valor original do argumento 'a'.
        }
    }
}
