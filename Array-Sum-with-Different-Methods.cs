using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //Using Sum Method Array Sum()
            int[] array = { 1, 2, 3, 5, 56, 54 };
            int sum = array.Sum();
            Console.WriteLine("Sum of Array :" + sum);
            Console.ReadLine();

            //Using Array.For EachMethod()
            int ArraySum = 0;
            Array.ForEach(array,i=> ArraySum+=i);
            Console.WriteLine("Array Sum is :"+ArraySum);

            Console.ReadLine();

            //Print array Values
            foreach(int item in array)
            {
                Console.WriteLine("Array Vlaues: "+item);
            }

            //Using ForEach Loop
            int sumOfArray = 0;
            foreach(int item in array)
            {
                sumOfArray += item;
            }
            Console.WriteLine("Array Sum is : "+sumOfArray);
            Console.ReadLine();


           

        }
      
       
    }
}
