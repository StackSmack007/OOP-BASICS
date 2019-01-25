using System;
using System.Collections.Generic;
using System.Linq;

namespace CustomStack
{
  public  class StackOfStrings
    {
        private List<string> List = new List<string>();

        public void Push(string item)
        {
            List.Add(item);
        }

        public string Pop()
        {
            string lastElement = Peek();
            List.RemoveAt(List.Count - 1);
            return lastElement;
        }

        public string Peek()
        {
            if (IsEmpty()) throw new ArgumentException("The Stack is empty");
            return List.Last();
        }

        public bool IsEmpty()
        {
            return List.Count==0;
        }
    }
}