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
            MiniSize.Tiny => "Tiny: 12mm (0.5\")",
            MiniSize.Small => "Small: 25mm (1\")",
            MiniSize.Medium => "Medium: 25mm (1\")",
            MiniSize.Large => "Large: 50mm (2\")",
            MiniSize.Huge => "Huge: 76mm (3\")",
            MiniSize.Gargantuan => "Gargantuan: 102mm (4\")",
            _ => size.ToString()
        };
    }
    public static double BaseSizeInches (this MiniSize size) {
        return size switch {
            MiniSize.Tiny => 0.5,
            MiniSize.Small => 1,
            MiniSize.Medium => 1,
            MiniSize.Large => 2,
            MiniSize.Huge => 3,
            MiniSize.Gargantuan => 4,
            _ => 1
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
    public float Scale {get; set;} = 1;

    private int _replicas;
    public int Replicas {
        get => _replicas;
        set => _replicas = Math.Max(1, value);
    }

    public Mini Clone() {
        return new Mini{
            Name = this.Name,
            Size = this.Size,
            FrontArt = this.FrontArt == null ? null : new MiniArt {
                Url = this.FrontArt.Url
            },
            ReverseArt = this.ReverseArt == null ? null : new MiniArt {
                Url = this.ReverseArt.Url
            },
            Scale = this.Scale,
            Replicas = this.Replicas
        };
    }

    public MiniArt GetReverseArt() => ReverseArt != null && !string.IsNullOrEmpty(ReverseArt.Url) ? ReverseArt : FrontArt;
}

}