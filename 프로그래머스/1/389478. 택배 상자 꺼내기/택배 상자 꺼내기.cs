using System;

public class Solution 
{
    public int solution(int n, int w, int num)
    {
        int answer = 1;
        int maxLine = 0;
        int numLine = 0;
        
        int numIndex = 0;
        
        
        
        maxLine = n % w == 0 ?  n / w : n / w + 1;
        
        numLine = num % w == 0 ? num / w : num / w + 1;
        
        numIndex = numLine % 2 == 0 ?  (w - 1) - (num - 1) % w : (num - 1) % w;
        

    
            for(; numLine < maxLine; numLine++)
            {
                if(numLine % 2 == 0)
                {
                    if((numLine + 1) * w - (w - numIndex) <= n)
                    {
                        answer++;
                    }
                }
                else
                {
                    if((numLine + 1) * w - numIndex <= n)
                    {
                        answer++;
                    }
                }
            }

        return answer;
    }
}