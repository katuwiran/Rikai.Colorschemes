namespace ColorschemeUtils;

public class Program
{
	public static void Main()
	{
		// todo: can probably DRY this thing more, but sometime
		// todo: btop
		// todo: fix bugs
		// - highlighting is wrong
		// - red is ugly.
		// - highlighted text in rider
		int columns = 7;

		List<ITheme> themes = new()
		{
			new RiderJson(ColorScheme.Moonlight),
			new RiderJson(ColorScheme.Skylight),
			new RiderXml(ColorScheme.Moonlight),
			new RiderXml(ColorScheme.Skylight),
			new Sublime(ColorScheme.Moonlight),
			new Sublime(ColorScheme.Skylight),
			new KvantumConfig(ColorScheme.Moonlight),
			new KvantumConfig(ColorScheme.Skylight),
			new KvantumSvg(ColorScheme.Moonlight),
			new KvantumSvg(ColorScheme.Skylight),
			new Kcolorscheme(ColorScheme.Moonlight),
			new Kcolorscheme(ColorScheme.Skylight),
			new Konsole(ColorScheme.Moonlight),
			new Konsole(ColorScheme.Skylight),
			new Alacritty(ColorScheme.Moonlight),
			new Alacritty(ColorScheme.Skylight),
		};

		foreach (ITheme theme in themes)
		{
			Publish(theme);
		}

		DiagramGenerator generator = new();

		generator.Generate(ColorSchemeEntry.Moonlight, columns, ConvertToTargetDir($"{Prefix}moonlight.png"));
		generator.Generate(ColorSchemeEntry.Skylight,  columns, ConvertToTargetDir($"{Prefix}skylight.png"));
	}

	static void Publish(ITheme theme)
	{
		using (StreamWriter sw = new StreamWriter(ConvertToTargetDir($"{Prefix}{theme.FilePath}")))
		{
			sw.Write(theme);
		}

		Console.WriteLine($"Generated Sublime Color scheme for {theme.Scheme.Name}");
	}

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

	private static string Prefix => $"outputs{Path.DirectorySeparatorChar}";
}