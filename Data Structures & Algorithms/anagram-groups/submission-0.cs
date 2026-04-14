public class Solution
{
    public List<List<string>> GroupAnagrams(string[] strs)
    {
        var dictionary = new Dictionary<string, List<string>>();

        foreach (var str in strs)
        {
            int[] count = new int[27];

            foreach (char c in str)
            {
                count[c - 'a']++;
            }

            string key = String.Join(',', count);

            if (!dictionary.ContainsKey(key))
            {
                dictionary[key] = new List<string>();
            }

            dictionary[key].Add(str);
        }

        var result = new List<List<string>>();
        foreach (var (k, v) in dictionary)
        {
            result.Add(v);
        }

        return result;
    }
}
