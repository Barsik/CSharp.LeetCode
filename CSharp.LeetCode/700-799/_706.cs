namespace CSharp.LeetCode._706;

//706. Design HashMap
//https://leetcode.com/problems/design-hashmap/description
public class MyHashMap {
    private readonly int _size = 100;
    private readonly Node[] _data;

    public MyHashMap() {
        _data = new Node[_size];
    }
    
    public void Put(int key, int value) {
        var hash = GetHash(key);
        var current = _data[hash];

        if(current==null){
            _data[hash] = new Node(key, value, null);
        }else{
            Node prev = null;
            while(current!=null && current.Key!=key){
                prev = current;
                current = current.Next;
            }

            if(current!=null){
                current.Value = value;
            }else{
                prev.Next = new Node(key, value, null);
            }
        }
    }
    
    public int Get(int key) {
        var hash = GetHash(key);
        var current = _data[hash];

        while(current!=null && current.Key!=key){
            current = current.Next;
        }

        if(current!=null){
            return current.Value;
        }

        return -1;
    }
    
    public void Remove(int key) {
        var hash = GetHash(key);
        var current = _data[hash];

        if(current!=null){
            Node prev = null;
            while(current!=null && current.Key!=key){
                prev = current;
                current = current.Next;
            }

            if(current!=null && prev!=null){
                prev.Next = current.Next;    
            }else if(current!=null && prev==null){
                _data[hash] = current.Next;
            }
        }
    }

    private int GetHash(int key){
        return key % _size;
    }

    private class Node{
        public int Key {get;set;}
        public int Value {get;set;}
        public Node Next {get;set;}

        public Node(int key, int value, Node next){
            Key = key;
            Value = value;
            Next = next;
        }
    }
}

/**
 * Your MyHashMap object will be instantiated and called as such:
 * MyHashMap obj = new MyHashMap();
 * obj.Put(key,value);
 * int param_2 = obj.Get(key);
 * obj.Remove(key);
 */