using System;
using System.Collections.Generic;

namespace StacksExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define a new stack
            Stack<int> stack = new Stack<int>();

            // Run Pop() only if there is at least one item in the stack
            if(stack.Count > 0)
            {
                stack.Pop();
            }

            // Add elements to the stack using Push()
            stack.Push(3);

            // Peek() will return the element at the top of the stack
            Console.WriteLine("Top value in the stack: {0}", stack.Peek());
            stack.Push(7);
            Console.WriteLine("Top value in the stack: {0}", stack.Peek());
            stack.Push(11);
            Console.WriteLine("Top value in the stack: {0}", stack.Peek());

            // Pop() removes top item from stack
            int myStackItem = stack.Pop();
            Console.WriteLine("Popped item: {0}", myStackItem);

            Console.WriteLine("Top value in the stack: {0}", stack.Peek());

            // As long as count > 0; as long as the stack is not empty
            while (stack.Count > 0)
            {
                Console.WriteLine("The top value {0} was removed from the stack.", stack.Pop());
                Console.WriteLine("Current stack count: {0}", stack.Count);
            }
        }
    }
}
