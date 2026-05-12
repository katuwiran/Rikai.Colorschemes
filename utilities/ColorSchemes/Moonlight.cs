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
			MethodName  = "purple",
			FieldName   = "blue",
			StringName  = "cyan",
			NumeralName = "green",
			InfoName    = "yellow",
			WarningName = "orange",
			ErrorName   = "red",

			HighlightLow  = "848bf4".AdjustAlphaAndFlatten(-0.85, "2a2840"),
			Highlight     = "848bf4".AdjustAlphaAndFlatten(-0.60, "2a2840"),
			HighlightHigh = "848bf4".AdjustAlphaAndFlatten(-0.3,  "2a2840")
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
			White   = colors.Text
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
			AddedHighlight    = base8.Green.AdjustAlphaAndFlatten(-0.3,  colors.Background).AdjustHsv(deltaV: -0.12),
			AddedBackground   = base8.Green.AdjustAlphaAndFlatten(-0.85, colors.Background),
			DeletedHighlight  = base8.Red.AdjustAlphaAndFlatten(-0.2,  colors.Background).AdjustHsv(deltaV: -0.05),
			DeletedBackground = base8.Red.AdjustAlphaAndFlatten(-0.85, colors.Background)
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
			BlackAlt   = colors.TextHidden,
			RedAlt     = colors.Class,
			GreenAlt   = colors.Method,
			YellowAlt  = colors.String,
			BlueAlt    = colors.Field,
			MagentaAlt = colors.Error,
			CyanAlt    = colors.Keyword,
			WhiteAlt   = colors.TextFaded
		};

		AccentColors accent = new()
		{
			Primary       = colors.Keyword.AdjustAlphaAndFlatten(-0.05, colors.Background),
			PrimaryText   = colors.BackgroundOverlay,
			Secondary     = colors.Field.AdjustAlphaAndFlatten(-0.2, colors.Background),
			SecondaryText = colors.BackgroundOverlay,
			Tertiary      = colors.Method.AdjustAlphaAndFlatten(-0.2, colors.Background),
			TertiaryText  = colors.BackgroundOverlay
		};

		// Defines ui, selections, highlights, buttons.
		// Most of this will be used by IDEs and Kvantum (software theming).
		UiColors ui = new()
		{
			MenuBackground              = colors.Background,
			Hover                       = accent.Primary,
			HoverBackground             = colors.HighlightLow,
			Inactive                    = colors.TextInactive,
			InactiveBackground          = colors.BackgroundOverlay,
			Match                       = colors.TextFaded,
			MatchBackground             = colors.HighlightLow,
			Selection                   = colors.Text,
			SelectionBackground         = colors.Highlight,
			SelectionInactive           = colors.Text,
			SelectionInactiveBackground = colors.HighlightLow,
			Pressed                     = colors.Text,
			PressedBackground           = colors.HighlightHigh
		};

		Rainbow rb = new()
		{
			Level0 = colors.Class,
			Level1 = colors.Keyword,
			Level2 = colors.String,
			Level3 = colors.Field,
			Level4 = colors.Method,
			Level5 = null,
			Level6 = null
		};

		// Tying all of them together.
		return new ColorScheme
		{
			Name        = "Moonlight",
			Description = "Rikai's scheme signifying a star-laden, well-lit, night sky. Inspired by Material Palenight, Rose Pine Moon, and Catpuccin",
			IsDark      = true,
			Colors      = colors,
			Base8       = base8,
			Diff        = diff,
			Console     = console,
			Accent      = accent,
			Ui          = ui,
			Rainbow     = rb
		};
	}
}
