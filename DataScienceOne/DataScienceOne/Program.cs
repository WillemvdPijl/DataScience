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
            Console.WriteLine(userItem[0]);

            foreach (string item in userItem)
            {

                var user = item.Split(',');

                Console.WriteLine(user);
            }
        }
    }
}
