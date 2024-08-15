# Project One
You are a professional robber planning to rob houses along a street. Each house has a certain amount of money stashed, the only constraint stopping you from robbing each of them is that adjacent houses have security systems connected and it will automatically contact the police if two adjacent houses were broken into on the same night. 

Given an integer array nums representing the amount of money of each house, return the maximum amount of money you can rob tonight without alerting the police. 

 

Example 1: 

Input: nums = [1,2,3,1] 

Output: 4 

Explanation: Rob house 1 (money = 1) and then rob house 3 (money = 3). 

Total amount you can rob = 1 + 3 = 4. 

Example 2: 

Input: nums = [2,7,9,3,1] 

Output: 12 

Explanation: Rob house 1 (money = 2), rob house 3 (money = 9) and rob house 5 (money = 1). 

Total amount you can rob = 2 + 9 + 1 = 12. 
# Sudo-Code
```
public static int RobAHouse(int[] house)
{
(int index, int value)[] valuesIndex = new (int index, int value)[house length]
int[] indexUsed = new int[house length]
int sum = 0

for(i equal to 0 while i less than house length index i)
{
	valuesIndex[0].index = i
	valuesIndex[0].value = houses[i]
}



for(int i equals 0 while i less than house length - 1 increment i)
{
	int minValPlace = i
	for(int j = i+1 while j less than house length increment j)
	{
	if valuesIndex[minValPlace].value < valuesIndex[j].value
		minValPlace = j
	}	

	if valuesIndex[minValPlace] != valuesIndex[i]
		(int index, int value) tempItem = valuesIndex[i]
		valuesIndex[i] = valuesIndex[minValPalce]
		vauesIndex[minValPlace] = tempItem
}

sum += valuesIndex[0].value
indexUsed[0] = valuesIndex.index

for(int i equals 1 while i less than house length increment i)
	
	int lessThan = valuesIndex[i].index - 1
	int moreThan = valuesIndex[i].index + 1
	
	if indexUsed contains lessThan or More than, continue
	else
		sum += valuesIndex[i].value
}
```