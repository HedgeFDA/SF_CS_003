using System;

class Program
{
    public static void Main(string[] args)
    {
        string Name = "Jane";
        byte Age    = 27;
        bool Pet    = true;
        float Size  = 37.5F;

        Console.WriteLine("My name is " + Name);
        Console.WriteLine("My age is " + Age);
        if (Pet) {
            Console.WriteLine("I have a pet");
        }
        else
        {
            Console.WriteLine("I don't have a pet");
        }
        Console.WriteLine("My shoe size is " + Size);
    }
}