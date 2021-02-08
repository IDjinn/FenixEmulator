using Api.Core;
using Api.Util.Interfaces;
using Server.Util;
using System.Collections.Generic;
using System.Timers;

namespace Server.Core
{
    public class CycleService : ICycleService
    {
        private IEnumerable<ICycleable> cycleables { get; init; }
        private Timer timer { get; init; }
        public CycleService(IEnumerable<ICycleable> cycleables)
        {
            this.cycleables = cycleables;
            timer = new Timer();
            foreach (var cycleableItem in this.cycleables)
            {
                timer.Elapsed += async (object sender, ElapsedEventArgs args) =>
                                   {
                                       await cycleableItem.OnTick(sender, args);
                                   };
            }
        }

        public void Start()
        {
            timer.Interval = Constants.GAME_TICK_DURATION;
            timer.AutoReset = true;
            timer.Start();
        }
    }
}
