public class Solution
{
    public bool hasDuplicate(int[] nums)
    {
        HashSet<int> occuredNumbers = new();

        foreach (int n in nums)
        {
            if (occuredNumbers.Contains(n))
            {
                return true;
            }

            occuredNumbers.Add(n);

        }

        return false;
    }
}