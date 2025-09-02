public static class Kata
{
  public static int Solution(int value)
  {
    if(value < 0) return 0;
    
    int num1 = 0;
    int num2 = 0;
    int num3 = 0;
​
    
    for(int i = 1; i * 3 < value; i++)
    {
      num1 += i * 3;
    }
    
    for(int i = 1; i * 5 < value; i++)
    {
      num2 += i * 5;
    }
    
    for(int i = 1; i * 15 < value; i++)
    {
      num3 += i * 15;
    }
    
    int answer = num1 +  num2 - num3;
​
    
    return answer;
  }
}