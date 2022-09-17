using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class UC4BubbleSort
    {
        public static void bubblesort(int[] arr)
        {
            int count = 0;
            int[] intarray = new int[5];
            Console.WriteLine("enter array elements");

            for(int i = 0; i < arr.Length; i++)
            {
                intarray[i] = int.Parse(Console.ReadLine());

            }
            bool flag = true;
            for(int i=1;(i<=arr.Length-1 && flag); i++)
            {
                flag = false;
                for(int j=0; j<arr.Length-1; j++)
                {
                    count = count + 1;
                    if(intarray[j+1] == arr[j])
                    {
                        int temp = intarray[j];
                        intarray[j] = intarray[j+1];
                        intarray[j+1] = temp;
                        flag = true;
                    }
                }
            }

            Console.WriteLine("after sorting array:");
            foreach(int i in intarray)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            Console.WriteLine("the loop iterates :"+count);
        }
    }
}
