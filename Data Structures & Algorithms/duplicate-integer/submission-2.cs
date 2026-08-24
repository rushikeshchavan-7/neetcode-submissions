public class Solution {
    public bool hasDuplicate(int[] nums) {
        var seen = new HashSet<int>(nums);

        if (nums.Length == seen.Count)
        {
            return false;
        }
        return true;
    }
}