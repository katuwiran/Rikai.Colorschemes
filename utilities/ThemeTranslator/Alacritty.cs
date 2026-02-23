namespace ColorschemeUtils;

public class Alacritty : ITheme
{
	public string      FilePath { get; set; }
	public ColorScheme Scheme   { get; set; }

	public Alacritty(ColorScheme colorScheme)
	{
		FilePath = $"{colorScheme.Name}.toml";
		Scheme   = colorScheme;
	}

	// for Kvantum's svg format
	public override string ToString()
	{
		return
			$"""
			 [colors.primary]
			 background = "#{Scheme.Base}"
			 foreground = "#{Scheme.Text}"
			 dim_foreground = "#{Scheme.Inactive}"
			 bright_foreground = "#{Scheme.Text}"

			 [colors.cursor]
			 text = "#{Scheme.Base}"
			 cursor = "#{Scheme.Highlight}"

			 [colors.vi_mode_cursor]
			 text = "#{Scheme.Base}"
			 cursor = "#babbf1"

			 [colors.search.matches]
			 foreground = "#{Scheme.Base}"
			 background = "#{Scheme.HighlightInactive}"

			 [colors.search.focused_match]
			 foreground = "#{Scheme.Base}"
			 background = "#{Scheme.HighlightInactive}"

			 [colors.footer_bar]
			 foreground = "#{Scheme.Base}"
			 background = "#{Scheme.HighlightInactive}"

			 [colors.hints.start]
			 foreground = "#{Scheme.Base}"
			 background = "#{Scheme.Yellow}"

			 [colors.hints.end]
			 foreground = "#{Scheme.Base}"
			 background = "#{Scheme.HighlightInactive}"

			 [colors.selection]
			 text = "#{Scheme.Base}"
			 background = "#{Scheme.Highlight}"

			 [colors.normal]
			 black = "#{Scheme.Base}"
			 red = "#{Scheme.Red}"
			 green = "#{Scheme.Lavender}"
			 yellow = "#{Scheme.Cyan}"
			 blue = "#{Scheme.Blue}"
			 magenta = "#{Scheme.Purple}"
			 cyan = "#{Scheme.Magenta}"
			 white = "#{Scheme.Text}"

			 [colors.bright]
			 black = "#{Scheme.Base}"
			 red = "#{Scheme.Red}"
			 green = "#{Scheme.Lavender}"
			 yellow = "#{Scheme.Cyan}"
			 blue = "#{Scheme.Blue}"
			 magenta = "#{Scheme.Purple}"
			 cyan = "#{Scheme.Magenta}"
			 white = "#{Scheme.Text}"

			 [[colors.indexed_colors]]
			 index = 16
			 color = "#{Scheme.Yellow}"

			 [[colors.indexed_colors]]
			 index = 17
			 color = "#{Scheme.Highlight}"
			 """;
	}
}