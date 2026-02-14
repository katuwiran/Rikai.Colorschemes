namespace ColorschemeUtils;

public class Program
{
	public static void Main()
	{
		int    columns   = 8;
		string prefix    = $"outputs{Path.DirectorySeparatorChar}";
		string moonlight = $"{prefix}moonlight.png";
		string skylight  = $"{prefix}skylight.png";

		string riderJsonDarkFilepath = $"{prefix}Moonlight.theme.json";
		string riderJsonLightFilepath = $"{prefix}Skylight.theme.json";
		
		string riderXmlDarkFilepath  = $"{prefix}Moonlight.xml";
		string riderXmlLightFilepath  = $"{prefix}Skylight.xml";

		string sublimeDarkPath  = $"{prefix}Moonlight.sublime-color-scheme";
		string sublimeLightPath = $"{prefix}Skylight.sublime-color-scheme";

		PublishRiderJson(ColorScheme.Moonlight, riderJsonDarkFilepath);
		PublishRiderJson(ColorScheme.Skylight, riderJsonLightFilepath);
		
		PublishRiderXml(ColorScheme.Moonlight, riderXmlDarkFilepath);
		PublishRiderXml(ColorScheme.Skylight, riderXmlLightFilepath);
		
		PublishSublime(ColorScheme.Moonlight, sublimeDarkPath);
		PublishSublime(ColorScheme.Skylight,  sublimeLightPath);

		DiagramGenerator generator = new();

		generator.Generate(ColorSchemeEntry.Moonlight, columns, moonlight);
		generator.Generate(ColorSchemeEntry.Skylight,  columns, skylight);
	}

	static void PublishSublime(ColorScheme scheme, string filePath)
	{
		using (StreamWriter sw = new StreamWriter(filePath))
		{
			sw.Write(ThemeTranslator.Sublime(scheme));
		}
	}

	static void PublishRiderJson(ColorScheme scheme, string filePath)
	{
		using (StreamWriter sw = new StreamWriter(filePath))
		{
			sw.Write(ThemeTranslator.RiderJson(scheme));
		}
	}

	static void PublishRiderXml(ColorScheme scheme, string filePath)
	{
		using (StreamWriter sw = new StreamWriter(filePath))
		{
			sw.Write(ThemeTranslator.RiderXml(scheme));
		}
	}
}