namespace Rikai.Colorschemes;

public class Alacritty : ITheme
{
	public string      FilePath { get; set; }
	public ColorScheme Scheme   { get; set; }

	public Alacritty(ColorScheme scheme)
	{
		FilePath = Path.Combine("Alacritty", $"{scheme.Name}.toml");
		Scheme   = scheme;
	}

	// for Kvantum's svg format
	public override string ToString()
	{
		return
			$"""
			[colors.primary]
			background = "#{Scheme.Colors.Background}"
			foreground = "#{Scheme.Colors.Text}"
			dim_foreground = "#{Scheme.Colors.TextFaded}"
			bright_foreground = "#{Scheme.Colors.Text}"

			[colors.cursor]
			text = "#{Scheme.Colors.Background}"
			cursor = "#{Scheme.Colors.HighlightHigh}"

			[colors.vi_mode_cursor]
			text = "#{Scheme.Colors.Background}"
			cursor = "#{Scheme.Colors.HighlightHigh}"

			[colors.search.matches]
			foreground = "#{Scheme.Ui.Match}"
			background = "#{Scheme.Ui.MatchBackground}"

			[colors.search.focused_match]
			foreground = "#{Scheme.Ui.Selection}"
			background = "#{Scheme.Ui.SelectionBackground}"

			[colors.footer_bar]
			foreground = "#{Scheme.Colors.Background}"
			background = "#{Scheme.Colors.HighlightLow}"

			[colors.hints.start]
			foreground = "#{Scheme.Colors.Background}"
			background = "#{Scheme.Colors.Info}"

			[colors.hints.end]
			foreground = "#{Scheme.Colors.Background}"
			background = "#{Scheme.Colors.HighlightLow}"

			[colors.selection]
			text = "#{Scheme.Ui.Selection}"
			background = "#{Scheme.Ui.SelectionBackground}"

			[colors.normal]
			black = "#{Scheme.Console.Black}"
			red = "#{Scheme.Console.Red}"
			green = "#{Scheme.Console.Green}"
			yellow = "#{Scheme.Console.Yellow}"
			blue = "#{Scheme.Console.Blue}"
			magenta = "#{Scheme.Console.Magenta}"
			cyan = "#{Scheme.Console.Cyan}"
			white = "#{Scheme.Console.White}"

			[colors.bright]
			black = "#{Scheme.Console.BlackAlt}"
			red = "#{Scheme.Console.RedAlt}"
			green = "#{Scheme.Console.GreenAlt}"
			yellow = "#{Scheme.Console.YellowAlt}"
			blue = "#{Scheme.Console.BlueAlt}"
			magenta = "#{Scheme.Console.MagentaAlt}"
			cyan = "#{Scheme.Console.CyanAlt}"
			white = "#{Scheme.Console.WhiteAlt}"

			[[colors.indexed_colors]]
			index = 16
			color = "#{Scheme.Colors.Info}"

			[[colors.indexed_colors]]
			index = 17
			color = "#{Scheme.Colors.Highlight}"
			""";
	}
}
