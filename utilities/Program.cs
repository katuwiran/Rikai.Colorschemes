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

		Console.WriteLine("Generating themes...");
		foreach (ITheme theme in themes)
		{
			string targetDir  = ConvertToTargetPath($"{theme.FilePath}");
			string projectDir = ConvertToPlatformsPath($"{theme.FilePath}");
			
			Publish(theme, targetDir);
			CopyThemeToProjectDir(targetDir, projectDir);
		}

		DiagramGenerator generator = new();
		
		generator.Generate(ColorSchemeEntry.Moonlight, columns, $"{AssetsPath}moonlight.png");
		generator.Generate(ColorSchemeEntry.Skylight,  columns, $"{AssetsPath}skylight.png");

		Console.WriteLine("Finished.");
	}

	static void Publish(ITheme theme, string path)
	{
		using (StreamWriter sw = new StreamWriter(path))
		{
			sw.Write(theme);
		}
	}

	static string ConvertToTargetPath(string themePath)
	{
		// Get the path to the bin folder (TargetDir)
		string binPath = BinPath;

		// Combine with filename
		string filePath = Path.Combine(binPath, themePath);
		
		// Create the directory if it's not null/empty
		if (!string.IsNullOrEmpty(Path.GetDirectoryName(filePath)))
		{
			Directory.CreateDirectory(Path.GetDirectoryName(filePath));
		}

		return filePath;
	}

	static string ConvertToPlatformsPath(string themePath)
	{
		// Get the path to output folder
		string targetPath = PlatformsPath;

		// Combine with filename
		string sourceFilePath = Path.Combine(targetPath, themePath);

		// Create the directory if it's not null/empty
		if (!string.IsNullOrEmpty(Path.GetDirectoryName(sourceFilePath)))
		{
			Directory.CreateDirectory(Path.GetDirectoryName(sourceFilePath));
		}

		return sourceFilePath;
	}

	static void CopyThemeToProjectDir(string sourcePath, string platformsPath)
	{
		File.Copy(sourcePath, platformsPath, overwrite: true);
	}
	
	static string AssetsPath => $"{Directory.GetParent(AppContext.BaseDirectory)?.Parent?.Parent?.Parent?.Parent?.FullName}{Path.DirectorySeparatorChar}assets{Path.DirectorySeparatorChar}";
	static string BinPath => $"{Directory.GetParent(AppContext.BaseDirectory).FullName}";
	static string PlatformsPath => $"{Directory.GetParent(AppContext.BaseDirectory)?.Parent?.Parent?.Parent?.Parent?.FullName}{Path.DirectorySeparatorChar}platforms{Path.DirectorySeparatorChar}";
}