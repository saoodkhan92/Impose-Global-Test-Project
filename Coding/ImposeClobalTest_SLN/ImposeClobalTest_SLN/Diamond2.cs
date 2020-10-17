using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImposeClobalTest_SLN
{
    class Diamond2
    {
        public static void Main(string[] args)
        {
           
            char[] letter = new char[26]
            {
                'Z', 'Y', 'X', 'W', 'V', 'U', 'T', 'S', 'R', 'Q', 'P', 'O', 'N', 'M', 'L', 'K', 'J', 'I', 'H', 'G', 'F',
                'E', 'D', 'C', 'B', 'A'
            };

            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("Please enter the no:- ");
            int No = Convert.ToInt32(Console.ReadLine());
            int i, j, k, m;
            for (i = 1; i <= No; i++)
            {
                for (j = No; j >= i; j--)
                    Console.Write(" ");
                for (k = 1; k <= i; k++)
                {
                    Console.Write(letter[j]);
                    j--;
                }
                for (m = 1; m < i; m++)
                    Console.Write(letter[m]);
                Console.Write("\n");
                
            }
         
        


            for (i = No-1; i >= 1; i--)
            {
                for (j = No; j >= i; j--)
                    Console.Write(" ");
                for (k = 1; k <= i; k++)
                {
                    Console.Write(letter[j]);
                    j--;
                }
                for (m = 1; m < i; m++)
                    Console.Write(letter[m]);
                Console.Write("\n");

            }
            Console.ReadKey();
        }
        
    }
}
