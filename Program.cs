using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        
        public string originalWords { get; set; }
        public static string Reverse(string originalWords)
        {
            char[] testArray = originalWords.ToCharArray();
            Array.Reverse(testArray);
            return new string(testArray);
        }
        static void Main(string[] args)
        {

            Console.WriteLine();
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("Lab-Fizz Buzz");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine();
            for (int i = 1; i <= 100; i++)
            {
                int num = i;
                
               


                    if (num % 3 == 0)
                    {
                        Console.WriteLine(num + "   Fizz");
                    }
                    else if(num%5==0)
                    {
                        Console.WriteLine(num + "   Buzz");
                    }
                    if ((num%3==0) && (num%15==0))
                    {
                        Console.WriteLine(num + "   Fizz Buzz");
                    }
                    else
                    {
                        Console.WriteLine(num);
                    }
                

            }


            Console.WriteLine();
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("Lab-Reverse order");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine();
            string originalWords = "test words to put in reverse";
            String reverseWords = Reverse(originalWords);
            
            Console.WriteLine(reverseWords);

            Console.WriteLine();
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("Lab-Extra Credit");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine();
            Console.WriteLine();
            foreach (var item in originalWords)
            {
                for (int i = 0; i < originalWords.Length; i++)
                {

                    Console.Write(originalWords[i]);Console.WriteLine(" "+ reverseWords[i]);
                }
              
            }
            

            
        }
    }
}
