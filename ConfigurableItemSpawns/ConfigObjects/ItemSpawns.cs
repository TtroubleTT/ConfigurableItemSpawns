namespace ConfigurableItemSpawns.ConfigObjects;

using Exiled.API.Enums;
using Exiled.API.Features;
using MapGeneration;
using UnityEngine;

public class ItemSpawns
{
    // Credit to Common Utils for this set up
    
    public RoomType Room { get; set; }
    
    public Vector3 Position { get; set; }
    
    public double Chance { get; set; }

    public void Deconstruct(out RoomType room, out Vector3 vector3, out double i)
    {
        room = Room;
        vector3 = Position;
        i = Chance;
    }
}