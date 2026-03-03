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
			new() { Index = "bg0", Name = "background", HexCode       = $"#{scheme.Background}" },
			new() { Index = "bg1", Name = "bg-edges", HexCode         = $"#{scheme.BackgroundEdges}" },
			new() { Index = "bg2", Name = "bg-overlay", HexCode       = $"#{scheme.BackgroundOverlay}" },
			new() { Index = "fg0", Name = "text", HexCode             = $"#{scheme.Text}" },
			new() { Index = "fg1", Name = "txt-faded", HexCode        = $"#{scheme.TextFaded}" },
			new() { Index = "fg2", Name = "txt-inactive", HexCode     = $"#{scheme.TextInactive}" },
			new() { Index = "fg3", Name = "txt-hidden", HexCode       = $"#{scheme.TextHidden}" },
			new() { Index = "hi0", Name = "hi-low", HexCode           = $"#{scheme.HighlightLow}" },
			new() { Index = "hi1", Name = "highlight", HexCode        = $"#{scheme.Highlight}" },
			new() { Index = "hi2", Name = "hi-high", HexCode          = $"#{scheme.HighlightHigh}" },
			new() { Index = "1", Name   = scheme.ClassName, HexCode   = $"#{scheme.Class}" },
			new() { Index = "2", Name   = scheme.KeywordName, HexCode = $"#{scheme.Keyword}" },
			new() { Index = "3", Name   = scheme.MethodName, HexCode  = $"#{scheme.Method}" },
			new() { Index = "4", Name   = scheme.FieldName, HexCode   = $"#{scheme.Field}" },
			new() { Index = "5", Name   = scheme.StringName, HexCode  = $"#{scheme.String}" },
			new() { Index = "6", Name   = scheme.ErrorName, HexCode   = $"#{scheme.Error}" },
			new() { Index = "7", Name   = scheme.WarningName, HexCode = $"#{scheme.Warning}" },
			new() { Index = "8", Name   = scheme.InfoName, HexCode    = $"#{scheme.Info}" },
			new() { Index = "9", Name   = scheme.NumeralName, HexCode = $"#{scheme.Numeral}" },
		};

		return entries;
	}
}