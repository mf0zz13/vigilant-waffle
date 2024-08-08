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
                switch (priceofTwo <= money)
                {
                    case true:
                        return $"You have {money - priceOfTwo:C2} left over ";
                        break;
                    default:
                        return "You cannot afford two chocolates. ";
                        break;

                }

            }

        }



        static void Main(string[] args)
        {




        }






    }









}


