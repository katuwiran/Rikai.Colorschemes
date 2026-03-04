namespace Rikai.Colorschemes;

/// <summary>
/// A static class that provides mappings of ColorSchemes to List ColorSchemeEntry
/// </summary>
public static class ColorSchemeEntry
{
	public static List<ColorEntry> MoonlightEntries = FromColorScheme(ColorSchemeFactory.Moonlight());
	public static List<ColorEntry> SkylightEntries  = FromColorScheme(ColorSchemeFactory.Skylight());
	public static List<ColorEntry> ChaosEntries     = FromColorScheme(ColorSchemeFactory.Chaos());
	
	private static List<ColorEntry> FromColorScheme(ColorScheme scheme)
	{
		// ColorEntry padding = new() { Index = "", Name = "", HexCode = $"00000000" };
		List<ColorEntry> entries = new()
		{
			new() { Index = "bg0", Name = "background", HexCode   = $"#{scheme.Colors.Background}" },
			new() { Index = "bg1", Name = "bg-edges", HexCode     = $"#{scheme.Colors.BackgroundEdges}" },
			new() { Index = "bg2", Name = "bg-overlay", HexCode   = $"#{scheme.Colors.BackgroundOverlay}" },
			new() { Index = "fg0", Name = "text", HexCode         = $"#{scheme.Colors.Text}" },
			new() { Index = "fg1", Name = "txt-faded", HexCode    = $"#{scheme.Colors.TextFaded}" },
			new() { Index = "fg2", Name = "txt-inactive", HexCode = $"#{scheme.Colors.TextInactive}" },
			new() { Index = "fg3", Name = "txt-hidden", HexCode   = $"#{scheme.Colors.TextHidden}" },
			new() { Index = "hi0", Name = "hi-low", HexCode       = $"#{scheme.Colors.HighlightLow}" },
			new() { Index = "hi1", Name = "highlight", HexCode    = $"#{scheme.Colors.Highlight}" },
			new() { Index = "hi2", Name = "hi-high", HexCode      = $"#{scheme.Colors.HighlightHigh}" },

			new() { Index = "1", Name = scheme.Colors.ClassName, HexCode   = $"#{scheme.Colors.Class}" },
			new() { Index = "2", Name = scheme.Colors.KeywordName, HexCode = $"#{scheme.Colors.Keyword}" },
			new() { Index = "3", Name = scheme.Colors.MethodName, HexCode  = $"#{scheme.Colors.Method}" },
			new() { Index = "4", Name = scheme.Colors.FieldName, HexCode   = $"#{scheme.Colors.Field}" },
			new() { Index = "5", Name = scheme.Colors.StringName, HexCode  = $"#{scheme.Colors.String}" },
			new() { Index = "6", Name = scheme.Colors.ErrorName, HexCode   = $"#{scheme.Colors.Error}" },
			new() { Index = "7", Name = scheme.Colors.WarningName, HexCode = $"#{scheme.Colors.Warning}" },
			new() { Index = "8", Name = scheme.Colors.InfoName, HexCode    = $"#{scheme.Colors.Info}" },
			new() { Index = "9", Name = scheme.Colors.NumeralName, HexCode = $"#{scheme.Colors.Numeral}" },
		};

		return entries;
	}
}
