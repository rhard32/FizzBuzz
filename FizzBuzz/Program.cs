using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {

            //FizzBuzz Problem

            for (int n = 0; n < 101; n++)
            {
                Console.WriteLine(n);


                if ((n % 3 == 0) && (n % 5 == 0))
                {
                    Console.WriteLine(n + "FIZZBUZZ");
                }
                    if (n % 3 == 0) 
                    
                        Console.WriteLine(n + "FIZZ");
                        if (n % 5 == 0)
                        {
                            Console.WriteLine(n + "BUZZ");


                         
                            //Console.ReadLine();
                        }



                        //foreach (var item in args)
                        //{
                        //    Console.WriteLine(item);
                        //    for (int i = 0; i < item.Length; i++)
                        //        Console.WriteLine("\t{0}", item[i]);
                        //}

                        //while (args.Length > 0)
                        //{
                        //    Console.WriteLine(args[0]);
                        //    int index = 0;
                        //    do
                        //    {
                        //        Console.WriteLine("\t{0}", args[0][index++]);
                        //    } while (index < args[0].Length);
                        //    args = args.Skip(1).ToArray();
                        //}

                        //string message;
                        //do
                        //{
                        //    Console.WriteLine("Write a message");
                        //    message = Console.ReadLine();
                        //    Console.WriteLine("Your message is {0}", message);
                        //} while (message != "quit");






                    }
                }
            }
        }
 

        
