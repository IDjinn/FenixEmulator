namespace Api.Hotel.Rooms.Units.Utils
{
    public interface IUnitIdleable
    {
        public long IdleTimestamp { get; }
        public bool IsIdle { get; }
        public void StartIdle(long value);
        public void StopIdle();
    }
}
