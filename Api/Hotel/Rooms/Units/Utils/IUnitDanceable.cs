namespace Api.Hotel.Rooms.Units.Utils
{
    public interface IUnitDanceable
    {
        public byte DanceId { get; }
        public bool IsDancing { get; }
        public void StartDance(byte danceId);
        public void StopDance();
    }
}
