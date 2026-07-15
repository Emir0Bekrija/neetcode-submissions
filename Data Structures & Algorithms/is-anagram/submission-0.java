class Solution {
    public boolean isAnagram(String s, String t) {
        return sort(s).equals(sort(t));


        /*if(s.length()!=t.length()){
            return false;
        }
        else{
            HashMap<Character, Integer> map = new HashMap<>();
            for (int i = 0; i < s.length(); i++) {
                char ch = s.charAt(i); // get the character at index i
                map.put(ch, map.getOrDefault(ch, 0) + 1); // update the count
            }
            for (int i=0; i<t.length(); i++){
                char ch = t.charAt(i);
                if(!map.containsKey(ch)){
                    return false;
                }

                map.put(ch, map.get(ch)-1);

                if(map.get(ch)<0){
                    return false;
                }
            }
            return true;
        }*/

    }

    private String sort(String str){
        char[] chars = str.toCharArray();
        Arrays.sort(chars);
        return new String(chars);
    }

}
