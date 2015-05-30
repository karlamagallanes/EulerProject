using System;
using BL=EulerProject.Business;
namespace EulerProject.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Euler Project Simulator");

            Console.WriteLine("Run");

            BL.Menu Menu = new BL.Menu();
            Menu.Print();
            Console.Read();

        }
    }
}
