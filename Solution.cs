// public class Solution
// {
//     public int MaximumLength(int[] nums, int k)
//     {
//         if(k==0)
//         {
//             return nums.GroupBy(x=>x).Max(x=>x.Count());
//         }
//         var dp = new int[k + 1, nums.Length + 1];
//         var result = 0;
//         for (int row = 1; row < k + 1; row++)
//         {
//             ///1	2	1	1	3
//             var prevRow = row - 1;
//             for (int i = 1; i <= nums.Length; i++)
//             {
//                 for (int j = 0; j < i; j++)
//                 {
//                     if (j > 0 && nums[i - 1] == nums[j - 1])
//                     {
//                         dp[row, i] = Math.Max(dp[row, i], dp[row, j] + 1);
//                     }
//                     else
//                     {
//                         dp[row, i] = Math.Max(dp[row, i], 1);
//                     }
//                 }
//                 for (int j = 0; j < i; j++)
//                 {
//                     dp[row, i] = Math.Max(dp[prevRow, j] + 1, dp[row, i]);
                    
//                 }
//                 result = Math.Max(result, dp[row, i]);
//             }
//         }
//         return result;

//     }
// }