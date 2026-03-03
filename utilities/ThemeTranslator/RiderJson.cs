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
			  		"bg": "#{{Scheme.Background}}",
			  		"borderLow": "#{{Scheme.BackgroundEdges}}",
			  		"border": "#{{Scheme.BackgroundOverlay}}",
			  		"bgOverlay": "#{{Scheme.BackgroundOverlay}}",
			  		"faded": "#{{Scheme.TextFaded}}",
			  		"inactive": "#{{Scheme.TextInactive}}",
			  		"hidden": "#{{Scheme.TextHidden}}",
			  		"class": "#{{Scheme.Class}}",
			  		"keyword": "#{{Scheme.Keyword}}",
			  		"field": "#{{Scheme.Field}}",
			  		"method": "#{{Scheme.Method}}",
			  		"string": "#{{Scheme.String}}",
			  		"numeral": "#{{Scheme.Numeral}}",
			  		"info": "#{{Scheme.Info}}",
			  		"warning": "#{{Scheme.Warning}}",
			  		"error": "#{{Scheme.Error}}",
			  		"text": "#{{Scheme.Text}}",
			  		"hiLow": "#{{Scheme.HighlightLow}}",
			  		"highlight": "#{{Scheme.Highlight}}",
			  		"hiHigh": "#{{Scheme.HighlightHigh}}",
			  		"black": "#{{Scheme.Black}}",
			  		"red": "#{{Scheme.Red}}",
			  		"green": "#{{Scheme.Green}}",
			  		"yellow": "#{{Scheme.Yellow}}",
			  		"blue": "#{{Scheme.Blue}}",
			  		"magenta": "#{{Scheme.Magenta}}",
			  		"cyan": "#{{Scheme.Cyan}}",
			  		"white": "#{{Scheme.White}}",
			  		"accentColor": "#{{Scheme.Keyword}}",
			  		"secondaryAccentColor": "#{{Scheme.Method}}",
			  		"buttonForeground": "#{{Scheme.Text}}",
			  		"inactiveBackground": "#{{Scheme.TextHidden}}",
			  		"inactiveForeground": "#{{Scheme.TextHidden}}",
			  		"hoverBackground": "#{{Scheme.HoverBackground}}",
			  		"hoverForeground": "#{{Scheme.HoverText}}",
			  		"pressedBackground": "#{{Scheme.PressedBackground}}",
			  		"selectionBackground": "#{{Scheme.SelectionBackground}}",
			  		"selectionForeground": "#{{Scheme.SelectionText}}",
			  		"selectionInactiveBackground": "#{{Scheme.SelectionInactiveBackground}}",
			  		"selectionInactiveForeground": "#{{Scheme.SelectionInactiveText}}",
			  		"searchMatchBackground": "#{{Scheme.HighlightLow}}",
			  		"gitLogBackground": "#{{Scheme.Background}}",
			  		"dragAndDropBackground": "#{{Scheme.Background}}"
			  	},
			  	"ui": {
			  		"*": {
			  			"arc": "7",
			  			"foreground": "text",
			  			"background": "bg",
			  			"borderColor": "border",
			  			"disabledForeground": "inactive",
			  			"disabledBackground": "bg",
			  			"disabledBorderColor": "borderLow",
			  			"disabledShadow": "borderLow",
			  			"disabledText": "inactive",
			  			"focusColor": "hiHigh",
			  			"focusedBorderColor": "hiHigh",
			  			"inactiveBackground": "inactiveBackground",
			  			"inactiveForeground": "inactiveForeground",
			  			"infoForeground": "text",
			  			"hoverForeground": "hoverForeground",
			  			"hoverBackground": "hoverBackground",
			  			"pressedBackground": "pressedBackground",
			  			"selectionBackground": "selectionBackground",
			  			"selectionForeground": "selectionForeground",
			  			"selectionInactiveBackground": "selectionInactiveBackground",
			  			"selectionInactiveForeground": "selectionInactiveForeground",
			  			"separatorColor": "border"
			  		},
			  		"ActionButton": {
			  			"hoverBorderColor": "hoverBackground",
			  			"hoverBackground": "hoverBackground",
			  			"pressedBackground": "pressedBackground",
			  			"pressedBorderColor": "selectionBackground"
			  		},
			  		"Banner": {
			  			"errorBackground": "error",
			  			"errorBorderColor": "error",
			  			"warningBackground": "warning",
			  			"warningBorderColor": "warning"
			  		},
			  		"Bookmark": {
			  			"Mnemonic": {
			  				"iconForeground": "text"
			  			},
			  			"MnemonicAssigned": {
			  				"background": "bgOverlay",
			  				"foreground": "text"
			  			},
			  			"MnemonicAvailable": {
			  				"background": "bgOverlay",
			  				"borderColor": "text",
			  				"foreground": "text"
			  			},
			  			"MnemonicCurrent": {
			  				"background": "selectionBackground",
			  				"foreground": "text"
			  			},
			  			"iconBackground": "accentColor"
			  		},
			  		"Borders": {
			  			"ContrastBorderColor": "border",
			  			"color": "borderLow"
			  		},
			  		"Button": {
			  			"background": "bg",
			  			"default": {
			  				"endBackground": "bg",
			  				"endBorderColor": "border",
			  				"focusColor": "accentColor",
			  				"focusedBorderColor": "accentColor",
			  				"foreground": "bg",
			  				"startBackground": "accentColor",
			  				"startBorderColor": "accentColor"
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
			  				"iconColor": "accentColor",
			  				"nonEditableBackground": "bgOverlay"
			  			},
			  			"modifiedItemForeground": "accentColor",
			  			"nonEditableBackground": "bgOverlay"
			  		},
			  		"CompletionPopup": {
			  			"foreground": "text",
			  			"matchForeground": "selectionForeground",
			  			"selectionBackground": "selectionBackground",
			  			"selectionInactiveBackground": "selectionInactiveBackground"
			  		},
			  		"Component": {
			  			"borderColor": "border",
			  			"disabledBorderColor": "selectionBackground",
			  			"errorFocusColor": "red",
			  			"focusColor": "accentColor",
			  			"focusedBorderColor": "selectionBackground",
			  			"iconColor": "text",
			  			"inactiveErrorFocusColor": "error",
			  			"inactiveWarningFocusColor": "warning",
			  			"warningFocusColor": "warning",
			  			"infoForeground": "info"
			  		},
			  		"Counter": {
			  			"background": "accentColor",
			  			"foreground": "bg"
			  		},
			  		"DefaultTabs": {
			  			"background": "bg",
			  			"hoverBackground": "hoverBackground",
			  			"underlinedTabBackground": "bg"
			  		},
			  		"DragAndDrop": {
			  			"areaBackground": "text",
			  			"areaForeground": "text",
			  			"borderColor": "selectionBackground",
			  			"rowBackground": "dragAndDropBackground"
			  		},
			  		"Editor": {
			  			"Toolbar": {
			  				"borderColor": "border"
			  			},
			  			"background": "bg",
			  			"shortcutForeground": "accentColor"
			  		},
			  		"EditorPane": {
			  			"caretForeground": "text",
			  			"splitBorder": "border"
			  		},
			  		"EditorTabs": {
			  			"background": "bg",
			  			"inactiveUnderlineColor": "secondaryAccentColor",
			  			"hoverBackground": "hoverBackground",
			  			"underlineColor": "accentColor",
			  			"underlineHeight": 1,
			  			"underlinedTabBackground": "bg",
			  			"unselectedBlend": 0.9
			  		},
			  		"FileColor": {
			  			"Blue": "{{Scheme.Field}}",
			  			"Green": "#{{Scheme.Numeral}}",
			  			"Orange": "#{{Scheme.Warning}}",
			  			"Rose": "#{{Scheme.Error}}",
			  			"Violet": "#{{Scheme.Method}}",
			  			"Yellow": "#{{Scheme.Info}}"
			  		},
			  		"Label": {
			  			"background": "bg",
			  			"selectedForeground": "selectionForeground"
			  		},
			  		"GotItTooltip": {
			  			"background": "background",
			  			"codeBackground": "overlay",
			  			"codeBorderColor": "border",
			  			"shortcutForeground": "text"
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
			  			"dropLineColor": "bg",
			  			"background": "bg",
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
			  			"background": "background"
			  		},
			  		"MainWindow": {
			  			"Tab": {
			  				"background": "bg",
			  				"borderColor": "border",
			  				"selectedBackground": "selectionBackground",
			  				"selectedForeground": "selectionForeground",
			  				"hoverBackground": "hoverBackground",
			  				"selectedInactiveBackground": "selectionInactiveBackground",
			  				"separatorColor": "border"
			  			}
			  		},
			  		"MemoryIndicator": {
			  			"allocatedBackground": "bg",
			  			"usedBackground": "selectionBackground"
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
			  				"hoverBackground": "hoverBackground"
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
			  				"installBorderColor": "secondaryAccentColor",
			  				"installFillBackground": "secondaryAccentColor",
			  				"installFillForeground": "buttonBackground",
			  				"installFocusedBackground": "bg",
			  				"installForeground": "secondaryAccentColor",
			  				"updateBackground": "accentColor",
			  				"updateBorderColor": "accentColor",
			  				"updateForeground": "bg"
			  			},
			  			"SearchField": {
			  				"background": "bg"
			  			},
			  			"SectionHeader": {
			  				"foreground": "text"
			  			},
			  			"Tab": {
			  				"hoverBackground": "hoverBackground",
			  				"selectedBackground": "selectionBackground",
			  				"selectedForeground": "selectionForeground"
			  			},
			  			"borderColor": "border",
			  			"hoverBackground": "hoverBackground",
			  			"lightSelectionBackground": "selectionBackground",
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
			  			"indeterminateEndColor": "secondaryAccentColor",
			  			"indeterminateStartColor": "accentColor",
			  			"passedColor": "green",
			  			"passedEndColor": "green",
			  			"progressColor": "accentColor",
			  			"trackColor": "selectionBackground"
			  		},
			  		"RadioButton": {
			  			"background": "bg"
			  		},
			  		"RunWidget": {
			  			"foreground": "text",
			  			"iconColor": "text",
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
			  				"background": "bgOverlay"
			  			},
			  			"Tab": {
			  				"selectedBackground": "bgOverlay",
			  				"selectedForeground": "text"
			  			}
			  		},
			  		"SearchMatch": {
			  			"endBackground": "searchMatchBackground",
			  			"startBackground": "searchMatchBackground"
			  		},
			  		"SegmentedButton": {
			  			"focusedSelectedButtonColor": "bgOverlay",
			  			"selectedButtonColor": "bgOverlay",
			  			"selectedEndBorderColor": "bgOverlay",
			  			"selectedStartBorderColor": "bgOverlay"
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
			  			},
			  			"borderColor": "border"
			  		},
			  		"TabbedPane": {
			  			"background": "bg",
			  			"contentAreaColor": "border",
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
			  			"bottomSeparatorColor": "bg"
			  		},
			  		"TextArea": {
			  			"background": "bg"
			  		},
			  		"TextField": {
			  			"background": "#{{Scheme.Background}}",
			  			"caretForeground": "bgOverlay",
			  			"foreground": "#{{Scheme.Text}}",
			  			"selectionForeground": "#{{Scheme.Text}}",
			  			"selectionBackground": "#{{Scheme.Highlight}}"
			  		},
			  		"ToggleButton": {
			  			"buttonColor": "text",
			  			"offBackground": "selectionBackground",
			  			"offForeground": "hoverBackground",
			  			"onBackground": "green",
			  			"onForeground": "hoverBackground"
			  		},
			  		"ToolBar": {
			  			"background": "bg",
			  			"borderHandleColor": "secondaryAccentColor"
			  		},
			  		"ToolWindow": {
			  			"Button": {
			  				"hoverBackground": "hoverBackground",
			  				"selectedBackground": "selectionBackground",
			  				"selectedForeground": "selectionForeground"
			  			},
			  			"Header": {
			  				"background": "bg",
			  				"borderColor": "border",
			  				"inactiveBackground": "bg"
			  			},
			  			"HeaderTab": {
			  				"hoverBackground": "surface0",
			  				"inactiveUnderlineColor": "text",
			  				"underlineColor": "accentColor"
			  			},
			  			"Stripe": {
			  			},
			  			"background": "bg"
			  		},
			  		"Tree": {
			  			"background": "bg",
			  			"foreground": "text",
			  			"hoverBackground": "hoverBackground",
			  			"modifiedItemForeground": "accentColor",
			  			"rowHeight": 24,
			  			"selectionBackground": "selectionBackground",
			  			"selectionInactiveBackground": "selectionInactiveBackground",
			  			"selectionForeground": "selectionForeground"
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
			  					"selectedBranchBackground": "bgOverlay"
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
			  					"selectionInactiveBackground": "selectionInactiveBackground"
			  				}
			  			},
			  			"RefLabel": {
			  				"foreground": "text"
			  			}
			  		},
			  		"WelcomeScreen": {
			  			"Projects": {
			  				"actions": {
			  					"background": "hoverBackground"
			  				},
			  				"background": "bg",
			  				"selectionBackground": "selectionBackground",
			  				"selectionInactiveBackground": "selectionInactiveBackground"
			  			},
			  			"SidePanel": {
			  				"background": "bg"
			  			},
			  			"separatorColor": "border"
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