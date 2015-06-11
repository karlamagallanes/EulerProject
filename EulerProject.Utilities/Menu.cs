using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using EulerProject.Business;

namespace EulerProject.Utilities
{
    public static class Menu
    {
        public static Dictionary<int, string> List;        
        public static void Init()
        {
            List = new Dictionary<int, string>();

            Assembly mscorlib = Assembly.ReflectionOnlyLoad("EulerProject.Business");
            foreach (Type type in mscorlib.GetTypes())
            {
                if (type.IsClass && !type.IsAbstract)
                {
                    List.Add(int.Parse(Regex.Match(type.FullName, @"\d+").Value), type.FullName.Split('.').Last());
                }
            }
        }

        public static void Print()
        {
            Console.Clear();
            Console.WriteLine("Euler Project Simulator");            
            Console.WriteLine("\nSelect:");
            foreach (KeyValuePair<int, string> item in List)
            { 
                Console.WriteLine(string.Format("{0} - {1}", item.Key, item.Value));
            }
            Console.WriteLine("Press the Escape (Esc) key to quit: \n");
        }
    }
}
