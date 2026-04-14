public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length)
        {
            return false;
        }

        Dictionary<char, int> firstStringLetters = new();

        foreach (char c in s)
        {
            if (!firstStringLetters.ContainsKey(c))
            {
                firstStringLetters[c] = 0;
            }
            
            firstStringLetters[c]++;
        }

        foreach (char c in t)
        {
            if (!firstStringLetters.ContainsKey(c))
            {
                return false;
            }

            firstStringLetters[c]--;
            if (firstStringLetters[c] < 0)
            {
                return false;
            }
        }

        return true;
    }
}
