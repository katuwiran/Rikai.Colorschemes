namespace Rikai.Colorschemes;

/// <summary>
/// A static class that provides mappings of ColorSchemes to List ColorSchemeEntry
/// </summary>
public static class ColorSchemeEntry
{
	public static List<ColorEntry> FromColorScheme(ColorScheme scheme)
	{
		ColorEntry padding = new() { Index = "", Name = "", HexCode = $"00000000" };
		List<ColorEntry> entries = new()
		{
			new ColorEntry { Index = "bg0", Name = "background", HexCode   = $"#{scheme.Colors.Background}" },
			new ColorEntry { Index = "bg1", Name = "bg-edges", HexCode     = $"#{scheme.Colors.BackgroundEdges}" },
			new ColorEntry { Index = "bg2", Name = "bg-overlay", HexCode   = $"#{scheme.Colors.BackgroundOverlay}" },
			new ColorEntry { Index = "fg0", Name = "text", HexCode         = $"#{scheme.Colors.Text}" },
			new ColorEntry { Index = "fg1", Name = "txt-faded", HexCode    = $"#{scheme.Colors.TextFaded}" },
			new ColorEntry { Index = "fg2", Name = "txt-inactive", HexCode = $"#{scheme.Colors.TextInactive}" },
			new ColorEntry { Index = "fg3", Name = "txt-hidden", HexCode   = $"#{scheme.Colors.TextHidden}" },
			new ColorEntry { Index = "hi0", Name = "hi-low", HexCode       = $"#{scheme.Colors.HighlightLow}" },
			new ColorEntry { Index = "hi1", Name = "highlight", HexCode    = $"#{scheme.Colors.Highlight}" },
			new ColorEntry { Index = "hi2", Name = "hi-high", HexCode      = $"#{scheme.Colors.HighlightHigh}" },
			new ColorEntry { Index = "ac1", Name = "accent 1", HexCode     = $"#{scheme.Accent.Primary}" },
			new ColorEntry { Index = "ac2", Name = "accent 2", HexCode     = $"#{scheme.Accent.Secondary}" },
			new ColorEntry { Index = "ac3", Name = "accent 3", HexCode     = $"#{scheme.Accent.Tertiary}" },
			padding,
			new ColorEntry { Index = "class", Name   = scheme.Colors.ClassName, HexCode   = $"#{scheme.Colors.Class}" },
			new ColorEntry { Index = "keyword", Name = scheme.Colors.KeywordName, HexCode = $"#{scheme.Colors.Keyword}" },
			new ColorEntry { Index = "method", Name  = scheme.Colors.MethodName, HexCode  = $"#{scheme.Colors.Method}" },
			new ColorEntry { Index = "field", Name   = scheme.Colors.FieldName, HexCode   = $"#{scheme.Colors.Field}" },
			new ColorEntry { Index = "string", Name  = scheme.Colors.StringName, HexCode  = $"#{scheme.Colors.String}" },
			new ColorEntry { Index = "error", Name   = scheme.Colors.ErrorName, HexCode   = $"#{scheme.Colors.Error}" },
			new ColorEntry { Index = "warning", Name = scheme.Colors.WarningName, HexCode = $"#{scheme.Colors.Warning}" },
			new ColorEntry { Index = "info", Name    = scheme.Colors.InfoName, HexCode    = $"#{scheme.Colors.Info}" },
			new ColorEntry { Index = "numeral", Name = scheme.Colors.NumeralName, HexCode = $"#{scheme.Colors.Numeral}" }
		};

		return entries;
	}
}
