namespace ConfigurableItemSpawns;

using System.Collections.Generic;
using ConfigurableItemSpawns.ConfigObjects;
using Exiled.API.Enums;
using Exiled.API.Features;
using Exiled.API.Features.Pickups;
using MEC;
using UnityEngine;

public class EventHandlers
{
    public static void OnWaitingForPlayers()
    {
        Timing.CallDelayed(5f, () => Methods.SpawnBaseGameItems());
    }
}