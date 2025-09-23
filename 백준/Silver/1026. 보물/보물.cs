using System;

class Program
{
    static void Main(string[] args)
    {
        int count;
        
        string input = Console.ReadLine();
        
        int.TryParse(input, out count);
        
        int[] arrayA = new int[count];
        int[] arrayB = new int[count];
        int[] arrayNew = new int[count];
        
        input = Console.ReadLine();
        string[] inputA = input.Split(' ');
        
        
        input = Console.ReadLine();
        string[] inputB = input.Split(' ');
        

        
        for(int i = 0; i < count; i++)
        {
            int.TryParse(inputA[i], out arrayA[i]);
            int.TryParse(inputB[i], out arrayB[i]);
        }
        
        Array.Sort(arrayA);
        
        
        for(int i = 0; i < count; i++)
        {
            int tempCount = 0;
            
            for(int j = 0; j < count; j++)
            {
                if(i == j) continue;
                
                if(arrayB[i] < arrayB[j] || (arrayB[j] == arrayB[i] && j < i))
                {
                    tempCount++;
                }
            }
            
            arrayNew[i] = arrayA[tempCount];
        }
        
        int sum = 0;
        
        for(int i = 0; i < count; i++)
        {
            sum += arrayNew[i] * arrayB[i];
        }
        
        Console.WriteLine(sum);
        
    }
}   