public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<int> stack = [];

        foreach (string token in tokens) {
          if (int.TryParse(token, out int number)) {
            stack.Push(number);
          } else {
            int right = stack.Pop();
            int left = stack.Pop();

            int value = token switch {
              "+" => left + right,
              "-" => left - right,
              "*" => left * right,
              "/" => left / right,

              _ => throw new Exception("???? Shouldnt ever happen"),
            };

            stack.Push(value);
        }
     }

    return stack.Pop();
  }
}
