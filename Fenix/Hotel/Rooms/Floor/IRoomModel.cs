﻿using Fenix.Util.Enums;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;

namespace Fenix.Hotel.Rooms.Floor
{
    public interface IRoomModel
    {
        public string Name { get; init; }
        public ushort DoorX { get; init; }
        public ushort DoorY { get; init; }
        public ushort DoorZ { get; init; }
        public Direction DoorDirection { get; init; }
        public string FloorHeigthMap { get; init; }
        public ReadOnlyDictionary<Point, IRoomTile> FloorMap { get; }


        public IRoomTile? GetRoomTile(Point point);
        public IRoomTile[] GetRoomTiles(Point[] points);
    }
}