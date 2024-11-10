using System;

namespace Question3
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter the length of the subarray");
            int subArrayLength = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the size of the input array");
            int sizeOfInput = int.Parse(Console.ReadLine());
            int[] inputArray = new int[sizeOfInput];
            Console.WriteLine("Enter the elements of the array");
            for(int i=0;i<sizeOfInput;i++)
            {
                inputArray[i] = int.Parse(Console.ReadLine());
            }

            //finding the maximum of the element in the sub array:
            int minSubValue = int.MaxValue;
            int maxElement=0;
            for(int i=0;i<inputArray.Length-subArrayLength;i++)
            {
                maxElement = inputArray[i];
                for(int j=i;j<i+subArrayLength;j++)
                {
                    if(inputArray[j]>maxElement)
                    {
                        maxElement = inputArray[j];
                    }
                }

                if(maxElement < minSubValue)
                {
                    minSubValue = maxElement;
                }
            }

            Console.WriteLine("Minimum Value is: "+minSubValue);
        }
    }
}