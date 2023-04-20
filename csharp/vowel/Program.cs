namespace vowel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char ch;
            Console.WriteLine("enter an alphabet");
            ch = Convert.ToChar(Console.ReadLine());
            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' || ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
            {

                Console.WriteLine("entered character "+ch+" is vowel");

            }
            else
            {
                Console.WriteLine("entered character " + ch + " is not vowel");
            }
        }
    }
}