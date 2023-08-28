namespace CSharp.LeetCode._225;

//225. Implement Stack using Queues
//https://leetcode.com/problems/implement-stack-using-queues/description/
public class MyStack {
    private  Queue<int> _activeQueue = new Queue<int>();
    private  Queue<int> _backQueue = new Queue<int>();
    private int _top;
    public MyStack() {
        
    }
    
    public void Push(int x) {
        _activeQueue.Enqueue(x);
        _top = x;
    }
    
    public int Pop() {
        if(_activeQueue.Count<2){
            return _activeQueue.Dequeue();
        }

        while(_activeQueue.Count!=1){
            _top = _activeQueue.Dequeue();
            _backQueue.Enqueue(_top);
        }
        var result = _activeQueue.Dequeue();
        (_activeQueue,_backQueue) = (_backQueue,_activeQueue);
        return result;
    }
    
    public int Top() {
        return _top;
    }
    
    public bool Empty() {
        return _activeQueue.Count==0;
    }
}