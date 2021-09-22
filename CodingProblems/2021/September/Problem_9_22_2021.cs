using System.Collections.Generic;

namespace CodingProblems._2021.September
{
  public class Problem_9_22_2021
  {
    // Given a list of numbers and a number k, return whether any two numbers from the list add up to k.
    // For example, given[10, 15, 3, 7] and k of 17, return true since 10 + 7 is 17.
    public bool ContainsSum(int[] arr, int sum)
    {
      if (arr.Length < 2)
      {
        return false;
      }
      var hs = new HashSet<int>();

      for (int i = 0; i < arr.Length; i++)
      {
        try
        {
          int complement = checked(sum - arr[i]);
          if (hs.Contains(complement))
          {
            return true;
          }
          else
          {
            hs.Add(arr[i]);
          }
        }
        catch
        {
          hs.Add(arr[i]);
        }
      }
      return false;
    }
  }
}
