using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteSomething();
            WriteSomethingSpecific("I am an argument!"); // The information inside the ("") is the argument. In other words this is what is being passed to the method's parameter.
        }

        public static void WriteSomething()
        {
            Console.WriteLine("I am called from a method");
        }

        public static void WriteSomethingSpecific(string myText) // string MyText is a parameter. This is what the method will require to have inorder to do the action.
        {
            Console.WriteLine(myText);
        }
    }
}
