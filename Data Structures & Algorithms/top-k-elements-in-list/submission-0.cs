public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int , int> most_frequent = new Dictionary<int , int>();
        foreach(int num in nums){
            if(!most_frequent.ContainsKey(num)){
                most_frequent[num] = 1;
            }
            else{
                most_frequent[num]++;
            }
        }

        return most_frequent
            .OrderByDescending(pair => pair.Value)
            .Take(k)
            .Select(pair => pair.Key)
            .ToArray();
    }
}
