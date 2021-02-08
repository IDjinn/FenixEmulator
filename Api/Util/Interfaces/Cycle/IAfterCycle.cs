using System.Threading.Tasks;

namespace Api.Util.Interfaces
{
    public interface IAfterCycle
    {
        public abstract ValueTask AfterCycle(params object[] args);
    }
}
