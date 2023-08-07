namespace ConfigurableItemSpawns;

using Exiled.API.Enums;
using Exiled.API.Features;
using UnityEngine;

public class Methods
{
    // Returns an absolute Vector3 based on a room's relative Vector3
    public static Vector3 RelativeToAbsolute(RoomType room, Vector3 relativePos) => Room.Get(room).Transform.TransformPoint(relativePos);

    // Returns a localized Vector3 based on a room and a position.
    public static Vector3 AbsoluteToRelative(Room room, Vector3 absolutePos) => room.Transform.InverseTransformPoint(absolutePos);
}