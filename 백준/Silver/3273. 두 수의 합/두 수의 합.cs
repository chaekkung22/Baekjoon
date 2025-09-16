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
        
        Array.Sort(array);
        
        int left = 0;
        int right = count - 1;
        
        while(left < right)
        {
            int sum = array[left] + array[right];
            
            if(sum == number)
            {
                answer++;
                left++;
                right--;
            }
            else if(sum < number)
            {
                left++;
            }
            else if(sum > number)
            {
                right--;
            }
        }
        
        Console.WriteLine(answer);
    }
}