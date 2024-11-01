/*
 * @lc app=leetcode id=334 lang=csharp
 *
 * [334] Increasing Triplet Subsequence
 */

// @lc code=start
public class Solution {
    public bool IncreasingTriplet(int[] nums) {
        // O(n) time complexity, O(1) space
        // can they skip?
        bool tripletExists = false;
        int n = nums.Length;
        int i = 0;
        int j;
        int k;

        // go three at a time. if conditions fail, skip to next number
        // i freaking knew it man
        // why didn't the spec say you could skip??
        while(!tripletExists) {
            if (i == n - 2) {
                return false;
            }
            j = i + 1;
            k = j + 1;
            if (nums[j] < nums[i]){
                i = j;
                continue;
            } else if (nums[k] < nums[j]) {
                i = k;
                continue;
            } else {
                tripletExists = true;
            }
        }
        
        return tripletExists;
    }
}
// @lc code=end

