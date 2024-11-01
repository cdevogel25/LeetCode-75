/*
 * @lc app=leetcode id=238 lang=csharp
 *
 * [238] Product of Array Except Self
 */

// @lc code=start
public class Solution {
    // O[n] solution
/*  public int[] ProductExceptSelf(int[] nums) {
        int[] prefixArray = new int[nums.Length];
        int[] suffixArray = new int[nums.Length];
        int[] returnArray = new int[nums.Length];
        int pInd;
        int sInd;

        // fix the first element of prefixArray to be the first element of nums
        prefixArray[0] = nums[0];
        // fix the last element of suffixArray to be the last element of nums
        suffixArray[nums.Length - 1] = nums[nums.Length - 1];

        // [1, 1*2, 1*2*3, etc...]
        for(int i = 1; i < nums.Length; i++) {
            prefixArray[i] = nums[i] * prefixArray[i - 1];
        }

        // [...2*3*4, 3*4, 4]
        for(int i = nums.Length - 2; i >= 0; i--) {
            suffixArray[i] = nums[i] * suffixArray[i + 1];
        }

        // start at suffix[1], prefix[-1], traverse in order to prefix[2]
        for(int i = 0; i < nums.Length; i++) {
            pInd = i - 1;
            sInd = i + 1;
            
            if (pInd < 0) {
                returnArray[i] = suffixArray[sInd];
            } else if (sInd >= nums.Length) {
                returnArray[i] = prefixArray[pInd];
            } else {
                returnArray[i] = suffixArray[sInd] * prefixArray[pInd];
            }
        }

        return returnArray;
    } */

    // efficient solution
    public int[] ProductExceptSelf(int[] nums) {
        int n = nums.Length;
        int[] right = new int[n];
        int[] res = new int[n];

        int prod = 1;
        for(int i = n - 1; i >= 0; i--) {
            prod *= nums[i];
            right[i] = prod;
        }

        prod = 1;
        for(int i = 0; i < n - 1; i++) {
            int leftProd = prod;
            int rightProd = right[i+1];

            res[i] = rightProd * leftProd;
            prod *= nums[i];
        }
        res[n-1] = prod;
        return res;
    }

}
// @lc code=end

