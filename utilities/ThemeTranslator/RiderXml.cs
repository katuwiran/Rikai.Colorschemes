namespace ColorschemeUtils;

/// <summary>
/// testing https://github.com 
/// </summary>
public static partial class ThemeTranslator
{
	public static string RiderXml(ColorScheme scheme)
	{
		return
			$$"""
			 <scheme name="{{scheme.Name}}" version="142" parent_scheme="Darcula">
			   <metaInfo>
			     <property name="ide">Rider</property>
			     <property name="ideVersion">2025.3.1.0.0</property>
			     <property name="originalScheme">Moonlight</property>
			   </metaInfo>
			   <colors>
			     <option name="CARET_ROW_COLOR" value="{{scheme.Overlay}}" />
			     <option name="DOCUMENTATION_COLOR" value="" />
			     <option name="DOC_COMMENT_LINK" value="{{scheme.Lavender}}" />
			     <option name="EDITOR_GUTTER_BACKGROUND" value="" />
			     <option name="FILESTATUS_ADDED" value="" />
			     <option name="FILESTATUS_COPIED" value="" />
			     <option name="FILESTATUS_DELETED" value="" />
			     <option name="FILESTATUS_HIJACKED" value="{{scheme.Text}}" />
			     <option name="FILESTATUS_IDEA_FILESTATUS_DELETED_FROM_FILE_SYSTEM" value="" />
			     <option name="FILESTATUS_IDEA_FILESTATUS_IGNORED" value="" />
			     <option name="FILESTATUS_IDEA_FILESTATUS_MERGED_WITH_BOTH_CONFLICTS" value="" />
			     <option name="FILESTATUS_IDEA_FILESTATUS_MERGED_WITH_CONFLICTS" value="" />
			     <option name="FILESTATUS_IDEA_FILESTATUS_MERGED_WITH_PROPERTY_CONFLICTS" value="" />
			     <option name="FILESTATUS_MERGED" value="" />
			     <option name="FILESTATUS_MODIFIED" value="" />
			     <option name="FILESTATUS_NOT_CHANGED_IMMEDIATE" value="" />
			     <option name="FILESTATUS_NOT_CHANGED_RECURSIVE" value="" />
			     <option name="FILESTATUS_RENAMED" value="" />
			     <option name="FILESTATUS_UNKNOWN" value="" />
			     <option name="FILESTATUS_addedOutside" value="" />
			     <option name="FILESTATUS_changelistConflict" value="" />
			     <option name="FILESTATUS_modifiedOutside" value="" />
			     <option name="FOLDED_TEXT_BORDER_COLOR" value="" />
			     <option name="INDENT_GUIDE" value="{{scheme.Overlay}}" />
			     <option name="INLINE_REFACTORING_SETTINGS_DEFAULT" value="{{scheme.Subtle}}" />
			     <option name="INLINE_REFACTORING_SETTINGS_FOCUSED" value="" />
			     <option name="INLINE_REFACTORING_SETTINGS_HOVERED" value="" />
			     <option name="LINE_NUMBERS_COLOR" value="{{scheme.Inactive}}" />
			     <option name="LINE_NUMBER_ON_CARET_ROW_COLOR" value="{{scheme.Text}}" />
			     <option name="MATCHED_BRACES_INDENT_GUIDE_COLOR" value="{{scheme.Overlay}}" />
			     <option name="METHOD_SEPARATORS_COLOR" value="{{scheme.Muted}}" />
			     <option name="NOTIFICATION_BACKGROUND" value="{{scheme.Muted}}" />
			     <option name="PREVIEW_BACKGROUND" value="{{scheme.Base}}" />
			     <option name="RIGHT_MARGIN_COLOR" value="{{scheme.Overlay}}" />
			     <option name="SELECTED_INDENT_GUIDE" value="{{scheme.Overlay}}" />
			     <option name="SELECTED_TEARLINE_COLOR" value="{{scheme.Muted}}" />
			     <option name="SELECTION_BACKGROUND" value="{{scheme.CyanAlt}}" />
			     <option name="SELECTION_FOREGROUND" value="{{scheme.Base}}" />
			     <option name="ScrollBar.hoverThumbColor" value="{{scheme.Muted}}A6" />
			     <option name="ScrollBar.thumbColor" value="{{scheme.Muted}}A6" />
			     <option name="TEARLINE_COLOR" value="{{scheme.Muted}}" />
			     <option name="VISUAL_INDENT_GUIDE" value="{{scheme.Overlay}}" />
			     <option name="WHITESPACES" value="{{scheme.Text}}" />
			   </colors>
			   <attributes>
			     <option name="BAD_CHARACTER">
			       <value>
			         <option name="FOREGROUND" value="{{scheme.Red}}" />
			         <option name="ERROR_STRIPE_COLOR" value="{{scheme.Red}}" />
			         <option name="EFFECT_TYPE" value="2" />
			       </value>
			     </option>
			     <option name="CODE_VISION_DEFAULT">
			       <value>
			         <option name="FOREGROUND" value="{{scheme.Subtle}}" />
			       </value>
			     </option>
			     <option name="CODE_VISION_HOVERED">
			       <value>
			         <option name="FOREGROUND" value="{{scheme.Blue}}" />
			       </value>
			     </option>
			     <option name="CTRL_CLICKABLE">
			       <value>
			         <option name="FOREGROUND" value="{{scheme.Purple}}" />
			         <option name="EFFECT_COLOR" value="{{scheme.Purple}}" />
			         <option name="EFFECT_TYPE" value="1" />
			       </value>
			     </option>
			     <option name="DEFAULT_ATTRIBUTE">
			       <value>
			         <option name="FOREGROUND" value="{{scheme.Text}}" />
			       </value>
			     </option>
			     <option name="DEFAULT_BLOCK_COMMENT">
			       <value>
			         <option name="FOREGROUND" value="{{scheme.Inactive}}" />
			         <option name="FONT_TYPE" value="2" />
			       </value>
			     </option>
			     <option name="DEFAULT_BRACES">
			       <value>
			         <option name="FOREGROUND" value="{{scheme.Blue}}" />
			       </value>
			     </option>
			     <option name="DEFAULT_BRACKETS">
			       <value>
			         <option name="FOREGROUND" value="{{scheme.Blue}}" />
			       </value>
			     </option>
			     <option name="DEFAULT_CLASS_NAME">
			       <value>
			         <option name="FOREGROUND" value="{{scheme.Magenta}}" />
			       </value>
			     </option>
			     <option name="DEFAULT_CLASS_REFERENCE">
			       <value>
			         <option name="FOREGROUND" value="{{scheme.Green}}" />
			       </value>
			     </option>
			     <option name="DEFAULT_COMMA">
			       <value>
			         <option name="FOREGROUND" value="{{scheme.Magenta}}" />
			       </value>
			     </option>
			     <option name="DEFAULT_CONSTANT">
			       <value>
			         <option name="FOREGROUND" value="{{scheme.Lavender}}" />
			       </value>
			     </option>
			     <option name="DEFAULT_DOC_COMMENT">
			       <value>
			         <option name="FOREGROUND" value="{{scheme.Inactive}}" />
			         <option name="FONT_TYPE" value="2" />
			       </value>
			     </option>
			     <option name="DEFAULT_DOC_COMMENT_TAG">
			       <value>
			         <option name="FOREGROUND" value="{{scheme.Green}}" />
			         <option name="EFFECT_TYPE" value="1" />
			       </value>
			     </option>
			     <option name="DEFAULT_DOC_COMMENT_TAG_VALUE">
			       <value>
			         <option name="FOREGROUND" value="{{scheme.Text}}" />
			       </value>
			     </option>
			     <option name="DEFAULT_DOC_MARKUP">
			       <value>
			         <option name="FOREGROUND" value="{{scheme.Lavender}}" />
			       </value>
			     </option>
			     <option name="DEFAULT_DOT">
			       <value>
			         <option name="FOREGROUND" value="{{scheme.Lavender}}" />
			       </value>
			     </option>
			     <option name="DEFAULT_ENTITY">
			       <value>
			         <option name="FOREGROUND" value="{{scheme.Text}}" />
			       </value>
			     </option>
			     <option name="DEFAULT_FUNCTION_CALL">
			       <value>
			         <option name="FOREGROUND" value="{{scheme.Purple}}" />
			       </value>
			     </option>
			     <option name="DEFAULT_FUNCTION_DECLARATION">
			       <value>
			         <option name="FOREGROUND" value="{{scheme.Purple}}" />
			       </value>
			     </option>
			     <option name="DEFAULT_GLOBAL_VARIABLE">
			       <value>
			         <option name="FOREGROUND" value="{{scheme.Text}}" />
			       </value>
			     </option>
			     <option name="DEFAULT_HIGHLIGHTED_REFERENCE">
			       <value>
			         <option name="FOREGROUND" value="{{scheme.GreenAlt}}" />
			       </value>
			     </option>
			     <option name="DEFAULT_IDENTIFIER">
			       <value>
			         <option name="FOREGROUND" value="{{scheme.Subtle}}" />
			       </value>
			     </option>
			     <option name="DEFAULT_INSTANCE_FIELD">
			       <value>
			         <option name="FOREGROUND" value="{{scheme.Blue}}" />
			       </value>
			     </option>
			     <option name="DEFAULT_INTERFACE_NAME">
			       <value>
			         <option name="FOREGROUND" value="{{scheme.Magenta}}" />
			       </value>
			     </option>
			     <option name="DEFAULT_INVALID_STRING_ESCAPE">
			       <value>
			         <option name="FOREGROUND" value="{{scheme.Red}}" />
			         <option name="ERROR_STRIPE_COLOR" value="{{scheme.Red}}" />
			         <option name="EFFECT_TYPE" value="2" />
			       </value>
			     </option>
			     <option name="DEFAULT_KEYWORD">
			       <value>
			         <option name="FOREGROUND" value="{{scheme.Lavender}}" />
			       </value>
			     </option>
			     <option name="DEFAULT_LABEL">
			       <value>
			         <option name="FOREGROUND" value="{{scheme.Text}}" />
			       </value>
			     </option>
			     <option name="DEFAULT_LINE_COMMENT">
			       <value>
			         <option name="FOREGROUND" value="{{scheme.Inactive}}" />
			         <option name="FONT_TYPE" value="2" />
			       </value>
			     </option>
			     <option name="DEFAULT_LOCAL_VARIABLE">
			       <value>
			         <option name="FOREGROUND" value="{{scheme.Text}}" />
			       </value>
			     </option>
			     <option name="DEFAULT_METADATA">
			       <value>
			         <option name="FOREGROUND" value="{{scheme.YellowAlt}}" />
			       </value>
			     </option>
			     <option name="DEFAULT_NUMBER">
			       <value>
			         <option name="FOREGROUND" value="{{scheme.Yellow}}" />
			       </value>
			     </option>
			     <option name="DEFAULT_OPERATION_SIGN">
			       <value>
			         <option name="FOREGROUND" value="{{scheme.Blue}}" />
			       </value>
			     </option>
			     <option name="DEFAULT_PARAMETER">
			       <value>
			         <option name="FOREGROUND" value="{{scheme.Text}}" />
			       </value>
			     </option>
			     <option name="DEFAULT_PARENTHS">
			       <value>
			         <option name="FOREGROUND" value="{{scheme.Blue}}" />
			       </value>
			     </option>
			     <option name="DEFAULT_PREDEFINED_SYMBOL">
			       <value>
			         <option name="FOREGROUND" value="{{scheme.Subtle}}" />
			       </value>
			     </option>
			     <option name="DEFAULT_REASSIGNED_LOCAL_VARIABLE">
			       <value>
			         <option name="FOREGROUND" value="{{scheme.Text}}" />
			         <option name="EFFECT_COLOR" value="{{scheme.Text}}" />
			         <option name="EFFECT_TYPE" value="1" />
			       </value>
			     </option>
			     <option name="DEFAULT_REASSIGNED_PARAMETER">
			       <value>
			         <option name="FOREGROUND" value="{{scheme.Text}}" />
			         <option name="EFFECT_COLOR" value="{{scheme.Text}}" />
			         <option name="EFFECT_TYPE" value="1" />
			       </value>
			     </option>
			     <option name="DEFAULT_SEMICOLON">
			       <value>
			         <option name="FOREGROUND" value="{{scheme.Blue}}" />
			       </value>
			     </option>
			     <option name="DEFAULT_STATIC_FIELD">
			       <value>
			         <option name="FOREGROUND" value="{{scheme.Blue}}" />
			       </value>
			     </option>
			     <option name="DEFAULT_STATIC_METHOD">
			       <value>
			         <option name="FOREGROUND" value="{{scheme.Purple}}" />
			       </value>
			     </option>
			     <option name="DEFAULT_STRING">
			       <value>
			         <option name="FOREGROUND" value="{{scheme.Cyan}}" />
			       </value>
			     </option>
			     <option name="DEFAULT_TAG">
			       <value>
			         <option name="FOREGROUND" value="{{scheme.Text}}" />
			         <option name="EFFECT_TYPE" value="5" />
			       </value>
			     </option>
			     <option name="DEFAULT_TEMPLATE_LANGUAGE_COLOR" baseAttributes="TEXT" />
			     <option name="DEFAULT_VALID_STRING_ESCAPE">
			       <value>
			         <option name="FOREGROUND" value="{{scheme.Lavender}}" />
			       </value>
			     </option>
			     <option name="DELETED_TEXT_ATTRIBUTES">
			       <value>
			         <option name="BACKGROUND" value="{{scheme.Base}}" />
			         <option name="EFFECT_COLOR" value="{{scheme.Subtle}}" />
			         <option name="EFFECT_TYPE" value="3" />
			       </value>
			     </option>
			     <option name="DEPRECATED_ATTRIBUTES">
			       <value>
			         <option name="EFFECT_COLOR" value="{{scheme.Text}}" />
			         <option name="EFFECT_TYPE" value="3" />
			       </value>
			     </option>
			     <option name="DUPLICATE_FROM_SERVER">
			       <value>
			         <option name="FOREGROUND" value="{{scheme.Base}}" />
			         <option name="BACKGROUND" value="{{scheme.Orange}}" />
			       </value>
			     </option>
			     <option name="ERRORS_ATTRIBUTES">
			       <value>
			         <option name="FOREGROUND" value="{{scheme.Red}}" />
			         <option name="ERROR_STRIPE_COLOR" value="{{scheme.Red}}" />
			         <option name="EFFECT_TYPE" value="2" />
			       </value>
			     </option>
			     <option name="FOLDED_TEXT_ATTRIBUTES">
			       <value />
			     </option>
			     <option name="FOLLOWED_HYPERLINK_ATTRIBUTES">
			       <value>
			         <option name="FOREGROUND" value="{{scheme.Purple}}" />
			         <option name="EFFECT_COLOR" value="{{scheme.Purple}}" />
			         <option name="EFFECT_TYPE" value="1" />
			       </value>
			     </option>
			     <option name="GENERIC_SERVER_ERROR_OR_WARNING">
			       <value>
			         <option name="EFFECT_COLOR" value="{{scheme.Red}}" />
			         <option name="ERROR_STRIPE_COLOR" value="{{scheme.Red}}" />
			         <option name="EFFECT_TYPE" value="1" />
			       </value>
			     </option>
			     <option name="HYPERLINK_ATTRIBUTES">
			       <value>
			         <option name="FOREGROUND" value="{{scheme.Lavender}}" />
			         <option name="EFFECT_COLOR" value="{{scheme.Lavender}}" />
			         <option name="EFFECT_TYPE" value="1" />
			       </value>
			     </option>
			     <option name="IDENTIFIER_UNDER_CARET_ATTRIBUTES">
			       <value>
			         <option name="BACKGROUND" value="{{scheme.Overlay}}" />
			         <option name="FONT_TYPE" value="1" />
			         <option name="EFFECT_TYPE" value="1" />
			       </value>
			     </option>
			     <option name="INACTIVE_HYPERLINK_ATTRIBUTES">
			       <value>
			         <option name="EFFECT_COLOR" value="{{scheme.Inactive}}" />
			         <option name="EFFECT_TYPE" value="1" />
			       </value>
			     </option>
			     <option name="INFO_ATTRIBUTES">
			       <value>
			         <option name="FOREGROUND" value="{{scheme.Orange}}" />
			         <option name="ERROR_STRIPE_COLOR" value="{{scheme.Orange}}" />
			         <option name="EFFECT_TYPE" value="2" />
			       </value>
			     </option>
			     <option name="INLAY_DEFAULT">
			       <value>
			         <option name="FOREGROUND" value="{{scheme.Text}}" />
			       </value>
			     </option>
			     <option name="INLAY_TEXT_WITHOUT_BACKGROUND">
			       <value>
			         <option name="FOREGROUND" value="{{scheme.Text}}" />
			       </value>
			     </option>
			     <option name="INLINE_PARAMETER_HINT">
			       <value>
			         <option name="FOREGROUND" value="{{scheme.Subtle}}" />
			         <option name="BACKGROUND" value="{{scheme.Base}}" />
			       </value>
			     </option>
			     <option name="INLINE_PARAMETER_HINT_CURRENT">
			       <value />
			     </option>
			     <option name="INLINE_PARAMETER_HINT_HIGHLIGHTED">
			       <value />
			     </option>
			     <option name="MARKED_FOR_REMOVAL_ATTRIBUTES">
			       <value>
			         <option name="EFFECT_COLOR" value="{{scheme.Red}}" />
			         <option name="EFFECT_TYPE" value="3" />
			       </value>
			     </option>
			     <option name="MATCHED_BRACE_ATTRIBUTES">
			       <value>
			         <option name="FOREGROUND" value="{{scheme.Blue}}" />
			         <option name="FONT_TYPE" value="1" />
			         <option name="EFFECT_COLOR" value="{{scheme.Blue}}" />
			         <option name="EFFECT_TYPE" value="4" />
			       </value>
			     </option>
			     <option name="NOT_USED_ELEMENT_ATTRIBUTES">
			       <value>
			         <option name="EFFECT_COLOR" value="{{scheme.Subtle}}" />
			         <option name="EFFECT_TYPE" value="1" />
			       </value>
			     </option>
			     <option name="RUNTIME_ERROR">
			       <value>
			         <option name="EFFECT_COLOR" value="{{scheme.Red}}" />
			         <option name="ERROR_STRIPE_COLOR" value="{{scheme.Red}}" />
			         <option name="EFFECT_TYPE" value="5" />
			       </value>
			     </option>
			     <option name="ReSharper.BUILTIN_TYPE_KEYWORD">
			       <value>
			         <option name="FOREGROUND" value="{{scheme.Lavender}}" />
			       </value>
			     </option>
			     <option name="ReSharper.CONTROL_FLOW_KEYWORD">
			       <value>
			         <option name="FOREGROUND" value="{{scheme.Lavender}}" />
			       </value>
			     </option>
			     <option name="ReSharper.CONTROL_TRANSFER_KEYWORD">
			       <value>
			         <option name="FOREGROUND" value="{{scheme.Lavender}}" />
			       </value>
			     </option>
			     <option name="ReSharper.CSHARP_TYPE_PARAMETER_IDENTIFIER">
			       <value>
			         <option name="FOREGROUND" value="{{scheme.Green}}" />
			       </value>
			     </option>
			     <option name="ReSharper.FORMAT_STRING_ITEM">
			       <value>
			         <option name="FOREGROUND" value="{{scheme.Text}}" />
			       </value>
			     </option>
			     <option name="ReSharper.FORMAT_STRING_ITEM_2">
			       <value>
			         <option name="FOREGROUND" value="{{scheme.Text}}" />
			       </value>
			     </option>
			     <option name="ReSharper.HINT">
			       <value>
			         <option name="EFFECT_COLOR" value="{{scheme.Inactive}}" />
			         <option name="ERROR_STRIPE_COLOR" value="{{scheme.Inactive}}" />
			         <option name="EFFECT_TYPE" value="5" />
			       </value>
			     </option>
			     <option name="ReSharper.MATCHED_FORMAT_STRING_ITEM">
			       <value>
			         <option name="FOREGROUND" value="{{scheme.Text}}" />
			       </value>
			     </option>
			     <option name="ReSharper.NAMESPACE_IDENTIFIER">
			       <value>
			         <option name="FOREGROUND" value="{{scheme.Text}}" />
			       </value>
			     </option>
			     <option name="ReSharper.OPERATOR_IDENTIFIER">
			       <value>
			         <option name="FOREGROUND" value="{{scheme.Blue}}" />
			       </value>
			     </option>
			     <option name="ReSharper.PROPERTY_IDENTIFIER">
			       <value>
			         <option name="FOREGROUND" value="{{scheme.Blue}}" />
			       </value>
			     </option>
			     <option name="ReSharper.STRING_ESCAPE_CHARACTER_2" baseAttributes="DEFAULT_VALID_STRING_ESCAPE" />
			     <option name="SEARCH_RESULT_ATTRIBUTES">
			       <value>
			         <option name="FOREGROUND" value="{{scheme.Text}}" />
			         <option name="BACKGROUND" value="{{scheme.Highlight}}" />
			         <option name="EFFECT_COLOR" value="" />
			         <option name="ERROR_STRIPE_COLOR" value="{{scheme.Green}}" />
			       </value>
			     </option>
			     <option name="SUGGESTION">
			       <value>
			         <option name="EFFECT_COLOR" value="{{scheme.YellowAlt}}" />
			         <option name="EFFECT_TYPE" value="2" />
			       </value>
			     </option>
			     <option name="TEMPLATE_VARIABLE_ATTRIBUTES">
			       <value>
			         <option name="FOREGROUND" value="{{scheme.Text}}" />
			       </value>
			     </option>
			     <option name="TEXT">
			       <value>
			         <option name="FOREGROUND" value="{{scheme.Subtle}}" />
			         <option name="BACKGROUND" value="{{scheme.Base}}" />
			         <option name="EFFECT_TYPE" value="5" />
			       </value>
			     </option>
			     <option name="TEXT_SEARCH_RESULT_ATTRIBUTES">
			       <value>
			         <option name="FOREGROUND" value="{{scheme.Text}}" />
			         <option name="BACKGROUND" value="{{scheme.Highlight}}" />
			         <option name="EFFECT_COLOR" value="" />
			         <option name="ERROR_STRIPE_COLOR" value="{{scheme.Green}}" />
			       </value>
			     </option>
			     <option name="TODO_DEFAULT_ATTRIBUTES">
			       <value>
			         <option name="FOREGROUND" value="{{scheme.Green}}" />
			         <option name="FONT_TYPE" value="2" />
			         <option name="ERROR_STRIPE_COLOR" value="{{scheme.Green}}" />
			       </value>
			     </option>
			     <option name="TYPO">
			       <value>
			         <option name="EFFECT_COLOR" value="{{scheme.Orange}}" />
			         <option name="EFFECT_TYPE" value="2" />
			       </value>
			     </option>
			     <option name="UNMATCHED_BRACE_ATTRIBUTES">
			       <value>
			         <option name="FOREGROUND" value="{{scheme.Red}}" />
			         <option name="ERROR_STRIPE_COLOR" value="{{scheme.Red}}" />
			       </value>
			     </option>
			     <option name="WARNING_ATTRIBUTES">
			       <value>
			         <option name="EFFECT_COLOR" value="{{scheme.Inactive}}" />
			         <option name="ERROR_STRIPE_COLOR" value="{{scheme.Inactive}}" />
			         <option name="EFFECT_TYPE" value="5" />
			       </value>
			     </option>
			     <option name="WRITE_IDENTIFIER_UNDER_CARET_ATTRIBUTES">
			       <value>
			         <option name="FOREGROUND" value="{{scheme.Red}}" />
			         <option name="EFFECT_TYPE" value="1" />
			       </value>
			     </option>
			     <option name="WRITE_SEARCH_RESULT_ATTRIBUTES">
			       <value>
			         <option name="FOREGROUND" value="{{scheme.Text}}" />
			         <option name="BACKGROUND" value="{{scheme.Highlight}}" />
			         <option name="EFFECT_COLOR" value="" />
			         <option name="ERROR_STRIPE_COLOR" value="{{scheme.Green}}" />
			       </value>
			     </option>
			     <option name="XML_TAG">
			       <value />
			     </option>
			   </attributes>
			 </scheme> 
			 """;
	}
}