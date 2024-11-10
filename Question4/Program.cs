using System;
using System.Collections.Generic;
namespace QUESTION4
{
    class Program{
        public static void Main()
        {
            Console.WriteLine("Enter the number of Flavours: ");
            int no_of_flavours = int.Parse(Console.ReadLine());
            string[] flavours = new string[no_of_flavours];
            Dictionary<string, int> flavour_count = new Dictionary<string, int>();
            Console.WriteLine("Enter the Flavours: ");
            for(int i=0;i<no_of_flavours;i++)
            {
                flavours[i] = Console.ReadLine();
                if(flavour_count.ContainsKey(flavours[i]))
                {
                    flavour_count[flavours[i]]++;
                }
                else
                {
                    flavour_count.Add(flavours[i],1);
                }
            }
            int maxCount = int.MinValue;
            string oddFlavour = "";
            //find the odd no of appearance of the flavours:
            bool oddCheck = false;
            for(int i=0;i<no_of_flavours;i++)
            {
                if(flavour_count[flavours[i]]%2!=0)
                {
                    oddCheck = true;
                    if(maxCount < flavour_count[flavours[i]])
                    {
                        maxCount = flavour_count[flavours[i]];
                        oddFlavour = flavours[i];
                    }
                }
            }
            if(oddCheck)
            {
                Console.WriteLine("\0"+oddFlavour+"\0"+" flavours appears an odd number of times.");
            }
            else
            {
                Console.WriteLine("All are Even.");
            }
            
        }
    }
}