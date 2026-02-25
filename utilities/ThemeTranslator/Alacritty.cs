namespace ColorschemeUtils;

public class Alacritty : ITheme
{
	public string      FilePath { get; set; }
	public ColorScheme Scheme   { get; set; }

	public Alacritty(ColorScheme colorScheme)
	{
		FilePath = $"Alacritty{Path.DirectorySeparatorChar}{colorScheme.Name}.toml";
		Scheme   = colorScheme;
	}

	// for Kvantum's svg format
	public override string ToString()
	{
		return
			$"""
			 [colors.primary]
			 background = "#{Scheme.Background}"
			 foreground = "#{Scheme.Text}"
			 dim_foreground = "#{Scheme.TextInactive}"
			 bright_foreground = "#{Scheme.Text}"

			 [colors.cursor]
			 text = "#{Scheme.Background}"
			 cursor = "#{Scheme.Highlight}"

			 [colors.vi_mode_cursor]
			 text = "#{Scheme.Background}"
			 cursor = "#babbf1"

			 [colors.search.matches]
			 foreground = "#{Scheme.Background}"
			 background = "#{Scheme.HighlightLow}"

			 [colors.search.focused_match]
			 foreground = "#{Scheme.Background}"
			 background = "#{Scheme.HighlightLow}"

			 [colors.footer_bar]
			 foreground = "#{Scheme.Background}"
			 background = "#{Scheme.HighlightLow}"

			 [colors.hints.start]
			 foreground = "#{Scheme.Background}"
			 background = "#{Scheme.Yellow}"

			 [colors.hints.end]
			 foreground = "#{Scheme.Background}"
			 background = "#{Scheme.HighlightLow}"

			 [colors.selection]
			 text = "#{Scheme.Background}"
			 background = "#{Scheme.Highlight}"

			 [colors.normal]
			 black = "#{Scheme.ConsoleBackground}"
			 red = "#{Scheme.ConsoleRed}"
			 green = "#{Scheme.ConsoleGreen}"
			 yellow = "#{Scheme.ConsoleYellow}"
			 blue = "#{Scheme.ConsoleBlue}"
			 magenta = "#{Scheme.ConsoleMagenta}"
			 cyan = "#{Scheme.ConsoleCyan}"
			 white = "#{Scheme.ConsoleForeground}"

			 [colors.bright]
			 black = "#{Scheme.ConsoleBackgroundAlt}"
			 red = "#{Scheme.ConsoleRedAlt}"
			 green = "#{Scheme.ConsoleGreenAlt}"
			 yellow = "#{Scheme.ConsoleYellowAlt}"
			 blue = "#{Scheme.ConsoleBlueAlt}"
			 magenta = "#{Scheme.ConsoleMagentaAlt}"
			 cyan = "#{Scheme.ConsoleCyanAlt}"
			 white = "#{Scheme.ConsoleForegroundAlt}"

			 [[colors.indexed_colors]]
			 index = 16
			 color = "#{Scheme.Yellow}"

			 [[colors.indexed_colors]]
			 index = 17
			 color = "#{Scheme.Highlight}"
			 """;
	}
}