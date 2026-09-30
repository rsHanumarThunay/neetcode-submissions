public class Solution {
    public void DisplayStack<T>(Stack<T> stack) {
        foreach (T item in stack) {
        Console.WriteLine(item);
        }
    }

    public int CalPoints(string[] operations) {
        Stack<int> ans = new Stack<int> ();
        int sum = 0;

        for (int i = 0; i<operations.Length; i++){

            if(operations[i] == "+"){
                if(ans.Count>1){
                    //Console.WriteLine($"A1: {operations[i]}");
                    int a1 = ans.Pop();
                    int a2 = ans.Peek();
                    int a3= a1+a2;
                    ans.Push(a1);
                    ans.Push(a3);
                    //Console.WriteLine($"B1: {ans.Peek()}");
                }
            }
            else if(operations[i] == "D"){
                if(ans.Count >0 ){
                    //Console.WriteLine($"A2: {operations[i]}");
                    //DisplayStack(ans);
                    int b1 = ans.Peek();
                    //Console.WriteLine($"A2 peeked value: {b1}");
                    int b2= b1*2;
                    ans.Push(b2);
                    //Console.WriteLine($"B2: {ans.Peek()}");
                    //DisplayStack(ans);
                }
            }
            else if(operations[i] == "C"){
                if(ans.Count > 0){

                    int disp1 = ans.Pop();
                    
                }
            }
            else{
               //Console.WriteLine($"A4: {operations[i]}");
               //DisplayStack(ans);
                if (int.TryParse(operations[i], out int result)){
                    //Console.WriteLine($"Success: {result}");
                    ans.Push(result);
                }
                else{
                    //Console.WriteLine("Invalid integer format.");
                }

                //Console.WriteLine($"B4: {ans.Peek()}");
                //DisplayStack(ans);

            }
        }

        if (ans.Count ==0)
            return 0;
        while (ans.Count > 0)
        {
            int item = ans.Pop();
            sum = sum + item;
            Console.WriteLine($"C1: {item}");
        }

        return sum;
        
    }
}