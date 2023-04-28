namespace inheritance
{
    public class Animal
    {
        
        public void Dog()
        {
            Console.WriteLine("i am dog");
        }
        public void Cat()
        {
            Console.WriteLine("i am cat");
        }
    }
    public class Food:Animal
    {
        public  Food()
        {
            Console.WriteLine("enter dog name");
            
            
            
        }
        public void show()
        {
            Console.WriteLine("eats grass");
        }
    }
    
        
    internal class Program
    {
        static void Main(string[] args)
        {
            Food f=new Food();
            f.show();
            f.Cat();
            
        }
    }
}