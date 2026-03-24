
//2...non static
using System;
class demo
{
    public static void fun()
    {
        Console.WriteLine("hello fun");
    }

    static void Main()
    {
        demo.fun();
    }
}
