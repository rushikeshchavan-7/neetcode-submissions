public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) {
            return false;
        }

        var charCount = new Dictionary<char, int>();
        
        // Count characters in the first string
        foreach (char c in s) {
            if (charCount.ContainsKey(c)) {
                charCount[c]++;
            } else {
                charCount[c] = 1;
            }
        }
        
        // Decrease counts using the second string
        foreach (char c in t) {
            if (!charCount.ContainsKey(c)) {
                return false;
            }
            charCount[c]--;
            if (charCount[c] < 0) {
                return false;
            }
        }
        
        return true;
    }
}