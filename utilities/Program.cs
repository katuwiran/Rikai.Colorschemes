namespace ColorschemeUtils;

public class Program
{
	public static void Main()
	{
		// todo: btop
		// todo: fix bugs
		// - highlighting is wrong
		// - highlighted text in rider
		int columns = 7;

		// create a list of ITheme constructors.
		List<Func<ColorScheme, ITheme>> constructors = new()
		{
			(scheme) => new RiderJson(scheme),
			(scheme) => new RiderXml(scheme),
			(scheme) => new Sublime(scheme),
			(scheme) => new KvantumConfig(scheme),
			(scheme) => new KvantumSvg(scheme),
			(scheme) => new Kcolorscheme(scheme),
			(scheme) => new Konsole(scheme),
			(scheme) => new Alacritty(scheme),
			(scheme) => new Btop(scheme),
		};

		// create a list that holds all themes later
		List<ITheme> themes = new();

		// iterates over the constructors list, creating one for each color scheme below
		foreach (var constructor in constructors)
		{
			themes.Add(constructor(ColorScheme.Moonlight));
			themes.Add(constructor(ColorScheme.Skylight));
		}

		Console.WriteLine("Generating themes...");
		
		// for each theme configuration file generated,
		// copy from the target directory the files
		// to the platforms directory.
		// the file structure definitions defined in each theme.cs is respected
		// hence one only has to bother with the individual files themselves.
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

	static string AssetsPath =>
		$"{Directory.GetParent(AppContext.BaseDirectory)?.Parent?.Parent?.Parent?.Parent?.FullName}{Path.DirectorySeparatorChar}assets{Path.DirectorySeparatorChar}";

	static string BinPath => $"{Directory.GetParent(AppContext.BaseDirectory).FullName}";

	static string PlatformsPath =>
		$"{Directory.GetParent(AppContext.BaseDirectory)?.Parent?.Parent?.Parent?.Parent?.FullName}{Path.DirectorySeparatorChar}platforms{Path.DirectorySeparatorChar}";
}