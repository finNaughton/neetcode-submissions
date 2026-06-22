public class Solution {
    public bool hasDuplicate(int[] nums) {
        int length = nums.Length;
        int current;
        for(int i = 0; i < length-1; i++) {
            current = nums[i];
            for(int j = i+1; j < length; j++) { 
                if(current == nums[j]) return true;
            }
        }
        return false;
    }
}