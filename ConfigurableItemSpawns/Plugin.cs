namespace ConfigurableItemSpawns;

using System;
using Exiled.API.Features;
using System.Collections.Generic;
using ConfigurableItemSpawns.ConfigObjects;
using Exiled.API.Enums;
using Scp914;
using UnityEngine;

public class Plugin : Plugin<Config>
{
    public static Plugin Singleton { get; private set; } = null!;
    
    public override string Name => "Configurable Item Spawns";

    public override string Author => "TtroubleTT";

    public override Version Version => new Version(1, 0, 0);
    
    public override void OnEnabled()
    {
        Singleton = this;

        Exiled.Events.Handlers.Server.WaitingForPlayers += EventHandlers.OnWaitingForPlayers;

        base.OnEnabled();
    }
    public override void OnDisabled()
    {
        Singleton = null;
        
        Exiled.Events.Handlers.Server.WaitingForPlayers -= EventHandlers.OnWaitingForPlayers;


        base.OnDisabled();
    }
}