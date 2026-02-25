namespace ColorschemeUtils;

public class RiderXml : ITheme
{
	public string      FilePath { get; set; }
	public ColorScheme Scheme   { get; set; }

	public RiderXml(ColorScheme colorScheme)
	{
		FilePath = $"{_prefix}{colorScheme.Name}.xml";
		Scheme   = colorScheme;
	}

	private string _prefix => $"Jetbrains{_sep}resources{_sep}theme{_sep}";
	private string _sep    => $"{Path.DirectorySeparatorChar}";

	// for Kvantum's svg format
	public override string ToString()
	{
		const string FontBold   = "1";
		const string FontItalic = "2";
		return
			$"""
			 <scheme name="{Scheme.Name}" version="142" parent_scheme="Darcula">
			   <metaInfo>
			     <property name="ide">Rider</property>
			     <property name="ideVersion">2025.3.1.0.0</property>
			     <property name="originalScheme">{Scheme.Name}</property>
			   </metaInfo>
			   <colors>
			     <option name="ADDED_LINES_COLOR" value="{Scheme.Green}"/>
			     <option name="ANNOTATIONS_COLOR" value="{Scheme.Text}"/>
			     <option name="BLOCK_TERMINAL_BLOCK_BACKGROUND_END" value="{Scheme.Background}"/>
			     <option name="BLOCK_TERMINAL_BLOCK_BACKGROUND_START" value="{Scheme.Background}"/>
			     <option name="BLOCK_TERMINAL_DEFAULT_BACKGROUND" value="{Scheme.Background}"/>
			     <option name="BLOCK_TERMINAL_DEFAULT_FOREGROUND" value="{Scheme.Text}"/>
			     <option name="BLOCK_TERMINAL_ERROR_BLOCK_STROKE_COLOR" value="{Scheme.Red}"/>
			     <option name="BLOCK_TERMINAL_INACTIVE_SELECTED_BLOCK_BACKGROUND" value="{Scheme.HighlightLow}"/>
			     <option name="BLOCK_TERMINAL_INACTIVE_SELECTED_BLOCK_STROKE_COLOR" value="{Scheme.BackgroundOverlay}"/>
			     <option name="BLOCK_TERMINAL_PROMPT_SEPARATOR_COLOR" value="{Scheme.HighlightLow}"/>
			     <option name="BLOCK_TERMINAL_SELECTED_BLOCK_BACKGROUND" value="{Scheme.BackgroundEdges}"/>
			     <option name="BLOCK_TERMINAL_SELECTED_BLOCK_STROKE_COLOR" value="{Scheme.Blue}"/>
			     <option name="CARET_COLOR" value="{Scheme.Text}"/>
			     <option name="CARET_ROW_COLOR" value="{Scheme.Text}"/>
			     <option name="CONSOLE_BACKGROUND_KEY" value="{Scheme.Background}"/>
			     <option name="DELETED_LINES_COLOR" value="{Scheme.Magenta}"/>
			     <option name="DIFF_SEPARATORS_BACKGROUND" value="{Scheme.BackgroundOverlay}"/>
			     <option name="DOCUMENTATION_COLOR" value="{Scheme.Background}"/>
			     <option name="DOC_COMMENT_LINK" value="{Scheme.Blue}"/>
			     <option name="ERROR_HINT" value="{Scheme.Red}"/>
			     <option name="CARET_ROW_COLOR" value="{Scheme.BackgroundOverlay}" />
			     <option name="DOCUMENTATION_COLOR" value="" />
			     <option name="DOC_COMMENT_LINK" value="{Scheme.Plum}" />
			     <option name="EDITOR_GUTTER_BACKGROUND" value="" />
			     <option name="FILESTATUS_ADDED" value="{Scheme.Green}"/>
			     <option name="FILESTATUS_COPIED" value="{Scheme.Green}"/>
			     <option name="FILESTATUS_DELETED" value="{Scheme.Magenta}"/>
			     <option name="FILESTATUS_HIJACKED" value="{Scheme.Orange}"/>
			     <option name="FILESTATUS_IDEA_FILESTATUS_DELETED_FROM_FILE_SYSTEM" value="{Scheme.Magenta}"/>
			     <option name="FILESTATUS_IDEA_FILESTATUS_IGNORED" value="{Scheme.TextFaded}"/>
			     <option name="FILESTATUS_IDEA_FILESTATUS_MERGED_WITH_BOTH_CONFLICTS" value="{Scheme.Plum}"/>
			     <option name="FILESTATUS_IDEA_FILESTATUS_MERGED_WITH_CONFLICTS" value="{Scheme.Plum}"/>
			     <option name="FILESTATUS_IDEA_FILESTATUS_MERGED_WITH_PROPERTY_CONFLICTS" value="{Scheme.Plum}"/>
			     <option name="FILESTATUS_IDEA_SVN_FILESTATUS_EXTERNAL" value="{Scheme.Green}"/>
			     <option name="FILESTATUS_IGNORE.PROJECT_VIEW.IGNORED" value="{Scheme.TextFaded}"/>
			     <option name="FILESTATUS_MERGED" value="{Scheme.Purple}"/>
			     <option name="FILESTATUS_MODIFIED" value="{Scheme.Purple}"/>
			     <option name="FILESTATUS_NOT_CHANGED_IMMEDIATE" value="{Scheme.Blue}"/>
			     <option name="FILESTATUS_NOT_CHANGED_RECURSIVE" value="{Scheme.Blue}"/>
			     <option name="FILESTATUS_SUPPRESSED" value="{Scheme.TextFaded}"/>
			     <option name="FILESTATUS_SWITCHED" value="{Scheme.Plum}"/>
			     <option name="FILESTATUS_UNKNOWN" value="{Scheme.TextFaded}"/>
			     <option name="FILESTATUS_addedOutside" value="{Scheme.Green}"/>
			     <option name="FILESTATUS_changelistConflict" value="{Scheme.Plum}"/>
			     <option name="FILESTATUS_modifiedOutside" value="{Scheme.Purple}"/>
			     <option name="FOLDED_TEXT_BORDER_COLOR" value="" />
			     <option name="GUTTER_BACKGROUND" value="{Scheme.Background}"/>
			     <option name="HTML_TAG_TREE_LEVEL0" value="{Scheme.Magenta}"/>
			     <option name="HTML_TAG_TREE_LEVEL1" value="{Scheme.Plum}"/>
			     <option name="HTML_TAG_TREE_LEVEL2" value="{Scheme.Cyan}"/>
			     <option name="HTML_TAG_TREE_LEVEL3" value="{Scheme.Blue}"/>
			     <option name="HTML_TAG_TREE_LEVEL4" value="{Scheme.Purple}"/>
			     <option name="HTML_TAG_TREE_LEVEL5" value="{Scheme.Yellow}"/>
			     <option name="INDENT_GUIDE" value="{Scheme.BackgroundEdges}" />
			     <option name="INFORMATION_HINT" value="{Scheme.BackgroundEdges}"/>
			     <option name="INLINE_REFACTORING_SETTINGS_DEFAULT" value="{Scheme.TextFaded}" />
			     <option name="INLINE_REFACTORING_SETTINGS_FOCUSED" value="" />
			     <option name="INLINE_REFACTORING_SETTINGS_HOVERED" value="" />
			     <option name="LINE_NUMBERS_COLOR" value="{Scheme.TextFaded}" />
			     <option name="LINE_NUMBER_ON_CARET_ROW_COLOR" value="{Scheme.Text}" />
			     <option name="LOOKUP_COLOR" value="{Scheme.BackgroundEdges}"/>
			     <option name="MATCHED_BRACES_INDENT_GUIDE_COLOR" value="{Scheme.TextHidden}" />
			     <option name="METHOD_SEPARATORS_COLOR" value="" />
			     <option name="MODIFIED_LINES_COLOR" value="{Scheme.Plum}"/>
			     <option name="MODIFIED_TAB_ICON" value="{Scheme.Blue}"/>
			     <option name="NOTIFICATION_BACKGROUND" value="{Scheme.TextHidden}" />
			     <option name="PREVIEW_BACKGROUND" value="{Scheme.Background}" />
			     <option name="PROMOTION_PANE" value="{Scheme.BackgroundEdges}"/>
			     <option name="QUESTION_HINT" value="{Scheme.BackgroundEdges}"/>
			     <option name="RECENT_LOCATIONS_SELECTION" value="{Scheme.BackgroundEdges}"/>
			     <option name="RIGHT_MARGIN_COLOR" value="{Scheme.BackgroundOverlay}" />
			     <option name="SELECTED_INDENT_GUIDE" value="{Scheme.BackgroundOverlay}" />
			     <option name="SELECTED_TEARLINE_COLOR" value="{Scheme.TextHidden}" />
			     <option name="SELECTION_BACKGROUND" value="{Scheme.Highlight}" />
			     <option name="SELECTION_FOREGROUND" value="{Scheme.Text}" />
			     <option name="SEPARATOR_BELOW_COLOR" value=""/>
			     <option name="ScrollBar.thumbColor" value="{Scheme.TextHidden}" />
			     <option name="ScrollBar.thumbBorderColor" value="{Scheme.BackgroundEdges}"/>
			     <option name="ScrollBar.hoverThumbColor" value="{Scheme.TextHidden}" />
			     <option name="ScrollBar.hoverThumbBorderColor" value="{Scheme.HighlightLow}"/>
			     <option name="ScrollBar.Mac.thumbColor" value="{Scheme.BackgroundEdges}"/>
			     <option name="ScrollBar.Mac.thumbBorderColor" value="{Scheme.BackgroundEdges}"/>
			     <option name="ScrollBar.Mac.hoverThumbColor" value="{Scheme.HighlightLow}"/>
			     <option name="ScrollBar.Mac.hoverThumbBorderColor" value="{Scheme.HighlightLow}"/>
			     <option name="VCS_ANNOTATIONS_COLOR_1" value="{Scheme.Text}"/>
			     <option name="VCS_ANNOTATIONS_COLOR_2" value="{Scheme.Text}"/>
			     <option name="VCS_ANNOTATIONS_COLOR_3" value="{Scheme.Text}"/>
			     <option name="VCS_ANNOTATIONS_COLOR_4" value="{Scheme.Text}"/>
			     <option name="VCS_ANNOTATIONS_COLOR_5" value="{Scheme.Text}"/>
			     <option name="TEARLINE_COLOR" value="{Scheme.TextHidden}" />
			     <option name="VISUAL_INDENT_GUIDE" value="{Scheme.TextHidden}" />
			     <option name="WHITESPACES" value="{Scheme.BackgroundEdges}" />
			     <option name="WHITESPACES_MODIFIED_LINES_COLOR" value="{Scheme.BackgroundEdges}"/>
			   </colors>
			   <attributes>
			     <option name="ABSTRACT_METHOD_ATTRIBUTES">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Blue}"/>
			       </value>
			     </option>
			     <option name="ANGLE_BRACKETS_RAINBOW_COLOR0">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Magenta}"/>
			       </value>
			     </option>
			     <option name="ANGLE_BRACKETS_RAINBOW_COLOR1">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Plum}"/>
			       </value>
			     </option>
			     <option name="ANGLE_BRACKETS_RAINBOW_COLOR2">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Cyan}"/>
			       </value>
			     </option>
			     <option name="ANGLE_BRACKETS_RAINBOW_COLOR3">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Blue}"/>
			       </value>
			     </option>
			     <option name="ANGLE_BRACKETS_RAINBOW_COLOR4">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Purple}"/>
			       </value>
			     </option>
			     <option name="BAD_CHARACTER">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Red}" />
			         <option name="ERROR_STRIPE_COLOR" value="{Scheme.Red}" />
			         <option name="EFFECT_TYPE" value="{FontItalic}" />
			       </value>
			     </option>
			     <option name="BASH.CONDITIONAL">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Green}"/>
			       </value>
			     </option>
			     <option name="BASH.EXTERNAL_COMMAND" baseAttributes="DEFAULT_IDENTIFIER"/>
			     <option name="BASH.FUNCTION_CALL">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Cyan}"/>
			       </value>
			     </option>
			     <option name="BASH.HERE_DOC_END" baseAttributes="DEFAULT_KEYWORD"/>
			     <option name="BASH.HERE_DOC_START" baseAttributes="DEFAULT_KEYWORD"/>
			     <option name="BASH.SHEBANG" baseAttributes="BASH.LINE_COMMENT"/>
			     <option name="BLADE_DIRECTIVE">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Purple}"/>
			       </value>
			     </option>
			     <option name="TERMINAL_BACKGROUND" value="{Scheme.Background}"/>
			     <option name="BLOCK_TERMINAL_COMMAND">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Blue}"/>
			         <option name="FONT_TYPE" value="{FontBold}"/>
			       </value>
			     </option>
			     <option name="BLOCK_TERMINAL_CURRENT_SEARCH_ENTRY">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Text}"/>
			         <option name="BACKGROUND" value="{Scheme.Highlight}"/>
			       </value>
			     </option>
			     <option name="BLOCK_TERMINAL_SEARCH_ENTRY">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Text}"/>
			         <option name="BACKGROUND" value="{Scheme.Highlight}"/>
			       </value>
			     </option>
			     <option name="BLOCK_TERMINAL_BLACK">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.BackgroundEdges}"/>
			         <option name="BACKGROUND" value="{Scheme.BackgroundEdges}"/>
			       </value>
			     </option>
			     <option name="BLOCK_TERMINAL_BLUE">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Blue}"/>
			         <option name="BACKGROUND" value="{Scheme.Blue}"/>
			       </value>
			     </option>
			     <option name="BLOCK_TERMINAL_CYAN">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Green}"/>
			         <option name="BACKGROUND" value="{Scheme.Green}"/>
			       </value>
			     </option>
			     <option name="BLOCK_TERMINAL_GREEN">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Green}"/>
			         <option name="BACKGROUND" value="{Scheme.Green}"/>
			       </value>
			     </option>
			     <option name="BLOCK_TERMINAL_MAGENTA">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Magenta}"/>
			         <option name="BACKGROUND" value="{Scheme.Magenta}"/>
			       </value>
			     </option>
			     <option name="BLOCK_TERMINAL_RED">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Red}"/>
			         <option name="BACKGROUND" value="{Scheme.Red}"/>
			       </value>
			     </option>
			     <option name="BLOCK_TERMINAL_WHITE">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.TextFaded}"/>
			         <option name="BACKGROUND" value="{Scheme.TextFaded}"/>
			       </value>
			     </option>
			     <option name="BLOCK_TERMINAL_YELLOW">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Orange}"/>
			         <option name="BACKGROUND" value="{Scheme.Orange}"/>
			       </value>
			     </option>
			     <option name="BLOCK_TERMINAL_BLACK_BRIGHT">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Text}"/>
			         <option name="BACKGROUND" value="{Scheme.Text}"/>
			       </value>
			     </option>
			     <option name="BLOCK_TERMINAL_BLUE_BRIGHT">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Blue}"/>
			         <option name="BACKGROUND" value="{Scheme.Blue}"/>
			       </value>
			     </option>
			     <option name="BLOCK_TERMINAL_CYAN_BRIGHT">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Green}"/>
			         <option name="BACKGROUND" value="{Scheme.Green}"/>
			       </value>
			     </option>
			     <option name="BLOCK_TERMINAL_GREEN_BRIGHT">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Green}"/>
			         <option name="BACKGROUND" value="{Scheme.Green}"/>
			       </value>
			     </option>
			     <option name="BLOCK_TERMINAL_MAGENTA_BRIGHT">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Magenta}"/>
			         <option name="BACKGROUND" value="{Scheme.Magenta}"/>
			       </value>
			     </option>
			     <option name="BLOCK_TERMINAL_RED_BRIGHT">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Red}"/>
			         <option name="BACKGROUND" value="{Scheme.Red}"/>
			       </value>
			     </option>
			     <option name="BLOCK_TERMINAL_WHITE_BRIGHT">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Text}"/>
			         <option name="BACKGROUND" value="{Scheme.Text}"/>
			       </value>
			     </option>
			     <option name="BLOCK_TERMINAL_YELLOW_BRIGHT">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Orange}"/>
			         <option name="BACKGROUND" value="{Scheme.Orange}"/>
			       </value>
			     </option>
			     <option name="BOOKMARKS_ATTRIBUTES">
			       <value/>
			     </option>
			     <option name="BREADCRUMBS_CURRENT">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Text}"/>
			         <option name="BACKGROUND" value="{Scheme.BackgroundEdges}"/>
			       </value>
			     </option>
			     <option name="BREADCRUMBS_DEFAULT">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Text}"/>
			       </value>
			     </option>
			     <option name="BREADCRUMBS_HOVERED">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Text}"/>
			         <option name="BACKGROUND" value="{Scheme.BackgroundEdges}"/>
			       </value>
			     </option>
			     <option name="BREADCRUMBS_INACTIVE">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Text}"/>
			       </value>
			     </option>
			     <option name="BREAKPOINT_ATTRIBUTES">
			       <value/>
			     </option>
			     <option name="BUILDOUT.KEY">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Purple}"/>
			       </value>
			     </option>
			     <option name="BUILDOUT.KEY_VALUE_SEPARATOR">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Text}"/>
			       </value>
			     </option>
			     <option name="BUILDOUT.LINE_COMMENT" baseAttributes="DEFAULT_LINE_COMMENT"/>
			     <option name="BUILDOUT.SECTION_NAME">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Plum}"/>
			       </value>
			     </option>
			     <option name="BUILDOUT.VALUE">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Green}"/>
			       </value>
			     </option>
			     <option name="CLASS_REFERENCE">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Orange}"/>
			       </value>
			     </option>
			     <option name="CODE_LENS_BORDER_COLOR">
			       <value>
			         <option name="BACKGROUND" value="{Scheme.BackgroundEdges}"/>
			         <option name="EFFECT_COLOR" value="{Scheme.Plum}"/>
			       </value>
			     </option>
			     <option name="CODE_VISION_DEFAULT">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.TextFaded}" />
			       </value>
			     </option>
			     <option name="CODE_VISION_HOVERED">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Blue}" />
			       </value>
			     </option>
			     <option name="COFFEESCRIPT.CLASS_NAME">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Plum}"/>
			       </value>
			     </option>
			     <option name="CONDITIONALLY_NOT_COMPILED">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.BackgroundEdges}"/>
			       </value>
			     </option>
			     <!-- Terminal colors -->
			     <!-- ANSI Color 00 -->
			     <option name="CONSOLE_BLACK_OUTPUT">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.BackgroundEdges}"/>
			       </value>
			     </option>
			     <!-- ANSI Color 01 -->
			     <option name="CONSOLE_RED_OUTPUT">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Red}"/>
			       </value>
			     </option>
			     <!-- ANSI Color 02 -->
			     <option name="CONSOLE_GREEN_OUTPUT">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Green}"/>
			       </value>
			     </option>
			     <!-- ANSI Color 03 -->
			     <option name="CONSOLE_YELLOW_OUTPUT">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Orange}"/>
			       </value>
			     </option>
			     <!-- ANSI Color 04 -->
			     <option name="CONSOLE_BLUE_OUTPUT">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Blue}"/>
			       </value>
			     </option>
			     <!-- ANSI Color 05 -->
			     <option name="CONSOLE_MAGENTA_OUTPUT">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Magenta}"/>
			       </value>
			     </option>
			     <!-- ANSI Color 06 -->
			     <option name="CONSOLE_CYAN_OUTPUT">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Green}"/>
			       </value>
			     </option>
			     <!-- ANSI Color 07 -->
			     <option name="CONSOLE_GRAY_OUTPUT">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.TextFaded}"/>
			       </value>
			     </option>
			     <!-- ANSI Color 08 -->
			     <option name="CONSOLE_DARKGRAY_OUTPUT">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Text}"/>
			       </value>
			     </option>
			     <!-- ANSI Color 09 -->
			     <option name="CONSOLE_RED_BRIGHT_OUTPUT" baseAttributes="CONSOLE_RED_OUTPUT"/>
			     <!-- ANSI Color 10 -->
			     <option name="CONSOLE_GREEN_BRIGHT_OUTPUT" baseAttributes="CONSOLE_GREEN_OUTPUT"/>
			     <!-- ANSI Color 11 -->
			     <option name="CONSOLE_YELLOW_BRIGHT_OUTPUT" baseAttributes="CONSOLE_YELLOW_OUTPUT"/>
			     <!-- ANSI Color 12 -->
			     <option name="CONSOLE_BLUE_BRIGHT_OUTPUT" baseAttributes="CONSOLE_BLUE_OUTPUT"/>
			     <!-- ANSI Color 13 -->
			     <option name="CONSOLE_MAGENTA_BRIGHT_OUTPUT" baseAttributes="CONSOLE_MAGENTA_OUTPUT"/>
			     <!-- ANSI Color 14 -->
			     <option name="CONSOLE_CYAN_BRIGHT_OUTPUT" baseAttributes="CONSOLE_CYAN_OUTPUT"/>
			     <!-- ANSI Color 15 -->
			     <option name="CONSOLE_NORMAL_OUTPUT">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Text}"/>
			       </value>
			     </option>
			     <!-- other terminal colors -->
			     <option name="CONSOLE_ERROR_OUTPUT">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Red}"/>
			       </value>
			     </option>
			     <option name="CONSOLE_RANGE_TO_EXECUTE">
			       <value>
			         <option name="EFFECT_COLOR" value="{Scheme.Purple}"/>
			       </value>
			     </option>
			     <option name="CONSOLE_SYSTEM_OUTPUT">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Red}"/>
			       </value>
			     </option>
			     <option name="CONSOLE_USER_INPUT">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Green}"/>
			       </value>
			     </option>
			     <option name="CONSOLE_WHITE_OUTPUT">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Text}"/>
			       </value>
			     </option>
			     <option name="CONSTRUCTOR_CALL_ATTRIBUTES">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Plum}"/>
			       </value>
			     </option>
			     <option name="CONSTRUCTOR_DECLARATION_ATTRIBUTES">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Plum}"/>
			       </value>
			     </option>
			     <option name="CSS.BRACKETS">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Red}"/>
			       </value>
			     </option>
			     <option name="CSS.CLASS_NAME">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Green}"/>
			       </value>
			     </option>
			     <option name="CSS.COLOR" baseAttributes="CSS.IDENT"/>
			     <option name="CSS.FUNCTION">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Cyan}"/>
			       </value>
			     </option>
			     <option name="CSS.HASH">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Blue}"/>
			       </value>
			     </option>
			     <option name="CSS.IMPORTANT">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Plum}"/>
			       </value>
			     </option>
			     <option name="CSS.KEYWORD">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Red}"/>
			       </value>
			     </option>
			     <option name="CSS.OPERATORS">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Text}"/>
			       </value>
			     </option>
			     <option name="CSS.PROPERTY_NAME">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Blue}"/>
			       </value>
			     </option>
			     <option name="CSS.PROPERTY_VALUE">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Orange}"/>
			       </value>
			     </option>
			     <option name="CSS.PSEUDO">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Green}"/>
			       </value>
			     </option>
			     <option name="CSS.TAG_NAME">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Orange}"/>
			       </value>
			     </option>
			     <option name="CSS.URL">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Green}"/>
			       </value>
			     </option>
			     <option name="CSV_PLUGIN_COLUMN_COLORING_ATTRIBUTE_1">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Red}"/>
			       </value>
			     </option>
			     <option name="CSV_PLUGIN_COLUMN_COLORING_ATTRIBUTE_2">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Cyan}"/>
			       </value>
			     </option>
			     <option name="CSV_PLUGIN_COLUMN_COLORING_ATTRIBUTE_3">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Green}"/>
			       </value>
			     </option>
			     <option name="CSV_PLUGIN_COLUMN_COLORING_ATTRIBUTE_4">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Blue}"/>
			       </value>
			     </option>
			     <option name="CSV_PLUGIN_COLUMN_COLORING_ATTRIBUTE_5">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Purple}"/>
			       </value>
			     </option>
			     <option name="CSV_PLUGIN_COLUMN_COLORING_ATTRIBUTE_6">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Green}"/>
			       </value>
			     </option>
			     <option name="CSV_PLUGIN_COLUMN_COLORING_ATTRIBUTE_7">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Orange}"/>
			       </value>
			     </option>
			     <option name="CSV_PLUGIN_COLUMN_COLORING_ATTRIBUTE_8">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Red}"/>
			       </value>
			     </option>
			     <option name="CSV_PLUGIN_COLUMN_COLORING_ATTRIBUTE_9">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Plum}"/>
			       </value>
			     </option>
			     <option name="CTRL_CLICKABLE">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Blue}"/>
			         <option name="EFFECT_COLOR" value="{Scheme.Blue}"/>
			         <option name="EFFECT_TYPE" value="1"/>
			       </value>
			     </option>

			     <option name="CTRL_CLICKABLE">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Purple}" />
			         <option name="EFFECT_COLOR" value="{Scheme.Purple}" />
			         <option name="EFFECT_TYPE" value="1" />
			       </value>
			     </option>
			     <option name="CUSTOM_KEYWORD1_ATTRIBUTES" baseAttributes="DEFAULT_KEYWORD"/>
			     <option name="CUSTOM_KEYWORD2_ATTRIBUTES">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Plum}"/>
			       </value>
			     </option>
			     <option name="CUSTOM_KEYWORD3_ATTRIBUTES">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Orange}"/>
			       </value>
			     </option>
			     <option name="CUSTOM_KEYWORD4_ATTRIBUTES">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Cyan}"/>
			       </value>
			     </option>
			     <option name="CUSTOM_STRING_ATTRIBUTES" baseAttributes="DEFAULT_STRING"/>
			     <option name="CUSTOM_VALID_STRING_ESCAPE_ATTRIBUTES" baseAttributes="DEFAULT_VALID_STRING_ESCAPE"/>
			     <option name="Class" baseAttributes="CLASS_NAME_ATTRIBUTES"/>
			     <option name="Clojure Atom">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Purple}"/>
			       </value>
			     </option>
			     <option name="Clojure Character">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Green}"/>
			       </value>
			     </option>
			     <option name="Clojure Keyword">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Text}"/>
			       </value>
			     </option>
			     <option name="Clojure Line comment" baseAttributes="DEFAULT_LINE_COMMENT"/>
			     <option name="Clojure Literal">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Text}"/>
			       </value>
			     </option>
			     <option name="Clojure Numbers">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Plum}"/>
			       </value>
			     </option>
			     <option name="Clojure Strings">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Green}"/>
			       </value>
			     </option>
			     <option name="CodeWithMe.USER_1_MARKER">
			       <value>
			         <option name="BACKGROUND" value="{Scheme.Red}"/>
			       </value>
			     </option>
			     <option name="CodeWithMe.USER_1_SELECTION">
			       <value>
			         <option name="BACKGROUND" value="{Scheme.Red}"/>
			       </value>
			     </option>
			     <option name="CodeWithMe.USER_2_MARKER">
			       <value>
			         <option name="BACKGROUND" value="{Scheme.Plum}"/>
			       </value>
			     </option>
			     <option name="CodeWithMe.USER_2_SELECTION">
			       <value>
			         <option name="BACKGROUND" value="{Scheme.Orange}"/>
			       </value>
			     </option>
			     <option name="CodeWithMe.USER_3_MARKER">
			       <value>
			         <option name="BACKGROUND" value="{Scheme.Orange}"/>
			       </value>
			     </option>
			     <option name="CodeWithMe.USER_3_SELECTION">
			       <value>
			         <option name="BACKGROUND" value="{Scheme.Yellow}"/>
			       </value>
			     </option>
			     <option name="CodeWithMe.USER_4_MARKER">
			       <value>
			         <option name="BACKGROUND" value="{Scheme.Green}"/>
			       </value>
			     </option>
			     <option name="CodeWithMe.USER_4_SELECTION">
			       <value>
			         <option name="BACKGROUND" value="{Scheme.Green}"/>
			       </value>
			     </option>
			     <option name="CodeWithMe.USER_5_MARKER">
			       <value>
			         <option name="BACKGROUND" value="{Scheme.Blue}"/>
			       </value>
			     </option>
			     <option name="CodeWithMe.USER_5_SELECTION">
			       <value>
			         <option name="BACKGROUND" value="{Scheme.Blue}"/>
			       </value>
			     </option>
			     <option name="CodeWithMe.USER_6_MARKER">
			       <value>
			         <option name="BACKGROUND" value="{Scheme.Purple}"/>
			       </value>
			     </option>
			     <option name="CodeWithMe.USER_6_SELECTION">
			       <value>
			         <option name="BACKGROUND" value="{Scheme.Purple}"/>
			       </value>
			     </option>
			     <option name="ComposableCallTextAttributes" baseAttributes="DEFAULT_FUNCTION_CALL"/>
			     <option name="DART_COLON">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Text}"/>
			       </value>
			     </option>
			     <option name="DEBUGGER_SMART_STEP_INTO_SELECTION" baseAttributes="LIVE_TEMPLATE_ATTRIBUTES"/>
			     <option name="DEBUGGER_SMART_STEP_INTO_TARGET" baseAttributes="SEARCH_RESULT_ATTRIBUTES"/>
			     <option name="DEFAULT_ATTRIBUTE">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Text}" />
			       </value>
			     </option>
			     <option name="DEFAULT_BLOCK_COMMENT">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.TextFaded}" />
			         <option name="FONT_TYPE" value="{FontItalic}" />
			       </value>
			     </option>
			     <option name="DEFAULT_BRACES">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Purple}" />
			       </value>
			     </option>
			     <option name="DEFAULT_BRACKETS">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Purple}" />
			       </value>
			     </option>
			     <option name="DEFAULT_CLASS_NAME">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Magenta}" />
			       </value>
			     </option>
			     <option name="DEFAULT_CLASS_REFERENCE">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Green}" />
			       </value>
			     </option>
			     <option name="DEFAULT_COMMA">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Plum}" />
			       </value>
			     </option>
			     <option name="DEFAULT_CONSTANT">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Plum}" />
			       </value>
			     </option>
			     <option name="DEFAULT_DOC_COMMENT">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.TextFaded}" />
			         <option name="FONT_TYPE" value="{FontItalic}" />
			       </value>
			     </option>
			     <option name="DEFAULT_DOC_COMMENT_TAG">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Green}" />
			         <option name="EFFECT_TYPE" value="1" />
			       </value>
			     </option>
			     <option name="DEFAULT_DOC_COMMENT_TAG_VALUE">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Text}" />
			       </value>
			     </option>
			     <option name="DEFAULT_DOC_MARKUP">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Plum}" />
			       </value>
			     </option>
			     <option name="DEFAULT_DOT">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Plum}" />
			       </value>
			     </option>
			     <option name="DEFAULT_ENTITY">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Text}" />
			       </value>
			     </option>
			     <option name="DEFAULT_FUNCTION_CALL">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Purple}" />
			       </value>
			     </option>
			     <option name="DEFAULT_FUNCTION_DECLARATION">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Purple}" />
			       </value>
			     </option>
			     <option name="DEFAULT_GLOBAL_VARIABLE">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Text}" />
			       </value>
			     </option>
			     <option name="DEFAULT_HIGHLIGHTED_REFERENCE">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Green}" />
			       </value>
			     </option>
			     <option name="DEFAULT_IDENTIFIER">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.TextFaded}" />
			       </value>
			     </option>
			     <option name="DEFAULT_INSTANCE_FIELD">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Blue}" />
			       </value>
			     </option>
			     <option name="DEFAULT_INTERFACE_NAME">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Magenta}" />
			       </value>
			     </option>
			     <option name="DEFAULT_INVALID_STRING_ESCAPE">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Red}" />
			         <option name="ERROR_STRIPE_COLOR" value="{Scheme.Red}" />
			         <option name="EFFECT_TYPE" value="{FontItalic}" />
			       </value>
			     </option>
			     <option name="DEFAULT_KEYWORD">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Plum}" />
			         <option name="BACKGROUND" value="{Scheme.Background}" />
			       </value>
			     </option>
			     <option name="DEFAULT_LABEL">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Text}" />
			       </value>
			     </option>
			     <option name="DEFAULT_LINE_COMMENT">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.TextFaded}" />
			         <option name="FONT_TYPE" value="{FontItalic}" />
			       </value>
			     </option>
			     <option name="DEFAULT_LOCAL_VARIABLE">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Text}" />
			       </value>
			     </option>
			     <option name="DEFAULT_METADATA">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Yellow}" />
			       </value>
			     </option>
			     <option name="DEFAULT_NUMBER">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Yellow}" />
			       </value>
			     </option>
			     <option name="DEFAULT_OPERATION_SIGN">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Blue}" />
			       </value>
			     </option>
			     <option name="DEFAULT_PARAMETER">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Text}" />
			       </value>
			     </option>
			     <option name="DEFAULT_PARENTHS">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Blue}" />
			       </value>
			     </option>
			     <option name="DEFAULT_PREDEFINED_SYMBOL">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.TextFaded}" />
			       </value>
			     </option>
			     <option name="DEFAULT_REASSIGNED_LOCAL_VARIABLE">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Text}" />
			         <option name="EFFECT_COLOR" value="{Scheme.Text}" />
			         <option name="EFFECT_TYPE" value="1" />
			       </value>
			     </option>
			     <option name="DEFAULT_REASSIGNED_PARAMETER">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Text}" />
			         <option name="EFFECT_COLOR" value="{Scheme.Text}" />
			         <option name="EFFECT_TYPE" value="1" />
			       </value>
			     </option>
			     <option name="DEFAULT_SEMICOLON">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Purple}" />
			       </value>
			     </option>
			     <option name="DEFAULT_STATIC_FIELD">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Blue}" />
			       </value>
			     </option>
			     <option name="DEFAULT_STATIC_METHOD">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Purple}" />
			       </value>
			     </option>
			     <option name="DEFAULT_STRING">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Cyan}" />
			       </value>
			     </option>
			     <option name="DEFAULT_TAG">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Text}" />
			         <option name="EFFECT_TYPE" value="5" />
			       </value>
			     </option>
			     <option name="DEFAULT_TEMPLATE_LANGUAGE_COLOR" baseAttributes="TEXT" />
			     <option name="DEFAULT_VALID_STRING_ESCAPE">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Plum}" />
			       </value>
			     </option>
			     <option name="DELETED_TEXT_ATTRIBUTES">
			       <value>
			         <option name="BACKGROUND" value="{Scheme.Background}" />
			         <option name="EFFECT_COLOR" value="{Scheme.TextFaded}" />
			         <option name="EFFECT_TYPE" value="3" />
			       </value>
			     </option>
			     <option name="DEPRECATED_ATTRIBUTES">
			       <value>
			         <option name="EFFECT_COLOR" value="{Scheme.Text}" />
			         <option name="EFFECT_TYPE" value="3" />
			       </value>
			     </option>
			     <option name="DIFF_CONFLICT">
			       <value>
			         <option name="BACKGROUND" value="{Scheme.Plum}"/>
			         <option name="ERROR_STRIPE_COLOR" value="{Scheme.Plum}"/>
			       </value>
			     </option>
			     <option name="DIFF_DELETED">
			       <value>
			         <option name="BACKGROUND" value="{Scheme.Magenta}"/>
			         <option name="ERROR_STRIPE_COLOR" value="{Scheme.Magenta}"/>
			       </value>
			     </option>
			     <option name="DIFF_INSERTED">
			       <value>
			         <option name="BACKGROUND" value="{Scheme.Green}"/>
			         <option name="ERROR_STRIPE_COLOR" value="{Scheme.Green}"/>
			       </value>
			     </option>
			     <option name="DIFF_MODIFIED">
			       <value>
			         <option name="BACKGROUND" value="{Scheme.Purple}"/>
			         <option name="ERROR_STRIPE_COLOR" value="{Scheme.Purple}"/>
			       </value>
			     </option>
			     <option name="DUPLICATE_FROM_SERVER">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Background}" />
			         <option name="BACKGROUND" value="{Scheme.Orange}" />
			       </value>
			     </option>
			     <option name="ERRORS_ATTRIBUTES">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Red}" />
			         <option name="ERROR_STRIPE_COLOR" value="{Scheme.Red}" />
			         <option name="EFFECT_TYPE" value="{FontItalic}" />
			       </value>
			     </option>
			     <option name="EXECUTIONPOINT_ATTRIBUTES">
			       <value>
			         <option name="BACKGROUND" value="{Scheme.Background}"/>
			       </value>
			     </option>
			     <option name="FOLDED_TEXT_ATTRIBUTES">
			       <value />
			     </option>
			     <option name="FOLLOWED_HYPERLINK_ATTRIBUTES">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Purple}" />
			         <option name="EFFECT_COLOR" value="{Scheme.Purple}" />
			         <option name="EFFECT_TYPE" value="1" />
			       </value>
			     </option>
			     <option name="GENERIC_SERVER_ERROR_OR_WARNING">
			       <value>
			         <option name="EFFECT_COLOR" value="{Scheme.Red}" />
			         <option name="ERROR_STRIPE_COLOR" value="{Scheme.Red}" />
			         <option name="EFFECT_TYPE" value="1" />
			       </value>
			     </option>
			     <option name="FOLLOWED_HYPERLINK_ATTRIBUTES">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Plum}"/>
			         <option name="EFFECT_COLOR" value="{Scheme.Plum}"/>
			         <option name="EFFECT_TYPE" value="1"/>
			       </value>
			     </option>
			     <option name="HYPERLINK_ATTRIBUTES">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Plum}" />
			         <option name="EFFECT_COLOR" value="{Scheme.Plum}" />
			         <option name="EFFECT_TYPE" value="1" />
			       </value>
			     </option>
			     <option name="IDENTIFIER_UNDER_CARET_ATTRIBUTES">
			       <value>
			         <option name="BACKGROUND" value="{Scheme.BackgroundOverlay}" />
			         <option name="FONT_TYPE" value="{FontBold}" />
			         <option name="EFFECT_TYPE" value="1" />
			       </value>
			     </option>
			     <option name="IMPLICIT_ANONYMOUS_CLASS_PARAMETER_ATTRIBUTES">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Red}"/>
			       </value>
			     </option>
			     <option name="INACTIVE_HYPERLINK_ATTRIBUTES">
			       <value>
			         <option name="EFFECT_COLOR" value="{Scheme.TextFaded}" />
			         <option name="EFFECT_TYPE" value="1" />
			       </value>
			     </option>
			     <option name="INDENT_GUIDES_RAINBOW_COLOR0">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Magenta}"/>
			       </value>
			     </option>
			     <option name="INDENT_GUIDES_RAINBOW_COLOR1">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Plum}"/>
			       </value>
			     </option>
			     <option name="INDENT_GUIDES_RAINBOW_COLOR2">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Cyan}"/>
			       </value>
			     </option>
			     <option name="INDENT_GUIDES_RAINBOW_COLOR3">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Blue}"/>
			       </value>
			     </option>
			     <option name="INDENT_GUIDES_RAINBOW_COLOR4">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Purple}"/>
			       </value>
			     </option>
			     <option name="INFO_ATTRIBUTES">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Yellow}" />
			         <option name="ERROR_STRIPE_COLOR" value="{Scheme.Yellow}" />
			         <option name="EFFECT_TYPE" value="{FontItalic}" />
			       </value>
			     </option>
			     <option name="INLAY_DEFAULT">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Text}" />
			       </value>
			     </option>
			     <option name="INLAY_TEXT_WITHOUT_BACKGROUND">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Text}" />
			       </value>
			     </option>
			     <option name="INLINE_PARAMETER_HINT">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.TextFaded}" />
			         <option name="BACKGROUND" value="{Scheme.Background}" />
			       </value>
			     </option>
			     <option name="INLINE_PARAMETER_HINT_CURRENT">
			       <value />
			     </option>
			     <option name="INLINE_PARAMETER_HINT_HIGHLIGHTED">
			       <value />
			     </option>
			     <option name="INLINE_STACK_FRAMES">
			       <value>
			         <option name="BACKGROUND" value="{Scheme.HighlightLow}"/>
			       </value>
			     </option>
			     <option name="INSTANCE_FIELD_ATTRIBUTES" baseAttributes="DEFAULT_INSTANCE_FIELD"/>
			     <option name="io.github.intellij.dlanguage.sdlang.TAG_IDENTIFIER">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Blue}"/>
			       </value>
			     </option>
			     <option name="LOGCAT_ASSERT_OUTPUT">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Red}"/>
			         <option name="EFFECT_COLOR" value="{Scheme.Red}"/>
			         <option name="EFFECT_TYPE" value="1"/>
			       </value>
			     </option>
			     <option name="LOGCAT_DEBUG_OUTPUT">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Blue}"/>
			       </value>
			     </option>
			     <option name="LOGCAT_FILTER_KEY">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Blue}"/>
			       </value>
			     </option>
			     <option name="LOGCAT_FILTER_KVALUE">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Text}"/>
			       </value>
			     </option>
			     <option name="LOGCAT_FILTER_REGEX_KVALUE">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Magenta}"/>
			       </value>
			     </option>
			     <option name="LOGCAT_FILTER_STRING_KVALUE">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Green}"/>
			       </value>
			     </option>
			     <option name="LOGCAT_INFO_OUTPUT">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Yellow}"/>
			       </value>
			     </option>
			     <option name="LOGCAT_VERBOSE_OUTPUT">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Cyan}"/>
			       </value>
			     </option>
			     <option name="LOGCAT_WARNING_OUTPUT">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Orange}"/>
			       </value>
			     </option>
			     <option name="LOG_DEBUG_OUTPUT">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Yellow}"/>
			       </value>
			     </option>
			     <option name="LOG_ERROR_OUTPUT">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Red}"/>
			       </value>
			     </option>
			     <option name="LOG_EXPIRED_ENTRY">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.HighlightLow}"/>
			       </value>
			     </option>
			     <option name="LOG_INFO_OUTPUT">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Green}"/>
			       </value>
			     </option>
			     <option name="LOG_VERBOSE_OUTPUT">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Cyan}"/>
			       </value>
			     </option>
			     <option name="LOG_WARNING_OUTPUT">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Orange}"/>
			       </value>
			     </option>
			     <option name="LUA_REGION_DESC">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Purple}"/>
			       </value>
			     </option>
			     <option name="MARKED_FOR_REMOVAL_ATTRIBUTES">
			       <value>
			         <option name="EFFECT_COLOR" value="{Scheme.Red}" />
			         <option name="EFFECT_TYPE" value="3" />
			       </value>
			     </option>
			     <option name="MARKDOWN_BLOCK_QUOTE_MARKER">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Green}"/>
			       </value>
			     </option>
			     <option name="MARKDOWN_BOLD">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Red}"/>
			         <option name="FONT_TYPE" value="{FontBold}"/>
			       </value>
			     </option>
			     <option name="MARKDOWN_BOLD_MARKER">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.BackgroundOverlay}"/>
			         <option name="FONT_TYPE" value="{FontBold}"/>
			       </value>
			     </option>
			     <option name="MARKDOWN_CODE_FENCE">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Text}"/>
			       </value>
			     </option>
			     <option name="MARKDOWN_CODE_SPAN">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Green}"/>
			       </value>
			     </option>
			     <option name="MARKDOWN_CODE_SPAN_MARKER">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Red}"/>
			       </value>
			     </option>
			     <option name="MARKDOWN_HEADER_LEVEL_1">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Red}"/>
			       </value>
			     </option>
			     <option name="MARKDOWN_HEADER_LEVEL_2">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Plum}"/>
			       </value>
			     </option>
			     <option name="MARKDOWN_HEADER_LEVEL_3">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Orange}"/>
			       </value>
			     </option>
			     <option name="MARKDOWN_HEADER_LEVEL_4">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Green}"/>
			       </value>
			     </option>
			     <option name="MARKDOWN_HEADER_LEVEL_5">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Blue}"/>
			       </value>
			     </option>
			     <option name="MARKDOWN_HEADER_LEVEL_6">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Plum}"/>
			       </value>
			     </option>
			     <option name="MARKDOWN_HRULE">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Green}"/>
			       </value>
			     </option>
			     <option name="MARKDOWN_HTML_BLOCK">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Text}"/>
			       </value>
			     </option>
			     <option name="MARKDOWN_ITALIC">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Red}"/>
			       </value>
			     </option>
			     <option name="MARKDOWN_ITALIC_MARKER">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.BackgroundOverlay}"/>
			         <option name="FONT_TYPE" value="{FontBold}"/>
			       </value>
			     </option>
			     <option name="MARKDOWN_LINK_DESTINATION">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Blue}"/>
			       </value>
			     </option>
			     <option name="MARKDOWN_LINK_LABEL">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Plum}"/>
			       </value>
			     </option>
			     <option name="MARKDOWN_LINK_TEXT">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Plum}"/>
			         <option name="EFFECT_TYPE" value="1"/>
			       </value>
			     </option>
			     <option name="MARKDOWN_LINK_TITLE">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Green}"/>
			       </value>
			     </option>
			     <option name="MARKDOWN_LIST_ITEM">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Text}"/>
			       </value>
			     </option>
			     <option name="MARKDOWN_LIST_MARKER">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Green}"/>
			       </value>
			     </option>
			     <option name="MARKDOWN_ORDERED_LIST">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Text}"/>
			       </value>
			     </option>
			     <option name="MARKDOWN_TABLE_SEPARATOR">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.BackgroundEdges}"/>
			       </value>
			     </option>
			     <option name="MARKDOWN_UNORDERED_LIST">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Text}"/>
			       </value>
			     </option>
			     <option name="MARKED_FOR_REMOVAL_ATTRIBUTES">
			       <value>
			         <option name="EFFECT_COLOR" value="{Scheme.Red}"/>
			         <option name="EFFECT_TYPE" value="3"/>
			       </value>
			     </option>
			     <option name="MATCHED_BRACE_ATTRIBUTES">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Blue}" />
			         <option name="FONT_TYPE" value="{FontBold}" />
			         <option name="EFFECT_COLOR" value="{Scheme.Blue}" />
			         <option name="EFFECT_TYPE" value="4" />
			       </value>
			     </option>
			     <option name="NOT_USED_ELEMENT_ATTRIBUTES">
			       <value>
			         <option name="EFFECT_COLOR" value="{Scheme.TextFaded}" />
			         <option name="EFFECT_TYPE" value="1" />
			       </value>
			     </option>
			     <option name="ReSharper.ASP_NET_RUN_AT_ATTRIBUTE">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Plum}"/>
			       </value>
			     </option>
			     <option name="ReSharper.BRACE_OUTLINE">
			       <value>
			         <option name="EFFECT_COLOR" value="{Scheme.Text}"/>
			       </value>
			     </option>
			     <option name="ReSharper.BUILTIN_TYPE_KEYWORD">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Plum}" />
			       </value>
			     </option>
			     <option name="ReSharper.CONTROL_FLOW_KEYWORD">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Plum}" />
			       </value>
			     </option>
			     <option name="ReSharper.CONTROL_TRANSFER_KEYWORD">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Plum}" />
			       </value>
			     </option>
			     <option name="ReSharper.CSHARP_TYPE_PARAMETER_IDENTIFIER">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Green}" />
			       </value>
			     </option>
			     <option name="ReSharper.FORMAT_STRING_ITEM">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Text}" />
			       </value>
			     </option>
			     <option name="ReSharper.FORMAT_STRING_ITEM_2">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Text}" />
			       </value>
			     </option>
			     <option name="ReSharper.HINT">
			       <value>
			         <option name="EFFECT_COLOR" value="{Scheme.TextFaded}" />
			         <option name="ERROR_STRIPE_COLOR" value="{Scheme.TextFaded}" />
			         <option name="EFFECT_TYPE" value="5" />
			       </value>
			     </option>
			     <option name="ReSharper.MATCHED_FORMAT_STRING_ITEM">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Text}" />
			       </value>
			     </option>
			     <option name="ReSharper.NAMESPACE_IDENTIFIER">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Text}" />
			       </value>
			     </option>
			     <option name="ReSharper.OPERATOR_IDENTIFIER">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Blue}" />
			       </value>
			     </option>
			     <option name="ReSharper.PROPERTY_IDENTIFIER">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Blue}" />
			       </value>
			     </option>
			     <option name="ReSharper.STRING_ESCAPE_CHARACTER_2" baseAttributes="DEFAULT_VALID_STRING_ESCAPE" />
			     <option name="SEARCH_RESULT_ATTRIBUTES">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Text}" />
			         <option name="BACKGROUND" value="{Scheme.Highlight}" />
			         <option name="EFFECT_COLOR" value="" />
			         <option name="ERROR_STRIPE_COLOR" value="{Scheme.Green}" />
			       </value>
			     </option>
			     <option name="ReSharper.IL_INSTRUCTION">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Red}"/>
			       </value>
			     </option>
			     <option name="ReSharper.IL_TARGET_CODE_LABEL">
			       <value>
			       </value>
			     </option>
			     <option name="ReSharper.IL_VIEWER_SYNCHRONIZATION">
			       <value/>
			     </option>
			     <option name="ReSharper.MATCHED_FORMAT_STRING_ITEM">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Plum}"/>
			       </value>
			     </option>
			     <option name="ReSharper.OUTLINED_ENTITY">
			       <value>
			         <option name="EFFECT_COLOR" value="{Scheme.Text}"/>
			       </value>
			     </option>
			     <option name="ReSharper.STRING_ESCAPE_CHARACTER_2">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Blue}"/>
			       </value>
			     </option>
			     <option name="ReSharper.XAML_CLASS">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Blue}"/>
			       </value>
			     </option>
			     <option name="ReSharper.XAML_NAMESPACE_ALIAS">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Orange}"/>
			       </value>
			     </option>
			     <option name="ReSharper.XAML_PROPERTY_IDENTIFIER">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Orange}"/>
			       </value>
			     </option>
			     <option name="RUNTIME_ERROR">
			       <value>
			         <option name="EFFECT_COLOR" value="{Scheme.Red}" />
			         <option name="ERROR_STRIPE_COLOR" value="{Scheme.Red}" />
			         <option name="EFFECT_TYPE" value="5" />
			       </value>
			     </option>
			     <option name="SQUARE_BRACKETS_RAINBOW_COLOR0">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Magenta}"/>
			       </value>
			     </option>
			     <option name="SQUARE_BRACKETS_RAINBOW_COLOR1">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Plum}"/>
			       </value>
			     </option>
			     <option name="SQUARE_BRACKETS_RAINBOW_COLOR2">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Cyan}"/>
			       </value>
			     </option>
			     <option name="SQUARE_BRACKETS_RAINBOW_COLOR3">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Blue}"/>
			       </value>
			     </option>
			     <option name="SQUARE_BRACKETS_RAINBOW_COLOR4">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Purple}"/>
			       </value>
			     </option>
			     <option name="SQUIGGLY_BRACKETS_RAINBOW_COLOR0">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Magenta}"/>
			       </value>
			     </option>
			     <option name="SQUIGGLY_BRACKETS_RAINBOW_COLOR1">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Plum}"/>
			       </value>
			     </option>
			     <option name="SQUIGGLY_BRACKETS_RAINBOW_COLOR2">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Cyan}"/>
			       </value>
			     </option>
			     <option name="SQUIGGLY_BRACKETS_RAINBOW_COLOR3">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Blue}"/>
			       </value>
			     </option>
			     <option name="SQUIGGLY_BRACKETS_RAINBOW_COLOR4">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Purple}"/>
			       </value>
			     </option>
			     <option name="SUGGESTION">
			       <value>
			         <option name="EFFECT_COLOR" value="{Scheme.Yellow}" />
			         <option name="EFFECT_TYPE" value="{FontItalic}" />
			       </value>
			     </option>
			     <option name="TAB_SELECTED">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Purple}"/>
			         <option name="BACKGROUND" value="{Scheme.Highlight}"/>
			       </value>
			     </option>
			     <option name="TAB_SELECTED_INACTIVE">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Purple}"/>
			         <option name="BACKGROUND" value="{Scheme.HighlightLow}"/>
			       </value>
			     </option>
			     <option name="TAG_ATTR_KEY">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Orange}"/>
			       </value>
			     </option>
			     <option name="TEMPLATE_VARIABLE_ATTRIBUTES">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Text}" />
			       </value>
			     </option>
			     <option name="TERMINAL_COMMAND_TO_RUN_USING_IDE">
			       <value>
			         <option name="BACKGROUND" value="{Scheme.HighlightLow}"/>
			       </value>
			     </option>
			     <option name="TEXT">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Text}" />
			         <option name="BACKGROUND" value="{Scheme.Background}" />
			       </value>
			     </option>
			     <option name="TEXT_SEARCH_RESULT_ATTRIBUTES">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Text}" />
			         <option name="BACKGROUND" value="{Scheme.Highlight}" />
			         <option name="EFFECT_COLOR" value="" />
			         <option name="ERROR_STRIPE_COLOR" value="{Scheme.Green}" />
			       </value>
			     </option>
			     <option name="TODO_DEFAULT_ATTRIBUTES">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Green}" />
			         <option name="FONT_TYPE" value="{FontItalic}" />
			         <option name="ERROR_STRIPE_COLOR" value="{Scheme.Green}" />
			       </value>
			     </option>
			     <option name="TYPEDEF">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Purple}"/>
			       </value>
			     </option>
			     <option name="TYPE_PARAMETER_NAME_ATTRIBUTES">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Orange}"/>
			       </value>
			     </option>
			     <option name="TYPO">
			       <value>
			         <option name="EFFECT_COLOR" value="{Scheme.Orange}" />
			         <option name="EFFECT_TYPE" value="{FontItalic}" />
			       </value>
			     </option>
			     <option name="UNMATCHED_BRACE_ATTRIBUTES">
			       <value>
			         <option name="BACKGROUND" value="{Scheme.Red}"/>
			         <option name="FONT_TYPE" value="{FontBold}"/>
			       </value>
			     </option>
			     <option name="Unresolved reference access">
			       <value>
			         <option name="EFFECT_COLOR" value="{Scheme.Red}"/>
			         <option name="EFFECT_TYPE" value="{FontItalic}"/>
			       </value>
			     </option>
			     <option name="UNMATCHED_BRACE_ATTRIBUTES">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Red}" />
			         <option name="ERROR_STRIPE_COLOR" value="{Scheme.Red}" />
			       </value>
			     </option>
			     <option name="WARNING_ATTRIBUTES">
			       <value>
			         <option name="EFFECT_COLOR" value="{Scheme.TextFaded}" />
			         <option name="ERROR_STRIPE_COLOR" value="{Scheme.TextFaded}" />
			         <option name="EFFECT_TYPE" value="5" />
			       </value>
			     </option>
			     <option name="WRITE_IDENTIFIER_UNDER_CARET_ATTRIBUTES">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Red}" />
			         <option name="EFFECT_TYPE" value="1" />
			       </value>
			     </option>
			     <option name="WRITE_SEARCH_RESULT_ATTRIBUTES">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Text}" />
			         <option name="BACKGROUND" value="{Scheme.Highlight}" />
			         <option name="EFFECT_COLOR" value="" />
			         <option name="ERROR_STRIPE_COLOR" value="{Scheme.Green}" />
			       </value>
			     </option>
			     <option name="WRONG_REFERENCES_ATTRIBUTES">
			       <value>
			         <option name="EFFECT_COLOR" value="{Scheme.Red}"/>
			         <option name="ERROR_STRIPE_COLOR" value="{Scheme.Red}"/>
			         <option name="EFFECT_TYPE" value="{FontItalic}"/>
			       </value>
			     </option>
			     <option name="XML_ATTRIBUTE_NAME" baseAttributes="DEFAULT_ATTRIBUTE"/>
			     <option name="XML_CUSTOM_TAG_NAME" baseAttributes="XML_TAG_NAME"/>
			     <option name="XML_ENTITY_REFERENCE" baseAttributes="DEFAULT_ENTITY"/>
			     <option name="XML_NS_PREFIX">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Plum}"/>
			       </value>
			     </option>
			     <option name="XML_TAG" baseAttributes="DEFAULT_TAG"/>
			     <option name="XML_TAG_DATA" baseAttributes="TEXT"/>
			     <option name="XML_TAG_NAME">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Blue}"/>
			       </value>
			     </option>
			     <!-- Semantic Highlights -->
			     <option name="RAINBOW_COLOR0">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Magenta}"/>
			       </value>
			     </option>
			     <option name="RAINBOW_COLOR1">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Plum}"/>
			       </value>
			     </option>
			     <option name="RAINBOW_COLOR2">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Cyan}"/>
			       </value>
			     </option>
			     <option name="RAINBOW_COLOR3">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Blue}"/>
			       </value>
			     </option>
			     <option name="RAINBOW_COLOR4">
			       <value>
			         <option name="FOREGROUND" value="{Scheme.Purple}"/>
			       </value>
			     </option>
			   </attributes>
			 </scheme> 
			 """;
	}
}