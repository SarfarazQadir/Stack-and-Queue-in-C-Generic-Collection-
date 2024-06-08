using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_and_Queue__Generic_Collection_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Stack<string> stk = new Stack<string>();

            stk.Push("Sarfaraz");
            stk.Push("Shahid");
            stk.Push("Junaid");
            stk.Push("Adan");
            stk.Push("Kamal");

            foreach (var item in stk)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("The Delete Value is :" + stk.Pop());
            Console.WriteLine("The Peak Value is :" + stk.Peek());
            Console.ReadKey();
*/
            Queue<string> stk1 = new Queue<string>();
            stk1.Enqueue("Sarfaraz");
            stk1.Enqueue("Shahid");
            stk1.Enqueue("Junaid");
            stk1.Enqueue("Adan");
            stk1.Enqueue("Kamal");

            foreach (var item in stk1)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("The Delete Value is :" + stk1.Dequeue());
            Console.WriteLine("The Peak Value is :" + stk1.Peek());
            Console.ReadKey();

        }
    }
}
