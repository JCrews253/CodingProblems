using CodingProblems._2021.September;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblems.Tests._2021.September
{
  [TestFixture]
  class Problem_9_24_2021_Tests
  {
    private Problem_9_24_2021 _client = new Problem_9_24_2021();


    //The following test should pass:
    // node = Node('root', Node('left', Node('left.left')), Node('right'))
    // assert deserialize(serialize(node)).left.left.val == 'left.left'
    [Test]
    public void ProvidedExample()
    {
      var node = new Node("root", new Node("left", new Node("left.left", null, null), null), null);
      var result = _client.Deserialize(_client.Serialize(node)).Left.Left.Val;
      Assert.That(result, Is.EqualTo("left.left"));
    }

    [Test]
    public void CreatedTest()
    {
      //               root 
      //               /  \
      //            left   right
      //           /    \
      //          /      \
      //         /        \
      //    left.left  left.right
      var node = new Node("root", new Node("left", new Node("left.left", null, null), new Node("left.right", null, null)), new Node("right", null, null));
      var deserialized = _client.Deserialize(_client.Serialize(node));
      var root = deserialized.Val;
      var rootLeft = deserialized.Left.Val;
      var rootRight = deserialized.Right.Val;
      var rootLeftLeft = deserialized.Left.Left.Val;
      var rootLeftRight = deserialized.Left.Right.Val;

      var rootLeftLeftLeft = deserialized.Left.Left.Left;
      var rootLeftLeftRight = deserialized.Left.Left.Right;
      var rootRightLeft = deserialized.Right.Left;
      var rootRightRight = deserialized.Right.Right;

      Assert.That(root, Is.EqualTo("root"));
      Assert.That(rootLeft, Is.EqualTo("left"));
      Assert.That(rootRight, Is.EqualTo("right"));
      Assert.That(rootLeftLeft, Is.EqualTo("left.left"));
      Assert.That(rootLeftRight, Is.EqualTo("left.right"));

      Assert.That(rootLeftLeftLeft, Is.Null);
      Assert.That(rootLeftLeftRight, Is.Null);
      Assert.That(rootRightLeft, Is.Null);
      Assert.That(rootRightRight, Is.Null);
    }
  }
}
