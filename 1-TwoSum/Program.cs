int[] nums = new int[] { 2, 7, 11, 15 };
int target = 25;
Console.WriteLine(string.Join(",", TwoSum(nums, target)));

int[] TwoSum(int[] nums, int target)
{
    for (int i = 0; i < nums.Length; i++)
    {
        for (int j = i + 1; j < nums.Length; j++)
        {
            if (nums[i] + nums[j] == target)
                return new int[] { i, j };
        }
    }
    return nums;
}
