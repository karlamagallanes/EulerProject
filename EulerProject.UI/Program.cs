using System;
using EulerProject.Business;
using EulerProject.Utilities;
namespace EulerProject.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Euler Project Simulator");
            Menu Menu = new Menu();
            Menu.Print();

            Problem1 problem = new Problem1();
            problem.Execute();
            
            Console.Read();
        }
    }
}
