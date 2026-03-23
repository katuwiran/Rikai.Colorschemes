namespace Rikai.Colorschemes;

public static partial class ColorSchemeFactory
{
	public static ColorScheme Skylight()
	{
		BasicColors colors = new()
		{
			Background        = "eaeef1",
			BackgroundEdges   = "e2ebf2",
			BackgroundOverlay = "e3eaf1",
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

			HighlightLow  = "4d5de5".AdjustAlphaAndFlatten(deltaAlpha: -0.95, "eaeef1"),
			Highlight     = "4d5de5".AdjustAlphaAndFlatten(deltaAlpha: -0.85, "eaeef1"),
			HighlightHigh = "4d5de5".AdjustAlphaAndFlatten(deltaAlpha: -0.3,  "eaeef1"),
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
			AddedHighlight    = base8.Green.AdjustAlphaAndFlatten(deltaAlpha: -0.6,  colors.Background).AdjustHsv(deltaV: +0.05),
			AddedBackground   = base8.Green.AdjustAlphaAndFlatten(deltaAlpha: -0.85, colors.Background),
			DeletedHighlight  = base8.Red.AdjustAlphaAndFlatten(deltaAlpha: -0.5,  colors.Background).AdjustHsv(deltaV: +0.05),
			DeletedBackground = base8.Red.AdjustAlphaAndFlatten(deltaAlpha: -0.85, colors.Background),
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
		
		AccentColors accent = new()
		{
			Primary       = colors.Keyword.AdjustAlphaAndFlatten(deltaAlpha: -0.05, colors.Background),
			PrimaryText   = colors.BackgroundOverlay,
			Secondary     = colors.Field.AdjustAlphaAndFlatten(deltaAlpha: -0.2, colors.Background),
			SecondaryText = colors.BackgroundOverlay,
			Tertiary      = colors.Method.AdjustAlphaAndFlatten(deltaAlpha: -0.2, colors.Background),
			TertiaryText  = colors.BackgroundOverlay,
		};

		UiColors ui = new()
		{
			MenuBackground              = colors.Background,
			HoverBackground             = accent.Secondary,
			HoverText                   = accent.SecondaryText,
			InactiveBackground          = colors.BackgroundOverlay,
			InactiveText                = colors.Text,
			MatchText                   = colors.TextFaded,
			MatchBackground             = colors.BackgroundOverlay,
			SelectionBackground         = colors.HighlightHigh,
			SelectionText               = colors.BackgroundOverlay,
			SelectionInactiveText       = colors.Text,
			SelectionInactiveBackground = colors.HighlightLow,
			PressedBackground           = accent.Tertiary,
			PressedText                 = accent.TertiaryText,
		};

		return new()
		{
			Name        = "Skylight",
			Description = "Rikai's opinionated light color scheme, fully my own",
			IsDark      = true,
			Colors      = colors,
			Base8       = base8,
			Diff        = diff,
			Accent      = accent,
			Console     = console,
			Ui          = ui
		};
	}
}