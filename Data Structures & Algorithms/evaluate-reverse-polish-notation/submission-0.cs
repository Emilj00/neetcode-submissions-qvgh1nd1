public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<string> stack = [];

        foreach (string token in tokens) {
          if (token is "+" or "-" or "*" or "/") {
            int right = int.Parse(stack.Pop());
            int left = int.Parse(stack.Pop());

            int value = token switch {
              "+" => left + right,
              "-" => left - right,
              "*" => left * right,
              "/" => left / right,

              _ => throw new Exception("???? Shouldnt ever happen"),
            };

            stack.Push("" + value);
          }
          else {
            stack.Push(token);
          }
        }

        return int.Parse(stack.Pop());
    }
}
