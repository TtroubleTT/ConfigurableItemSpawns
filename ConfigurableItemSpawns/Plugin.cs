namespace ConfigurableItemSpawns;

using System;
using Exiled.API.Features;
using Exiled.Events.Handlers;

public class Plugin : Plugin<Config>
{
    public static Plugin Singleton { get; private set; } = null!;
    
    public override string Name => "Configurable Item Spawns";

    public override string Author => "TtroubleTT";

    public override Version Version => new Version(1, 0, 0);
    
    public override void OnEnabled()
    {
        Singleton = this;

        base.OnEnabled();
    }
    public override void OnDisabled()
    {
        Singleton = null;

        base.OnDisabled();
    }
}