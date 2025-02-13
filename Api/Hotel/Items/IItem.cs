﻿using System.Threading.Tasks;

using Api.Hotel.Habbos.Profile;
using Api.Hotel.Rooms;
using Api.Hotel.Rooms.Info;

namespace Api.Hotel.Items
{
    public interface IItem
    {
        public ulong Id { get; init; }
        public uint OwnerId { get; init; }
        public ushort ItemDataId { get; init; }
        public uint? RoomInfoId { get; init; }

        public IHabboProfile? Owner { get; }
        public IItemData? ItemData { get; }
        public IRoomInfo? RoomInfo { get; }

        public IRoom? Room { get; }
        public bool InRoom => Room is IRoom;

        public ValueTask Update(params object[] args);
        public void SetOwner(IHabboProfile? owner);
        public void SetItemData(IItemData? itemData);
        public void SetRoomInfo(IRoomInfo? roomInfo);
    }
}