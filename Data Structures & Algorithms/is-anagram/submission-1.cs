public class Solution {
    public bool IsAnagram(string s, string t) {
        /* Solution 1
        if (s.Length!=t.Length){
            return false;
        }
        return s.OrderBy(c => c).SequenceEqual(t.OrderBy(c => c));*/

        /* Solution 2
        if (s.Length!=t.Length){
            return false;
        }

        int[] count = new int[26];

        foreach(char c in s){
            count[c - 'a']++;
        }

        foreach(char c in t){
            count[c-'a']--;
        }

        foreach(int n in count){
            if(n!=0){
                return false;
            }
        }

        return true;*/

        /*
        Solution 3
        */

        if (s.Length!=t.Length){
            return false;
        }

        Dictionary<char, int> count = new Dictionary<char, int>();

        for(int i =0; i< s.Length; i++){
            char c = s[i];
            if(count.ContainsKey(c)){
                count[c]++;
            }
            else{
                count[c]=1;
            }
        }

        for(int i=0; i < t.Length ; i++){
            char c = t[i];
            if(count.ContainsKey(c)){
                count[c]--;
            }
            else{
                return false;
            }

            if(count[c]<0){
                return false;
            }
        }

        return true;
    }
}
