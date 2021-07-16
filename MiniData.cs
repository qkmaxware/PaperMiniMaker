using System;
using System.Collections.Generic;

namespace PaperMiniMaker {


public class MiniArt {
    public string Url {get; set;}
}

public enum MiniSize {
    Tiny, Small, Medium, Large, Huge, Gargantuan
}

public static class MiniSizeMethods {
    public static string Description(this MiniSize size) {
        return size switch {
            MiniSize.Tiny => "Tiny: 12mm x 14mm (0.5\" x 0.6\")",
            MiniSize.Small => "Small: 25mm x 20mm (1\" x 0.8\")",
            MiniSize.Medium => "Medium: 25mm x 28mm  (1\" x 1.1\")",
            MiniSize.Large => "Large: 50mm x 60mm (2\" x 2.4\")",
            MiniSize.Huge => "Huge: 76mm x 122mm (3\" x 4.8\")",
            MiniSize.Gargantuan => "Gargantuan: 102mm x 244mm (4\" x 9.6\")",
            _ => size.ToString()
        };
    }
    public static string CssClass (this MiniSize size) {
        return size switch {
            MiniSize.Tiny => "size-tiny",
            MiniSize.Small => "size-small",
            MiniSize.Medium => "size-medium",
            MiniSize.Large => "size-large",
            MiniSize.Huge => "size-huge",
            MiniSize.Gargantuan => "size-gargantuan",
            _ => "size-medium"
        };
    }
}

public class Mini {
    public string Name {get; set;}
    public MiniSize Size {get; set;}
    public MiniArt FrontArt {get; set;}
    public MiniArt ReverseArt {get; set;}

    private int _replicas;
    public int Replicas {
        get => _replicas;
        set => _replicas = Math.Max(1, value);
    }

    public MiniArt GetReverseArt() => ReverseArt != null && !string.IsNullOrEmpty(ReverseArt.Url) ? ReverseArt : FrontArt;
}

}