using System;

namespace CustomStack
{
  public  class StartUp
    {
        static void Main()
        {
          StackOfStrings stack = new StackOfStrings();
 
        stack.Push("riba");
        stack.Push("rak");
        stack.Push("shtuka");
        stack.Push("sirene");
        Console.WriteLine(stack.Peek());
        Console.WriteLine(stack.Pop());
        Console.WriteLine(stack.Pop());
        Console.WriteLine(stack.Peek());
        Console.WriteLine(stack.IsEmpty());
        stack.Pop();
        stack.Pop();
        Console.WriteLine(stack.IsEmpty());
        }
    }
}