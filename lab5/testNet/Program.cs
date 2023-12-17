using System;
using TestNetStandart;

namespace testNet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
			TestNetStandart.Program program = new TestNetStandart.Program();
			program.ShowMenu();
        }
    }
}
