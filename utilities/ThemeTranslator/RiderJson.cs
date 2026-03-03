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
			  		"base": "#{{Scheme.Background}}",
			  		"surface": "#{{Scheme.BackgroundEdges}}",
			  		"overlay": "#{{Scheme.BackgroundOverlay}}",
			  		"faded": "#{{Scheme.TextFaded}}",
			  		"hidden": "#{{Scheme.TextHidden}}",
			  		"class": "#{{Scheme.Class}}",
			  		"keyword": "#{{Scheme.Keyword}}",
			  		"field": "#{{Scheme.Field}}",
			  		"method": "#{{Scheme.Method}}",
			  		"cyan": "#{{Scheme.String}}",
			  		"green": "#{{Scheme.Numeral}}",
			  		"yellow": "#{{Scheme.Info}}",
			  		"red": "#{{Scheme.Error}}",
			  		"orange": "#{{Scheme.Warning}}",
			  		"pink": "#{{Scheme.Keyword}}",
			  		"surface0": "#{{Scheme.BackgroundEdges}}",
			  		"text": "#{{Scheme.Text}}",
			  		"accentColor": "#{{Scheme.Class}}",
			  		"secondaryAccentColor": "#{{Scheme.Class}}",
			  		"buttonForeground": "#{{Scheme.Text}}",
			  		"primaryForeground": "#{{Scheme.Text}}",
			  		"primaryBackground": "#{{Scheme.Background}}",
			  		"secondaryBackground": "#{{Scheme.Background}}",
			  		"inactiveBackground": "#{{Scheme.TextHidden}}",
			  		"panelForeground": "#{{Scheme.Text}}",
			  		"panelBackground": "#{{Scheme.Background}}",
			  		"toolbarBackground": "#{{Scheme.Background}}",
			  		"hoverBackground": "#{{Scheme.Highlight}}",
			  		"pressedBackground": "#{{Scheme.HighlightHigh}}",
			  		"selectionForeground": "#{{Scheme.Text}}",
			  		"selectionBackground": "#{{Scheme.Highlight}}",
			  		"selectionInactiveBackground": "#{{Scheme.HighlightLow}}",
			  		"borderColor": "#{{Scheme.HighlightLow}}",
			  		"separatorColor": "#{{Scheme.BackgroundEdges}}",
			  		"searchMatchBackground": "#{{Scheme.Highlight}}",
			  		"gitLogBackground": "#{{Scheme.Background}}",
			  		"dragAndDropBackground": "#{{Scheme.Background}}"
			  	},
			  	"ui": {
			  		"*": {
			  			"arc": "7",
			  			"foreground": "primaryForeground",
			  			"background": "primaryBackground",
			  			"disabledForeground": "primaryBackground",
			  			"disabledBackground": "primaryBackground",
			  			"disabledText": "primaryBackground",
			  			"disabledBorderColor": "primaryBackground",
			  			"inactiveBackground": "primaryBackground",
			  			"selectionBackground": "selectionBackground",
			  			"selectionForeground": "selectionForeground",
			  			"selectionInactiveBackground": "selectionInactiveBackground",
			  			"selectionInactiveForeground": "primaryForeground",
			  			"separatorColor": "separatorColor",
			  			"borderColor": "borderColor",
			  			"focusColor": "accentColor",
			  			"infoForeground": "faded"
			  		},
			  		"ActionButton": {
			  			"focusedBorderColor": "hoverBackground",
			  			"hoverBackground": "hoverBackground",
			  			"hoverBorderColor": "hoverBackground",
			  			"hoverBackground": "hoverBackground",
			  			"pressedBackground": "pressedBackground",
			  			"pressedBorderColor": "selectionBackground"
			  		},
			  		"Banner": {
			  			"errorBackground": "#{{Scheme.Error}}",
			  			"errorBorderColor": "#{{Scheme.Error}}",
			  			"warningBackground": "#{{Scheme.Info}}",
			  			"warningBorderColor": "#{{Scheme.Info}}"
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
			  			"infoForeground": "faded"
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
			  			"inactiveUnderlineColor": "#{{Scheme.Method}}",
			  			"hoverBackground": "hoverBackground",
			  			"underlineColor": "accentColor",
			  			"underlineHeight": 1,
			  			"underlinedTabBackground": "panelBackground",
			  			"unselectedBlend": 0.9
			  		},
			  		"FileColor": {
			  			"Blue": "#{{Scheme.Field}}",
			  			"Green": "#{{Scheme.Numeral}}",
			  			"Orange": "#{{Scheme.Warning}}",
			  			"Rose": "#{{Scheme.Error}}",
			  			"Violet": "#{{Scheme.Method}}",
			  			"Yellow": "#{{Scheme.Info}}"
			  		},
			  		"Label": {
			  			"background": "panelBackground",
			  			"selectedForeground": "selectionBackground"
			  		},
			  		"GotItTooltip": {
			  			"background": "panelBackground",
			  			"codeBackground": "#{{Scheme.Error}}",
			  			"codeBorderColor": "#{{Scheme.Field}}",
			  			"shortcutForeground": "{{Scheme.Class}}"
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
			  			"background": "#{{Scheme.Background}}",
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
			  			"background": "#{{Scheme.Background}}",
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
			  			"Actions.Blue": "#{{Scheme.Field}}",
			  			"Actions.Green": "#{{Scheme.Numeral}}",
			  			"Actions.Grey": "#{{Scheme.TextHidden}}",
			  			"Actions.GreyInline": "#{{Scheme.Field}}",
			  			"Actions.GreyInline.Dark": "#{{Scheme.Field}}",
			  			"Actions.Red": "#{{Scheme.Error}}",
			  			"Actions.Yellow": "#{{Scheme.Info}}",
			  			"Objects.BlackText": "#{{Scheme.BackgroundEdges}}",
			  			"Objects.Blue": "#{{Scheme.Field}}",
			  			"Objects.Green": "#{{Scheme.Numeral}}",
			  			"Objects.Grey": "#{{Scheme.TextHidden}}",
			  			"Objects.Pink": "#{{Scheme.Keyword}}",
			  			"Objects.Purple": "#{{Scheme.Method}}",
			  			"Objects.Red": "#{{Scheme.Error}}",
			  			"Objects.RedStatus": "#{{Scheme.Error}}",
			  			"Objects.Yellow": "#{{Scheme.Info}}",
			  			"Objects.YellowDark": "#{{Scheme.Warning}}",
			  			"Checkbox.Background.Default": "#{{Scheme.Background}}",
			  			"Checkbox.Background.Default.Dark": "#{{Scheme.BackgroundEdges}}",
			  			"Checkbox.Background.Disabled": "#{{Scheme.Background}}",
			  			"Checkbox.Background.Disabled.Dark": "#{{Scheme.BackgroundEdges}}",
			  			"Checkbox.Background.Selected": "#{{Scheme.HighlightHigh}}",
			  			"Checkbox.Background.Selected.Dark": "#{{Scheme.HighlightLow}}",
			  			"Checkbox.Border.Default": "#{{Scheme.BackgroundEdges}}",
			  			"Checkbox.Border.Disabled": "#{{Scheme.BackgroundEdges}}",
			  			"Checkbox.Border.Selected": "#{{Scheme.BackgroundEdges}}",
			  			"Checkbox.Foreground.Disabled": "#{{Scheme.TextHidden}}",
			  			"Checkbox.Foreground.Disabled.Dark": "#{{Scheme.TextHidden}}",
			  			"Checkbox.Foreground.Selected": "#{{Scheme.Class}}",
			  			"Checkbox.Foreground.Selected.Dark": "#{{Scheme.Class}}",
			  			"Tree.iconColor": "#{{Scheme.Text}}"
			  		}
			  	}
			  }
			  """;
	}
}