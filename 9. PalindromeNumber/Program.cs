Console.WriteLine(IsPalindrome(-121));

static bool IsPalindrome(int x)
{
    int r, sum = 0, target;
    for (target = x; x > 0; x = x / 10)
    {
        r = x % 10;
        sum = sum * 10 + r;
    }
    return target == sum;
}