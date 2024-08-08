using System;


namespace Week5GroupProject
{
    class Project_1
    {
        static string CanBuyTwoChocs(int[] sortedArray, int money)
        {
            Array.Sort(sortedArray);
            int priceOfTwo = sortedArray[0] + sortedArray[1];
            switch (priceOfTwo <= money)
            {
                case true:
                    return $"You have {money - priceOfTwo:C2} left over ";
                    break;
                default:
                    return "You cannot afford two chocolates. ";
                    break;


            }
            return "Calcualtion Failed!";
        }

        static void Main(string[] args)
        {
            int[] chocArray = new int[] { 3, 2, 3 };
            Console.WriteLine(CanBuyTwoChocs(chocArray, 6));
            Console.ReadKey();
        }

    }
}



