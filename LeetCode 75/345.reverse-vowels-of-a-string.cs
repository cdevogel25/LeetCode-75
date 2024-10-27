/*
 * @lc app=leetcode id=345 lang=csharp
 *
 * [345] Reverse Vowels of a String
 */

// @lc code=start
public class Solution {
    // public string ReverseVowels(string s) {
    //     List<char> vowelList = new List<char>();
    //     List<int> indexList = new List<int>();

    //     for(int i = 0; i < s.Length; i++) {
    //         if(
    //             s[i] == 'a' ||
    //             s[i] == 'e' ||
    //             s[i] == 'i' ||
    //             s[i] == 'o' ||
    //             s[i] == 'u' ||
    //             s[i] == 'A' ||
    //             s[i] == 'E' ||
    //             s[i] == 'I' ||
    //             s[i] == 'O' ||
    //             s[i] == 'U'
    //         ) {
    //             vowelList.Add(s[i]);
    //             indexList.Add(i);
    //         }
    //     }

    //     string s2 = "";
    //     for(int i = 0; i < s.Length; i++) {
    //         if(indexList.Contains(i)) {
    //             int reverseInd = indexList.IndexOf(i);
    //             s2 = s2 + vowelList[vowelList.Count - 1 - reverseInd];
    //         } else {
    //             s2 = s2 + s[i];
    //         }
    //     }

    //     GC.Collect();

    //     return s2;
    // }
    public string ReverseVowels(string s) {
        int left = 0;
        int right = s.Length - 1;
        StringBuilder str = new StringBuilder(s);

        while (left < right) {
            char tmp;
            if (!IsVowel(str[right])) {
                right--;
            } else if (!IsVowel(str[left])) {
                left++;
            } else if (IsVowel(str[left]) && IsVowel(str[right])) {
                tmp = str[left];
                str[left] = str[right];
                str[right] = tmp;
                left++;
                right--;
            } else {
                left++;
                right--;
            }
        }
        
        GC.Collect();
        return str.ToString();
    }

    public bool IsVowel(char c) {
        switch (c) {
            case 'A':
            case 'a':
                return true;
            case 'E':
            case 'e':
                return true;
            case 'I':
            case 'i':
                return true;
            case 'O':
            case 'o':
                return true;
            case 'U':
            case 'u':
                return true;
            default:
                return false;
        }
    }
}
// @lc code=end

