using System;
using System.Collections.Generic;
namespace Question2
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter the input String:");
            string flrBee = Console.ReadLine();

            int[] strtIdx = new int[2];
            int[] endIdx = new int[2];

            for (int i = 0; i <= 3; i++)
            {
                if (i < 2)
                {
                    strtIdx[i] = int.Parse(Console.ReadLine());
                }
                else
                {
                    endIdx[i - 2] = int.Parse(Console.ReadLine());
                }
            }

            // finding the no of bees between the two flowers for the given ranges:
            int flowerCount = 0;
            int beeCount = 0;
            int maxBeeCount = 0;
            List<int> beeCountsList = new List<int>();
            bool beeCheck = false;
            for (int i = 0; i < strtIdx.Length; i++)
            {
                beeCount = 0;
                flowerCount = 0;
                for (int j = strtIdx[i] - 1; j < endIdx[i]; j++)
                {
                    if (flrBee[j] == '|')
                    {
                        flowerCount++;
                        if (flowerCount == 2)
                        {
                            beeCheck = true;
                            if (beeCount > 0)
                            {
                                maxBeeCount = beeCount;
                                beeCount = 0;
                            }
                            flowerCount -= 1;
                        }
                    }
                    else
                    {
                        if(flowerCount==1)
                        {
                            beeCount++;
                        }
                    }
                }
                if (beeCheck)
                {
                    beeCountsList.Add(maxBeeCount);
                    beeCheck = false;
                }
            }
            Console.Write("[");
            for(int i=0;i<beeCountsList.Count;i++)
            {
                Console.Write(beeCountsList[i]);
                if (i != beeCountsList.Count - 1)
                {
                    Console.Write(",");
                }
            }

            Console.WriteLine("]");
        }
    }
}