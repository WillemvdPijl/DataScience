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
            string[] userItem = System.IO.File.ReadAllLines(@"../../userItem.data");

            Dictionary<int, Dictionary<int, float>> result = new Dictionary<int, Dictionary<int, float>>();

            foreach (string item in userItem)
            {

                Dictionary<int, float> rating = new Dictionary<int, float>();
    
                var user = item.Split(',');

                rating.Add(int.Parse(user[1]), float.Parse(user[2]));

                if (result.ContainsKey(int.Parse(user[0])))
                {
                    result[int.Parse(user[0])].Add(int.Parse(user[1]), float.Parse(user[2]));
                }
                else
                {
                    result.Add(int.Parse(user[0]), rating);
                }
                    

                Console.WriteLine(result);

            }
            Console.ReadKey();
        }
    }
}
