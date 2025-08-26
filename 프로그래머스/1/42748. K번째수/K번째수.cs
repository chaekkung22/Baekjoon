using System;
using System.Collections.Generic;

public class Solution 
{
    public int[] solution(int[] array, int[,] commands) 
    {
        int[] answer = new int[commands.GetLength(0)];
        List<int> _array = new List<int>();
        
        for(int i = 0; i < commands.GetLength(0); i++)
        {
            _array.Clear();
            
            for(int j = commands[i, 0] - 1; j < commands[i, 1]; j++)
            {
               _array.Add(array[j]);
            }
            
            _array.Sort();
            
            answer[i] = _array[commands[i, 2] - 1];
        }
        
        return answer;
    }
}