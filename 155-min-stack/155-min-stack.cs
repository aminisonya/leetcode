public class MinStack {

    public Stack<(int, int)> _stack;
    
    public MinStack() {
        _stack = new Stack<(int, int)>();
    }
    
    public void Push(int val) {
        var min = val;
        if (_stack.Count > 0)
        {
            var top = _stack.Peek();
            min = Math.Min(val, top.Item2);
        }
        _stack.Push((val, min));
    }
    
    public void Pop() {
        _stack.Pop();
    }
    
    public int Top() {
        var top = _stack.Peek();
        return top.Item1;
    }
    
    public int GetMin() {
        var top = _stack.Peek();
        return top.Item2;
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(val);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */