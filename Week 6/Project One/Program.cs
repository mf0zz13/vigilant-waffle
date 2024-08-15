using System;

namespace WeekSixGroupProject
{
    class ProjectOne
    {
        // Finds the most lucrative houses to rob that are not adjecent to other houses that will be robbed
        static int RobAHouse(int[] house)
        {
            // creating a touple that will keep track of inital index and values
            (int index, int value)[] valuesIndex = new (int index, int value)[house.Length];
            int[] indexUsed = new int[house.Length];
            int sum = 0;

            // For loop that takes inital array passed and puts values into new tuple array
            for (int i = 0; i < house.Length; i++)
            {
                valuesIndex[i].index = i;
                valuesIndex[i].value = house[i];
            }

            // Nested for loop to conduct a Select swap in decending order by value
            for (int i = 0; i < house.Length - 1; i ++)
            {
                int maxValPlace = i;
                for (int j = i + 1; j < house.Length; j++) { if (valuesIndex[maxValPlace].value < valuesIndex[j].value) { maxValPlace = j; } }

                if (valuesIndex[maxValPlace] != valuesIndex[i])
                {
                    (int index, int value) tempItem = valuesIndex[i];
                    valuesIndex[i] = valuesIndex[maxValPlace];
                    valuesIndex[maxValPlace] = tempItem;
                }
            }

            sum += valuesIndex[0].value;
            indexUsed[0] = valuesIndex[0].index;
            int postion = 1;

            // For loop to pick the house to rob based off if house is adjcent to a house that has already been robbed.
            for (int i = 1; i < house.Length; i++)
            {
                int lessThan = (valuesIndex[i].index) - 1;
                int moreThan = (valuesIndex[i].index) + 1;
                
                if (indexUsed.Contains(lessThan) || indexUsed.Contains(moreThan)) { continue; }
                else { indexUsed[postion] = valuesIndex[i].index ; postion++; sum += valuesIndex[i].value; }
            }
            return sum;
        }

        static void Main(string[] args)
        {
            int[] nums = new int[] { 2,7,9,3,1};
            Console.WriteLine(RobAHouse(nums));
            Console.ReadKey();
        }
    }
}