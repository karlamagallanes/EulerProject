using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EulerProject.Utilities
{
    public class Menu
    {
        private Dictionary<int, string> _list;

        public Menu()
        {
            GetData();
        }
        private  void GetData()
        {
            _list = new Dictionary<int, string>();

            Assembly mscorlib = Assembly.ReflectionOnlyLoad("EulerProject.Business");
            foreach (Type type in mscorlib.GetTypes())
            {
                if (type.IsClass&&!type.IsAbstract)
                    _list.Add(int.Parse(Regex.Match(type.FullName, @"\d+").Value), type.FullName.Split('.').Last());
            }
        }


        public void Print()
        {
            Console.WriteLine("\nSelect:");
            foreach (KeyValuePair<int, string> item in _list)
            { 
                Console.WriteLine(string.Format("{0} - {1}", item.Key, item.Value));
            }
        }
    }
}
