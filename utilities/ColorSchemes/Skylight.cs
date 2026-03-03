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

		Class   = "e153b3",
		Keyword = "dd6e96",
		Method  = "9e55dd",
		Field   = "4d5de5",
		String  = "4897e8",
		Numeral = "70b20c", // todo should be closer to cyan than orange
		Info    = "d19700",
		Warning = "f28a70",
		Error   = "f04f4e",

		ClassName   = "magenta",
		KeywordName = "plum",
		MethodName  = "blue",
		FieldName   = "purple",
		StringName  = "cyan",
		NumeralName = "green",
		InfoName    = "yellow",
		WarningName = "orange",
		ErrorName   = "red",

		// todo follow changes in moonlight's highlighting
		HighlightLow  = "e3e9ed",
		Highlight     = "acc2df",
		HighlightHigh = "85bbff",

		// todo adapt this to light mode
		DiffAddedHighlight    = "444d56",
		DiffAddedBackground   = "556565",
		DiffDeletedHighlight  = "6a3654",
		DiffDeletedBackground = "51304c",
	};
}