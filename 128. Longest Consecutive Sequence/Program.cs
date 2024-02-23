int[] nums = new int[] { 100, 4, 200, 1, 3, 2 };

Console.WriteLine(LongestConsecutive(nums));
int LongestConsecutive(int[] nums)
{
    int[] consecutiveElements = new int[10];
    int index = 0;
    int Fsequence = 0;
    int Lsequence = 0;
    nums = SelectionSort(nums.ToList());
    for (int i = 1; i < nums.Length; i++)
    {
        if (Fsequence != nums[i] - nums[i - 1])
        {
            Fsequence = nums[i] - nums[i - 1];
            index++;
        }
        if (nums[i] - Fsequence == nums[i - 1])
        {
            consecutiveElements[index] += 1;
        }

    }
    return consecutiveElements[index];
}
static int[] SelectionSort(List<int> arr)
{
    var newArr = new int[arr.Count];
    for (int i = 0; i < newArr.Length; i++)
    {
        var smallest = FindSmallest(arr);
        newArr[i] = arr[smallest];
        arr.RemoveAt(smallest);
    }
    return newArr;
}
static int FindSmallest(List<int> arr)
{
    var smallest = arr[0];
    var smallestIndex = 0;
    for (int i = 1; i < arr.Count; i++)
    {
        if (arr[i] < smallest)
        {
            smallest = arr[i];
            smallestIndex = i;
        }
    }
    return smallestIndex;
}