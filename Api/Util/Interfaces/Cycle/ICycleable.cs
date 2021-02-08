using System.Threading.Tasks;

namespace Api.Util.Interfaces
{
    public interface ICycleable
    {
        public ushort CyclesInterval { get; }
        public ushort Ticks { get; set; }


        public abstract ValueTask OnCycle(params object[] args);
        public virtual async ValueTask OnTick(params object[] args)
        {
            if (Ticks++ >= CyclesInterval)
                await OnCycle(args);
        }
    }
}
