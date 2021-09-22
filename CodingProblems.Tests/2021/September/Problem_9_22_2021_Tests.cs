using NUnit.Framework;
using CodingProblems._2021.September;

namespace CodingProblems.Tests._2021.September
{
  [TestFixture]
  public class Problem_9_22_2021_Tests
  {
    private Problem_9_22_2021 _client = new Problem_9_22_2021();

    [TestCase(new[] { 10, 15, 3, 7 }, 17, true)]
    public void ProvidedExample(int[] arr, int sum, bool expected)
    {
      var result = _client.ContainsSum(arr, sum);
      Assert.That(result, Is.EqualTo(expected));
    }

    [TestCase(new int[0], 0, false)]
    [TestCase(new[] { 0 }, 0, false)]
    [TestCase(new[] { 0, 0 }, 0, true)]
    [TestCase(new[] { int.MaxValue, int.MaxValue }, 0, false)]
    [TestCase(new[] { int.MaxValue, int.MinValue }, 0, false)]
    [TestCase(new[] { int.MinValue, int.MaxValue }, 0, false)]
    [TestCase(new[] { int.MinValue, int.MinValue }, 0, false)]
    [TestCase(new[] { int.MaxValue, int.MinValue + 1 }, 0, true)]
    [TestCase(new[] { int.MinValue + 1, int.MaxValue }, 0, true)]
    [TestCase(new[] { -8, -7, -4, -1,  9 },  8, true)]
    [TestCase(new[] { -6, -3, -2,  7,  9 },  5, true)]
    [TestCase(new[] { -5, -1,  0,  4,  6 }, 10, true)]
    [TestCase(new[] { -9, -8, -4, -2,  8 }, -6, true)]
    [TestCase(new[] { -9, -8, -3, -2,  2 },  0, true)]
    [TestCase(new[] { -3,  3,  5,  8,  9 },  1, false)]
    [TestCase(new[] { -9, -8, -4, -1,  8 }, -3, false)]
    [TestCase(new[] { -3, -2,  3,  7,  9 },  3, false)]
    [TestCase(new[] { -2, -1,  1,  8, 10 },  5, false)]
    [TestCase(new[] { -9, -2,  1,  2,  4 },  7, false)]
    public void CreatedTest(int[] arr, int sum, bool expected)
    {
      var result = _client.ContainsSum(arr, sum);
      Assert.That(result, Is.EqualTo(expected));
    }
  }
}
