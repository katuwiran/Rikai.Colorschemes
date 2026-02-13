namespace ColorschemeUtils;

public partial class ColorScheme
{
	public static ColorScheme Skylight => new()
	{
		Name        = "Skylight",
		Description = "Rikai's light color scheme, light version of Moonlight",
		IsDark      = false,
		Accent      = "e153b3",

		Base     = "eaeef1",
		Surface  = "e2ebf2",
		Overlay  = "d2e1f2",
		Subtle   = "818ec9",
		Inactive = "6f78aa",
		Muted    = "666684",
		Text     = "525b8f",

		Magenta  = "e153b3",
		Lavender = "dd6e96",
		Blue     = "4d5de5",
		Purple   = "9e55dd",
		Cyan     = "4897e8",
		Green    = "70b20c",
		Yellow   = "d19700",
		Red      = "f04f4e",
		Orange   = "f28a70",

		HighlightInactive = "dde4ea",
		Highlight         = "acc2df",
		HighlightOverlay  = "85bbff"
	};
}