public class Solution
{
    public int MaximumLength(int[] nums, int k)
    {
        var numOfProblems = 0;
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] != nums[i - 1])
            {
                numOfProblems++;
            }
        }
        if (numOfProblems <= k)
        {
            return nums.Length;
        }
        var toremove = numOfProblems - k;

        var ll = new LinkedList<int>(nums);


        while (toremove != 0 || ll.Count != 0)
        {
            LinkedListNode<int> fromLeft = ll.First;
            var leftcntr = 0;
            var rightCntr = 0;
            LinkedListNode<int> fromRight = ll.Last;
            while(fromLeft.Next)
        }

    }
}