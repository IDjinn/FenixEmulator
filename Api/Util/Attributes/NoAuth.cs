using System;

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
