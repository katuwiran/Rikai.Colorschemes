namespace ColorschemeUtils;

public class RiderJson : ITheme
{
	public string      FilePath { get; set; }
	public ColorScheme Scheme   { get; set; }

	public RiderJson(ColorScheme colorScheme)
	{
		FilePath = $"{_prefix}{colorScheme.Name}.theme.json";
		Scheme   = colorScheme;
	}

	private string _prefix => $"Jetbrains{_sep}resources{_sep}theme{_sep}";
	private string _sep    => $"{Path.DirectorySeparatorChar}";

	// for Kvantum's svg format
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
			  		"base": "#{{Scheme.Base}}",
			  		"surface": "#{{Scheme.Surface}}",
			  		"overlay": "#{{Scheme.Overlay}}",
			  		"subtle": "#{{Scheme.Subtle}}",
			  		"muted": "#{{Scheme.Muted}}",
			  		"magenta": "#{{Scheme.Magenta}}",
			  		"lavender": "#{{Scheme.Lavender}}",
			  		"blue": "#{{Scheme.Blue}}",
			  		"purple": "#{{Scheme.Purple}}",
			  		"cyan": "#{{Scheme.Cyan}}",
			  		"green": "#{{Scheme.Green}}",
			  		"yellow": "#{{Scheme.Yellow}}",
			  		"red": "#{{Scheme.Red}}",
			  		"orange": "#{{Scheme.Orange}}",
			  		"pink": "#{{Scheme.Lavender}}",
			  		"surface0": "#{{Scheme.Surface}}",
			  		"text": "#{{Scheme.Text}}",
			  		"accentColor": "#{{Scheme.Magenta}}",
			  		"secondaryAccentColor": "#{{Scheme.Magenta}}",
			  		"buttonForeground": "#{{Scheme.Text}}",
			  		"primaryForeground": "#{{Scheme.Text}}",
			  		"primaryBackground": "#{{Scheme.Base}}",
			  		"secondaryBackground": "#{{Scheme.Surface}}",
			  		"inactiveBackground": "#{{Scheme.Muted}}",
			  		"panelForeground": "#{{Scheme.Text}}",
			  		"panelBackground": "#{{Scheme.Base}}",
			  		"toolbarBackground": "#{{Scheme.Base}}",
			  		"hoverBackground": "#{{Scheme.Highlight}}",
			  		"pressedBackground": "#{{Scheme.HighlightOverlay}}",
			  		"selectionForeground": "#{{Scheme.Text}}",
			  		"selectionBackground": "#{{Scheme.Highlight}}",
			  		"selectionInactiveBackground": "#{{Scheme.HighlightInactive}}",
			  		"borderColor": "#{{Scheme.HighlightInactive}}",
			  		"separatorColor": "#{{Scheme.Surface}}",
			  		"searchMatchBackground": "#{{Scheme.Highlight}}",
			  		"gitLogBackground": "#{{Scheme.Base}}",
			  		"dragAndDropBackground": "#{{Scheme.Base}}"
			  	},
			  	"ui": {
			  		"*": {
			  			"arc": "7",
			  			"foreground": "primaryForeground",
			  			"background": "primaryBackground",
			  			"disabledBackground": "primaryBackground",
			  			"inactiveBackground": "primaryBackground",
			  			"selectionBackground": "selectionBackground",
			  			"selectionForeground": "selectionForeground",
			  			"selectionInactiveBackground": "selectionInactiveBackground",
			  			"selectionInactiveForeground": "primaryForeground",
			  			"separatorColor": "separatorColor",
			  			"borderColor": "borderColor",
			  			"focusColor": "accentColor",
			  			"infoForeground": "subtle"
			  		},
			  		"ActionButton": {
			  			"hoverBackground": "hoverBackground",
			  			"pressedBackground": "pressedBackground",
			  			"pressedBorderColor": "selectionBackground"
			  		},
			  		"Banner": {
			  			"errorBackground": "#{{Scheme.Red}}",
			  			"errorBorderColor": "#{{Scheme.Red}}",
			  			"warningBackground": "#{{Scheme.Yellow}}",
			  			"warningBorderColor": "#{{Scheme.Yellow}}"
			  		},
			  		"Bookmark": {
			  			"Mnemonic": {
			  				"iconBackground": "secondaryBackground",
			  				"iconForeground": "primaryForeground"
			  			},
			  			"MnemonicAssigned": {
			  				"background": "secondaryBackground",
			  				"foreground": "primaryForeground"
			  			},
			  			"MnemonicAvailable": {},
			  			"MnemonicCurrent": {
			  				"background": "selectionBackground",
			  				"foreground": "selectionForeground"
			  			},
			  			"iconBackground": "accentColor"
			  		},
			  		"Borders": {
			  			"ContrastBorderColor": "separatorColor",
			  			"color": "borderColor"
			  		},
			  		"Button": {
			  			"background": "panelBackground",
			  			"default": {
			  				"endBackground": "accentColor",
			  				"endBorderColor": "accentColor",
			  				"focusColor": "accentColor",
			  				"focusedBorderColor": "accentColor",
			  				"foreground": "primaryBackground",
			  				"startBackground": "accentColor",
			  				"startBorderColor": "accentColor"
			  			},
			  			"disabledBorderColor": "secondaryBackground",
			  			"endBackground": "secondaryBackground",
			  			"endBorderColor": "secondaryBackground",
			  			"focusedBorderColor": "secondaryBackground",
			  			"foreground": "primaryForeground",
			  			"startBackground": "secondaryBackground",
			  			"startBorderColor": "secondaryBackground"
			  		},
			  		"CheckBox": {
			  			"background": "panelBackground"
			  		},
			  		"ComboBox": { 
			  			"ArrowButton": {
			  				"background": "secondaryBackground",
			  				"disabledIconColor": "lavender",
			  				"iconColor": "accentColor",
			  				"nonEditableBackground": "secondaryBackground"
			  			},
			  			"modifiedItemForeground": "accentColor",
			  			"nonEditableBackground": "secondaryBackground",
			  			"selectionBackground": "selectionBackground"
			  		},
			  		"CompletionPopup": {
			  			"foreground": "primaryForeground",
			  			"matchForeground": "selectionForeground",
			  			"selectionBackground": "selectionBackground",
			  			"selectionInactiveBackground": "primaryBackground"
			  		},
			  		"Component": {
			  			"borderColor": "borderColor",
			  			"disabledBorderColor": "selectionBackground",
			  			"errorFocusColor": "red",
			  			"focusColor": "accentColor",
			  			"focusedBorderColor": "selectionBackground",
			  			"iconColor": "primaryForeground",
			  			"inactiveErrorFocusColor": "red",
			  			"inactiveWarningFocusColor": "yellow",
			  			"warningFocusColor": "yellow",
			  			"infoForeground": "subtle"
			  		},
			  		"Counter": {
			  			"background": "accentColor",
			  			"foreground": "primaryBackground"
			  		},
			  		"DefaultTabs": {
			  			"background": "panelBackground",
			  			"hoverBackground": "hoverBackground",
			  			"underlinedTabBackground": "panelBackground"
			  		},
			  		"DragAndDrop": {
			  			"borderColor": "selectionBackground",
			  			"rowBackground": "dragAndDropBackground",
			  			"areaForeground": "primaryForeground",
			  			"areaBackground": "panelBackground",
			  			"areaBorderColor": "accentColor"
			  		},
			  		"Editor": {
			  			"Toolbar": {
			  				"borderColor": "separatorColor"
			  			},
			  			"background": "primaryBackground",
			  			"shortcutForeground": "accentColor"
			  		},
			  		"EditorPane": {
			  			"splitBorder": "separatorColor"
			  		},
			  		"EditorTabs": {
			  			"background": "primaryBackground",
			  			"inactiveUnderlineColor": "#{{Scheme.Purple}}",
			  			"hoverBackground": "hoverBackground",
			  			"underlineColor": "accentColor",
			  			"underlineHeight": 1,
			  			"underlinedTabBackground": "panelBackground",
			  			"unselectedBlend": 0.9
			  		},
			  		"FileColor": {
			  			"Blue": "#{{Scheme.Blue}}",
			  			"Green": "#{{Scheme.Green}}",
			  			"Orange": "#{{Scheme.Orange}}",
			  			"Rose": "#{{Scheme.Red}}",
			  			"Violet": "#{{Scheme.Purple}}",
			  			"Yellow": "#{{Scheme.Yellow}}"
			  		},
			  		"Label": {
			  			"background": "panelBackground",
			  			"selectedForeground": "selectionBackground"
			  		},
			  		"GotItTooltip": {
			  			"background": "panelBackground",
			  			"codeBackground": "#{{Scheme.Red}}",
			  			"codeBorderColor": "#{{Scheme.Blue}}",
			  			"shortcutForeground": "{{Scheme.Magenta}}"
			  		},
			  		"Link": {
			  			"activeForeground": "accentColor",
			  			"hoverForeground": "accentColor",
			  			"pressedForeground": "secondaryAccentColor",
			  			"visitedForeground": "secondaryAccentColor"
			  		},
			  		"List": {
			  			"Button": {
			  				"leftRightInset": 8,
			  				"separatorInset": 4,
			  				"hoverBackground": "hoverBackground"
			  			},
			  			"background": "panelBackground",
			  			"hoverBackground": "hoverBackground",
			  			"rowHeight": "24",
			  			"selectionInactiveBackground": "selectionInactiveBackground"
			  		},
			  		"MainToolbar": {
			  			"Dropdown": {
			  				"maxWidth": 350
			  			},
			  			"Icon": {
			  				"insets": "5,5,5,5"
			  			},
			  			"background": "toolbarBackground"
			  		},
			  		"MainWindow": {
			  			"Tab": {
			  				"background": "toolbarBackground",
			  				"borderColor": "toolbarBackground",
			  				"selectedBackground": "panelBackground",
			  				"selectedForeground": "primaryForeground",
			  				"hoverBackground": "hoverBackground",
			  				"selectedInactiveBackground": "primaryBackground",
			  				"separatorColor": "separatorColor"
			  			}
			  		},
			  		"MemoryIndicator": {
			  			"allocatedBackground": "panelBackground",
			  			"usedBackground": "selectionBackground"
			  		},
			  		"Notification": {
			  			"ToolWindow": {
			  				"errorBackground": "primaryBackground",
			  				"errorBorderColor": "red",
			  				"errorForeground": "primaryForeground",
			  				"informativeBackground": "primaryBackground",
			  				"informativeBorderColor": "secondaryAccentColor",
			  				"informativeForeground": "primaryForeground",
			  				"warningBackground": "primaryBackground",
			  				"warningBorderColor": "yellow",
			  				"warningForeground": "primaryForeground"
			  			},
			  			"background": "panelBackground",
			  			"borderColor": "borderColor",
			  			"errorBackground": "primaryBackground",
			  			"errorBorderColor": "red",
			  			"errorForeground": "primaryForeground"
			  		},
			  		"NotificationsToolwindow": {
			  			"newNotification": {
			  				"background": "primaryBackground",
			  				"hoverBackground": "hoverBackground"
			  			}
			  		},
			  		"Panel": {
			  			"foreground": "panelForeground",
			  			"background": "panelBackground"
			  		},
			  		"PasswordField": {
			  			"background": "secondaryBackground"
			  		},
			  		"Plugins": {
			  			"Button": {
			  				"installBackground": "primaryBackground",
			  				"installBorderColor": "secondaryAccentColor",
			  				"installFillBackground": "secondaryAccentColor",
			  				"installFillForeground": "primaryBackground",
			  				"installFocusedBackground": "primaryBackground",
			  				"installForeground": "secondaryAccentColor",
			  				"updateBackground": "accentColor",
			  				"updateBorderColor": "accentColor",
			  				"updateForeground": "primaryBackground"
			  			},
			  			"SearchField": {
			  				"background": "panelBackground"
			  			},
			  			"SectionHeader": {
			  				"foreground": "primaryForeground"
			  			},
			  			"Tab": {
			  				"hoverBackground": "hoverBackground",
			  				"selectedBackground": "selectionBackground",
			  				"selectedForeground": "selectionForeground"
			  			},
			  			"borderColor": "borderColor",
			  			"hoverBackground": "hoverBackground",
			  			"lightSelectionBackground": "selectionBackground",
			  			"tagBackground": "panelBackground"
			  		},
			  		"Popup": {
			  			"Advertiser": {
			  				"background": "panelBackground",
			  				"foreground": "text"
			  			},
			  			"Header": {
			  				"activeBackground": "panelBackground",
			  				"inactiveBackground": "panelBackground"
			  			},
			  			"borderColor": "separatorColor",
			  			"borderWidth": 1,
			  			"inactiveBorderColor": "separatorColor",
			  			"paintBorder": false
			  		},
			  		"ProgressBar": {
			  			"failedColor": "red",
			  			"failedEndColor": "red",
			  			"indeterminateEndColor": "secondaryAccentColor",
			  			"indeterminateStartColor": "accentColor",
			  			"passedColor": "green",
			  			"passedEndColor": "green",
			  			"progressColor": "accentColor",
			  			"trackColor": "selectionBackground"
			  		},
			  		"RadioButton": {
			  			"background": "panelBackground"
			  		},
			  		"RunWidget": {
			  			"foreground": "text",
			  			"iconColor": "primaryForeground",
			  			"pressedBackground": "pressedBackground",
			  			"stopBackground": "red"
			  		},
			  		"ScrollBar": {
			  			"thumbBorderColor": "surface0",
			  			"thumbColor": "surface0",
			  			"hoverThumbColor": "selectionBackground",
			  			"hoverThumbBorderColor": "selectionBackground",
			  			"Mac": {
			  				"thumbBorderColor": "surface0",
			  				"thumbColor": "surface0",
			  				"hoverThumbColor": "selectionBackground",
			  				"hoverThumbBorderColor": "selectionBackground"
			  			}
			  		},
			  		"SearchEverywhere": {
			  			"SearchField": {
			  				"background": "secondaryBackground"
			  			},
			  			"Tab": {
			  				"selectedBackground": "secondaryBackground",
			  				"selectedForeground": "primaryForeground"
			  			}
			  		},
			  		"SearchMatch": {
			  			"endBackground": "searchMatchBackground",
			  			"startBackground": "searchMatchBackground"
			  		},
			  		"SegmentedButton": {
			  			"focusedSelectedButtonColor": "secondaryBackground",
			  			"selectedButtonColor": "secondaryBackground",
			  			"selectedEndBorderColor": "secondaryBackground",
			  			"selectedStartBorderColor": "secondaryBackground"
			  		},
			  		"Separator": {
			  			"separatorColor": "separatorColor"
			  		},
			  		"SidePanel": {
			  			"background": "panelBackground"
			  		},
			  		"Slider": {
			  			"background": "panelBackground"
			  		},
			  		"StatusBar": {
			  			"Breadcrumbs": {
			  			},
			  			"borderColor": "borderColor",
			  			"hoverBackground": "hoverBackground"
			  		},
			  		"TabbedPane": {
			  			"background": "panelBackground",
			  			"contentAreaColor": "borderColor",
			  			"focusColor": "selectionBackground",
			  			"hoverColor": "hoverBackground",
			  			"tabHeight": 40,
			  			"tabSelectionArc": 4,
			  			"underlineColor": "accentColor"
			  		},
			  		"Table": {
			  			"gridColor": "hoverBackground",
			  			"hoverBackground": "hoverBackground",
			  			"lightSelectionBackground": "selectionBackground"
			  		},
			  		"TableHeader": {
			  			"bottomSeparatorColor": "primaryBackground"
			  		},
			  		"TextArea": {
			  			"background": "panelBackground"
			  		},
			  		"TextField": {
			  			"background": "#{{Scheme.Base}}",
			  			"caretForeground": "secondaryBackground",
			  			"foreground": "#{{Scheme.Text}}",
			  			"selectionForeground": "#{{Scheme.Text}}",
			  			"selectionBackground": "#{{Scheme.Highlight}}"
			  		},
			  		"ToggleButton": {
			  			"buttonColor": "primaryForeground",
			  			"offBackground": "selectionBackground",
			  			"offForeground": "hoverBackground",
			  			"onBackground": "green",
			  			"onForeground": "hoverBackground"
			  		},
			  		"ToolBar": {
			  			"background": "panelBackground",
			  			"borderHandleColor": "secondaryAccentColor"
			  		},
			  		"ToolWindow": {
			  			"Button": {
			  				"hoverBackground": "hoverBackground",
			  				"selectedBackground": "selectionBackground",
			  				"selectedForeground": "selectionForeground"
			  			},
			  			"Header": {
			  				"background": "panelBackground",
			  				"borderColor": "borderColor",
			  				"inactiveBackground": "panelBackground"
			  			},
			  			"HeaderTab": {
			  				"hoverBackground": "surface0",
			  				"inactiveUnderlineColor": "text",
			  				"underlineColor": "accentColor"
			  			},
			  			"Stripe": {
			  			},
			  			"background": "panelBackground"
			  		},
			  		"Tree": {
			  			"background": "#{{Scheme.Base}}",
			  			"foreground": "#{{Scheme.Text}}",
			  			"hoverBackground": "hoverBackground",
			  			"modifiedItemForeground": "accentColor",
			  			"rowHeight": 24,
			  			"selectionBackground": "#{{Scheme.Highlight}}",
			  			"selectionInactiveBackground": "#{{Scheme.Highlight}}",
			  			"selectionForeground": "#{{Scheme.Text}}"
			  		},
			  		"UiDesigner": {
			  			"Panel.background": "panelBackground",
			  			"Preview.background": "panelBackground"
			  		},
			  		"ValidationTooltip": {
			  			"errorBackground": "panelBackground",
			  			"errorBorderColor": "red",
			  			"warningBackground": "panelBackground",
			  			"warningBorderColor": "secondaryAccentColor"
			  		},
			  		"VersionControl": {
			  			"FileHistory": {
			  				"Commit": {
			  					"selectedBranchBackground": "secondaryBackground"
			  				}
			  			},
			  			"GitLog": {
			  				"headIconColor": "secondaryAccentColor",
			  				"localBranchIconColor": "green",
			  				"otherIconColor": "green",
			  				"remoteBranchIconColor": "secondaryAccentColor",
			  				"tagIconColor": "accentColor"
			  			},
			  			"Log": {
			  				"Commit": {
			  					"currentBranchBackground": "gitLogBackground",
			  					"hoveredBackground": "hoverBackground",
			  					"selectionInactiveBackground": "hoverBackground"
			  				}
			  			},
			  			"RefLabel": {
			  				"foreground": "primaryForeground"
			  			}
			  		},
			  		"WelcomeScreen": {
			  			"Projects": {
			  				"actions": {
			  					"background": "hoverBackground"
			  				},
			  				"background": "primaryBackground",
			  				"selectionBackground": "selectionBackground",
			  				"selectionInactiveBackground": "secondaryBackground"
			  			},
			  			"SidePanel": {
			  				"background": "panelBackground"
			  			},
			  			"separatorColor": "separatorColor"
			  		}
			  	},
			  	"icons": {
			  		"ColorPalette": {
			  			"Actions.Blue": "#{{Scheme.Blue}}",
			  			"Actions.Green": "#{{Scheme.Green}}",
			  			"Actions.Grey": "#{{Scheme.Muted}}",
			  			"Actions.GreyInline": "#{{Scheme.Blue}}",
			  			"Actions.GreyInline.Dark": "#{{Scheme.Blue}}",
			  			"Actions.Red": "#{{Scheme.Red}}",
			  			"Actions.Yellow": "#{{Scheme.Yellow}}",
			  			"Objects.BlackText": "#{{Scheme.Surface}}",
			  			"Objects.Blue": "#{{Scheme.Blue}}",
			  			"Objects.Green": "#{{Scheme.Green}}",
			  			"Objects.Grey": "#{{Scheme.Muted}}",
			  			"Objects.Pink": "#{{Scheme.Lavender}}",
			  			"Objects.Purple": "#{{Scheme.Purple}}",
			  			"Objects.Red": "#{{Scheme.Red}}",
			  			"Objects.RedStatus": "#{{Scheme.Red}}",
			  			"Objects.Yellow": "#{{Scheme.Yellow}}",
			  			"Objects.YellowDark": "#{{Scheme.Orange}}",
			  			"Checkbox.Background.Default": "#{{Scheme.Base}}",
			  			"Checkbox.Background.Default.Dark": "#{{Scheme.Surface}}",
			  			"Checkbox.Background.Disabled": "#{{Scheme.Base}}",
			  			"Checkbox.Background.Disabled.Dark": "#{{Scheme.Surface}}",
			  			"Checkbox.Background.Selected": "#{{Scheme.HighlightOverlay}}",
			  			"Checkbox.Background.Selected.Dark": "#{{Scheme.HighlightInactive}}",
			  			"Checkbox.Border.Default": "#{{Scheme.Surface}}",
			  			"Checkbox.Border.Disabled": "#{{Scheme.Surface}}",
			  			"Checkbox.Border.Selected": "#{{Scheme.Surface}}",
			  			"Checkbox.Foreground.Disabled": "#{{Scheme.Muted}}",
			  			"Checkbox.Foreground.Disabled.Dark": "#{{Scheme.Muted}}",
			  			"Checkbox.Foreground.Selected": "#{{Scheme.Magenta}}",
			  			"Checkbox.Foreground.Selected.Dark": "#{{Scheme.Magenta}}",
			  			"Tree.iconColor": "#{{Scheme.Text}}"
			  		}
			  	}
			  }
			  """;
	}
}