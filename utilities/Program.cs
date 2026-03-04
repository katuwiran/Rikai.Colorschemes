using Rikai.Colorschemes;

namespace ColorschemeUtils;

public class Program
{
	public static void Main()
	{
		// todo: fix bugs
		// todo: refactor with named variables
		// - highlighting is wrong
		// - highlighted text in rider

		// create a list of ITheme constructors.
		List<Func<ColorScheme, ITheme>> constructors = new()
		{
			(scheme) => new JetbrainsJson(scheme),
			(scheme) => new JetbrainsXml(scheme),
			(scheme) => new Sublime(scheme),
			(scheme) => new KvantumConfig(scheme),
			(scheme) => new KvantumSvg(scheme),
			(scheme) => new Kcolorscheme(scheme),
			(scheme) => new Konsole(scheme),
			(scheme) => new Alacritty(scheme),
			(scheme) => new Btop(scheme),
			(scheme) => new SourceGit(scheme),
			(scheme) => new Noctalia(scheme),
		};

		// create a list that holds all theme settings generator later
		List<ITheme> themeGenerator = new();

		// create a list that holds all 
		List<ColorScheme> colorSchemes = new()
		{
			ColorSchemeFactory.Moonlight(),
			ColorSchemeFactory.Skylight()
		};

		// iterates over the constructors list, creating one for each color scheme below
		foreach (var constructor in constructors)
		{
			foreach (var scheme in colorSchemes)
			{
				themeGenerator.Add(constructor(scheme));
			}
		}

		Console.WriteLine("Generating themes...");

		// for each theme configuration file generated,
		// copy from the target directory the files
		// to the platforms directory.
		// the file structure definitions defined in each theme.cs is respected
		// hence one only has to bother with the individual files themselves.
		foreach (ITheme theme in themeGenerator)
		{
			string targetDir  = ConvertToTargetPath($"{theme.FilePath}");
			string projectDir = ConvertToPlatformsPath($"{theme.FilePath}");

			Publish(theme, targetDir);
			CopyThemeToProjectDir(targetDir, projectDir);
		}

		// Generates the diagrams of the palette for each
		// of the defined colorschemes on the list
		DiagramGenerator generator = new();
		generator.GenerateDiagrams(colorSchemes);

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
	
	static string BinPath => $"{Directory.GetParent(AppContext.BaseDirectory).FullName}";

	static string PlatformsPath =>
		$"{Directory.GetParent(AppContext.BaseDirectory)?.Parent?.Parent?.Parent?.Parent?.FullName}{Path.DirectorySeparatorChar}platforms{Path.DirectorySeparatorChar}";
}