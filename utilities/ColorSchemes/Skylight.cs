namespace ColorschemeUtils;

public partial class ColorScheme
{
	public static ColorScheme Skylight => new()
	{
		Name        = "Skylight",
		Description = "Rikai's light color scheme, light version of Moonlight",
		IsDark      = false,

		Background        = "eaeef1",
		BackgroundEdges   = "e2ebf2",
		BackgroundOverlay = "d2e1f2",
		TextHidden        = "9ca4d1",
		TextInactive      = "6f78aa",
		TextFaded         = "818ec9",
		Text              = "525b8f",

		Magenta = "e153b3",
		Plum    = "dd6e96",
		Blue    = "4d5de5",
		Purple  = "9e55dd",
		Cyan    = "4897e8",
		Green   = "70b20c",
		Yellow  = "d19700",
		Red     = "f04f4e",
		Orange  = "f28a70",

		HighlightLow = "e3e9ed",
		Highlight         = "acc2df",
		HighlightHigh  = "85bbff"
	};
}