using System;

public class Solution 
{
    public int[] solution(int brown, int yellow) 
    {
        int[] answer = new int[2];
        
        int total = brown + yellow;
        int sum = (brown + 4) / 2;
        
        for(int length = 1; length <= brown; length++)
        {
            int width = sum - length;
            
            if(width * length == total)
            {
                answer[0] = width;
                answer[1] = length;
                break;
            }
        }
        
        
        return answer;
    }
}