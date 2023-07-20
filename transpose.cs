using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace transpose2D
{
    class Program
{
     public static  void Main()
    {
            int[,] arr1 = new int[3, 3];
            int[,] arr2 = new int[3, 3];
            Console.WriteLine("Enter array elements: ");
            for(int i=0;i<3;i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("input ({0},{1}) ", i, j);
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }

            }
            Console.WriteLine("Original Array ");
            for(int i=0;i<3;i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("{0}  ", arr1[i, j]);
                }
                Console.WriteLine();
            }


            for (int i = 0; i < 3; i++)
            {
                for(int j=0;j<3;j++)
                {
                    arr2[j, i] = arr1[i, j];
                }
            }
            Console.WriteLine("Transpose of array");
            for (int i= 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("{0} ", arr2[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    
    }
}
