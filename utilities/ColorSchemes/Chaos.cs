namespace Rikai.Colorschemes;

public static partial class ColorSchemeFactory
{
	public static ColorScheme Chaos()
	{
		BasicColors colors = new()
		{
			Background        = "1e1e2e", // bg
			BackgroundEdges   = "332e51", // borders
			BackgroundOverlay = "3d375f", // scrollbars
			TextHidden        = "474b62", // folded
			TextInactive      = "474b62", // not highlighted, inactive
			TextFaded         = "656a85", // comments
			Text              = "c8d5fe", // text, variable names

			Class   = "6a9ef0", // keywords na new(), =
			Keyword = "ffbfed", // keywords na walagnkwenta
			Error   = "fe8dad", // !!! errors
			Method  = "e072d3", // properties/fields
			Field   = "38c3dc", // method names
			String  = "95d5ca", // strings
			Info    = "fff7b2", // !!! warnings
			Warning = "feba90", // bools
			Numeral = "a2f69c", // numbers

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
		};

		Base8Colors base8 = new()
		{
			Black   = colors.Background,
			Red     = colors.Error,
			Green   = colors.Numeral,
			Yellow  = colors.Info,
			Blue    = colors.Method,
			Magenta = colors.Class,
			Cyan    = colors.String,
			White   = colors.Text,
		};

		DiffColors diff = new()
		{
			Added             = base8.Green,
			Deleted           = base8.Red,
			Modified          = colors.Keyword,
			Ignored           = colors.TextFaded,
			Conflict          = colors.Field,
			AddedHighlight    = "61766f",
			AddedBackground   = "36394a",
			DeletedHighlight  = "9a4063",
			DeletedBackground = "51304c",
		};

		ConsoleColors console = new()
		{
			Black      = colors.Background,
			Red        = colors.Class,
			Green      = colors.Method,
			Yellow     = colors.String,
			Blue       = colors.Field,
			Magenta    = colors.Error,
			Cyan       = colors.Keyword,
			White      = colors.Text,
			BlackAlt   = colors.BackgroundOverlay,
			RedAlt     = colors.Class,
			GreenAlt   = colors.Method,
			YellowAlt  = colors.String,
			BlueAlt    = colors.Field,
			MagentaAlt = colors.Error,
			CyanAlt    = colors.Keyword,
			WhiteAlt   = colors.TextHidden
		};

		UiColors ui = new()
		{
			Accent                      = colors.Highlight,
			AccentText                  = colors.BackgroundOverlay,
			SecondaryAccent             = colors.HighlightLow,
			SecondaryAccentText         = colors.Text,
			MenuBackground              = colors.Background,
			HoverBackground             = colors.HighlightHigh,
			HoverText                   = colors.BackgroundOverlay,
			InactiveBackground          = colors.BackgroundOverlay,
			InactiveText                = colors.Text,
			MatchText                   = colors.TextFaded,
			MatchBackground             = colors.BackgroundOverlay,
			SelectionBackground         = colors.Highlight,
			SelectionText               = colors.BackgroundOverlay,
			SelectionInactiveText       = colors.Text,
			SelectionInactiveBackground = colors.HighlightLow,
			PressedBackground           = colors.Highlight,
			PressedText                 = colors.BackgroundOverlay,
		};

		return new()
		{
			Name        = "Moonlight",
			Description = "Rikai's opinionated color scheme, derivative of Material Palenight & Rose Pine Moon",
			IsDark      = true,
			Colors      = colors,
			Base8       = base8,
			Diff        = diff,
			Console     = console,
			Ui          = ui
		};
	}
}