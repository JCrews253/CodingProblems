using CodingProblems._2021.September;
using NUnit.Framework;

namespace CodingProblems.Tests._2021.September
{
  [TestFixture]
  public class Problem_9_23_2021_Tests
  {
    private Problem_9_23_2021 _client = new Problem_9_23_2021();

    [TestCase(new[] { 1, 2, 3, 4, 5 }, new[] { 120, 60, 40, 30, 24 })]
    [TestCase(new[] { 3, 2, 1 }, new[] { 2, 3, 6 })]
    public void ProvidedExample(int[] arr, int[] expected)
    {
      var result = _client.WithDivision(arr);
      var result2 = _client.WithoutDivision(arr);
      Assert.That(result, Is.EqualTo(expected));
      Assert.That(result2, Is.EqualTo(expected));
    }

    // Assume no overflows occur and no zeros
    [TestCase(new[] { -8, -7, -4, -1,  9 }, new[] { -252, -288, -504,  -2016,  224 })]
    [TestCase(new[] { -6, -3, -2,  7,  9 }, new[] {  378,  756, 1134,   -324, -252 })] 
    [TestCase(new[] { -9, -8, -4, -2,  8 }, new[] { -512, -576, -1152, -2304,  576 })]
    [TestCase(new[] { -9, -8, -3, -2,  2 }, new[] {  -96, -108, -288,   -432,  432 })]
    public void CreatedTest(int[] arr, int[] expected)
    {
      var result = _client.WithDivision(arr);
      var result2 = _client.WithoutDivision(arr);
      Assert.That(result, Is.EqualTo(expected));
      Assert.That(result2, Is.EqualTo(expected));
    }
  }
}
