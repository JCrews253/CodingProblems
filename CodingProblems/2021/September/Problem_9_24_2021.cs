using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblems._2021.September
{
  // Given the root to a binary tree, implement serialize(root),
  // which serializes the tree into a string, and deserialize(s),
  // which deserializes the string back into the tree.

  // class Node:
  // def __init__(self, val, left= None, right= None):
  //      self.val = val
  //      self.left = left
  //      self.right = right

  public record Node(string Val, Node Left, Node Right);

  public class Problem_9_24_2021
  {
    private int _index;

    public string Serialize(Node root)
    {
      if(root == null)
      {
        return "null";
      }
      return root.Val + ',' + Serialize(root.Left) + ',' + Serialize(root.Right);
    }

    public Node Deserialize(string data)
    {
      _index = 0;
      return DeserializeHelper(data.Split(','));
    }

    private Node DeserializeHelper(string[] data)
    { 
      if(_index >= data.Length)
      {
        return null;
      }
      var  current = data[_index++];
      if(current == "null")
      {
        return null;
      }
      var node = new Node(current, DeserializeHelper(data), DeserializeHelper(data));
      return node;
    }
  }
}
