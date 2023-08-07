using Exiled.API.Features.Pickups;

namespace ConfigurableItemSpawns;

using System.Collections.Generic;
using ConfigurableItemSpawns.ConfigObjects;
using Exiled.API.Enums;
using Exiled.API.Features;
using UnityEngine;

public class EventHandlers
{
    public static void OnWaitingForPlayers()
    {
        foreach (KeyValuePair<ItemType, List<ItemSpawns>> item in Plugin.Singleton.Config.ItemSpawnPositions)
        {
            foreach ((RoomType room, Vector3 vector3, float chance) in item.Value)
            {
                float number = UnityEngine.Random.Range(1f, 101);
                Log.Debug($"Random number generated: {number} <= {chance}");
                if (UnityEngine.Random.Range(1f, 101) <= chance)
                {
                    Log.Debug("Chance check passed... spawning item");
                    Vector3 pos = Methods.RelativeToAbsolute(room, vector3);
                    Log.Debug($"Item: {item.Key}, Room: {room}, Relative Position: {vector3}, Absolute Position: {pos}");
                    Pickup.CreateAndSpawn(item.Key, pos, default);
                }
            }
        }
    }
}