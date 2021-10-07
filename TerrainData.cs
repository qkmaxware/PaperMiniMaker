using System;
using System.Collections.Generic;

namespace PaperMiniMaker {

public class TerrainArt {
    public string Url {get; set;}
}

public enum TerrainKind {
    Wall,
    Clip,
    Floor,
    Platform,
}

public static class TerrainKindMethods {
    public static string Description(this TerrainKind size) {
        return size switch {
            TerrainKind.Wall => "Vertical walls supported by a flat base.",
            TerrainKind.Clip => "Decoration which can be slid over walls, good for doors or windows.",
            TerrainKind.Floor => "Flat image for laying on the ground, good for carpets or trap doors.",
            TerrainKind.Platform => "Slightly raised box, good for applying ellivation to maps.",
            _ => string.Empty
        };
    }
}

public class Terrain {
    public string Name {get; set;}
    public TerrainKind Kind {get; set;}
    public TerrainArt Art {get; set;}
    public int Replicas {get; set;}

    public float Length {get; set;}
    public float Height {get; set;}
    public double HalfHeight => Height * 0.5f;
}

}