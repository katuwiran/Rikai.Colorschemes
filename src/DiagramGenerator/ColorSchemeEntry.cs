namespace ColorschemeUtils;

public class ColorSchemeEntry
{
	public required ColorEntry Base     { get; set; }
	public required ColorEntry Surface  { get; set; }
	public required ColorEntry Overlay  { get; set; }
	public required ColorEntry Inactive { get; set; }
	public required ColorEntry Subtle   { get; set; }
	public required ColorEntry Muted    { get; set; }
	public required ColorEntry Text     { get; set; }

	public required ColorEntry Magenta  { get; set; }
	public required ColorEntry Lavender { get; set; }
	public required ColorEntry Blue     { get; set; }
	public required ColorEntry Purple   { get; set; }
	public required ColorEntry Cyan     { get; set; }
	public required ColorEntry Green    { get; set; }
	public required ColorEntry Yellow   { get; set; }
	public required ColorEntry Red      { get; set; }
	public required ColorEntry Orange   { get; set; }

	public required ColorEntry Highlight         { get; set; }
	public required ColorEntry HighlightInactive { get; set; }
	public required ColorEntry HighlightOverlay  { get; set; }

	public static List<ColorEntry> Test      => ColorSchemeEntry.ToList(ColorSchemeEntry.FromColorScheme(ColorScheme.Test));
	public static List<ColorEntry> Moonlight => ColorSchemeEntry.ToList(ColorSchemeEntry.FromColorScheme(ColorScheme.Moonlight));
	public static List<ColorEntry> Skylight  => ColorSchemeEntry.ToList(ColorSchemeEntry.FromColorScheme(ColorScheme.Skylight));

	private static List<ColorEntry> ToList(ColorSchemeEntry scheme)
	{
		ColorEntry padding = new() { Index = "", Name = "", HexCode = $"00000000" };

		return new()
		{
			scheme.Base,
			scheme.Surface,
			scheme.Overlay,
			scheme.Inactive,
			scheme.Muted,
			scheme.Subtle,
			scheme.Text,
			padding,

			scheme.Magenta,
			scheme.Lavender,
			scheme.Blue,
			scheme.Purple,
			scheme.Cyan,
			scheme.Green,
			scheme.Yellow,
			scheme.Red,

			scheme.Orange,
			// padding,
			// padding,
			// padding,
			// padding,
			// padding,
			// padding,
			// padding,

			scheme.HighlightInactive,
			scheme.Highlight,
			scheme.HighlightOverlay
		};
	}

	private static ColorSchemeEntry FromColorScheme(ColorScheme scheme)
	{
		return new ColorSchemeEntry()
		{
			Base     = new() { Index = "10", Name = "base", HexCode     = $"#{scheme.Base}" },
			Surface  = new() { Index = "11", Name = "surface", HexCode  = $"#{scheme.Surface}" },
			Overlay  = new() { Index = "12", Name = "overlay", HexCode  = $"#{scheme.Overlay}" },
			Inactive = new() { Index = "13", Name = "inactive", HexCode = $"#{scheme.Inactive}" },
			Muted    = new() { Index = "14", Name = "muted", HexCode    = $"#{scheme.Muted}" },
			Subtle   = new() { Index = "13", Name = "subtle", HexCode   = $"#{scheme.Subtle}" },
			Text     = new() { Index = "6", Name  = "text", HexCode     = $"#{scheme.Text}" },

			Magenta  = new() { Index = "1", Name  = "magenta", HexCode  = $"#{scheme.Magenta}" },
			Lavender = new() { Index = "2", Name  = "lavender", HexCode = $"#{scheme.Lavender}" },
			Blue     = new() { Index = "3", Name  = "blue", HexCode     = $"#{scheme.Blue}" },
			Purple   = new() { Index = "4", Name  = "purple", HexCode   = $"#{scheme.Purple}" },
			Cyan     = new() { Index = "5", Name  = "cyan", HexCode     = $"#{scheme.Cyan}" },
			Green    = new() { Index = "7", Name  = "green", HexCode    = $"#{scheme.Green}" },
			Yellow   = new() { Index = "8", Name  = "yellow", HexCode   = $"#{scheme.Yellow}" },
			Red      = new() { Index = "9", Name  = "red", HexCode      = $"#{scheme.Red}" },
			Orange   = new() { Index = "10", Name = "orange", HexCode   = $"#{scheme.Orange}" },

			Highlight         = new() { Index = "10", Name = "highlight", HexCode   = $"#{scheme.Highlight}" },
			HighlightInactive = new() { Index = "10", Name = "hi-inactive", HexCode = $"#{scheme.HighlightInactive}" },
			HighlightOverlay  = new() { Index = "10", Name = "hi-overlay", HexCode  = $"#{scheme.HighlightOverlay}" },
		};
	}
}