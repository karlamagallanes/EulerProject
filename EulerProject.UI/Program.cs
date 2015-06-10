using System;
using System.Reflection;
using EulerProject.Business;
using EulerProject.Utilities;
namespace EulerProject.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo cki;
            Menu.Init();
            do
            {
                Menu.Print();
                string text = Console.ReadLine();
                int option;
                string className;
                if (int.TryParse(text, out option) && Menu.List.TryGetValue(option,out className))
                {
                    //TODO: Finish This

                    //Assembly magicAssembly = Assembly.ReflectionOnlyLoad("EulerProject.Business");
                    //Type magicType = magicAssembly.GetType("EulerProject.Business."+className);
                    //MethodInfo magicExecutor = magicType.GetMethod("Execute");
                    //magicExecutor.Invoke(new object(), new object[]{});
                    
                    Problem1 problem = new Problem1();
                    problem.Execute();
                }
                else
                {
                    Console.WriteLine("Not an valid option!");
                }
                Console.WriteLine("Press any key:");
                cki = Console.ReadKey();
            }
            while (cki.Key != ConsoleKey.Escape);
        }
    }
}
