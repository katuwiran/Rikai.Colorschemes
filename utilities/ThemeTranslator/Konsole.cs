namespace Rikai.Colorschemes;

public class Konsole : ITheme
{
	public string      FilePath { get; set; }
	public ColorScheme Scheme   { get; set; }

	public Konsole(ColorScheme scheme)
	{
		FilePath = Path.Combine("Konsole", $"{scheme.Name}.colorscheme");
		Scheme   = scheme;
	}

	// for Kvantum's svg format
	public override string ToString()
	{
		return
			$"""
			 [Background]
			 Color=#{Scheme.Colors.Background}

			 [BackgroundFaint]
			 Color=#{Scheme.Colors.BackgroundEdges}

			 [BackgroundIntense]
			 Color=#{Scheme.Colors.BackgroundOverlay}

			 [Color0]
			 Color=#{Scheme.Console.Black}

			 [Color0Faint]
			 Color=#{Scheme.Console.Black}

			 [Color0Intense]
			 Color=#{Scheme.Console.Black}

			 [Color1]
			 Color=#{Scheme.Console.Red}

			 [Color1Faint]
			 Color=#{Scheme.Console.Red}

			 [Color1Intense]
			 Color=#{Scheme.Console.Red}

			 [Color2]
			 Color=#{Scheme.Console.Green}

			 [Color2Faint]
			 Color=#{Scheme.Console.Green}

			 [Color2Intense]
			 Color=#{Scheme.Console.Green}

			 [Color3]
			 Color=#{Scheme.Console.Yellow}

			 [Color3Faint]
			 Color=#{Scheme.Console.Yellow}

			 [Color3Intense]
			 Color=#{Scheme.Console.Yellow}

			 [Color4]
			 Color=#{Scheme.Console.Blue}

			 [Color4Faint]
			 Color=#{Scheme.Console.Blue}

			 [Color4Intense]
			 Color=#{Scheme.Console.Blue}

			 [Color5]
			 Color=#{Scheme.Console.Magenta}

			 [Color5Faint]
			 Color=#{Scheme.Console.Magenta}

			 [Color5Intense]
			 Color=#{Scheme.Console.Magenta}

			 [Color6]
			 Color=#{Scheme.Console.Cyan}

			 [Color6Faint]
			 Color=#{Scheme.Console.Cyan}

			 [Color6Intense]
			 Color=#{Scheme.Console.Cyan}

			 [Color7]
			 Color=#{Scheme.Console.White}

			 [Color7Faint]
			 Color=#{Scheme.Console.White}

			 [Color7Intense]
			 Color=#{Scheme.Console.White}

			 [Foreground]
			 Color=#{Scheme.Colors.Text}

			 [ForegroundFaint]
			 Color=#{Scheme.Colors.Text}

			 [ForegroundIntense]
			 Color=#{Scheme.Colors.Text}

			 [General]
			 Blur=false
			 ColorRandomization=false
			 Description={Scheme.Name}
			 Opacity=1
			 Wallpaper= 
			 """;
	}
}