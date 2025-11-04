// single dimensional integer array
int[] favNum = { 4, 8, 9, 12, 15 };
//Sorting Array in ascending order
Array.Sort(favNum);
// Reversing Sorted Array
Array.Reverse(favNum);
//Displaying Array elements
for (int i = 0; i < favNum.Length; i++)
{
    Console.WriteLine($"Element at index {i}: {favNum[i]}");
}
//finding the index of the element 9
int index = Array.IndexOf(favNum, 9);
Console.WriteLine($"Index of element 9: {index}");