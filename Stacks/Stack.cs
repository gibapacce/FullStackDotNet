using System;
using System.Collections.Generic;
using System.Text;

namespace Stacks
{
  public class Stack
  {
    private Node root = null;
    private Node current = null;
    private int length;

    public Node Root
    {
      get { return this.root; }
      set { this.root = value; }
    }

    public int Length
    {
      get { return this.length; }
      set { this.length = value; }
    }

    public void push(Node node)
    {
      node.Next = null;
      if (root == null)
      {
        root = node;
        length = 1;
        current = root;
        root.Prev = null;
      }
      else
      {
        current.Next = node;
        node.Prev = current;
        current = node;
        length++;
      }
    }

    public Node pop()
    {
      if (current == null)
      {
        return null;
      }
      else if (current == root)
      {
        Node n = current;
        current = null;
        root = null;
        length = 0;
        return n;
      }
      else
      {
        Node n = current;
        current = current.Prev;
        current.Next = null;
        length--;
        return n;
      }
    }
    public Node peek()
    {
      if (current == null || current.Next == null)
        return null;
      else
        return current.Next;
    }

    public Node getRoot()
    {
      current = root;
      return this.root;
    }



    public int getLengthOfStack()
    {
      return this.length;
    }

    public string listContents()
    {
      string retVal = "";

      current = root;
      while (current != null)
      {
        retVal += current.Data + " ";
        current = current.Next;
      }
      current = root;
      return retVal;
    }
  }
}
