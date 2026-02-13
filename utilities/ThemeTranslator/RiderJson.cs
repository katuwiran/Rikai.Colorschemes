namespace ColorschemeUtils;

public static partial class ThemeTranslator
{
	public static string RiderJson(ColorScheme scheme)
	{
		return
			$$"""
			   {
			     "name": "{{ scheme.Name }}",
			     "dark": {{ scheme.IsDark.ToString().ToLower() }},
			     "author": "Rikai. built on top by catppuccin's template",
			     "editorScheme": "/{{ scheme.Name }}.xml",
			     "colors": {
			       "base": "#{{ scheme.Base }}",
			       "surface": "#{{ scheme.Surface}}",
			       "overlay": "#{{ scheme.Overlay }}",
			       "subtle": "#{{ scheme.Subtle }}",
			       "muted": "#{{ scheme.Muted }}",
			       "magenta": "#{{ scheme.Magenta }}",
			       "lavender": "#{{ scheme.Lavender }}",
			       "blue": "#{{ scheme.Blue }}",
			       "purple": "#{{ scheme.Purple }}",
			       "cyan": "#{{ scheme.Cyan }}",
			       "green": "#{{ scheme.Green }}",
			       "yellow": "#{{ scheme.Yellow }}",
			       "red": "#{{ scheme.Red }}",
			       "orange": "#{{ scheme.Orange }}",
			       "highlight-low": "#{{ scheme.Highlight }}",
			       "pink": "#{{ scheme.Lavender }}",
			       "surface0": "#{{ scheme.Surface }}",
			       "overlay0": "#{{ scheme.Inactive }}",
			       "text": "#{{ scheme.Text }}",
			       "subtext0": "#{{ scheme.Surface }}",
			       "accentColor": "#{{ scheme.Accent }}",
			       "secondaryAccentColor": "#{{ scheme.Accent }}",
			       "primaryForeground": "#{{ scheme.Text }}",
			       "primaryBackground": "#{{ scheme.Base }}",
			       "secondaryBackground": "#{{ scheme.Surface }}",
			       "inactiveBackground": "#{{ scheme.Inactive }}",
			       "panelForeground": "#{{ scheme.Text }}",
			       "panelBackground": "#{{ scheme.Overlay }}",
			       "toolbarBackground": "#{{ scheme.Inactive }}",
			       "hoverBackground": "#{{ scheme.HighlightOverlay }}",
			       "selectionBackground": "#{{ scheme.HighlightOverlay }}",
			       "selectionInactiveBackground": "#{{ scheme.HighlightInactive }}",
			       "borderColor": "#{{ scheme.Surface }}",
			       "separatorColor": "#{{ scheme.Surface }}",
			       "searchMatchBackground": "#{{ scheme.Highlight }}",
			       "textFieldBackground": "#{{ scheme.Base }}",
			       "gitLogBackground": "#{{ scheme.Base }}",
			       "dragAndDropBackground": "#{{ scheme.Base }}"
			     },
			     "ui": {
			       "*": {
			         "arc": "7",
			         "foreground": "primaryForeground",
			         "background": "primaryBackground",
			         "disabledBackground": "primaryBackground",
			         "inactiveBackground": "primaryBackground",
			         "selectionBackground": "selectionBackground",
			         "selectionForeground": "primaryForeground",
			         "selectionInactiveBackground": "selectionInactiveBackground",
			         "selectionInactiveForeground": "primaryForeground",
			         "separatorColor": "separatorColor",
			         "borderColor": "borderColor",
			         "focusColor": "accentColor",
			         "infoForeground": "subtext0"
			       },
			       "ActionButton": {
			         "hoverBackground": "hoverBackground",
			         "pressedBackground": "hoverBackground",
			         "pressedForeground": "selectionBackground",
			         "pressedBorderColor": "selectionBackground"
			       },
			       "Banner": {
			         "foreground": "#{{ scheme.Text }}",
			         "errorBackground": "#{{ scheme.Red }}",
			         "errorBorderColor": "#{{ scheme.Red }}",
			         "errorForeground": "primaryForeground",
			         "informativeBackground": "#{{ scheme.Blue }}",
			         "informativeBorderColor": "#{{ scheme.Blue }}",
			         "informativeForeground": "primaryForeground",
			         "warningBackground": "#{{ scheme.Yellow }}",
			         "warningBorderColor": "#{{ scheme.Yellow }}",
			         "warningForeground": "primaryForeground"
			       },
			       "Bookmark": {
			         "Mnemonic": {
			           "iconBackground": "secondaryBackground",
			           "iconBorderColor": "accentColor",
			           "iconForeground": "primaryForeground"
			         },
			         "MnemonicAssigned": {
			           "background": "secondaryBackground",
			           "borderColor": "secondaryAccentColor",
			           "foreground": "primaryForeground"
			         },
			         "MnemonicAvailable": {},
			         "MnemonicCurrent": {
			           "background": "selectionBackground",
			           "borderColor": "accentColor",
			           "foreground": "primaryForeground"
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
			           "foreground": "crust",
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
			         "matchForeground": "accentColor",
			         "selectionBackground": "selectionBackground",
			         "selectionInactiveBackground": "selectionInactiveBackground"
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
			         "infoForeground": "subtext0"
			       },
			       "Counter": {
			         "background": "accentColor",
			         "foreground": "primaryBackground"
			       },
			       "DefaultTabs": {
			         "background": "panelBackground",
			         "hoverBackground": "primaryBackground",
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
			         "inactiveHoverBackground": "#{{ scheme.Magenta }}",
			         "inactiveUnderlineColor": "#{{ scheme.Purple }}",
			         "hoverBackground": "selectionBackground",
			         "underTabsBorderColor": "separatorColor",
			         "underlineArc": 4,
			         "underlineColor": "accentColor",
			         "underlineHeight": 1,
			         "underlinedTabBackground": "panelBackground",
			         "unselectedBlend": 0.9
			       },
			       "FileColor": {
			         "Blue": "#{{ scheme.Blue }}",
			         "Green": "#{{ scheme.Green }}",
			         "Orange": "#{{ scheme.Orange }}",
			         "Rose": "#{{ scheme.Red }}",
			         "Violet": "#{{ scheme.Purple }}",
			         "Yellow": "#{{ scheme.Yellow }}"
			       },
			       "Label": {
			         "background": "panelBackground",
			         "selectedForeground": "selectionBackground"
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
			         "border": "4,0,4,0",
			         "hoverBackground": "hoverBackground",
			         "rowHeight": "24",
			         "selectionInactiveBackground": "selectionInactiveBackground"
			       },
			       "MainToolbar": {
			         "Dropdown": {
			           "hoverBackground": "hoverBackground",
			           "maxWidth": 350,
			           "pressedBackground": "hoverBackground"
			         },
			         "Icon": {
			           "hoverBackground": "hoverBackground",
			           "insets": "5,5,5,5",
			           "pressedBackground": "hoverBackground"
			         },
			         "background": "toolbarBackground",
			         "inactiveBackground": "panelBackground"
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
			         "allocatedBackground": "surface0",
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
			           "selectedForeground": "primaryForeground"
			         },
			         "borderColor": "borderColor",
			         "hoverBackground": "hoverBackground",
			         "lightSelectionBackground": "selectionBackground",
			         "tagBackground": "panelBackground"
			       },
			       "Popup": {
			         "Advertiser": {
			           "background": "panelBackground",
			           "fontSizeOffset": -1,
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
			         "background": "secondaryBackground",
			         "foreground": "text",
			         "iconColor": "primaryForeground",
			         "pressedBackground": "green",
			         "separatorColor": "separatorColor",
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
			           "chevronInset": 0
			         },
			         "background": "panelBackground",
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
			         "hoverBackground": "selectionBackground",
			         "lightSelectionBackground": "secondaryBackground"
			       },
			       "TableHeader": {
			         "bottomSeparatorColor": "primaryBackground"
			       },
			       "TextArea": {
			         "background": "panelBackground"
			       },
			       "TextField": {
			         "background": "secondaryBackground",
			         "selectionBackground": "textFieldBackground"
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
			           "selectedBackground": "hoverBackground",
			           "selectedForeground": "primaryForeground"
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
			           "background": "panelBackground"
			         },
			         "background": "panelBackground"
			       },
			       "Tree": {
			         "background": "panelBackground",
			         "border": "4,12,4,12",
			         "foreground": "primaryForeground",
			         "hoverBackground": "hoverBackground",
			         "modifiedItemForeground": "accentColor",
			         "rowHeight": 24,
			         "selectionBackground": "selectionBackground",
			         "selectionInactiveBackground": "selectionBackground"
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
			           "background": "hoverBackground",
			           "selectionBackground": "secondaryBackground",
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
			         "Actions.Blue": "#{{ scheme.Blue }}",
			         "Actions.Green": "#{{ scheme.Green }}",
			         "Actions.Grey": "#{{ scheme.Inactive }}",
			         "Actions.GreyInline": "#{{ scheme.Blue }}",
			         "Actions.GreyInline.Dark": "#{{ scheme.Blue }}",
			         "Actions.Red": "#{{ scheme.Red }}",
			         "Actions.Yellow": "#{{ scheme.Yellow }}",
			         "Objects.BlackText": "#{{ scheme.Surface }}",
			         "Objects.Blue": "#{{ scheme.Blue }}",
			         "Objects.Green": "#{{ scheme.Green }}",
			         "Objects.Grey": "#{{ scheme.Inactive }}",
			         "Objects.Pink": "#{{ scheme.Lavender }}",
			         "Objects.Purple": "#{{ scheme.Purple }}",
			         "Objects.Red": "#{{ scheme.Red }}",
			         "Objects.RedStatus": "#{{ scheme.Red }}",
			         "Objects.Yellow": "#{{ scheme.Yellow }}",
			         "Objects.YellowDark": "#{{ scheme.Orange }}",
			         "Checkbox.Background.Default": "#{{ scheme.Base }}",
			         "Checkbox.Background.Default.Dark": "#{{ scheme.Surface }}",
			         "Checkbox.Background.Disabled": "#{{ scheme.Base }}",
			         "Checkbox.Background.Disabled.Dark": "#{{ scheme.Surface }}",
			         "Checkbox.Background.Selected": "#{{ scheme.HighlightOverlay }}",
			         "Checkbox.Background.Selected.Dark": "#{{ scheme.HighlightInactive }}",
			         "Checkbox.Border.Default": "#{{ scheme.Surface }}",
			         "Checkbox.Border.Disabled": "#{{ scheme.Surface }}",
			         "Checkbox.Border.Selected": "#{{ scheme.Surface }}",
			         "Checkbox.Foreground.Disabled": "#{{ scheme.Inactive }}",
			         "Checkbox.Foreground.Disabled.Dark": "#{{ scheme.Inactive }}",
			         "Checkbox.Foreground.Selected": "#{{ scheme.Accent }}",
			         "Checkbox.Foreground.Selected.Dark": "#{{ scheme.Accent }}",
			         "Tree.iconColor": "#{{ scheme.Text }}"
			       }
			     }
			   }
			   	         
			   """;
	}
}