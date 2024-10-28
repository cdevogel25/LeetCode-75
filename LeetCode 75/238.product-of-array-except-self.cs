/*
 * @lc app=leetcode id=238 lang=csharp
 *
 * [238] Product of Array Except Self
 */

// @lc code=start
public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] prefixArray = new int[nums.Length];
        int[] suffixArray = new int[nums.Length];
        int[] returnArray = new int[nums.Length];

        prefixArray[0] = nums[0];
        suffixArray[nums.Length - 1] = nums[nums.Length - 1];

        for(int i = 1; i < nums.Length; i++) {
            prefixArray[i] = nums[i] * nums[i - 1];
        }

        for(int i = nums.Length - 2; i >= 0; i--) {
            suffixArray[i] = nums[i] * suffixArray[i + 1];
        }

        // for the prefix/suffix array: it's an alternating pointers thing
        // when the pointer is out of bounds of one, just use the other??
        for(int i = 0; i < nums.Length; i++) {
            if(i == 0) {
                returnArray[i] = suffixArray[suffixArray.Length - 1];
            } else if (i == nums.Length - 1) {
                returnArray[i] = prefixArray[prefixArray.Length - 1];
            } else {
                returnArray[i] = suffixArray[suffixArray.Length - i] * prefixArray[i - 1];
            }
        }

        
        return returnArray;
    }
}
// @lc code=end

