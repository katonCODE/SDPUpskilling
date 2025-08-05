using System.Net.WebSockets;

namespace CS_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("c# basics");

            TestClass ts = new TestClass(6, 7);
            Console.WriteLine($"num 1 = {ts.num1}\n");
            Console.WriteLine($"num 2 = {ts.num2}\n");
            Console.WriteLine(ts.TestFunction());
        }

        class TestClass
        {
            public int num1 { get; set; }
            public int num2 { get; set; }
            public TestClass(int n1, int n2)
            {
                this.num1 = n1;
                this.num2 = n2;
            }
            public int TestFunction()
            {
                return this.num1 + this.num2;
            }


        }

    }
}