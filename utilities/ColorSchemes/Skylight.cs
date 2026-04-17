namespace Rikai.Colorschemes;

public static partial class ColorSchemeFactory
{
	public static ColorScheme Skylight()
	{
		BasicColors colors = new()
		{
			Background        = "eaeef1",
			BackgroundEdges   = "e2ebf2",
			BackgroundOverlay = "dde6ee",
			TextHidden        = "bec4d6",
			TextInactive      = "8f99b3",
			TextFaded         = "7b83b0",
			Text              = "4f5789",

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
			MethodName  = "purple",
			FieldName   = "blue",
			StringName  = "cyan",
			NumeralName = "green",
			InfoName    = "yellow",
			WarningName = "orange",
			ErrorName   = "red",

			HighlightLow  = "4d5de5".AdjustAlphaAndFlatten(-0.95, "eaeef1"),
			Highlight     = "4d5de5".AdjustAlphaAndFlatten(-0.85, "eaeef1"),
			HighlightHigh = "4d5de5".AdjustAlphaAndFlatten(-0.3,  "eaeef1")
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
			White   = colors.Text
		};

		DiffColors diff = new()
		{
			Added             = base8.Green,
			Deleted           = base8.Red,
			Modified          = colors.Keyword,
			Ignored           = colors.TextFaded,
			Conflict          = colors.Field,
			AddedHighlight    = base8.Green.AdjustAlphaAndFlatten(-0.6,  colors.Background).AdjustHsv(deltaV: +0.05),
			AddedBackground   = base8.Green.AdjustAlphaAndFlatten(-0.85, colors.Background),
			DeletedHighlight  = base8.Red.AdjustAlphaAndFlatten(-0.5,  colors.Background).AdjustHsv(deltaV: +0.05),
			DeletedBackground = base8.Red.AdjustAlphaAndFlatten(-0.85, colors.Background)
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

		return new ColorScheme
		{
			Name        = "Skylight",
			Description = "Rikai's opinionated light color scheme, fully my own",
			IsDark      = false,
			Colors      = colors,
			Base8       = base8,
			Diff        = diff,
			Accent      = accent,
			Console     = console,
			Ui          = ui
		};
	}
}
