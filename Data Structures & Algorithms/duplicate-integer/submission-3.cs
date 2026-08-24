public class Solution {
    public bool hasDuplicate(int[] nums) {
       var HashNums = new HashSet<int>(nums);

       if (nums.Length == HashNums.Count)
       {
        return false;
       }
       return true;
    }
}