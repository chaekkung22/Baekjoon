using System;

class Program
{
    static void Main(string[] args)
    {
        int maxCount = 0;
        int num = 0;
        int currentNum = 0;
        List<(int index, int move)> nums = new List<(int index, int move)>();
        
        string? input = Console.ReadLine();
        
        int.TryParse(input, out maxCount);

        int[] answer = new int[maxCount]; 
        
        input = Console.ReadLine();
        string[] words = input.Split(' ');
        
        for(int i = 0; i < maxCount; i++)
        {
            if(int.TryParse(words[i], out int value))
            {
                nums.Add((i + 1, value));
            }
        }
        
        for(int i = 0; i < maxCount; i++)
        {
            if(nums.Count == maxCount)
            {
                currentNum = 0;
            }
            
            num = nums[currentNum].move;
            answer[i] = nums[currentNum].index;
            nums.RemoveAt(currentNum);
            
            if(nums.Count == 0) break;
            
            int steps;
            
            if(num > 0)
            {
                steps = (num - 1) % nums.Count;
            }
            else
            {
                steps = ((num % nums.Count) + nums.Count) % nums.Count;
            }
            
            currentNum = (currentNum + steps) % nums.Count;
        }
        
        for(int i = 0; i < answer.Length; i++)
        {
            Console.Write(answer[i] + " ");
        }
    }
}