using System;

public class Solution
{
    public int solution(int[] schedules, int[,] timelogs, int startday)
    {
        int answer = 0;
        bool canGetPresent = true;

        
        for(int i = 0; i < schedules.Length; i++)
        {
            canGetPresent = true;
            int currentday = startday;
            
            int deadline = schedules[i] + 10;
            
            
            int time = deadline / 100;
            int minute = deadline % 100;

            if(minute >= 60)
            {
                time = time + 1;
                minute = minute - 60;
                deadline = time * 100 + minute;
            }
            
            for(int j = 0; j < 7; j++)
            {
                if(currentday > 7)
                {
                    currentday = currentday - 7;
                }
                
                
                if(currentday == 6 || currentday == 7) 
                {
                    currentday++;
                    continue;
                }
                
                if(deadline < timelogs[i, j])
                {
                    canGetPresent = false;
                    break;
                }
                
                currentday++;
            }
            
            if(canGetPresent)
            {
                answer++;
            }

        }

        
        return answer;
    }
}