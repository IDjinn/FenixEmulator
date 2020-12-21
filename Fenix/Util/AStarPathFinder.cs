using Fenix.Hotel.Rooms;
using Fenix.Hotel.Rooms.Floor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fenix.Util
{
    public sealed class AStarPathFinder
    {
        private IRoom room;
        public static Double Heuristic(IRoomTile inStart, IRoomTile inEnd)
        {
            return Math.Abs(inStart.X - inEnd.X) + Math.Abs(inStart.Y - inEnd.Y);
        }

        public static Double NeighborDistance(IRoomTile inStart, IRoomTile inEnd)
        {
            return Heuristic(inStart, inEnd);
        }

        public static void AStar(IRoomTile start, IRoomTile goal)
        {
            List<IRoomTile> openList = new List<IRoomTile>() { start };
            List<IRoomTile> closedList = new List<IRoomTile>();
            List<IRoomTile> neighbors = new List<IRoomTile>();

            while (openList.Count > 0)
            {
                IRoomTile? current = null;
                int index = -1;
                for (int i = 0; i < openList.Count; i++)
                {
                    if (current?.FScore > openList[i].FScore)
                        continue;

                    current = openList[i];
                    index = i;
                }
                if (current == goal)
                    return; //reconstruct_path

                closedList.Add(current!);
                openList.RemoveAt(index);

                for (int i = 0; i < neighbors.Count; i++)
                {
                    IRoomTile neighbor = neighbors[i];
                    float gScore = 0f;// some function here
                }
            }
        }
    }
}
