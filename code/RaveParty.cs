using Sandbox;
using System;

public class RaveParty
{
    static readonly Random Rnd = new();

    [Event.Frame]
	public static void Rave()
	{
        Map.Scene.AmbientLightColor = Color.FromBytes(Rnd.Next(256), Rnd.Next(256), Rnd.Next(256), Rnd.Next(256));
    }
}