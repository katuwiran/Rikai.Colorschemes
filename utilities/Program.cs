namespace ColorschemeUtils;

public class Program
{
	public static void Main()
	{
		int    columns   = 8;
		string prefix    = $"outputs{Path.DirectorySeparatorChar}";
		string moonlight = $"{prefix}moonlight.png";
		string skylight  = $"{prefix}skylight.png";

		string riderJsonDarkFilepath  = $"{prefix}Moonlight.theme.json";
		string riderJsonLightFilepath = $"{prefix}Skylight.theme.json";

		string riderXmlDarkFilepath  = $"{prefix}Moonlight.xml";
		string riderXmlLightFilepath = $"{prefix}Skylight.xml";

		string sublimeDarkPath  = $"{prefix}Moonlight.sublime-color-scheme";
		string sublimeLightPath = $"{prefix}Skylight.sublime-color-scheme";

		PublishRiderJson(ColorScheme.Moonlight, riderJsonDarkFilepath);
		PublishRiderJson(ColorScheme.Skylight,  riderJsonLightFilepath);

		PublishRiderXml(ColorScheme.Moonlight, riderXmlDarkFilepath);
		PublishRiderXml(ColorScheme.Skylight,  riderXmlLightFilepath);

		PublishSublime(ColorScheme.Moonlight, sublimeDarkPath);
		PublishSublime(ColorScheme.Skylight,  sublimeLightPath);

		DiagramGenerator generator = new();

		generator.Generate(ColorSchemeEntry.Moonlight, columns, ConvertToTargetDir(moonlight));
		generator.Generate(ColorSchemeEntry.Skylight,  columns, ConvertToTargetDir(skylight));
	}

	static void PublishSublime(ColorScheme scheme, string filePath)
	{
		using (StreamWriter sw = new StreamWriter(ConvertToTargetDir(filePath)))
		{
			sw.Write(ThemeTranslator.Sublime(scheme));
		}

		Console.WriteLine($"Generated Sublime Color scheme for {scheme.Name}");
	}

	static void PublishRiderJson(ColorScheme scheme, string filePath)
	{
		using (StreamWriter sw = new StreamWriter(ConvertToTargetDir(filePath)))
		{
			sw.Write(ThemeTranslator.RiderJson(scheme));
		}

		Console.WriteLine($"Generated Rider json for {scheme.Name}");
	}

	static void PublishRiderXml(ColorScheme scheme, string filePath)
	{
		using (StreamWriter sw = new StreamWriter(ConvertToTargetDir(filePath)))
		{
			sw.Write(ThemeTranslator.RiderXml(scheme));
		}

		Console.WriteLine($"Generated Rider xml for {scheme.Name}");
	}

	static string ConvertToTargetDir(string path)
	{
		// 1. Get the path to the bin folder (TargetDir)
		string binPath = AppContext.BaseDirectory;

		// 2. Combine with filename
		string filePath = Path.Combine(binPath, path);

		// 1. Get the directory path (handles just filename cases too)
		string? directory = Path.GetDirectoryName(filePath);

		// 2. Create the directory if it's not null/empty
		if (!string.IsNullOrEmpty(directory))
		{
			Directory.CreateDirectory(directory);
		}

		return filePath;
	}
}