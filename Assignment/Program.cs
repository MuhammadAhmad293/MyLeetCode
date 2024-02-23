// Create a function that takes an array of items, removes all duplicate items and returns a new array in the same sequential order as the old array (minus duplicates).
// Examples
//removeDups([1, 5, 1, 0, 2, 5]) ➞ [1, 5, 0, 2]
//removeDups(["The", "big", "cat", "big"]) ➞ ["The", "big", "cat"]
//removeDups(["Sky", "is", "blue"]) ➞ ["Sky", "is", "blue"]
//removeDups(["John", "Taylor", "John"]) ➞ ["John", "Taylor"] 
//int[] nums1 = new int[] { 1, 5, 1, 0, 2, 5 };
//Console.WriteLine(string.Join(",", RemoveDublicate(nums1)));

//IEnumerable<T> RemoveDublicate<T>(IEnumerable<T> arr)
//{
//    HashSet<T> newArr = new ();
//    foreach (var item in arr)
//    {
//        if (!newArr.Add(item))
//        {

//        }
//    }
//    return newArr;
//}

//Console.WriteLine(CalcPageNumber(8, 9));
//int CalcPageNumber(int n, int page)
//{
//    int maxMove = page / 2;
//    int move = n / 2;
//    return maxMove;
//}

int[] nums = new int[] { 1, -2, -8, 4, 5 };
Console.WriteLine(ComputeClosestToZero(nums));
int ComputeClosestToZero(int[] ts)
{
    if (ts.Length is default(int))
        return default;

    int closestTemp = ts[0];
    for (int i = 1; i < ts.Length; i++)
    {
        if (Math.Abs(ts[i]) < Math.Abs(closestTemp))
            closestTemp = ts[i];
        else if (Math.Abs(ts[i]) == Math.Abs(closestTemp))
            closestTemp = ts[i];
    }
    return closestTemp;
}
