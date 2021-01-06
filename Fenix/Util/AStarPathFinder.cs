using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

using Api.Hotel.Rooms.Floor;

namespace Server.Util.PathFinder
{
    public static class AStarPathFinder
    {
        public static IRoomTile[]? AStar(IRoomModel roomModel, IRoomTile start, IRoomTile goal)
        {
            IList<IRoomTile> openList = new List<IRoomTile>() { start };
            IList<IRoomTile> closedList = new List<IRoomTile>();

            float g = 0;
            while (openList.Count > 0)
            {
                IRoomTile? current = null;
                int index = -1;
                for (int i = 0; i < openList.Count; i++)
                {
                    if (current?.FScore <= openList[i].FScore)
                        continue;

                    current = openList[i];
                    index = i;
                }

                if (current == goal || current == null)
                {
                    openList.Reverse();
                    return openList.ToArray();
                }

                closedList.Add(current);
                openList.RemoveAt(index);
                g++;

                var neighbors = roomModel.GetRoomTiles(GetPointNeighbors(current.ToPoint));
                for (int i = 0; i < neighbors.Length; i++)
                {
                    var neighbor = neighbors[i];
                    if (closedList.Contains(neighbor))
                        continue;

                    if (neighbor.FloorState != FloorState.OPEN)
                    {
                        closedList.Add(neighbor);
                        continue;
                    }

                    var hScore = Heuristic(current, neighbor);
                    if (!openList.Contains(neighbor))
                    {
                        neighbor.GScore = g;
                        neighbor.FScore = neighbor.GScore + hScore;
                        neighbor.Parent = current;

                        openList.Insert(0, neighbor);
                    }
                    else if (g + hScore < neighbor.FScore)
                    {
                        neighbor.GScore = g;
                        neighbor.FScore = neighbor.GScore + hScore;
                        neighbor.Parent = current;
                    }
                }
            }

            return null;
        }

        public static float Heuristic(IRoomTile from, IRoomTile to)
        {
            return Math.Abs(from.X - to.X) + Math.Abs(from.Y - to.Y);
        }

        public static Point[] GetPointNeighbors(Point point, bool withDiagonal = true)
        {
            if (withDiagonal)
            {
                return new Point[]
                {
                    new Point(point.X+1,point.Y),
                    new Point(point.X-1,point.Y),
                    new Point(point.X,point.Y+1),
                    new Point(point.X,point.Y-1),

                    new Point(point.X+1,point.Y),
                    new Point(point.X-1,point.Y),
                    new Point(point.X,point.Y+1),
                    new Point(point.X,point.Y-1)
                };
            }
            else
            {
                return new Point[]
                {
                    new Point(point.X+1,point.Y),
                    new Point(point.X-1,point.Y),
                    new Point(point.X,point.Y+1),
                    new Point(point.X,point.Y-1)
                };
            }
        }
    }
}
