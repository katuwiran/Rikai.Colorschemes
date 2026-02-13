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
		Muted    = "444158",
		Inactive = "666684",
		Subtle   = "908caa",
		Text     = "c0c0ff",

		Magenta  = "ef5abf",
		Lavender = "ec93c1",
		Blue     = "848bf4",
		Purple   = "c188ef",
		Cyan     = "80b5f7",
		Green    = "c8e899",
		Yellow   = "fcb986",
		Red      = "fa593f",
		Orange   = "ff744d",

		HighlightInactive = "333a54",
		Highlight         = "31335f",
		HighlightOverlay  = "394781"
	};
}