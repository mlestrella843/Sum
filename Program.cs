
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            string dataEntry;
            string transicion;
            var accumulatedS = 0.0;
            var accumulatedM = 1.0;

            do
            {
                dataEntry = Console.ReadLine();
                dataEntry = dataEntry.Trim();
                while (dataEntry.Contains("  ")) dataEntry = dataEntry.Replace(" ", " ");
                dataEntry = dataEntry.ToLower();

                var split = dataEntry.Split();

                //If command is a Sum
                if (split[0] == "add")
                {
                    for (int i = 1; i < split.Length; i++)
                    {
                        transicion = split[i];
                        accumulatedS = accumulatedS + Convert.ToDouble(transicion);
                    }
                    //Show informacion and Result

                    for (int i = 1; i < split.Length; i++)
                    {
                        Console.Write(split[i] + " + ");
                    }
                    Console.Write("=" + accumulatedS);
                    Console.WriteLine(" ");
                    accumulatedS = 0;
                }

                //Inf command is a product
                else if (split[0] == "product")
                {
                    for (int i = 1; i < split.Length; i++)
                    {
                        transicion = split[i];
                        accumulatedM = accumulatedM * Convert.ToDouble(transicion);
                    }
                    //Show informacion and Result

                    for (int i = 1; i < split.Length; i++)
                    {
                        Console.Write(split[i] + " * ");
                    }
                    Console.Write("=" + accumulatedM);
                    Console.WriteLine(" ");
                    accumulatedM = 1.0;
                }
                else {
                    Console.WriteLine("Unknown Command");

                }

            } while (dataEntry != "exit");              

        }

     }

 }
