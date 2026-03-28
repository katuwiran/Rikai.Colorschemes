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
			 Color=#{Scheme.Console.BlackAlt}

			 [Color0Intense]
			 Color=#{Scheme.Console.BlackAlt}

			 [Color1]
			 Color=#{Scheme.Console.Red}

			 [Color1Faint]
			 Color=#{Scheme.Console.RedAlt}

			 [Color1Intense]
			 Color=#{Scheme.Console.RedAlt}

			 [Color2]
			 Color=#{Scheme.Console.Green}

			 [Color2Faint]
			 Color=#{Scheme.Console.GreenAlt}

			 [Color2Intense]
			 Color=#{Scheme.Console.GreenAlt}

			 [Color3]
			 Color=#{Scheme.Console.Yellow}

			 [Color3Faint]
			 Color=#{Scheme.Console.YellowAlt}

			 [Color3Intense]
			 Color=#{Scheme.Console.YellowAlt}

			 [Color4]
			 Color=#{Scheme.Console.Blue}

			 [Color4Faint]
			 Color=#{Scheme.Console.BlueAlt}

			 [Color4Intense]
			 Color=#{Scheme.Console.BlueAlt}

			 [Color5]
			 Color=#{Scheme.Console.Magenta}

			 [Color5Faint]
			 Color=#{Scheme.Console.MagentaAlt}

			 [Color5Intense]
			 Color=#{Scheme.Console.MagentaAlt}

			 [Color6]
			 Color=#{Scheme.Console.Cyan}

			 [Color6Faint]
			 Color=#{Scheme.Console.CyanAlt}

			 [Color6Intense]
			 Color=#{Scheme.Console.CyanAlt}

			 [Color7]
			 Color=#{Scheme.Console.White}

			 [Color7Faint]
			 Color=#{Scheme.Console.WhiteAlt}

			 [Color7Intense]
			 Color=#{Scheme.Console.WhiteAlt}

			 [Foreground]
			 Color=#{Scheme.Colors.Text}

			 [ForegroundFaint]
			 Color=#{Scheme.Colors.TextHidden}

			 [ForegroundIntense]
			 Color=#{Scheme.Colors.TextHidden}

			 [General]
			 Blur=false
			 ColorRandomization=false
			 Description={Scheme.Name}
			 Opacity=1
			 Wallpaper= 
			 """;
	}
}