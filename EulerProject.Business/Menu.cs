using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EulerProject.Business 
{
    public class Menu
    {
     
        public Dictionary<int, string> Print(){
            Dictionary<int, string> list = new Dictionary<int, string>();

            Assembly mscorlib = Assembly.ReflectionOnlyLoad("EulerProject.Business");
            foreach (Type type in mscorlib.GetTypes())
            {
                Console.WriteLine(type.FullName);
            }
            return list;
        }
    }
}
