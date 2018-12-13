using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concurrency
{
    public class DelayAction
    {
        Action<string> toDo;

        public DelayAction(Action<string> toDoAction)
        {
            toDo = toDoAction;                 
        }

        public void Run(Action<string> todoOK, Action<string> todoNOK)
        {
            todoOK.Invoke(string.Empty);
            todoNOK.Invoke(string.Empty);
        }
    }
}
