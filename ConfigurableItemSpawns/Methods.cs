namespace ConfigurableItemSpawns;

using Exiled.API.Enums;
using Exiled.API.Features;
using UnityEngine;
using System.Collections.Generic;
using ConfigurableItemSpawns.ConfigObjects;
using Exiled.API.Features.Pickups;

public class Methods
{
    // Returns an absolute Vector3 based on a room's relative Vector3
    public static Vector3 RelativeToAbsolute(RoomType room, Vector3 relativePos) => Room.Get(room).Transform.TransformPoint(relativePos);

    // Returns a localized Vector3 based on a room and a position.
    public static Vector3 AbsoluteToRelative(Room room, Vector3 absolutePos) => room.Transform.InverseTransformPoint(absolutePos);

    public static void SpawnBaseGameItems()
    {
        foreach (KeyValuePair<ItemType, List<ItemSpawns>> item in Plugin.Singleton.Config.ItemSpawnPositions)
        {
            foreach ((RoomType room, Vector3 vector3, float chance) in item.Value)
            {
                float number = UnityEngine.Random.Range(1f, 101);
                Log.Debug($"Random number generated: {number} <= {chance}");
                if (number <= chance)
                {
                    Log.Debug("Chance check passed... spawning item");
                    Vector3 pos = Methods.RelativeToAbsolute(room, vector3);
                    Log.Debug($"Item: {item.Key}, Room: {room}, Relative Position: {vector3}, Absolute Position: {pos}");
                    Pickup.CreateAndSpawn(item.Key, pos, Quaternion.identity);
                }
            }
        }
    }
}