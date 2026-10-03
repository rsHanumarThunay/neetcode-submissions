public class MinStack {

    private Stack<int> mStack;
    private Stack<int> minStack;

    public MinStack() {
        mStack = new Stack<int>();
        minStack = new Stack<int>();

    }
    
    public void Push(int val) {
        mStack.Push(val);
        //int min = minStack.Count ==0 ? val : Math.Min(val,minStack.Peek());
        //minStack.Push(min);
        int min = int.MaxValue;
        if(minStack.Count == 0) {
            min = val;
        }
        else{
            min = Math.Min(val,minStack.Peek());
        }
        minStack.Push(min);
        
    }
    
    public void Pop() {
        mStack.Pop();
        minStack.Pop();
    }
    
    public int Top() {
        int rc= mStack.Peek();
        return rc;
        
    }
    
    public int GetMin() {
        
        int min = minStack.Peek();
        return min;
        
    }
}
