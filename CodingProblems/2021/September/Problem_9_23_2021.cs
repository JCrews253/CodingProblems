namespace CodingProblems._2021.September
{
  //Given an array of integers, return a new array such that each element
  //at index i of the new array is the product of all the numbers in the original array except the one at i.

  // For example, if our input was[1, 2, 3, 4, 5], the expected output would be[120, 60, 40, 30, 24].
  // If our input was[3, 2, 1], the expected output would be[2, 3, 6].
  public class Problem_9_23_2021
  {
    public int[] WithDivision(int[] arr)
    {
      var totalProduct = 1;
      for (int i = 0; i < arr.Length; i++)
      {
        totalProduct = totalProduct * arr[i];
      }

      var newArr = new int[arr.Length];
      for (int i = 0; i < arr.Length; i++)
      {
        newArr[i] = totalProduct / arr[i];
      }
      return newArr;
    }

    // Follow-up: what if you can't use division?
    public int[] WithoutDivision(int[] arr)
    {
      var forward = new int[arr.Length];
      var backward = new int[arr.Length];

      for(int i = 0; i < arr.Length; i++)
      {
        if(i == 0)
        {
          forward[i] =  arr[i];
        }
        else
        {
          forward[i] = forward[i - 1] * arr[i];
        }  
      }

      for(int i = arr.Length - 1; i > -1; i--)
      {
        if(i == arr.Length - 1)
        {
          backward[i] = arr[i];
        }
        else
        {
          backward[i] = backward[i + 1] * arr[i];
        }
      }

      var newArr = new int[arr.Length];
      for(int i = 0; i < arr.Length; i++)
      {
        if(i == 0)
        {
          newArr[i] = backward[1];
        }
        else if(i == arr.Length - 1)
        {
          newArr[i] = forward[i - 1];
        }
        else
        {
          newArr[i] = forward[i - 1] * backward[i + 1];
        }
      }
      return newArr;
    }
  }
}
