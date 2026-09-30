public class Solution {
    public int[] GetConcatenation(int[] nums) {
        
        int loe = (nums.Length>0)?(nums.Length*2):0;
        int[] ans = new int[loe];

        int k= 0;
        while(k<loe){
            for (int i=0;i<nums.Length;i++ ){
                ans[k] = nums[i];
                k++;
            }
        }
        return ans;
        
    }
}