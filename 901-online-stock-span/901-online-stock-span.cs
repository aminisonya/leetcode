public class StockSpanner {

    public Stack<(int Price, int Span)> Stack;
    
    public StockSpanner() {
        this.Stack = new Stack<(int, int)>();
    }
    
    public int Next(int price) {
        var span = 1;
        
        while (Stack.Count > 0 && Stack.Peek().Price <= price)
        {
            span = span + Stack.Pop().Span;
        }
        
        
        Stack.Push((price, span));
        return span;
    }
}

/**
 * Your StockSpanner object will be instantiated and called as such:
 * StockSpanner obj = new StockSpanner();
 * int param_1 = obj.Next(price);
 */