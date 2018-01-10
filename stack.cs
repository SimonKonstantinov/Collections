using System;
using System.Collections.Generic;

namespace ConsoleApplication1
{
    class stack
    {
        static void Main()
        {

            char y;
            Console.WriteLine("Сколько элементов вы хотите создать?\n");

            int x = int.Parse(Console.ReadLine());

            var MyStack = new Stack<char>();

            while (MyStack.Count < x)
            {
                Console.WriteLine("\nсоздайте элемент");
                y = Console.ReadKey().KeyChar;
                MyStack.Push(y);
            }

            Console.WriteLine("\nИсходный стек: ");
            foreach (char s in MyStack)
            {
                Console.Write(s);
            }
            Console.WriteLine("\n");

            while (MyStack.Count > 0)
            {
                Console.WriteLine("Pop -> {0}", MyStack.Pop());
            }

            if (MyStack.Count == 0)
                Console.WriteLine("\nСтек пуст!");

            Console.ReadLine();
        }
    }
}