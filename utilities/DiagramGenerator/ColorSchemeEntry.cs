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
			new() { Index = "bg0", Name = "background", HexCode   = $"#{scheme.Background}" },
			new() { Index = "bg1", Name = "bg-edges", HexCode     = $"#{scheme.BackgroundEdges}" },
			new() { Index = "bg2", Name = "bg-overlay", HexCode   = $"#{scheme.BackgroundOverlay}" },
			new() { Index = "fg0", Name = "text", HexCode         = $"#{scheme.Text}" },
			new() { Index = "fg1", Name = "txt-faded", HexCode    = $"#{scheme.TextFaded}" },
			new() { Index = "fg2", Name = "txt-inactive", HexCode = $"#{scheme.TextInactive}" },
			new() { Index = "fg3", Name = "txt-hidden", HexCode   = $"#{scheme.TextHidden}" },
			new() { Index = "hi0", Name = "hi-low", HexCode       = $"#{scheme.HighlightLow}" },
			new() { Index = "hi1", Name = "highlight", HexCode    = $"#{scheme.Highlight}" },
			new() { Index = "hi2", Name = "hi-high", HexCode      = $"#{scheme.HighlightHigh}" },
			new() { Index = "1", Name   = "magenta", HexCode      = $"#{scheme.Magenta}" },
			new() { Index = "2", Name   = "plum", HexCode         = $"#{scheme.Plum}" },
			new() { Index = "3", Name   = "purple", HexCode       = $"#{scheme.Purple}" },
			new() { Index = "4", Name   = "blue", HexCode         = $"#{scheme.Blue}" },
			new() { Index = "5", Name   = "cyan", HexCode         = $"#{scheme.Cyan}" },
			new() { Index = "6", Name   = "red", HexCode          = $"#{scheme.Red}" },
			new() { Index = "7", Name   = "orange", HexCode       = $"#{scheme.Orange}" },
			new() { Index = "8", Name   = "yellow", HexCode       = $"#{scheme.Yellow}" },
			new() { Index = "9", Name   = "green", HexCode        = $"#{scheme.Green}" },
		};

		return entries;
	}
}