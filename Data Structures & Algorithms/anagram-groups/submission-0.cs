public class Solution
{
    public List<List<string>> GroupAnagrams(string[] strs)
    {
        /*Dictionary<string, List<string>> groups = new Dictionary<string, List<string>>();
        foreach(string word in strs){
            string sorted = new string(word.OrderBy(c => c).ToArray());

            if(!groups.ContainsKey(sorted)){
                groups[sorted] = new List<string>();
            }
            groups[sorted].Add(word);
        }
        return groups.Values.ToList();*/

        Dictionary<string, List<string>> groups = new Dictionary<string, List<string>>();

        foreach(string word in strs){
            string sorted = new string(word.OrderBy(c => c).ToArray());

            if(!groups.ContainsKey(sorted)){
                groups[sorted] = new List<string>();
            }

            groups[sorted].Add(word);
        }
        return groups.Values.ToList();
    }
}