using System;
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

            Dictionary<int, Dictionary<int, float>> result = new Dictionary<int, Dictionary<int, float>>();

            Console.WriteLine(" ");
            Console.WriteLine("========= Task 1 =========");
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
                    Console.WriteLine("Adding to new key...");
                }
            }

            Console.WriteLine(" ");
            Console.WriteLine("========= Done =========");
            Console.WriteLine(" ");
            Console.WriteLine("Hit any key to exit...");
            Console.ReadKey();
        }
    }
}
