using System;

public class Solution
{
    public int solution(int n) 
    {
        int answer = 0;
        
        if(n % 2 == 1)
        {
            n -= 1;
        }
        
        while(0 < n)
        {
            answer += n;
            n -= 2;
        }
        
        
        return answer;
    }
}