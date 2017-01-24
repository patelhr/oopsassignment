using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsasign
{
    class Bracket
    {
       static bool isOpen(char temp)
        {
            if (temp == '{' || temp == '(' || temp == '[')
                return true;
            else
                return false;

        }
        static bool isBalanced(char popvar,char pushvar)
        {
            if (popvar == '{' && pushvar == '}')
                return true;
            if (popvar == '[' && pushvar == ']')
                return true;
            if (popvar == '(' && pushvar == ')')
                return true;
            return false;
        }
        static void Main(string[] ar)
        {
            int testCase;
            int count;

            testCase =Convert.ToInt32(Console.ReadLine());
            for(int i=0;i<testCase;i++)
            {
                string str;
                Stack<char> stack=new Stack<char>();
                count = 0;
                str = Console.ReadLine();
               for(int j=0;j<str.Length;j++)
                {
                    char pushtemp = str[j];
                    if(isOpen(pushtemp)==true)
                    {
                        stack.Push(pushtemp);
                    }
                    else
                    {
                        char poptemp;
                        if(stack.Count>0)
                        {
                              poptemp = stack.Peek(); 
                              stack.Pop();

                        }
                        else
                        {
                            count = 1;
                            break;
                        }
                        if(isBalanced(poptemp,pushtemp))
                        {
                            continue;
                        }
                        else
                        {
                            count = 1;
                            break;
                        }
                    }
                }
                if (stack.Count() != 0)
                    count = 1;
                if (count==1)
                    Console.WriteLine("NO");
                else
                    Console.WriteLine("YES");
            }

            Console.ReadLine();
        }
    }
}
