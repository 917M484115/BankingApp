using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aids.Logging
{
    public interface ILogBook
    {
        void WriteEntry(string message);

        void WriteEntry(Exception e);
    }
}
