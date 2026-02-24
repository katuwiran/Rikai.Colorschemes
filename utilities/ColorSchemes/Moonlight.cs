namespace ColorschemeUtils;

public partial class ColorScheme
{
	public static ColorScheme Moonlight => new()
	{
		Name        = "Moonlight",
		Description = "Rikai's opinionated color scheme, derivative of Material Palenight & Rose Pine Moon",
		IsDark      = true,
		Accent      = "ef5abf",

		Base     = "2a2840",
		Surface  = "332e51",
		Overlay  = "3d375f",
		Muted    = "696383",
		Inactive = "666684",
		Subtle   = "908caa",
		Text     = "c0c0ff",

		Magenta  = "ef5abf",
		Red      = "eb517c",
		Purple   = "c188ef",
		Lavender = "ec93c1",
		Blue     = "848bf4",
		Cyan     = "80b5f7",
		Yellow   = "fcb986",
		Orange   = "ff8c4f",
		Green    = "c8e899",

		HighlightInactive = "333a54",
		Highlight         = "89537f",
		HighlightOverlay  = "394781"
	};
}