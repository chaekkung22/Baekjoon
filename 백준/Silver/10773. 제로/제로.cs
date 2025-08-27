using System;

class Program
{
    static void Main(string[] args)
    {
        int answer = 0;
        int num = 0;
        int max;
        Stack<int> stk = new Stack<int>();
        
        string input =  Console.ReadLine()!;

        int.TryParse(input, out max);
        
        for(int i = 0; i < max; i++)
        {
            input = Console.ReadLine()!;
            int.TryParse(input, out num);
            
            if(num == 0)
            {
                stk.Pop();
                continue;
            }
            
            stk.Push(num);
        }
        
        foreach(int number in stk)
        {
            answer+= number;
        }
        
        Console.WriteLine(answer);
    }
}
