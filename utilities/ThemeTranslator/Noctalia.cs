namespace Rikai.Colorschemes;

public class Noctalia : ITheme
{
	public string      FilePath { get; set; }
	public ColorScheme Scheme   { get; set; }
	
	public Noctalia(ColorScheme scheme)
	{
		FilePath = Path.Combine("Noctalia", scheme.Name, $"{scheme.Name}.json");
		Scheme   = scheme;
	}

	public override string ToString()
	{
		return
			$$"""
			  {
			      "dark": {
			          "mPrimary": "#{{Scheme.Ui.Accent}}",
			          "mOnPrimary": "#{{Scheme.Ui.AccentText}}",
			          "mSecondary": "#{{Scheme.Ui.SecondaryAccent}}",
			          "mOnSecondary": "#{{Scheme.Ui.SecondaryAccentText}}",
			          "mTertiary": "#{{Scheme.Colors.Method}}",
			          "mOnTertiary": "#{{Scheme.Ui.AccentText}}",
			          "mError": "#{{Scheme.Colors.Error}}",
			          "mOnError": "#{{Scheme.Ui.AccentText}}",
			          "mSurface": "#{{Scheme.Colors.Background}}",
			          "mOnSurface": "#{{Scheme.Colors.Text}}",
			          "mHover": "#{{Scheme.Ui.HoverBackground}}",
			          "mOnHover": "#{{Scheme.Ui.HoverText}}",
			          "mSurfaceVariant": "#{{Scheme.Colors.BackgroundOverlay}}",
			          "mOnSurfaceVariant": "#{{Scheme.Colors.Text}}",
			          "mOutline": "#{{Scheme.Colors.BackgroundEdges}}",
			          "mShadow": "#272822",
			          "terminal": {
			              "background": "#{{Scheme.Colors.Background}}",
			              "foreground": "#{{Scheme.Colors.Text}}",
			              "cursor": "#{{Scheme.Colors.Caret}}",
			              "cursorText": "#{{Scheme.Colors.CaretText}}",
			              "selectionBackground": "#{{Scheme.Ui.SelectionBackground}}",
			              "selectionForeground": "#{{Scheme.Ui.SelectionText}}",
			              "normal": {
			                  "black": "#{{Scheme.Console.Black}}",
			                  "red": "#{{Scheme.Console.Red}}",
			                  "green": "#{{Scheme.Console.Green}}",
			                  "yellow": "#{{Scheme.Console.Yellow}}",
			                  "blue": "#{{Scheme.Console.Blue}}",
			                  "magenta": "#{{Scheme.Console.Magenta}}",
			                  "cyan": "#{{Scheme.Console.Cyan}}",
			                  "white": "#{{Scheme.Console.White}}"
			              },
			              "bright": {
			                  "black": "#{{Scheme.Console.BlackAlt}}",
			                  "red": "#{{Scheme.Console.RedAlt}}",
			                  "green": "#{{Scheme.Console.GreenAlt}}",
			                  "yellow": "#{{Scheme.Console.YellowAlt}}",
			                  "blue": "#{{Scheme.Console.BlueAlt}}",
			                  "magenta": "#{{Scheme.Console.MagentaAlt}}",
			                  "cyan": "#{{Scheme.Console.CyanAlt}}",
			                  "white": "#{{Scheme.Console.WhiteAlt}}"
			              }
			          }
			      },
			      "light": {
			          "mPrimary": "#{{Scheme.Ui.Accent}}",
			          "mOnPrimary": "#{{Scheme.Ui.AccentText}}",
			          "mSecondary": "#{{Scheme.Colors.Highlight}}",
			          "mOnSecondary": "#{{Scheme.Ui.AccentText}}",
			          "mTertiary": "#{{Scheme.Colors.HighlightLow}}",
			          "mOnTertiary": "#{{Scheme.Colors.Text}}",
			          "mError": "#{{Scheme.Colors.Error}}",
			          "mOnError": "#{{Scheme.Ui.AccentText}}",
			          "mSurface": "#{{Scheme.Colors.Background}}",
			          "mOnSurface": "#{{Scheme.Colors.Text}}",
			          "mHover": "#{{Scheme.Ui.HoverBackground}}",
			          "mOnHover": "#{{Scheme.Ui.HoverText}}",
			          "mSurfaceVariant": "#{{Scheme.Colors.BackgroundOverlay}}",
			          "mOnSurfaceVariant": "#{{Scheme.Colors.Text}}",
			          "mOutline": "#{{Scheme.Colors.BackgroundEdges}}",
			          "mShadow": "#272822",
			          "terminal": {
			              "background": "#{{Scheme.Colors.Background}}",
			              "foreground": "#{{Scheme.Colors.Text}}",
			              "cursor": "#{{Scheme.Colors.Caret}}",
			              "cursorText": "#{{Scheme.Colors.CaretText}}",
			              "selectionBackground": "#{{Scheme.Ui.SelectionBackground}}",
			              "selectionForeground": "#{{Scheme.Ui.SelectionText}}",
			              "normal": {
			                  "black": "#{{Scheme.Console.Black}}",
			                  "red": "#{{Scheme.Console.Red}}",
			                  "green": "#{{Scheme.Console.Green}}",
			                  "yellow": "#{{Scheme.Console.Yellow}}",
			                  "blue": "#{{Scheme.Console.Blue}}",
			                  "magenta": "#{{Scheme.Console.Magenta}}",
			                  "cyan": "#{{Scheme.Console.Cyan}}",
			                  "white": "#{{Scheme.Console.White}}"
			              },
			              "bright": {
			                  "black": "#{{Scheme.Console.BlackAlt}}",
			                  "red": "#{{Scheme.Console.RedAlt}}",
			                  "green": "#{{Scheme.Console.GreenAlt}}",
			                  "yellow": "#{{Scheme.Console.YellowAlt}}",
			                  "blue": "#{{Scheme.Console.BlueAlt}}",
			                  "magenta": "#{{Scheme.Console.MagentaAlt}}",
			                  "cyan": "#{{Scheme.Console.CyanAlt}}",
			                  "white": "#{{Scheme.Console.WhiteAlt}}"
			              }
			          }
			      }
			  }
			  """;
	}
}