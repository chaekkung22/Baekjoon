using System;

public class Solution
{
    public string solution(string[] cards1, string[] cards2, string[] goal) 
    {
        string answer = "";
        bool isSuccess = true;
        int count1 = 0;
        int count2 = 0;
        
        for(int i = 0; i < goal.Length; i++)
        {
            if(goal[i] == cards1[count1])
            {
                if(count1 < cards1.Length - 1)
                {
                    count1++;
                }

                continue;
            }
            else if(goal[i] == cards2[count2])
            {
                if(count2 < cards2.Length - 1)
                {
                    count2++;
                }
                continue;
            }
            
            isSuccess = false;
            break;
        }
        
        answer = isSuccess ? "Yes" : "No";
        
        return answer;
    }
}