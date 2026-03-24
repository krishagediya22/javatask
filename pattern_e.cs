using System;

class Parent
{
    public int[][] arr;   // jagged array declare
}

class Child : Parent
{
    public Child()
    {
        arr = new int[3][];

        arr[0] = new int[] { 1, 1, 1, 1, 1 };
        arr[1] = new int[] { 1, 1, 1 };
        arr[2] = new int[] { 1, 1, 1, 1, 1 };
    }

    public void Show()
    {
        foreach (var row in arr)
        {
            foreach (var val in row)
            {
                Console.Write(val + " ");
            }
            Console.Write();
        }
    }
}

class Program
{
    static void Main()
    {
        Child obj = new Child();
        obj.Show();

        Console.ReadLine();
    }
}