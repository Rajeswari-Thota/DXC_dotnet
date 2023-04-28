using System.Collections;
namespace collections_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //Hashtable ht = new Hashtable();
           // ht.Add(1, "raji");
           // int x= ht.Count;
           // Console.WriteLine(x);
           Stack stack = new Stack();
            stack.Push(10);
            stack.Push(20);
            stack.Push("raji");
            stack.Pop();
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}