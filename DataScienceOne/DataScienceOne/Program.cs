﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataScienceOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Reading file...");
            string[] userItem = System.IO.File.ReadAllLines(@"../../userItem.data");

  //======================================== Task 1 ========================================

            Dictionary<int, Dictionary<int, float>> result = new Dictionary<int, Dictionary<int, float>>();

            Console.WriteLine(" ");
            Console.WriteLine("============== Task 1 ==============");
            Console.WriteLine(" ");

            foreach (string item in userItem)
            {

                Dictionary<int, float> rating = new Dictionary<int, float>();
    
                var user = item.Split(',');

                rating.Add(int.Parse(user[1]), float.Parse(user[2]));

                if (result.ContainsKey(int.Parse(user[0])))
                {
                    result[int.Parse(user[0])].Add(int.Parse(user[1]), float.Parse(user[2]));
                    Console.WriteLine("Adding to existing key...");
                }
                else
                {
                    result.Add(int.Parse(user[0]), rating);
                    Console.WriteLine("Creating and adding to new key " + user[0] + "...");
                }
            }

            Console.WriteLine(" ");
            Console.WriteLine("============== Done ==============");
            Console.WriteLine(" ");

//======================================== Task 2 ========================================

            Console.WriteLine("Hit any key to exit...");
            Console.ReadKey();
        }
    }
}
