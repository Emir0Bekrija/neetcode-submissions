public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int[] pair = new int[2];
        for(int i=0; i<nums.Length-1; i++){
            for(int j=1; j<nums.Length; j++){
                if(nums[i]+nums[j]==target){
                    pair=new int[] {i,j};
                    return pair;
                }
            }
        }
        return new int[0];
    }
    
}
