using System;


namespace Week5GroupProject
{
    class Project_1
    {
        static string CanBuyTwoChocs(int[] sortedArray, int money)
        {
            Array.Sort(sortedArray);
            int lowestPrice = sortedArray[0];

            for (int i = 1; i < sortedArray.Length; i++)
            {
                int priceOfTwo = lowestPrice + sortedArray[i];
                switch (priceOfTwo <= money)
                {
                    case true:
                        return $"You have {money - priceOfTwo:C2} left over ";
                        break;
                    default:
                        return "You cannot afford two chocolates. ";
                        break;


                }
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



