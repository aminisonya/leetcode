public class MyQueue {

    public Stack<int> stackOne;
    public Stack<int> stackTwo;
    
    public MyQueue() {
        stackOne = new Stack<int>();
        stackTwo = new Stack<int>();
    }
    
    public void Push(int x) {
        stackOne.Push(x);
    }
    
    public int Pop() {
        while (stackOne.Count > 1)
        {
            var curr = stackOne.Pop();
            stackTwo.Push(curr);
        }
        
        var firstInStack = stackOne.Pop();
        
        while (stackTwo.Count > 0)
        {
            var curr = stackTwo.Pop();
            stackOne.Push(curr);
        }
        
        return firstInStack;
    }
    
    public int Peek() {
        while (stackOne.Count > 1)
        {
            var curr = stackOne.Pop();
            stackTwo.Push(curr);
        }
        
        var firstPeek = stackOne.Peek();
        
        while (stackTwo.Count > 0)
        {
            var curr = stackTwo.Pop();
            stackOne.Push(curr);
        }
        
        return firstPeek;
    }
    
    public bool Empty() {
        return (stackOne.Count == 0);
    }
}

/**
 * Your MyQueue object will be instantiated and called as such:
 * MyQueue obj = new MyQueue();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Peek();
 * bool param_4 = obj.Empty();
 */