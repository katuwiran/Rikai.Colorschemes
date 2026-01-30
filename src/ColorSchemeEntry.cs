namespace ColorschemeUtils;

public class ColorSchemeEntry
{
	public required ColorEntry Base     { get; init; }
	public required ColorEntry Surface  { get; init; }
	public required ColorEntry Overlay  { get; init; }
	public required ColorEntry Inactive { get; init; }
	public required ColorEntry Subtle   { get; init; }
	public required ColorEntry Muted    { get; init; }
	public required ColorEntry Text     { get; init; }
	public required ColorEntry Magenta  { get; init; }
	public required ColorEntry Lavender { get; init; }
	public required ColorEntry Blue     { get; init; }
	public required ColorEntry Purple   { get; init; }
	public required ColorEntry Cyan     { get; init; }
	public required ColorEntry Green    { get; init; }
	public required ColorEntry Yellow   { get; init; }
	public required ColorEntry Red      { get; init; }
	public required ColorEntry Orange   { get; init; }

	public static ColorSchemeEntry Logseq => new ColorSchemeEntry()
	{
		Base     = new() { Index = 10, Name = "base", HexCode     = ColorScheme.Logseq.Base },
		Surface  = new() { Index = 11, Name = "surface", HexCode  = ColorScheme.Logseq.Surface },
		Overlay  = new() { Index = 12, Name = "overlay", HexCode  = ColorScheme.Logseq.Overlay },
		Subtle   = new() { Index = 13, Name = "subtle", HexCode   = ColorScheme.Logseq.Subtle },
		Inactive = new() { Index = 13, Name = "inactive", HexCode = ColorScheme.Logseq.Inactive },
		Muted    = new() { Index = 14, Name = "orange", HexCode   = ColorScheme.Logseq.Muted },
		Text     = new() { Index = 6, Name  = "text", HexCode     = ColorScheme.Logseq.Text },
		Magenta  = new() { Index = 1, Name  = "magenta", HexCode  = ColorScheme.Logseq.Magenta },
		Lavender = new() { Index = 2, Name  = "lavender", HexCode = ColorScheme.Logseq.Lavender },
		Blue     = new() { Index = 3, Name  = "blue", HexCode     = ColorScheme.Logseq.Blue },
		Purple   = new() { Index = 4, Name  = "purple", HexCode   = ColorScheme.Logseq.Purple },
		Cyan     = new() { Index = 5, Name  = "cyan", HexCode     = ColorScheme.Logseq.Cyan },
		Green    = new() { Index = 7, Name  = "green", HexCode    = ColorScheme.Logseq.Green },
		Yellow   = new() { Index = 8, Name  = "yellow", HexCode   = ColorScheme.Logseq.Yellow },
		Red      = new() { Index = 9, Name  = "red", HexCode      = ColorScheme.Logseq.Red },
		Orange   = new() { Index = 10, Name = "orange", HexCode   = ColorScheme.Logseq.Orange },
	};

	public static ColorSchemeEntry Rider => new ColorSchemeEntry()
	{
		Base     = new() { Index = 11, Name = "orange", HexCode   = ColorScheme.Rider.Base },
		Surface  = new() { Index = 12, Name = "orange", HexCode   = ColorScheme.Rider.Surface },
		Overlay  = new() { Index = 13, Name = "orange", HexCode   = ColorScheme.Rider.Overlay },
		Subtle   = new() { Index = 14, Name = "orange", HexCode   = ColorScheme.Rider.Subtle },
		Inactive = new() { Index = 14, Name = "orange", HexCode   = ColorScheme.Rider.Inactive },
		Muted    = new() { Index = 15, Name = "orange", HexCode   = ColorScheme.Rider.Muted },
		Text     = new() { Index = 6, Name  = "text", HexCode     = ColorScheme.Rider.Text },
		Magenta  = new() { Index = 1, Name  = "magenta", HexCode  = ColorScheme.Rider.Magenta },
		Lavender = new() { Index = 2, Name  = "lavender", HexCode = ColorScheme.Rider.Lavender },
		Blue     = new() { Index = 3, Name  = "blue", HexCode     = ColorScheme.Rider.Blue },
		Purple   = new() { Index = 4, Name  = "purple", HexCode   = ColorScheme.Rider.Purple },
		Cyan     = new() { Index = 5, Name  = "cyan", HexCode     = ColorScheme.Rider.Cyan },
		Green    = new() { Index = 7, Name  = "green", HexCode    = ColorScheme.Rider.Green },
		Yellow   = new() { Index = 8, Name  = "yellow", HexCode   = ColorScheme.Rider.Yellow },
		Red      = new() { Index = 9, Name  = "red", HexCode      = ColorScheme.Rider.Red },
		Orange   = new() { Index = 10, Name = "orange", HexCode   = ColorScheme.Rider.Orange },
	};

	public static List<ColorEntry> ToList(ColorSchemeEntry scheme)
	{
		return new List<ColorEntry>()
		{
			new() { Index = scheme.Magenta.Index, Name  = scheme.Magenta.Name, HexCode  = scheme.Magenta.HexCode },
			new() { Index = scheme.Lavender.Index, Name = scheme.Lavender.Name, HexCode = scheme.Lavender.HexCode },
			new() { Index = scheme.Blue.Index, Name     = scheme.Blue.Name, HexCode     = scheme.Blue.HexCode },
			new() { Index = scheme.Purple.Index, Name   = scheme.Purple.Name, HexCode   = scheme.Purple.HexCode },
			new() { Index = scheme.Cyan.Index, Name     = scheme.Cyan.Name, HexCode     = scheme.Cyan.HexCode },
			new() { Index = scheme.Text.Index, Name     = scheme.Text.Name, HexCode     = scheme.Text.HexCode },
			new() { Index = scheme.Green.Index, Name    = scheme.Green.Name, HexCode    = scheme.Green.HexCode },
			new() { Index = scheme.Yellow.Index, Name   = scheme.Yellow.Name, HexCode   = scheme.Yellow.HexCode },
			new() { Index = scheme.Red.Index, Name      = scheme.Red.Name, HexCode      = scheme.Red.HexCode },
			new() { Index = scheme.Orange.Index, Name   = scheme.Orange.Name, HexCode   = scheme.Orange.HexCode },
		};
	}
}