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
                    Type magicType = Type.GetType("EulerProject.Business." + className+", EulerProject.Business");
                    object instance = Activator.CreateInstance(magicType);
                    MethodInfo magicExecutor = magicType.GetMethod("Execute");
                    DateTime initTime= DateTime.Now;
                    magicExecutor.Invoke(instance, new object[]{});
                    Console.WriteLine(string.Format("Executed in {0} seconds", (DateTime.Now - initTime).TotalSeconds));
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
