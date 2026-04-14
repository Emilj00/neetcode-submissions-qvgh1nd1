public class Solution
{

    public string Encode(IList<string> strs)
    {
        string encoded = "";

        foreach (string s in strs)
        {
            encoded += s.Length + "#" + s;
        }

        return encoded;
    }

    public List<string> Decode(string s)
    {
        List<string> strings = new();
        int i = 0;

        while (i < s.Length)
        {
            int j = i;
            while (s[j] != '#')
            {
                j++;
            }

            int length = int.Parse(s.Substring(i, j - i));

            i = j + 1;
            j = i + length;

            strings.Add(s.Substring(i, length));

            i = j;
        }

        return strings;
    }
}
