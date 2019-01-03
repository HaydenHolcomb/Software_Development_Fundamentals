using System;
using System.Collections;
using System.linq;
using System.Text;
using System.Threading.Tasks;

namespace MVA_Data_Structure_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Array sample
            string[] myArray = new string[] {"Item1", "Item2", "Item3", 
                "Item4", "Item5", "Item6", "Item7", "Item8", "Item9", "Item10"};

            Console.WriteLine("Item at index 2 is: " + myArray[2]);
            Console.WriteLine();

            Console.WriteLine("This is the contents of the array.");

            foreach (string value in myArray)
            {
                Console.WriteLine(value);
            }

            // Stack sample
            Stack myStack = new STack();
            myStack.Push("Item1");
            myStack.Push("Item2");
            myStack.Push("Item3");
            myStack.Push("Item4");
            myStack.Push("Item5");
            myStack.Push("Item6");
            myStack.Push("Item7");
            myStack.Push("Item8");
            myStack.Push("Item9");
            myStack.Push("Item10");

            Console.WriteLine("Initial stack count: " + myStack.Count);
            Console.WriteLine();

            while (myStack.Count > 0)
            {
                Object item = myStack.Pop();
                Console.WriteLine("Popped " + item.ToString() + " off the stack");
            }

            // Queue sample
            Queue myQueue = new Queue();
            myQueue.Enqueue("Item1");
            myQueue.Enqueue("Item2");
            myQueue.Enqueue("Item3");
            myQueue.Enqueue("Item4");
            myQueue.Enqueue("Item5");
            myQueue.Enqueue("Item6");
            myQueue.Enqueue("Item7");
            myQueue.Enqueue("Item8");
            myQueue.Enqueue("Item9");
            myQueue.Enqueue("Item10");

            Console.WriteLine(myQueue.Peek());
            Console.WriteLine(myQueue.Count);

            Object qValue = myQueue.Dequeue();
            Console.WriteLine(qValue.ToString());
            Console.WriteLine("Queue count is: " + myQueue.Count);
            Console.WriteLine(myQueue.Peek());

            // Dictionary sample
            Dictionary<string, string> myDictionary = new Dictionary<string, string>

            myDictionary.Add("key1", "First Item");
            myDictionary.Add("key2", "second Item");
            myDictionary.Add("key3", "Third Item");
            myDictionary.Add("key4", "Fourth Item");
            myDictionary.Add("key5", "Fifth Item");

            Console.WriteLine("Item represented by the key 'key 3': " + myDictionary[key3])

            myDictionary.Remove("key4");
        }
    }
}