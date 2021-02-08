using System.Threading.Tasks;

namespace Api.Util.Interfaces
{
    public interface IBeforeCycle
    {
        public abstract ValueTask BeforeCycle(params object[] args);
    }
}
