namespace ColorschemeUtils;

public partial class ColorScheme
{
	public static ColorScheme Moonlight => new()
	{
		Name        = "Moonlight",
		Description = "Rikai's opinionated color scheme, derivative of Material Palenight & Rose Pine Moon",
		IsDark      = true,

		Background        = "2a2840",
		BackgroundEdges   = "332e51",
		BackgroundOverlay = "3d375f",
		TextHidden        = "696383",
		TextInactive      = "666684",
		TextFaded         = "908caa",
		Text              = "c0c0ff",

		Magenta = "ef5abf",
		Red     = "eb517c",
		Purple  = "c188ef",
		Plum    = "ec93c1",
		Blue    = "848bf4",
		Cyan    = "80b5f7",
		Yellow  = "fcb986",
		Orange  = "ff8c4f",
		Green   = "c8e899",

		HighlightLow = "b65da5",
		Highlight         = "89537f",
		HighlightHigh  = "ec93c1"
	};
}