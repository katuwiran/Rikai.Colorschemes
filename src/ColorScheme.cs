namespace ColorschemeUtils;

public class ColorScheme
{
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

	public static ColorScheme Logseq => new ColorScheme()
	{
		Base     = "#2a2840",
		Surface  = "#2c2b40",
		Overlay  = "#2c2b40",
		Subtle   = "#2e2d40",
		Inactive = "#2e2d40",
		Muted    = "#666684",
		Text     = "#c0c0ff",
		Magenta  = "#ff67ce",
		Lavender = "#f085bc",
		Blue     = "#9590f4",
		Purple   = "#c481ff",
		Cyan     = "#7dbbf6",
		Green    = "#c8e899",
		Yellow   = "#fcb986",
		Red      = "#f7504b",
		Orange   = "#ff744d",
	};

	public static ColorScheme Rider => new()
	{
		Base     = "#2a2840",
		Surface  = "#2a2840",
		Overlay  = "#393552",
		Subtle   = "#9c9cbf",
		Inactive = "#59546d",
		Muted    = "#9c9cbf",
		Text     = "#c0c0ff",
		Magenta  = "#f23cb8",
		Lavender = "#f096ea",
		Blue     = "#848bf4",
		Purple   = "#c188ef",
		Cyan     = "#80b5f7",
		Green    = "#c8e899",
		Yellow   = "#fcb986",
		Red      = "#fa593f",
		Orange   = "#ff744d",
	};
}