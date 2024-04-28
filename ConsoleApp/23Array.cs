using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class _23Array
    {
        public static void Main(string[] args)
        {
            int temp;
            //int[] a = { 1, 2, 3, 4, 5 };
            int[] a = new int[5] { 1, 2, 3, 4, 5 };
            foreach(int x in a)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine(a.Length);
            int[] b = new int[5] { 6, 7, 8, 9, 10 };
            var c=a.Concat(b);
            foreach(int x in c)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine(a.Contains(9));
            int[] u=new int[5] { 89,56,90,78,45};
            Array.Sort(u);
            foreach(int x in u)
            {
                Console.WriteLine(x);
            }
            int[,] matrix = new int[3, 3] { {1,2,3 },{4,5,6 },{7,8,9 } };
            for(int i=0;i<3;i++)
            {
                for(int j=0;j<3;j++)
                {
                    Console.Write(matrix[i, j]+"\t");
                }
                Console.WriteLine();
            }
            int n;
            Console.WriteLine("Enter size of array:");
            n=int.Parse(Console.ReadLine());
            int[] A= new int[n];
            Console.WriteLine("Enter n array elements:");
            for(int i=0;i<n;i++)
            {
                A[i]=int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Array before sort:");
            for(int i=0;i<n;i++)
            {
                Console.Write(A[i]+"\t");
            }
            Console.WriteLine("\nArray after sort:");
            for(int i=0;i<n-1;i++)
            {
                for(int j=0;j<n-1-i;j++)
                {
                    if (A[j] > A[j+1])
                    {
                         temp = A[j];
                        A[j] = A[j+1];
                        A[j+1] = temp;  

                    }
                }
            }
            for(int i=0;i<n;i++)
            {
                Console.Write(A[i] + "\t");
            }
        }
    }
}
