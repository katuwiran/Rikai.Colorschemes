namespace Rikai.Colorschemes;

public static partial class ColorSchemeFactory
{
	public static ColorScheme Moonlight()
	{
		// primary definition of colors
		BasicColors colors = new()
		{
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
		};
		
		// the expected colors for most editors, you can base them on your basic colors,
		// I strongly suggest to adhere to the colors here,
		// e.g. base8.Red defines errors, base8.Orange defines warnings, etc.
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
		
		// Colors that define the typical git file changes.
		// the highlight definitions are used for SourceGit's theming.
		// Skip them if you don't use it.
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
		
		// Definitions for console colors.
		// I opted to differentiate this because I am absolutely not
		// going to comply on Ansi standard's color definitions,
		// Becase my eyes are aversive to Green, Orange, etc.
		// But of course, YMMV!
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
			BlackAlt   = colors.TextFaded,
			RedAlt     = colors.Class,
			GreenAlt   = colors.Method,
			YellowAlt  = colors.String,
			BlueAlt    = colors.Field,
			MagentaAlt = colors.Error,
			CyanAlt    = colors.Keyword,
			WhiteAlt   = colors.TextFaded
		};
		
		// Defines ui, selections, highlights, buttons.
		// Most of this will be used by IDEs and Kvantum (software theming).
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
			MatchText                   = colors.TextHidden,
			MatchBackground             = colors.BackgroundOverlay,
			SelectionBackground         = colors.Highlight,
			SelectionText               = colors.BackgroundOverlay,
			SelectionInactiveText       = colors.Text,
			SelectionInactiveBackground = colors.HighlightLow,
			PressedBackground           = colors.Highlight,
			PressedText                 = colors.Text,
		};
		
		// Tying all of them together.
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