using System;

namespace VorsinArraysHomework4
{
    class Program
    {
        static int[] Reverse(int[] array)
        {
            
            int length = array.Length;
            var newArray = new int[length];
            array.CopyTo(newArray, 0);

            int length1 = array.Length - 1;

            for (int i = 0; i < length; i++)
            {
                newArray[i] = array[length1];
                length1--;
            }
            return newArray;
        }

        static void Main(string[] args)
        {
            /*
            int[] array = { 1, 2, 3, 4, 5, 6,7 };
            int length = array.Length;
            var newArray = new int[length];
            array.CopyTo(newArray, 0);
            
            int length1 = array.Length -1;

            for (int i = 0; i < length; i++)
            {
                newArray[i] = array[length1];
                length1--;
            }
            
            
            for (int i = 0; i < newArray.Length; i++)
            {
                Console.WriteLine(newArray[i]);
            }
            */

            int[] testArray = { 1, 2, 3, 4, 5, 6, 7 ,8,9,10};

            

            for (int i = 0; i < testArray.Length; i++)
            {
                Console.WriteLine(Reverse(testArray)[i]);
            }

            
        }


    }
}
