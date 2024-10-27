/*
 * @lc app=leetcode id=605 lang=csharp
 *
 * [605] Can Place Flowers
 */

// @lc code=start
public class Solution {
    public bool CanPlaceFlowers(int[] flowerbed, int n) {
        int[] paddedFlowerbed = new int[flowerbed.Length + 2];
        Array.Copy(flowerbed, 0, paddedFlowerbed, 1, flowerbed.Length);
        for (int i = 1; i < paddedFlowerbed.Length - 1; i++) {
            if(n == 0) {
                break;
            }
            int plotSum = PlotSum(new ArraySegment<int>(paddedFlowerbed, i - 1, 3));
            if (plotSum == 0) {
                paddedFlowerbed[i] = 1;
                n -= 1;
            }
        }
        
        GC.Collect();

        if (n == 0) {
            return true;
        } else {
            return false;
        }
    }

    public int PlotSum(ArraySegment<int> segment) {
        int[] ints = segment.ToArray();
        return ints.Sum();
    }
}
// @lc code=end

