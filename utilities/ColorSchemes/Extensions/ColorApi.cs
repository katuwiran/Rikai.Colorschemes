using Wacton.Unicolour;

namespace Rikai.Colorschemes;

public static class ColorApi
{
    public static string AdjustHsv(this string hex, double deltaS = 0, double deltaV = 0)
    {
        var color = new Unicolour($"#{hex}");
        
        // Grab existing HSB values
        double currentH = color.Hsb.H;
        double currentS = color.Hsb.S;
        double currentB = color.Hsb.B;

        // Create new color with clamped values
        var newColor = new Unicolour(
            ColourSpace.Hsb, 
            currentH, 
            Math.Clamp(currentS + deltaS, 0, 1), 
            Math.Clamp(currentB + deltaV, 0, 1)
        );

        return newColor.Hex.TrimStart('#');
    }
}