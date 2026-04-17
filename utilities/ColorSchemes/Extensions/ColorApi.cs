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

	/// <summary>
	/// Adjusts the alpha of a color and flattens it over a background, returning a 6-hex.
	/// </summary>
	public static string AdjustAlphaAndFlatten(this string foregroundHex, double deltaAlpha, string backgroundHex = "FFFFFF")
	{
		var fg = new Unicolour(foregroundHex);
		var bg = new Unicolour(backgroundHex);

		// Calculate the new alpha
		double newAlpha = Math.Clamp(fg.Alpha.A + deltaAlpha, 0, 1);

		// Apply the new alpha to the foreground color
		var transparentFg = new Unicolour(
			ColourSpace.Rgb,
			fg.Rgb.R,
			fg.Rgb.G,
			fg.Rgb.B,
			newAlpha
		);

		// Blend over the background
		Unicolour result = transparentFg.Blend(bg, BlendMode.Normal);

		// Return the solid 6-character hex
		return result.Hex.TrimStart('#');
	}

	public static string FlattenAlpha(this string hex8, string backgroundHex = "FFFFFF")
	{
		var foreground = new Unicolour(hex8);
		var background = new Unicolour(backgroundHex);

		// Blend the foreground over the background
		Unicolour result = foreground.Blend(background, BlendMode.Normal);

		// Because the background is solid, the result is solid.
		// .Hex automatically returns a 6-character string here.
		return result.Hex.TrimStart('#');
	}
}
