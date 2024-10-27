/*
 * @lc app=leetcode id=151 lang=csharp
 *
 * [151] Reverse Words in a String
 */

// @lc code=start
public class Solution {
    public string ReverseWords(string s) {
        string[] words = s.Split(' ', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
        Array.Reverse(words);
        // GC.Collect();
        return string.Join(" ", words);
    }
}
// @lc code=end

