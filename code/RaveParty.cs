using Sandbox;
using System;

public class RaveParty
{
    static readonly Random Rnd = new();
    static float elapsed;

    [ConVar.Replicated("ravespeed", Help = "The time between light changes in seconds (default = 0.1)", Min = 0f, Max = 10f, Saved = true)]
    public static float ravespeed { get; set; } = 0.1f;

    [Event.Client.Frame]
    public static void Rave()
    {
        elapsed += Time.Delta;
        if (elapsed < ravespeed) return;
        elapsed = 0f;
        Camera.Main.AmbientLightColor = Color.FromBytes(Rnd.Next(256), Rnd.Next(256), Rnd.Next(256), Rnd.Next(256));
    }
}