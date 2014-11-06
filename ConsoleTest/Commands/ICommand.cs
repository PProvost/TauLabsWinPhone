using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Log2Csv.Commands
{
    public interface ICommand
    {
        string CommandName { get; }

        void Invoke();
    }
}
