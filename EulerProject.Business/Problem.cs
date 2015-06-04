using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProject.Business
{
    public abstract class Problem : IProblem
    {
        public int id;
        public string Name;
        public abstract void Init();
        public abstract void Execute();
    }
}
