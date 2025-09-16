using System;

class Program
{
    static void Main(string[] args)
    {
        int count;
        int number;
        int answer = 0;
        
        string input = Console.ReadLine();
        
        int.TryParse(input, out count);
        
        int[] array = new int[count];
        
        input = Console.ReadLine();
        string[] numbers = input.Split(' ');
        
        for(int i = 0; i < count; i++)
        {
            int.TryParse(numbers[i], out array[i]);
        }
        
        input = Console.ReadLine();
        int.TryParse(input, out number);
        
        for(int i = 0; i < count; i++)
        {
            int num1 = array[i];
            
            for(int j = i + 1; j < count; j++)
            {
                int num2 = array[j];
                
                if(num1 + num2 == number)
                {
                    answer++;
                    break;
                }
            }
        }
        
        Console.WriteLine(answer);
    }
}