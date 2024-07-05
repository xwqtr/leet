public class Solution
{
    public int MinDifference(int[] nums)
    {
        Array.Sort(nums);

        var avg = (int)Math.Round(nums.Average());

        var start = 0;
        var end = nums.Length - 1;
        var q = 3;
        while (q != 0)
        {
            var ds = Math.Abs(avg - nums[start]);
            var ds2 = Math.Abs(avg - nums[end]);
            if (ds >= ds2)
            {
                nums[start] = avg;
                start++;
            }
            else
            {
                nums[end] = avg;
                end--;
            }
            q--;
        }

        return Math.Abs(nums.Min() - nums.Max());
    }
}