using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProject.Business
{
    public interface IProblem
    {
        void Init();
        void Execute();
    }
}
