using System;


namespace Week5GroupProject
{
    class Project_1
    {
        static string CanBuyTwoChocs(int[] sortedArray, int money)
        {
            // Sorting the array so it is order from least to greatest
            Array.Sort(sortedArray);

            // Finding the lowest price of two chocolates
            int priceOfTwo = sortedArray[0] + sortedArray[1];

            // Returning the money that is left over or that the user can not afford two chocolates.
            switch (priceOfTwo <= money)
            {
                case true:
                    return $"You have {money - priceOfTwo:C2} left over ";
                    break;
                default:
                    return "You cannot afford two chocolates. ";
                    break;
            }
            return "Calculation Failed!";
        }

        static void Main(string[] args)
        {
            int[] chocArray = new int[] { 3, 2, 3 };
            Console.WriteLine(CanBuyTwoChocs(chocArray, 6));
            Console.ReadKey();
        }
    }
}



