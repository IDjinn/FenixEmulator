using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Util.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public class NoAuth : Attribute
    {
        public NoAuth()
        {

        }
    }
}
