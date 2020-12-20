using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fenix.Util.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    class NoAuth : Attribute
    {
        public NoAuth()
        {

        }
    }
}
