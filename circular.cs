using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsasign
{ 
    class circular
    {
        public static int calculat(int a, int b)
        {
            while( a<0)
            {
                a += b;
            }
            return a % b;
         }
      
        static void Main(string[] args)
        {
            int i, j;
            string[] token = Console.ReadLine().Split(' ');
            int numbers = Convert.ToInt32(token[0]);
            int kOperation = Convert.ToInt32(token[1]);
            int queries = Convert.ToInt32(token[2]);
            int[] tempArr = new int[1000000];
            int[] finalArr = new int[1000000];
            string[] querietoken = Console.ReadLine().Split(' ');
            for ( i=0;i<numbers;i++)
            {
            tempArr[i] = Convert.ToInt32(querietoken[i]);
              
            }
            
              for ( j=0;j<numbers;j++)
            {
                finalArr[j] = tempArr[calculat(j - kOperation + numbers, numbers)];
               
            }

            for(int k=0;k<queries;k++)
            {
                int temp=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(finalArr[temp]);
                
            }
            Console.ReadLine();
        }    

    }
}
