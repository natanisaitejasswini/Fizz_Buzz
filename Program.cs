using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
           ////////First Loop/////////////
           for (int i = 1; i <= 255; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("*********");
            ////////Second Loop/////////////
            for (int j = 1; j <= 100; j++)
            {
                if(j%3 == 0 || j%5 == 0)
                {
                    if(!(j%3 == 0 && j%5 == 0))
                    {
                        Console.WriteLine(j);
                    }
                }
            }
            Console.WriteLine("*********");
             ////////Third Loop/////////////
            for (int k = 1; k <= 100; k++)
            {
                if(k%3 == 0 && k%5 == 0)
                {
                    Console.WriteLine("FizzBuzz" + k);
                }
                else if(k%5 == 0){
                    Console.WriteLine("Buzz"+ k);   
                }
                else if(k%3 == 0){
                     Console.WriteLine("Fizz"+ k);   
                }
            } 
            Console.WriteLine("*********");
        }
    }
}
