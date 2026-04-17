namespace Rikai.Colorschemes;

public class JetbrainsJson : ITheme
{
	public string      FilePath { get; set; }
	public ColorScheme Scheme   { get; set; }

	public JetbrainsJson(ColorScheme scheme)
	{
		FilePath = Path.Combine("Jetbrains", "resources", "theme", $"{scheme.Name}.theme.json");
		Scheme   = scheme;
	}
	
	public override string ToString()
	{
		return
			$$"""
 			  {
 			  	"name": "{{Scheme.Name}}",
 			  	"dark": {{Scheme.IsDark.ToString().ToLower()}},
 			  	"author": "Rikai. built on top of catppuccin's template",
 			  	"editorScheme": "/{{Scheme.Name}}.xml",
 			  	"colors": {
 			  		"bg": "#{{Scheme.Colors.Background}}",
 			  		"border": "#{{Scheme.Colors.BackgroundOverlay}}",
 			  		"bgOverlay": "#{{Scheme.Colors.BackgroundOverlay}}",
 			  		"faded": "#{{Scheme.Colors.TextFaded}}",
 			  		"inactive": "#{{Scheme.Colors.TextInactive}}",
 			  		"hidden": "#{{Scheme.Colors.TextHidden}}",
 			  		"class": "#{{Scheme.Colors.Class}}",
 			  		"keyword": "#{{Scheme.Colors.Keyword}}",
 			  		"field": "#{{Scheme.Colors.Field}}",
 			  		"method": "#{{Scheme.Colors.Method}}",
 			  		"string": "#{{Scheme.Colors.String}}",
 			  		"numeral": "#{{Scheme.Colors.Numeral}}",
 			  		"info": "#{{Scheme.Colors.Info}}",
 			  		"warning": "#{{Scheme.Colors.Warning}}",
 			  		"error": "#{{Scheme.Colors.Error}}",
 			  		"text": "#{{Scheme.Colors.Text}}",
 			  		"hiLow": "#{{Scheme.Colors.HighlightLow}}",
 			  		"highlight": "#{{Scheme.Colors.Highlight}}",
 			  		"hiHigh": "#{{Scheme.Colors.HighlightHigh}}",
 			  		"black": "#{{Scheme.Base8.Black}}",
 			  		"red": "#{{Scheme.Base8.Red}}",
 			  		"green": "#{{Scheme.Base8.Green}}",
 			  		"yellow": "#{{Scheme.Base8.Yellow}}",
 			  		"blue": "#{{Scheme.Base8.Blue}}",
 			  		"magenta": "#{{Scheme.Base8.Magenta}}",
 			  		"cyan": "#{{Scheme.Base8.Cyan}}",
 			  		"grey": "#{{Scheme.Console.BlackAlt}}",
 			  		"pink": "#{{Scheme.Colors.Keyword}}",
 			  		"purple": "#{{Scheme.Colors.Method}}",
 			  		"white": "#{{Scheme.Base8.White}}",
 			  		"accent": "#{{Scheme.Accent.Primary}}",
 			  		"secondaryAccent": "#{{Scheme.Accent.Secondary}}",
 			  		"buttonForeground": "#{{Scheme.Colors.Text}}",
 			  		"inactiveBg": "#{{Scheme.Ui.InactiveBackground}}",
 			  		"inactiveFg": "#{{Scheme.Ui.Inactive}}",
 			  		"hoverBg": "#{{Scheme.Ui.HoverBackground.AdjustAlphaAndFlatten(-0.5, Scheme.Colors.Background)}}",
 			  		"hoverFg": "#{{Scheme.Accent.Tertiary}}",
 			  		"pressedBg": "#{{Scheme.Ui.PressedBackground.AdjustAlphaAndFlatten(-0.5, Scheme.Colors.Background)}}",
 			  		"selectionBg": "#{{Scheme.Ui.SelectionBackground.AdjustAlphaAndFlatten(-0.5, Scheme.Colors.Background)}}",
 			  		"selectionFg": "#{{Scheme.Ui.Selection}}",
 			  		"selectionInactiveBg": "#{{Scheme.Ui.SelectionInactiveBackground}}",
 			  		"selectionInactiveFg": "#{{Scheme.Ui.SelectionInactive}}",
 			  		"searchMatchBg": "#{{Scheme.Colors.HighlightLow}}",
 			  		"gitLogBg": "#{{Scheme.Colors.Background}}",
 			  		"dragAndDropBg": "#{{Scheme.Colors.Background}}"
 			  	},
 			  	"ui": {
 			  		"*": {
 			  			"arc": "7",
 			  			"foreground": "text",
 			  			"background": "bg",
 			  			"borderColor": "border",
 			  			"disabledBackground": "bg",
 			  			"focusColor": "hoverBg",
 			  			"inactiveBackground": "inactiveBg",
 			  			"selectionBackground": "selectionBg",
 			  			"selectionInactiveBackground": "selectionInactiveBg",
 			  			"selectionInactiveForeground": "selectionInactiveFg",
 			  			"separatorColor": "border"
 			  		},
 			  		"ActionButton": {
 			  			"hoverBorderColor": "hoverBg",
 			  			"hoverBackground": "hoverBg",
 			  			"pressedBackground": "pressedBg",
 			  			"pressedBorderColor": "pressedBg"
 			  		},
 			  		"Banner": {
 			  			"errorBackground": "error",
 			  			"errorBorderColor": "error",
 			  			"informativeBackground": "info",
 			  			"informativeBorderColor": "info",
 			  			"warningBackground": "warning",
 			  			"warningBorderColor": "warning"
 			  		},
 			  		"Bookmark": {
 			  			"Mnemonic": {
 			  				"iconBackground": "bg",
 			  				"borderColor": "border",
 			  				"iconForeground": "text"
 			  			},
 			  			"MnemonicAssigned": {
 			  				"background": "bgOverlay",
 			  				"borderColor": "border",
 			  				"foreground": "text"
 			  			},
 			  			"MnemonicAvailable": {},
 			  			"MnemonicCurrent": {
 			  				"background": "selectionBg",
 			  				"borderColor": "accent",
 			  				"foreground": "text"
 			  			},
 			  			"iconBackground": "accent"
 			  		},
 			  		"Borders": {
 			  			"ContrastBorderColor": "border",
 			  			"color": "borderLow"
 			  		},
 			  		"Button": {
 			  			"background": "bg",
 			  			"default": {
 			  				"endBackground": "accent",
 			  				"endBorderColor": "accent",
 			  				"focusColor": "accent",
 			  				"focusedBorderColor": "accent",
 			  				"foreground": "bg",
 			  				"startBackground": "accent",
 			  				"startBorderColor": "accent"
 			  			},
 			  			"disabledBorderColor": "border",
 			  			"disabledText": "inactive",
 			  			"endBackground": "bgOverlay",
 			  			"endBorderColor": "bgOverlay",
 			  			"focusedBorderColor": "bgOverlay",
 			  			"foreground": "text",
 			  			"shadowColor": "bgOverlay",
 			  			"startBackground": "bgOverlay",
 			  			"startBorderColor": "bgOverlay"
 			  		},
 			  		"CheckBox": {
 			  			"background": "bg",
 			  			"disabledText": "inactive",
 			  			"foreground": "text",
 			  			"select": "highlight"
 			  		},
 			  		"ComboBox": { 
 			  			"ArrowButton": {
 			  				"background": "bgOverlay",
 			  				"disabledIconColor": "keyword",
 			  				"iconColor": "accent",
 			  				"nonEditableBackground": "bgOverlay"
 			  			},
 			  			"modifiedItemForeground": "accent",
 			  			"nonEditableBackground": "bgOverlay",
 			  			"selectionBackground": "selectionBg"
 			  		},
 			  		"CompletionPopup": {
 			  			"matchForeground": "accent",
 			  			"selectionBackground": "selectionInactiveBg",
 			  			"selectionInactiveBackground": "selectionInactiveBg"
 			  		},
 			  		"Component": {
 			  			"borderColor": "border",
 			  			"disabledBorderColor": "selectionBg",
 			  			"errorFocusColor": "red",
 			  			"focusColor": "accent",
 			  			"focusedBorderColor": "selectionBg",
 			  			"iconColor": "text",
 			  			"inactiveErrorFocusColor": "error",
 			  			"inactiveWarningFocusColor": "warning",
 			  			"warningFocusColor": "warning",
 			  			"infoForeground": "faded"
 			  		},
 			  		"Counter": {
 			  			"background": "accent",
 			  			"foreground": "bg"
 			  		},
 			  		"DefaultTabs": {
 			  			"background": "bg",
 			  			"hoverBackground": "#{{Scheme.Colors.BackgroundOverlay}}",
 			  			"underlinedTabBackground": "bg"
 			  		},
 			  		"DragAndDrop": {
 			  			"borderColor": "selectionBg",
 			  			"rowBackground": "bgOverlay",
 			  			"areaBackground": "text",
 			  			"areaForeground": "text"
 			  		},
 			  		"Editor": {
 			  			"Toolbar": {
 			  				"borderColor": "border"
 			  			},
 			  			"background": "bg",
 			  			"shortcutForeground": "accent"
 			  		},
 			  		"EditorPane": {
 			  			"caretForeground": "text",
 			  			"splitBorder": "border"
 			  		},
 			  		"EditorTabs": {
 			  			"background": "bg",
 			  			"inactiveUnderlineColor": "secondaryAccent",
 			  			"hoverBackground": "hoverBg",
 			  			"underlineColor": "accent",
 			  			"underlineHeight": 1,
 			  			"underlinedTabBackground": "bg",
 			  			"unselectedBlend": 0.9
 			  		},
 			  		"FileColor": {
 			  			"Blue": "{{Scheme.Base8.Blue}}",
 			  			"Green": "#{{Scheme.Base8.Green}}",
 			  			"Orange": "#{{Scheme.Base8.Blue}}",
 			  			"Rose": "#{{Scheme.Base8.Red}}",
 			  			"Violet": "#{{Scheme.Colors.Method}}",
 			  			"Yellow": "#{{Scheme.Base8.Yellow}}"
 			  		},
 			  		"Label": {
 			  			"background": "bg",
 			  			"selectedForeground": "selectionFg"
 			  		},
 			  		"GotItTooltip": {
 			  			"background": "background",
 			  			"codeBackground": "overlay",
 			  			"codeBorderColor": "border",
 			  			"shortcutForeground": "text"
 			  		},
 			  		"Link": {
 			  			"activeForeground": "accent",
 			  			"hoverForeground": "accent",
 			  			"pressedForeground": "secondaryAccent",
 			  			"visitedForeground": "secondaryAccent"
 			  		},
 			  		"List": {
 			  			"Button": {
 			  				"leftRightInset": 8,
 			  				"separatorInset": 4,
 			  				"hoverBackground": "hoverBg"
 			  			},
 			  			"background": "bg",
 			  			"hoverBackground": "hoverBg",
 			  			"rowHeight": "24",
 			  			"selectionForeground": "hoverFg",
 			  			"selectionInactiveBackground": "selectionInactiveBg"
 			  		},
 			  		"MainToolbar": {
 			  			"Dropdown": {
 			  				"maxWidth": 350
 			  			},
 			  			"Icon": {
 			  				"insets": "5,5,5,5"
 			  			},
 			  			"background": "bg"
 			  		},
 			  		"MainWindow": {
 			  			"Tab": {
 			  				"background": "bg",
 			  				"borderColor": "border",
 			  				"selectedBackground": "selectedBg",
 			  				"selectedForeground": "selectionFg",
 			  				"hoverBackground": "hoverBg",
 			  				"selectedInactiveBackground": "selectionInactiveBg",
 			  				"separatorColor": "border"
 			  			}
 			  		},
 			  		"MemoryIndicator": {
 			  			"allocatedBackground": "bg",
 			  			"usedBackground": "selectionBg"
 			  		},
 			  		"Menu": {
 			  			"allocatedBackground": "bg",
 			  			"usedBackground": "selectionBg"
 			  		},
 			  		"Notification": {
 			  			"ToolWindow": {
 			  				"errorBackground": "bg",
 			  				"errorBorderColor": "error",
 			  				"errorForeground": "text",
 			  				"informativeBackground": "bg",
 			  				"informativeBorderColor": "info",
 			  				"informativeForeground": "text",
 			  				"warningBackground": "bg",
 			  				"warningBorderColor": "warning",
 			  				"warningForeground": "text"
 			  			},
 			  			"background": "bg",
 			  			"borderColor": "border",
 			  			"errorBackground": "bg",
 			  			"errorBorderColor": "red",
 			  			"errorForeground": "text"
 			  		},
 			  		"NotificationsToolwindow": {
 			  			"newNotification": {
 			  				"background": "bg",
 			  				"hoverBackground": "hoverBg"
 			  			}
 			  		},
 			  		"Panel": {
 			  			"foreground": "text",
 			  			"background": "bg"
 			  		},
 			  		"PasswordField": {
 			  			"background": "bgOverlay"
 			  		},
 			  		"Plugins": {
 			  			"Button": {
 			  				"installBackground": "bg",
 			  				"installBorderColor": "secondaryAccent",
 			  				"installFillBackground": "secondaryAccent",
 			  				"installFillForeground": "buttonBackground",
 			  				"installFocusedBackground": "bg",
 			  				"installForeground": "secondaryAccent",
 			  				"updateBackground": "accent",
 			  				"updateBorderColor": "accent",
 			  				"updateForeground": "bg"
 			  			},
 			  			"SearchField": {
 			  				"background": "bg"
 			  			},
 			  			"SectionHeader": {
 			  				"foreground": "text"
 			  			},
 			  			"Tab": {
 			  				"hoverBackground": "hoverBg",
 			  				"selectedBackground": "selectionBg",
 			  				"selectedForeground": "selectionFg"
 			  			},
 			  			"borderColor": "border",
 			  			"hoverBackground": "hoverBg",
 			  			"lightSelectionBackground": "selectionBg",
 			  			"tagBackground": "bg"
 			  		},
 			  		"Popup": {
 			  			"Advertiser": {
 			  				"background": "bg",
 			  				"foreground": "text"
 			  			},
 			  			"Header": {
 			  				"activeBackground": "bg",
 			  				"inactiveBackground": "bg"
 			  			},
 			  			"borderColor": "border",
 			  			"borderWidth": 1,
 			  			"inactiveBorderColor": "border",
 			  			"paintBorder": false
 			  		},
 			  		"ProgressBar": {
 			  			"failedColor": "red",
 			  			"failedEndColor": "red",
 			  			"indeterminateEndColor": "secondaryAccent",
 			  			"indeterminateStartColor": "accent",
 			  			"passedColor": "green",
 			  			"passedEndColor": "green",
 			  			"progressColor": "accent",
 			  			"trackColor": "selectionBg"
 			  		},
 			  		"RadioButton": {
 			  			"background": "bg"
 			  		},
 			  		"RunWidget": {
 			  			"background": "bgOverlay",
 			  			"foreground": "text",
 			  			"iconColor": "text",
 			  			"pressedBackground": "pressedBackground",
 			  			"separatorColor": "border",
 			  			"stopBackground": "red"
 			  		},
 			  		"ScrollBar": {
 			  			"Transparent": {
 			  				"background": "bg",
 			  				"thumbColor": "bgOverlay",
 			  				"hoverThumbColor": "bgOverlay"
 			  			},
 			  			"thumbBorderColor": "border",
 			  			"thumbColor": "bgOverlay",
 			  			"hoverThumbColor": "selectionBg",
 			  			"hoverThumbBorderColor": "selectionBg",
 			  			"Mac": {
 			  				"thumbBorderColor": "border",
 			  				"thumbColor": "bgOverlay",
 			  				"hoverThumbColor": "selectionBg",
 			  				"hoverThumbBorderColor": "selectionBg"
 			  			}
 			  		},
 			  		"SearchEverywhere": {
 			  			"SearchField": {
 			  				"background": "bgOverlay"
 			  			},
 			  			"Tab": {
 			  				"selectedBackground": "bgOverlay",
 			  				"selectedForeground": "text"
 			  			}
 			  		},
 			  		"SearchMatch": {
 			  			"endBackground": "searchMatchBg",
 			  			"startBackground": "searchMatchBg"
 			  		},
 			  		"SegmentedButton": {
 			  			"focusedSelectedButtonColor": "hoverBg",
 			  			"selectedButtonColor": "selectionBg",
 			  			"selectedEndBorderColor": "selectionBg",
 			  			"selectedStartBorderColor": "selectionBg"
 			  		},
 			  		"Separator": {
 			  			"separatorColor": "border"
 			  		},
 			  		"SidePanel": {
 			  			"background": "bg"
 			  		},
 			  		"Slider": {
 			  			"background": "bg"
 			  		},
 			  		"StatusBar": {
 			  			"Breadcrumbs": {
 			  				"chevronInset": 0
 			  			},
 			  			"background": "bg",
 			  			"borderColor": "border",
 			  			"hoverBackground": "hoverBg"
 			  		},
 			  		"TabbedPane": {
 			  			"background": "bg",
 			  			"contentAreaColor": "border",
 			  			"focusColor": "selectedBg",
 			  			"hoverColor": "hoverBg",
 			  			"tabHeight": 40,
 			  			"tabSelectionArc": 4,
 			  			"unselectedBackground": "inactiveBg",
 			  			"underlineColor": "accent"
 			  		},
 			  		"Table": {
 			  			"gridColor": "hoverBg",
 			  			"hoverBackground": "hoverBg",
 			  			"lightSelectionBackground": "selectionBg"
 			  		},
 			  		"TableHeader": {
 			  			"bottomSeparatorColor": "border"
 			  		},
 			  		"TextArea": {
 			  			"background": "bg"
 			  		},
 			  		"TextField": {
 			  			"background": "bg",
 			  			"caretForeground": "accent",
 			  			"foreground": "text",
 			  			"selectionForeground": "hoverFg",
 			  			"selectionBackground": "selectionBg"
 			  		},
 			  		"ToggleButton": {
 			  			"buttonColor": "accent",
 			  			"offBackground": "text",
 			  			"offForeground": "hoverFg",
 			  			"onBackground": "pressedBg",
 			  			"onForeground": "bg"
 			  		},
 			  		"ToolBar": {
 			  			"background": "bg",
 			  			"borderHandleColor": "secondaryAccent"
 			  		},
 			  		"ToolWindow": {
 			  			"Button": {
 			  				"hoverBackground": "hoverBg",
 			  				"selectedBackground": "selectionBg",
 			  				"selectedForeground": "selectionFg"
 			  			},
 			  			"Header": {
 			  				"background": "bg",
 			  				"borderColor": "border",
 			  				"inactiveBackground": "inactiveBg"
 			  			},
 			  			"HeaderTab": {
 			  				"hoverBackground": "hoverBg",
 			  				"inactiveUnderlineColor": "text",
 			  				"underlineColor": "accent"
 			  			},
 			  			"Stripe": {
 			  				"background": "bgOverlay"
 			  			},
 			  			"background": "bg"
 			  		},
 			  		"Tree": {
 			  			"background": "bg",
 			  			"foreground": "text",
 			  			"hash": "border",
 			  			"hoverBackground": "hoverBg",
 			  			"modifiedItemForeground": "accent",
 			  			"rowHeight": 24,
 			  			"selectionBackground": "selectionBg",
 			  			"selectionInactiveBackground": "selectionInactiveBg",
 			  			"selectionForeground": "hoverFg",
 			  			"textBackground": "bgOverlay"
 			  		},
 			  		"UiDesigner": {
 			  			"Panel.background": "bg",
 			  			"Preview.background": "bg"
 			  		},
 			  		"ValidationTooltip": {
 			  			"errorBackground": "bg",
 			  			"errorBorderColor": "red",
 			  			"warningBackground": "bg",
 			  			"warningBorderColor": "warning"
 			  		},
 			  		"VersionControl": {
 			  			"FileHistory": {
 			  				"Commit": {
 			  					"selectedBranchBackground": "selectionBg"
 			  				}
 			  			},
 			  			"GitLog": {
 			  				"headIconColor": "secondaryAccent",
 			  				"localBranchIconColor": "green",
 			  				"otherIconColor": "green",
 			  				"remoteBranchIconColor": "secondaryAccent",
 			  				"tagIconColor": "accent"
 			  			},
 			  			"Log": {
 			  				"Commit": {
 			  					"currentBranchBackground": "gitLogBackground",
 			  					"hoveredBackground": "hoverBg",
 			  					"selectionInactiveBackground": "selectionInactiveBg"
 			  				}
 			  			},
 			  			"RefLabel": {
 			  				"foreground": "text"
 			  			}
 			  		},
 			  		"WelcomeScreen": {
 			  			"Projects": {
 			  				"actions": {
 			  					"background": "hoverBg"
 			  				},
 			  				"background": "bg",
 			  				"selectionBackground": "selectionBg",
 			  				"selectionInactiveBackground": "selectionInactiveBg"
 			  			},
 			  			"SidePanel": {
 			  				"background": "bg"
 			  			},
 			  			"separatorColor": "border"
 			  		}
 			  	},
 			  	"icons": {
 			  		"ColorPalette": {
 			  			"Actions.Blue": "blue",
 			  			"Actions.Green": "green",
 			  			"Actions.Grey": "grey",
 			  			"Actions.GreyInline": "#{{Scheme.Colors.Field}}",
 			  			"Actions.GreyInline.Dark": "#{{Scheme.Colors.Field}}",
 			  			"Actions.Red": "red",
 			  			"Actions.Yellow": "yellow",
 			  			"Objects.BlackText": "black",
 			  			"Objects.Blue": "blue",
 			  			"Objects.Green": "green",
 			  			"Objects.Grey": "grey",
 			  			"Objects.Pink": "pink",
 			  			"Objects.Purple": "purple",
 			  			"Objects.Red": "red",
 			  			"Objects.RedStatus": "red",
 			  			"Objects.Yellow": "yellow",
 			  			"Objects.YellowDark": "yellow",
 			  			"Checkbox.Background.Default": "bg",
 			  			"Checkbox.Background.Default.Dark": "bg",
 			  			"Checkbox.Background.Disabled": "inactiveBg",
 			  			"Checkbox.Background.Disabled.Dark": "inactiveBg",
 			  			"Checkbox.Background.Selected": "selectionBg",
 			  			"Checkbox.Background.Selected.Dark": "selectionBg",
 			  			"Checkbox.Border.Default": "border",
 			  			"Checkbox.Border.Disabled": "inactiveBg",
 			  			"Checkbox.Border.Selected": "selectionBg",
 			  			"Checkbox.Foreground.Disabled": "#{{Scheme.Ui.Inactive}}",
 			  			"Checkbox.Foreground.Disabled.Dark": "#{{Scheme.Ui.Inactive}}",
 			  			"Checkbox.Foreground.Selected": "#{{Scheme.Ui.Selection}}",
 			  			"Checkbox.Foreground.Selected.Dark": "#{{Scheme.Ui.Selection}}",
 			  			"Tree.iconColor": "text"
 			  		}
 			  	}
 			  }
 			  """;
	}
}