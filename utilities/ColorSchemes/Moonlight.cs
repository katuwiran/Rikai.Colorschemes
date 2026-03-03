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

		Class   = "ef5abf",
		Keyword = "ec93c1",
		Method  = "c188ef",
		Field   = "848bf4",
		String  = "80b5f7",
		Numeral = "c8e899",
		Info    = "fcb986",
		Warning = "ff8c4f",
		Error   = "eb517c",

		ClassName   = "magenta",
		KeywordName = "plum",
		MethodName  = "blue",
		FieldName   = "purple",
		StringName  = "cyan",
		NumeralName = "green",
		InfoName    = "yellow",
		WarningName = "orange",
		ErrorName   = "red",

		HighlightLow  = "6c3b62",
		Highlight     = "89537f",
		HighlightHigh = "e981c6",

		DiffAddedHighlight    = "61766f",
		DiffAddedBackground   = "36394a",
		DiffDeletedHighlight  = "9a4063",
		DiffDeletedBackground = "51304c",
	};
}