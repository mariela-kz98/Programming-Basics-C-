using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
                i++;
                
                for (int m =2; m <= n; m++)
                {
                    
                        Console.Write(m++);
                        m+=1;
                    continue;
                }
                
            }

            
        }
    }
}
