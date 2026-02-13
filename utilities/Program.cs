using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;

namespace ColorschemeUtils;

public class Program
{
	static ColorScheme currentScheme = ColorScheme.Moonlight;

	public static void Main()
	{
		int    columns   = 8;
		string moonlight = "/mnt/Rikai/Projects/Programming/Colorschemes/Moonlight/moonlight.png";
		string skylight  = "/mnt/Rikai/Projects/Programming/Colorschemes/Moonlight/skylight.png";
		string test      = "/mnt/Rikai/Projects/Programming/Colorschemes/Moonlight/test.png";

		string riderJsonDarkFilepath = "/mnt/Rikai/Projects/Programming/Colorschemes/Moonlight/Moonlight.theme.json";
		string riderJsonLightFilepath = "/mnt/Rikai/Projects/Programming/Colorschemes/Moonlight/Skylight.theme.json";
		
		string riderXmlDarkFilepath  = "/mnt/Rikai/Projects/Programming/Colorschemes/Moonlight/Moonlight.xml";
		string riderXmlLightFilepath  = "/mnt/Rikai/Projects/Programming/Colorschemes/Moonlight/Skylight.xml";

		string sublimeDarkPath  = "/mnt/Rikai/Projects/Programming/Colorschemes/Moonlight/Moonlight.sublime-color-scheme";
		string sublimeLightPath = "/mnt/Rikai/Projects/Programming/Colorschemes/Moonlight/Skylight.sublime-color-scheme";

		PublishRiderJson(riderJsonDarkFilepath);
		PublishRiderJson(riderJsonLightFilepath);
		
		PublishRiderXml(riderXmlDarkFilepath);
		PublishRiderXml(riderXmlLightFilepath);
		
		PublishSublime(ColorScheme.Moonlight, sublimeDarkPath);
		PublishSublime(ColorScheme.Skylight,  sublimeLightPath);

		DiagramGenerator generator = new();

		generator.Generate(ColorSchemeEntry.Moonlight, columns, moonlight);
		generator.Generate(ColorSchemeEntry.Skylight,  columns, skylight);
		generator.Generate(ColorSchemeEntry.Test,      columns, test);
	}

	static void PublishSublime(ColorScheme scheme, string filePath)
	{
		using (StreamWriter sw = new StreamWriter(filePath))
		{
			sw.Write(ThemeTranslator.Sublime(scheme));
		}
	}

	static void PublishRiderJson(string filePath)
	{
		using (StreamWriter sw = new StreamWriter(filePath))
		{
			sw.Write(ThemeTranslator.RiderJson(currentScheme));
		}
	}

	static void PublishRiderXml(string filePath)
	{
		using (StreamWriter sw = new StreamWriter(filePath))
		{
			sw.Write(ThemeTranslator.RiderXml(currentScheme));
		}
	}
}