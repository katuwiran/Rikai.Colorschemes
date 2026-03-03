namespace Rikai.Colorschemes;

public class RiderJson : ITheme
{
	public string      FilePath { get; set; }
	public ColorScheme Scheme   { get; set; }

	public RiderJson(ColorScheme scheme)
	{
		FilePath = Path.Combine("Jetbrains", $"{scheme.Name}.theme.json");
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
			  		"borderLow": "#{{Scheme.Colors.BackgroundEdges}}",
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
			  		"white": "#{{Scheme.Base8.White}}",
			  		"accentColor": "#{{Scheme.Colors.Keyword}}",
			  		"secondaryAccentColor": "#{{Scheme.Colors.Method}}",
			  		"buttonForeground": "#{{Scheme.Colors.Text}}",
			  		"inactiveBackground": "#{{Scheme.Colors.TextHidden}}",
			  		"inactiveForeground": "#{{Scheme.Colors.TextHidden}}",
			  		"hoverBackground": "#{{Scheme.Ui.HoverBackground}}",
			  		"hoverForeground": "#{{Scheme.Ui.HoverText}}",
			  		"pressedBackground": "#{{Scheme.Ui.PressedBackground}}",
			  		"selectionBackground": "#{{Scheme.Colors.HighlightLow}}",
			  		"selectionForeground": "#{{Scheme.Colors.Text}}",
			  		"selectionInactiveBackground": "#{{Scheme.Ui.SelectionInactiveBackground}}",
			  		"selectionInactiveForeground": "#{{Scheme.Ui.SelectionInactiveText}}",
			  		"searchMatchBackground": "#{{Scheme.Colors.HighlightLow}}",
			  		"gitLogBackground": "#{{Scheme.Colors.Background}}",
			  		"dragAndDropBackground": "#{{Scheme.Colors.Background}}"
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
			  			"selectionBackground": "pressedBackground",
			  			"selectionForeground": "selectionForeground",
			  			"selectionInactiveBackground": "selectionInactiveBackground",
			  			"selectionInactiveForeground": "selectionInactiveForeground",
			  			"separatorColor": "border"
			  		},
			  		"ActionButton": {
			  			"hoverBorderColor": "hoverBackground",
			  			"hoverBackground": "hoverBackground",
			  			"pressedBackground": "hoverBackground",
			  			"pressedBorderColor": "hoverBackground"
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
			  				"endBackground": "accentColor",
			  				"endBorderColor": "accentColor",
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
			  			"infoForeground": "faded"
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
			  			"Blue": "{{Scheme.Colors.Field}}",
			  			"Green": "#{{Scheme.Colors.Numeral}}",
			  			"Orange": "#{{Scheme.Colors.Warning}}",
			  			"Rose": "#{{Scheme.Colors.Error}}",
			  			"Violet": "#{{Scheme.Colors.Method}}",
			  			"Yellow": "#{{Scheme.Colors.Info}}"
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
			  			"selectionForeground": "hoverForeground",
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
			  				"selectedBackground": "pressedBackground",
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
			  		"Menu": {
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
			  			"Transparent": {
			  				"background": "bg",
			  				"thumbColor": "bgOverlay",
			  				"hoverThumbColor": "bgOverlay"
			  			},
			  			"thumbBorderColor": "border",
			  			"thumbColor": "bgOverlay",
			  			"hoverThumbColor": "selectionBackground",
			  			"hoverThumbBorderColor": "selectionBackground",
			  			"Mac": {
			  				"thumbBorderColor": "border",
			  				"thumbColor": "bgOverlay",
			  				"hoverThumbColor": "selectionBackground",
			  				"hoverThumbBorderColor": "selectionBackground"
			  			}
			  		},
			  		"SearchEverywhere": {
			  			"SearchField": {
			  				"background": "highlight"
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
			  			"focusColor": "bgOverlay",
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
			  			"background": "#{{Scheme.Colors.Background}}",
			  			"caretForeground": "bgOverlay",
			  			"foreground": "#{{Scheme.Colors.Text}}",
			  			"selectionForeground": "#{{Scheme.Colors.Text}}",
			  			"selectionBackground": "#{{Scheme.Colors.Highlight}}"
			  		},
			  		"ToggleButton": {
			  			"buttonColor": "secondaryAccentColor",
			  			"offBackground": "text",
			  			"offForeground": "hoverForegroun",
			  			"onBackground": "pressedBackground",
			  			"onForeground": "bg"
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
			  			"Actions.Blue": "#{{Scheme.Colors.Field}}",
			  			"Actions.Green": "#{{Scheme.Colors.Numeral}}",
			  			"Actions.Grey": "#{{Scheme.Colors.TextHidden}}",
			  			"Actions.GreyInline": "#{{Scheme.Colors.Field}}",
			  			"Actions.GreyInline.Dark": "#{{Scheme.Colors.Field}}",
			  			"Actions.Red": "#{{Scheme.Colors.Error}}",
			  			"Actions.Yellow": "#{{Scheme.Colors.Info}}",
			  			"Objects.BlackText": "#{{Scheme.Colors.BackgroundEdges}}",
			  			"Objects.Blue": "#{{Scheme.Colors.Field}}",
			  			"Objects.Green": "#{{Scheme.Colors.Numeral}}",
			  			"Objects.Grey": "#{{Scheme.Colors.TextHidden}}",
			  			"Objects.Pink": "#{{Scheme.Colors.Keyword}}",
			  			"Objects.Purple": "#{{Scheme.Colors.Method}}",
			  			"Objects.Red": "#{{Scheme.Colors.Error}}",
			  			"Objects.RedStatus": "#{{Scheme.Colors.Error}}",
			  			"Objects.Yellow": "#{{Scheme.Colors.Info}}",
			  			"Objects.YellowDark": "#{{Scheme.Colors.Warning}}",
			  			"Checkbox.Background.Default": "#{{Scheme.Colors.Background}}",
			  			"Checkbox.Background.Default.Dark": "#{{Scheme.Colors.BackgroundEdges}}",
			  			"Checkbox.Background.Disabled": "#{{Scheme.Colors.Background}}",
			  			"Checkbox.Background.Disabled.Dark": "#{{Scheme.Colors.BackgroundEdges}}",
			  			"Checkbox.Background.Selected": "#{{Scheme.Colors.HighlightHigh}}",
			  			"Checkbox.Background.Selected.Dark": "#{{Scheme.Colors.HighlightLow}}",
			  			"Checkbox.Border.Default": "#{{Scheme.Colors.BackgroundEdges}}",
			  			"Checkbox.Border.Disabled": "#{{Scheme.Colors.BackgroundEdges}}",
			  			"Checkbox.Border.Selected": "#{{Scheme.Colors.BackgroundEdges}}",
			  			"Checkbox.Foreground.Disabled": "#{{Scheme.Colors.TextHidden}}",
			  			"Checkbox.Foreground.Disabled.Dark": "#{{Scheme.Colors.TextHidden}}",
			  			"Checkbox.Foreground.Selected": "#{{Scheme.Colors.Class}}",
			  			"Checkbox.Foreground.Selected.Dark": "#{{Scheme.Colors.Class}}",
			  			"Tree.iconColor": "#{{Scheme.Colors.Text}}"
			  		}
			  	}
			  }
			  """;
	}
}