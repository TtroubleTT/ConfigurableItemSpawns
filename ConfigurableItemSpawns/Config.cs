namespace ConfigurableItemSpawns;

using Exiled.API.Interfaces;
using System.ComponentModel;
using System.Collections.Generic;
using ConfigurableItemSpawns.ConfigObjects;
using Exiled.API.Enums;
using Exiled.API.Features;
using Scp914;
using UnityEngine;

public class Config : IConfig
{
    [Description("Whether or not the plugin is enabled.")]
    public bool IsEnabled { get; set; } = true;

    [Description("Debug Config.")]
    public bool Debug { get; set; } = false;
    
    
    // Credit to common utils for inspiration for config set up
    [Description("List of basegame items to spawn on the map. Each section is the item you want to spawn. Room is the room the item will spawn in. Position is the x, y, z relative position of the item (gotten from the RayCastGun). Chance is the percent chance of it spawning at that position.")]
    public Dictionary<ItemType, List<ItemSpawns>> ItemSpawns { get; set; } = new()
    {
        {
            ItemType.Coin, new List<ItemSpawns>
            {
                new()
                {
                    Room = RoomType.Hcz049,
                    Position = new Vector3(1.5f, 2f, 3f),
                    Chance = 50,
                },
            }
        },
        {
            ItemType.Flashlight, new List<ItemSpawns>
            {
                new()
                {
                    Room = RoomType.Hcz106,
                    Position = new Vector3(2f, 5f, 1.4f),
                    Chance = 20,
                },
            }
        },
    };
}