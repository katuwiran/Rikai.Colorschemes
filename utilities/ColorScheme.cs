namespace ColorschemeUtils;

public class ColorScheme
{
	public string Name        { get; set; } = "";
	public string Description { get; set; } = "";
	public bool   IsDark      { get; set; } = false;
	public string Accent      { get; set; } = "e543b1";

	public required string Base     { get; set; }
	public required string Surface  { get; set; }
	public required string Overlay  { get; set; }
	public required string Inactive { get; set; }
	public required string Subtle   { get; set; }
	public required string Muted    { get; set; }
	public required string Text     { get; set; }

	public required string Magenta  { get; set; }
	public required string Lavender { get; set; }
	public required string Blue     { get; set; }
	public required string Purple   { get; set; }
	public required string Cyan     { get; set; }
	public required string Green    { get; set; }
	public required string Yellow   { get; set; }
	public required string Red      { get; set; }
	public required string Orange   { get; set; }

	public string YellowAlt { get; set; } = "f0d896";
	public string BlueAlt   { get; set; } = "648fc4";
	public string GreenAlt  { get; set; } = "6a8759";
	public string Lime      { get; set; } = "ddffa7";
	public string CyanAlt   { get; set; } = "4074a9";

	public required string Highlight         { get; set; }
	public required string HighlightInactive { get; set; }
	public required string HighlightOverlay  { get; set; }

	public static ColorScheme Logseq => new ColorScheme()
	{
		Base     = "2a2840",
		Surface  = "2c2b40",
		Overlay  = "2c2b40",
		Subtle   = "2e2d40",
		Inactive = "2e2d40",
		Muted    = "666684",
		Text     = "c0c0ff",

		Magenta  = "ff67ce",
		Lavender = "f085bc",
		Blue     = "9590f4",
		Purple   = "c481ff",
		Cyan     = "7dbbf6",
		Green    = "c8e899",
		Yellow   = "fcb986",
		Red      = "f7504b",
		Orange   = "ff744d",

		Highlight         = "ff744d",
		HighlightInactive = "ff744d",
		HighlightOverlay  = "ff744d",
	};

	public static ColorScheme Rider => new()
	{
		Base     = "2a2840",
		Surface  = "2a2840",
		Overlay  = "393552",
		Subtle   = "9c9cbf",
		Inactive = "59546d",
		Muted    = "9c9cbf",
		Text     = "c0c0ff",

		Magenta  = "f14fbd",
		Lavender = "f096ea",
		Blue     = "848bf4",
		Purple   = "c188ef",
		Cyan     = "80b5f7",
		Green    = "c8e899",
		Yellow   = "fcb986",
		Red      = "fa593f",
		Orange   = "ff744d",

		Highlight         = "393552",
		HighlightInactive = "201e30",
		HighlightOverlay  = "201e30"
	};

	public static ColorScheme Moonlight => new()
	{
		Name        = "Moonlight",
		Description = "Rikai's opinionated color scheme, derivative of Material Palenight & Rose Pine Moon",
		IsDark      = true,

		Base     = "2a2840",
		Surface  = "332e51",
		Overlay  = "3d375f",
		Subtle   = "908caa",
		Inactive = "59546d",
		Muted    = "666684",
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
		Highlight         = "313a5f",
		HighlightOverlay  = "394781"
	};

	public static ColorScheme Skylight => new()
	{
		Name        = "Skylight",
		Description = "Rikai's light color scheme, light version of Moonlight",
		IsDark      = false,

		Base     = "eaeef1",
		Surface  = "e2ebf2",
		Overlay  = "d2e1f2",
		Subtle   = "6f78aa",
		Inactive = "818ec9",
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
		HighlightOverlay  = "579aed"
	};

	public static ColorScheme Test => new()
	{
		Base     = "eaeef1",
		Surface  = "e2ebf2",
		Overlay  = "d2e1f2",
		Subtle   = "6f78aa",
		Inactive = "818ec9",
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
		HighlightOverlay  = "579aed"
	};
}