using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsasign
{
    class camel
    {
        static void Main(string[] ar)
        {
            string str = Console.ReadLine();
            int count = 1;
            int length = str.Length;
           
            if (str[0] >= 'a' && str[0] <= 'z')
            {
                for (int j = 0; j < length; j++)
                {
                    if (str[j] >= 'A' && str[j] <= 'Z')
                    {
                        count++;
                    }
                }
            }
            else
            {
                count = 0;
                Console.WriteLine("Invalid Text");
            }
            Console.WriteLine(count);
            Console.ReadLine();
        }
    }
}
