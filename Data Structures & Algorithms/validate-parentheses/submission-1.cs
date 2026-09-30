public class Solution {
    public bool IsValid(string s) { //1
        if(s.Length % 2 != 0) return false;

        Stack<char> stk = new Stack<char>();


        bool rc= false;
        foreach(char ch in s) { //2
           switch (ch){
            case '(': 
                stk.Push(ch);
                break;
            case '{': 
                stk.Push(ch);
                break;
            case '[': 
                stk.Push(ch);
                break;
            
            //closing cases
            case ')':
                if(stk.Count ==0 || stk.Pop() != '('){
                    return false;
                    
                }
                break;
            case '}':
                if(stk.Count ==0 || stk.Pop() != '{'){
                    return false;
                    
                }
                break;
            case ']':
                if(stk.Count ==0 || stk.Pop() != '['){
                    return false;
                    
                }
                break;
           }

        }  //2
        return stk.Count == 0;
    }//1
}
