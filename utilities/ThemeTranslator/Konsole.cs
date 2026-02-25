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
			 Color=#{Scheme.ConsoleBackground}

			 [Color0Faint]
			 Color=#{Scheme.ConsoleBackground}

			 [Color0Intense]
			 Color=#{Scheme.ConsoleBackground}

			 [Color1]
			 Color=#{Scheme.ConsoleRed}

			 [Color1Faint]
			 Color=#{Scheme.ConsoleRed}

			 [Color1Intense]
			 Color=#{Scheme.ConsoleRed}

			 [Color2]
			 Color=#{Scheme.ConsoleGreen}

			 [Color2Faint]
			 Color=#{Scheme.ConsoleGreen}

			 [Color2Intense]
			 Color=#{Scheme.ConsoleGreen}

			 [Color3]
			 Color=#{Scheme.ConsoleYellow}

			 [Color3Faint]
			 Color=#{Scheme.ConsoleYellow}

			 [Color3Intense]
			 Color=#{Scheme.ConsoleYellow}

			 [Color4]
			 Color=#{Scheme.ConsoleBlue}

			 [Color4Faint]
			 Color=#{Scheme.ConsoleBlue}

			 [Color4Intense]
			 Color=#{Scheme.ConsoleBlue}

			 [Color5]
			 Color=#{Scheme.ConsoleMagenta}

			 [Color5Faint]
			 Color=#{Scheme.ConsoleMagenta}

			 [Color5Intense]
			 Color=#{Scheme.ConsoleMagenta}

			 [Color6]
			 Color=#{Scheme.ConsoleCyan}

			 [Color6Faint]
			 Color=#{Scheme.ConsoleCyan}

			 [Color6Intense]
			 Color=#{Scheme.ConsoleCyan}

			 [Color7]
			 Color=#{Scheme.ConsoleForeground}

			 [Color7Faint]
			 Color=#{Scheme.ConsoleForeground}

			 [Color7Intense]
			 Color=#{Scheme.ConsoleForeground}

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