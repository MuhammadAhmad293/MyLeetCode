int[] nums1 = new int[] { 1, 2, 3, 0, 0, 0 };
int[] nums2 = new int[] { 2, 5, 6 };
int m = 3;
int n = 3;
Merge(nums1, m, nums2, n);

static void Merge(int[] nums1, int m, int[] nums2, int n)
{
    int mi = m - 1;
    int ni = n - 1;
    int len = m + n - 1;

    while (mi >= 0 || ni >= 0)
    {
        if (ni < 0)
            break;
        if (mi >= 0 && ni >= 0)
            nums1[len--] = nums1[mi] > nums2[ni] ? nums1[mi--] : nums2[ni--];
        else
            nums1[len--] = nums2[ni--];
    }
}

