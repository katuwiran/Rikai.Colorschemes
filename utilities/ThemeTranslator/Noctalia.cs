namespace ColorschemeUtils;

public class Noctalia : ITheme
{
	public string      FilePath { get; set; }
	public ColorScheme Scheme   { get; set; }
	public ColorScheme Dark     { get; set; }
	public ColorScheme Light    { get; set; }

	public Noctalia(ColorScheme darkScheme)
	{
		Dark     = darkScheme;
		Light    = ColorScheme.Skylight;
		FilePath = $"Noctalia{Path.DirectorySeparatorChar}{Dark.Name}{Light.Name}.json";
		Scheme   = Dark;
	}

	public Noctalia(ColorScheme darkScheme, ColorScheme lightScheme)
	{
		Dark     = darkScheme;
		Light    = lightScheme;
		FilePath = $"Noctalia{Path.DirectorySeparatorChar}{Dark.Name}{Light.Name}.json";
		Scheme   = Dark;
	}

	public override string ToString()
	{
		return
			$$"""
			  {
			      "dark": {
			          "mPrimary": "#{{Dark.Class}}",
			          "mOnPrimary": "#{{Dark.AccentText}}",
			          "mSecondary": "#{{Dark.Keyword}}",
			          "mOnSecondary": "#{{Dark.AccentText}}",
			          "mTertiary": "#{{Dark.Method}}",
			          "mOnTertiary": "#{{Dark.AccentText}}",
			          "mError": "#{{Dark.Error}}",
			          "mOnError": "#{{Dark.AccentText}}",
			          "mSurface": "#{{Dark.Background}}",
			          "mOnSurface": "#{{Dark.Text}}",
			          "mHover": "#{{Dark.HoverBackground}}",
			          "mOnHover": "#{{Dark.HoverText}}",
			          "mSurfaceVariant": "#{{Dark.BackgroundOverlay}}",
			          "mOnSurfaceVariant": "#{{Dark.Text}}",
			          "mOutline": "#{{Dark.BackgroundEdges}}",
			          "mShadow": "#272822",
			          "terminal": {
			              "background": "#{{Dark.Background}}",
			              "foreground": "#{{Dark.Text}}",
			              "cursor": "#{{Dark.Caret}}",
			              "cursorText": "#{{Dark.CaretText}}",
			              "selectionBackground": "#{{Dark.SelectionBackground}}",
			              "selectionForeground": "#{{Dark.SelectionText}}",
			              "normal": {
			                  "black": "#{{Dark.ConsoleBackground}}",
			                  "red": "#{{Dark.ConsoleRed}}",
			                  "green": "#{{Dark.ConsoleGreen}}",
			                  "yellow": "#{{Dark.ConsoleYellow}}",
			                  "blue": "#{{Dark.ConsoleBlue}}",
			                  "magenta": "#{{Dark.ConsoleMagenta}}",
			                  "cyan": "#{{Dark.ConsoleCyan}}",
			                  "white": "#{{Dark.ConsoleForeground}}"
			              },
			              "bright": {
			                  "black": "#{{Dark.ConsoleBackgroundAlt}}",
			                  "red": "#{{Dark.ConsoleRedAlt}}",
			                  "green": "#{{Dark.ConsoleGreenAlt}}",
			                  "yellow": "#{{Dark.ConsoleYellowAlt}}",
			                  "blue": "#{{Dark.ConsoleBlueAlt}}",
			                  "magenta": "#{{Dark.ConsoleMagentaAlt}}",
			                  "cyan": "#{{Dark.ConsoleCyanAlt}}",
			                  "white": "#{{Dark.ConsoleForegroundAlt}}"
			              }
			          }
			      },
			      "light": {
			          "mPrimary": "#{{Light.Accent}}",
			          "mOnPrimary": "#{{Light.AccentText}}",
			          "mSecondary": "#{{Light.Highlight}}",
			          "mOnSecondary": "#{{Light.AccentText}}",
			          "mTertiary": "#{{Light.HighlightLow}}",
			          "mOnTertiary": "#{{Light.Text}}",
			          "mError": "#{{Light.Error}}",
			          "mOnError": "#{{Light.AccentText}}",
			          "mSurface": "#{{Light.Background}}",
			          "mOnSurface": "#{{Light.Text}}",
			          "mHover": "#{{Light.HoverBackground}}",
			          "mOnHover": "#{{Light.HoverText}}",
			          "mSurfaceVariant": "#{{Light.BackgroundOverlay}}",
			          "mOnSurfaceVariant": "#{{Light.Text}}",
			          "mOutline": "#{{Light.BackgroundEdges}}",
			          "mShadow": "#272822",
			          "terminal": {
			              "background": "#{{Light.Background}}",
			              "foreground": "#{{Light.Text}}",
			              "cursor": "#{{Light.Caret}}",
			              "cursorText": "#{{Light.CaretText}}",
			              "selectionBackground": "#{{Light.SelectionBackground}}",
			              "selectionForeground": "#{{Light.SelectionText}}",
			              "normal": {
			                  "black": "#{{Light.ConsoleBackground}}",
			                  "red": "#{{Light.ConsoleRed}}",
			                  "green": "#{{Light.ConsoleGreen}}",
			                  "yellow": "#{{Light.ConsoleYellow}}",
			                  "blue": "#{{Light.ConsoleBlue}}",
			                  "magenta": "#{{Light.ConsoleMagenta}}",
			                  "cyan": "#{{Light.ConsoleCyan}}",
			                  "white": "#{{Light.ConsoleForeground}}"
			              },
			              "bright": {
			                  "black": "#{{Light.ConsoleBackgroundAlt}}",
			                  "red": "#{{Light.ConsoleRedAlt}}",
			                  "green": "#{{Light.ConsoleGreenAlt}}",
			                  "yellow": "#{{Light.ConsoleYellowAlt}}",
			                  "blue": "#{{Light.ConsoleBlueAlt}}",
			                  "magenta": "#{{Light.ConsoleMagentaAlt}}",
			                  "cyan": "#{{Light.ConsoleCyanAlt}}",
			                  "white": "#{{Light.ConsoleForegroundAlt}}"
			              }
			          }
			      }
			  }
			  """;
	}
}