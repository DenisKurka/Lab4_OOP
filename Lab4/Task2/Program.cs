using System;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Heir1 heir1 = new Heir1();
            Heir2 heir2 = new Heir2();
            Heir3 heir3 = new Heir3();
            A a = new A(heir1, heir2, heir3);
            double y = heir1.Math(1, 3);
            Console.WriteLine(y);
        }
    }
}
