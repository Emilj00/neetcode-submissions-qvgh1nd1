public class MinStack {
    int index = 0;
    List<(int minIndexUpThisPoint, int value)> members = new();

    public void Push(int val) {
        int minIndex;

        if (index == 0) {
            minIndex = 0;
        } else {
            int currentMinIndex = members[index - 1].minIndexUpThisPoint;
            int currentMinValue = members[currentMinIndex].value;

            minIndex = val < currentMinValue ? index : currentMinIndex;
        }

        if (index < members.Count) {
            members[index] = (minIndex, val);
        } else {
            members.Add((minIndex, val));
        }

        index++;
    }

    public void Pop() {
        index--;
    }

    public int Top() {
        return members[index - 1].value;
    }

    public int GetMin() {
        int minIndex = members[index - 1].minIndexUpThisPoint;
        return members[minIndex].value;
    }
}
