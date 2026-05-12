namespace Rikai.Colorschemes;

public class ColorScheme
{
	// Scheme Descriptions
	public required string Name        { get; set; }
	public required string Description { get; set; }
	public required bool   IsDark      { get; set; }

	public required BasicColors   Colors  { get; set; }
	public required Base8Colors   Base8   { get; set; }
	public required ConsoleColors Console { get; set; }
	public required DiffColors    Diff    { get; set; }
	public required AccentColors  Accent  { get; set; }
	public required UiColors      Ui      { get; set; }
	public required Rainbow       Rainbow { get; set; }

	public override string ToString()
	{
		return $"{Name}";
	}
}

public class BasicColors
{
	public required string Background        { get; set; } // background
	public required string BackgroundEdges   { get; set; } // borders, dividers, etc.
	public required string BackgroundOverlay { get; set; } // scrollbars, unpressed buttons

	public required string Text         { get; set; } // foreground
	public required string TextFaded    { get; set; } // comments, 
	public required string TextInactive { get; set; } // disabled, unfocused
	public required string TextHidden   { get; set; } // toggled off, whitespace

	public required string Class   { get; set; } // "heavy" keywords
	public required string Keyword { get; set; } // "light" keywords
	public required string Field   { get; set; } // method Names
	public required string Method  { get; set; } // variable names
	public required string String  { get; set; } // strings
	public required string Numeral { get; set; } // numerals
	public required string Info    { get; set; } // 
	public required string Error   { get; set; } // 
	public required string Warning { get; set; } // 

	public required string ClassName   { get; set; } // "heavy" keywords
	public required string KeywordName { get; set; } // "light" keywords
	public required string FieldName   { get; set; } // method Names
	public required string MethodName  { get; set; } // variable names
	public required string StringName  { get; set; } // strings
	public required string NumeralName { get; set; } // numerals
	public required string InfoName    { get; set; } // usually yellow
	public required string WarningName { get; set; } // usually yellow / orange
	public required string ErrorName   { get; set; } // usually red

	public required string HighlightLow  { get; set; } // search results, unpressed
	public required string Highlight     { get; set; } // selected result, on press
	public required string HighlightHigh { get; set; } // on hover

	public string Caret     => Highlight;
	public string CaretText => Background;
}

public class Base8Colors
{
	public required string Black   { get; set; }
	public required string Red     { get; set; }
	public required string Green   { get; set; }
	public required string Yellow  { get; set; }
	public required string Blue    { get; set; }
	public required string Magenta { get; set; }
	public required string Cyan    { get; set; }
	public required string White   { get; set; }
}

public class ConsoleColors
{
	public required string Black   { get; set; }
	public required string Red     { get; set; }
	public required string Green   { get; set; }
	public required string Yellow  { get; set; }
	public required string Blue    { get; set; }
	public required string Magenta { get; set; }
	public required string Cyan    { get; set; }
	public required string White   { get; set; }

	public required string BlackAlt   { get; set; }
	public required string RedAlt     { get; set; }
	public required string GreenAlt   { get; set; }
	public required string YellowAlt  { get; set; }
	public required string BlueAlt    { get; set; }
	public required string MagentaAlt { get; set; }
	public required string CyanAlt    { get; set; }
	public required string WhiteAlt   { get; set; }
}

public class DiffColors
{
	// git diff marks
	public required string Added    { get; set; }
	public required string Deleted  { get; set; }
	public required string Modified { get; set; }
	public required string Ignored  { get; set; }
	public required string Conflict { get; set; }

	// git diff text highlights, for source git
	public required string AddedHighlight    { get; set; }
	public required string AddedBackground   { get; set; }
	public required string DeletedHighlight  { get; set; }
	public required string DeletedBackground { get; set; }

	public DiffColors()
	{
	}

	public DiffColors(BasicColors colors)
	{
		Added   = colors.Numeral;
		Deleted = colors.Error;
	}
}

public class AccentColors
{
	public required string Primary       { get; set; }
	public required string PrimaryText   { get; set; }
	public required string Secondary     { get; set; }
	public required string SecondaryText { get; set; }
	public required string Tertiary      { get; set; }
	public required string TertiaryText  { get; set; }
}

public class Rainbow
{
	public required string Level0 { get; set; }
	public required string Level1 { get; set; }
	public required string Level2 { get; set; }
	public required string Level3 { get; set; }
	public required string Level4 { get; set; }
	public required string Level5 { get; set; }
	public required string Level6 { get; set; }
}

public class UiColors
{
	public required string MenuBackground              { get; set; }
	public required string HoverBackground             { get; set; } // on hover
	public required string Hover                       { get; set; } // text on hover
	public required string InactiveBackground          { get; set; } // inactive button
	public required string Inactive                    { get; set; } // inactive text on buttons
	public required string MatchBackground             { get; set; }
	public required string Match                       { get; set; }
	public required string SelectionBackground         { get; set; } // selection
	public required string Selection                   { get; set; } // selected text
	public required string SelectionInactive           { get; set; } // selected text but unfocused
	public required string SelectionInactiveBackground { get; set; } // inactive selection
	public required string PressedBackground           { get; set; } // on press
	public required string Pressed                     { get; set; } // text on press
}
