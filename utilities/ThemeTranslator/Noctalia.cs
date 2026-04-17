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
			        "mPrimary": "#{{Scheme.Accent.Primary}}",
			        "mOnPrimary": "#{{Scheme.Accent.PrimaryText}}",
			        "mSecondary": "#{{Scheme.Accent.Secondary}}",
			        "mOnSecondary": "#{{Scheme.Accent.SecondaryText}}",
			        "mTertiary": "#{{Scheme.Accent.Tertiary}}",
			        "mOnTertiary": "#{{Scheme.Accent.TertiaryText}}",
			        "mError": "#{{Scheme.Colors.Error}}",
			        "mOnError": "#{{Scheme.Accent.PrimaryText}}",
			        "mSurface": "#{{Scheme.Colors.Background}}",
			        "mOnSurface": "#{{Scheme.Colors.Text}}",
			        "mHover": "#{{Scheme.Ui.HoverBackground}}",
			        "mOnHover": "#{{Scheme.Ui.Hover}}",
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
			            "selectionForeground": "#{{Scheme.Ui.Selection}}",
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
			        "mPrimary": "#{{Scheme.Accent.Primary}}",
			        "mOnPrimary": "#{{Scheme.Accent.PrimaryText}}",
			        "mSecondary": "#{{Scheme.Accent.Secondary}}",
			        "mOnSecondary": "#{{Scheme.Accent.SecondaryText}}",
			        "mTertiary": "#{{Scheme.Accent.Tertiary}}",
			        "mOnTertiary": "#{{Scheme.Accent.TertiaryText}}",
			        "mError": "#{{Scheme.Colors.Error}}",
			        "mOnError": "#{{Scheme.Accent.PrimaryText}}",
			        "mSurface": "#{{Scheme.Colors.Background}}",
			        "mOnSurface": "#{{Scheme.Colors.Text}}",
			        "mHover": "#{{Scheme.Ui.HoverBackground}}",
			        "mOnHover": "#{{Scheme.Ui.Hover}}",
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
			            "selectionForeground": "#{{Scheme.Ui.Selection}}",
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
