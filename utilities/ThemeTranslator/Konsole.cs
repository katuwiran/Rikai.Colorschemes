namespace ColorschemeUtils;

public class Konsole : ITheme
{
	public string      FilePath { get; set; }
	public ColorScheme Scheme   { get; set; }

	public Konsole(ColorScheme colorScheme)
	{
		FilePath = $"Konsole{Path.DirectorySeparatorChar}{colorScheme.Name}.colorscheme";
		Scheme   = colorScheme;
	}

	// for Kvantum's svg format
	public override string ToString()
	{
		return
			$"""
			 [Background]
			 Color=#{Scheme.Base}

			 [BackgroundFaint]
			 Color=#{Scheme.Surface}

			 [BackgroundIntense]
			 Color=#{Scheme.Overlay}

			 [Color0]
			 Color=#{Scheme.HighlightInactive}

			 [Color0Faint]
			 Color=#{Scheme.HighlightInactive}

			 [Color0Intense]
			 Color=#{Scheme.HighlightInactive}

			 [Color1]
			 Color=#{Scheme.Red}

			 [Color1Faint]
			 Color=#{Scheme.Red}

			 [Color1Intense]
			 Color=#{Scheme.Red}

			 [Color2]
			 Color=#{Scheme.Lavender}

			 [Color2Faint]
			 Color=#{Scheme.Lavender}

			 [Color2Intense]
			 Color=#{Scheme.Lavender}

			 [Color3]
			 Color=#{Scheme.Cyan}

			 [Color3Faint]
			 Color=#{Scheme.Cyan}

			 [Color3Intense]
			 Color=#{Scheme.Cyan}

			 [Color4]
			 Color=#{Scheme.Blue}

			 [Color4Faint]
			 Color=#{Scheme.Blue}

			 [Color4Intense]
			 Color=#{Scheme.Blue}

			 [Color5]
			 Color=#{Scheme.Purple}

			 [Color5Faint]
			 Color=#{Scheme.Purple}

			 [Color5Intense]
			 Color=#{Scheme.Purple}

			 [Color6]
			 Color=#{Scheme.Magenta}

			 [Color6Faint]
			 Color=#{Scheme.Magenta}

			 [Color6Intense]
			 Color=#{Scheme.Magenta}

			 [Color7]
			 Color=#{Scheme.Text}

			 [Color7Faint]
			 Color=#{Scheme.Text}

			 [Color7Intense]
			 Color=#{Scheme.Text}

			 [Foreground]
			 Color=#{Scheme.Text}

			 [ForegroundFaint]
			 Color=#{Scheme.Text}

			 [ForegroundIntense]
			 Color=#{Scheme.Text}

			 [General]
			 Blur=false
			 ColorRandomization=false
			 Description={Scheme.Name}
			 Opacity=1
			 Wallpaper= 
			 """;
	}
}