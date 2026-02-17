namespace ColorschemeUtils;

public class Program
{
	public static void Main()
	{
		int    columns = 8;
		// todo: can probably DRY this thing more, but sometime
		string prefix  = $"outputs{Path.DirectorySeparatorChar}";

		// diagrams
		string diagramMoonlight = $"{prefix}moonlight.png";
		string diagramSkylight  = $"{prefix}skylight.png";

		// rider json
		string riderJsonMoonlight = $"{prefix}Moonlight.theme.json";
		string riderJsonSkylight  = $"{prefix}Skylight.theme.json";

		// rider xml
		string riderXmlMoonlight = $"{prefix}Moonlight.xml";
		string riderXmlSkylight  = $"{prefix}Skylight.xml";

		// sublime
		string sublimeMoonlight = $"{prefix}Moonlight.sublime-color-scheme";
		string sublimeSkylight  = $"{prefix}Skylight.sublime-color-scheme";

		// kcolorscheme
		string kcolorschemeMoonlight = $"{prefix}moonlight.colors";
		string kcolorschemeSkylight  = $"{prefix}skylight.colors";

		// kvantum svg
		string kvantumSvgMoonlight = $"{prefix}Moonlight.svg";
		string kvantumSvgSkylight  = $"{prefix}Skylight.svg";

		// kvantum kvconfig
		string kvantumCfgMoonlight = $"{prefix}Moonlight.kvconfig";
		string kvantumCfgSkylight  = $"{prefix}Skylight.kvconfig";

		PublishRiderJson(ColorScheme.Moonlight, riderJsonMoonlight);
		PublishRiderJson(ColorScheme.Skylight,  riderJsonSkylight);

		PublishRiderXml(ColorScheme.Moonlight, riderXmlMoonlight);
		PublishRiderXml(ColorScheme.Skylight,  riderXmlSkylight);

		PublishSublime(ColorScheme.Moonlight, sublimeMoonlight);
		PublishSublime(ColorScheme.Skylight,  sublimeSkylight);

		PublishKColorscheme(ColorScheme.Moonlight, kcolorschemeMoonlight);
		PublishKColorscheme(ColorScheme.Skylight,  kcolorschemeSkylight);

		PublishKvantumSvg(ColorScheme.Moonlight, kvantumSvgMoonlight);
		PublishKvantumSvg(ColorScheme.Skylight,  kvantumSvgSkylight);

		PublishKvantumCfg(ColorScheme.Moonlight, kvantumCfgMoonlight);
		PublishKvantumCfg(ColorScheme.Skylight,  kvantumCfgSkylight);

		DiagramGenerator generator = new();

		generator.Generate(ColorSchemeEntry.Moonlight, columns, ConvertToTargetDir(diagramMoonlight));
		generator.Generate(ColorSchemeEntry.Skylight,  columns, ConvertToTargetDir(diagramSkylight));
	}

	static void Publish(ColorScheme scheme, string filePath, Func<ColorScheme, string> formatter)
	{
		using (StreamWriter sw = new StreamWriter(ConvertToTargetDir(filePath)))
		{
			sw.Write(formatter(scheme));
		}

		Console.WriteLine($"Generated Sublime Color scheme for {scheme.Name}");
	}

	static void PublishSublime(ColorScheme      scheme, string filePath) => Publish(scheme, filePath, ThemeTranslator.Sublime);
	static void PublishRiderJson(ColorScheme    scheme, string filePath) => Publish(scheme, filePath, ThemeTranslator.RiderJson);
	static void PublishRiderXml(ColorScheme     scheme, string filePath) => Publish(scheme, filePath, ThemeTranslator.RiderXml);
	static void PublishKColorscheme(ColorScheme scheme, string filePath) => Publish(scheme, filePath, ThemeTranslator.KColorscheme);
	static void PublishKvantumSvg(ColorScheme   scheme, string filePath) => Publish(scheme, filePath, ThemeTranslator.KvantumSvg);
	static void PublishKvantumCfg(ColorScheme   scheme, string filePath) => Publish(scheme, filePath, ThemeTranslator.KvantumConfig);

	static string ConvertToTargetDir(string path)
	{
		// Get the path to the bin folder (TargetDir)
		string binPath = AppContext.BaseDirectory;

		// Combine with filename
		string filePath = Path.Combine(binPath, path);

		// Get the directory path (handles just filename cases too)
		string? directory = Path.GetDirectoryName(filePath);

		// Create the directory if it's not null/empty
		if (!string.IsNullOrEmpty(directory))
		{
			Directory.CreateDirectory(directory);
		}

		return filePath;
	}
}