using System;
namespace  Question1
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter the number of days and prices");
            string daysAndPrices = Console.ReadLine().Replace("[","");
            daysAndPrices = daysAndPrices.Replace("]","");
            string[] noOfDaysAndPrices = daysAndPrices.Split(","); //Splitting the input string into an array of strings

            //Finding the maximum profit:
            bool continiousDown = true;
            
            //finding if the prices are conitnuously decreasing:
            for(int i=1;i<noOfDaysAndPrices.Length-1;i++)
            {
                if(int.Parse(noOfDaysAndPrices[i]) < int.Parse(noOfDaysAndPrices[i+1]))
                {
                    continiousDown = false;
                    break;
                }
            }

            //if the prices are not continously decreasing, we can find the maximum profit:
            if(!continiousDown)
            {
                int maxProfit = 0;
                int minPrice = int.Parse(noOfDaysAndPrices[1]);
                for(int i=2;i<noOfDaysAndPrices.Length;i++)
                {
                    if(int.Parse(noOfDaysAndPrices[i]) > minPrice)
                    {
                        int difer = int.Parse(noOfDaysAndPrices[i]) - minPrice;
                        if(difer > maxProfit)
                        {
                            maxProfit = difer;
                        }
                    }
                    else
                    {
                        minPrice = int.Parse(noOfDaysAndPrices[i]);
                    }
                }
                Console.WriteLine("maxProfit: "+maxProfit);
            }
            else
            {
                Console.WriteLine("The price always went down, so Meera never bought any property.");
            }

        }
    }
}