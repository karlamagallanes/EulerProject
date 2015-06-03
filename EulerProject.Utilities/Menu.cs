using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EulerProject.Utilities
{
    public class Menu
    {
        public Dictionary<int,string> GetData()
        {
            Dictionary<int, string> problems = new Dictionary<int, string>();
            Assembly mscorlib = typeof(string).Assembly;
            Type[] classes = mscorlib.GetTypes();
            for (int i = 0; i < classes.Count();i++)
            {
                problems.Add(i,classes[i].FullName);
            }
            return problems;
        }
    }
}
