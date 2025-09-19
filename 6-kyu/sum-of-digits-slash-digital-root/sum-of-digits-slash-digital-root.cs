public class Number
{
  public static int DigitalRoot(long n)
  {
    
    int sum = 0;
    int[]nums = SplitNumbers(n);
    
    int[] SplitNumbers(long num)
      {
          string tempnumber = num.ToString();
    
          char[] tempsplitNumber = tempnumber.ToCharArray();
    
          int[] tempnums = new int[tempsplitNumber.Length];
    
          for(int i = 0; i < tempnums.Length; i++)
            {
              tempnums[i] = tempsplitNumber[i] - '0';
            }
      
      return tempnums;
      }
    
    foreach(int num in nums)
    {
      sum += num;
    }
    
    while(sum > 9)
      {
        nums = SplitNumbers((long)sum);
        sum = 0;
        
        foreach(int num in nums)
          {
            sum += num;
          }
      }
    
    return sum;
  }
}