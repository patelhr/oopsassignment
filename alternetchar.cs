using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace oopsasign
{
    class alternetchar
    {
        static void Main(String[] args)
        {

            int testCase, i, count;
            testCase = Convert.ToInt32(Console.ReadLine());
            while (testCase != 0)
            {
                string str = Console.ReadLine();
                int length = str.Length;
                count = 0;
                for (i = 0; i < length - 1; i++)
                {
                    if (str[i] == str[i + 1])
                    {
                        count++;
                    }
                }
                Console.WriteLine(count);
            }
        }
    }
}
