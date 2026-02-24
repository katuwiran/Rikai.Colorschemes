namespace ColorschemeUtils;

/// <summary>
/// A static class that provides mappings of ColorSchemes to List ColorSchemeEntry
/// </summary>
public static class ColorSchemeEntry
{
	public static List<ColorEntry> Moonlight = FromColorScheme(ColorScheme.Moonlight);
	public static List<ColorEntry> Skylight  = FromColorScheme(ColorScheme.Skylight);

	private static List<ColorEntry> FromColorScheme(ColorScheme scheme)
	{
		ColorEntry padding = new() { Index = "", Name = "", HexCode = $"00000000" };
		List<ColorEntry> entries = new()
		{
			new() { Index = "bg0", Name = "base", HexCode     = $"#{scheme.Base}" },
			new() { Index = "bg1", Name = "surface", HexCode  = $"#{scheme.Surface}" },
			new() { Index = "bg2", Name = "overlay", HexCode  = $"#{scheme.Overlay}" },
			new() { Index = "fg0", Name = "text", HexCode     = $"#{scheme.Text}" },
			new() { Index = "fg1", Name = "subtle", HexCode   = $"#{scheme.Subtle}" },
			new() { Index = "fg2", Name = "inactive", HexCode = $"#{scheme.Inactive}" },
			new() { Index = "fg3", Name = "muted", HexCode    = $"#{scheme.Muted}" },
			new() { Index = "hi0", Name = "hi-inactive", HexCode = $"#{scheme.HighlightInactive}" },
			new() { Index = "hi1", Name = "highlight", HexCode   = $"#{scheme.Highlight}" },
			new() { Index = "hi2", Name = "hi-overlay", HexCode  = $"#{scheme.HighlightOverlay}" },
			new() { Index = "1", Name = "magenta", HexCode = $"#{scheme.Magenta}" },
			new() { Index = "2", Name = "lavender", HexCode = $"#{scheme.Lavender}" },
			new() { Index = "3", Name = "purple", HexCode  = $"#{scheme.Purple}" },
			new() { Index = "4", Name = "blue", HexCode    = $"#{scheme.Blue}" },
			new() { Index = "5", Name = "cyan", HexCode     = $"#{scheme.Cyan}" },
			new() { Index = "6", Name = "red", HexCode      = $"#{scheme.Red}" },
			new() { Index = "7", Name = "orange", HexCode   = $"#{scheme.Orange}" },
			new() { Index = "8", Name = "yellow", HexCode  = $"#{scheme.Yellow}" },
			new() { Index = "9", Name = "green", HexCode   = $"#{scheme.Green}" },
		};

		return entries;
	}
}