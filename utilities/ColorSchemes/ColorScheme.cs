namespace ColorschemeUtils;

public partial class ColorScheme
{
	// Scheme Descriptions
	public required string Name        { get; set; }
	public required string Description { get; set; }
	public required bool   IsDark      { get; set; }

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

	// Color Names
	public required string ClassName   { get; set; } // "heavy" keywords
	public required string KeywordName { get; set; } // "light" keywords
	public required string FieldName   { get; set; } // method Names
	public required string MethodName  { get; set; } // variable names
	public required string StringName  { get; set; } // strings
	public required string NumeralName { get; set; } // numerals
	public required string InfoName    { get; set; } // 
	public required string ErrorName   { get; set; } // 
	public required string WarningName { get; set; } // 

	public required string HighlightLow  { get; set; } // search results, unpressed
	public required string Highlight     { get; set; } // selected result, on press
	public required string HighlightHigh { get; set; } // on hover

	public string Accent     => HighlightHigh; // primary color
	public string AccentText => Background;    // primary color

	public string HoverText             => Keyword;    // text on hover
	public string PressedText           => Keyword;    // text on press
	public string SelectionText         => Background; // selected text
	public string SelectionInactiveText => Text;       // selected text but unfocused
	public string InactiveText          => Text;       // inactive text on buttons

	public string HoverBackground             => HighlightLow;      // on hover
	public string PressedBackground           => HighlightHigh;     // on press
	public string SelectionBackground         => Highlight;         // selection
	public string SelectionInactiveBackground => BackgroundOverlay; // inactive selection
	public string InactiveBackground          => BackgroundOverlay; // inactive button

	public string MenuBackground => Background;

	// linting
	public string Annotations => Text;

	// Console
	public string Caret                => Highlight;
	public string CaretText            => Background;
	public string ConsoleBackground    => Background;   // Console 0. Background
	public string ConsoleBackgroundAlt => TextInactive; // Console 0. Bright
	public string ConsoleRed           => Class;        // Console 1. Red
	public string ConsoleRedAlt        => Class;        // Console 1. Red
	public string ConsoleGreen         => Method;       // Console 2. Green
	public string ConsoleGreenAlt      => Method;       // Console 2. Green Bright
	public string ConsoleYellow        => String;       // Console 3. Yellow
	public string ConsoleYellowAlt     => String;       // Console 3. Yellow Bright
	public string ConsoleBlue          => Field;        // Console 4. Blue
	public string ConsoleBlueAlt       => Field;        // Console 4. Blue Bright
	public string ConsoleMagenta       => Error;        // Console 5. Magenta
	public string ConsoleMagentaAlt    => Error;        // Console 5. Magenta Bright
	public string ConsoleCyan          => Keyword;      // Console 6. Cyan
	public string ConsoleCyanAlt       => Keyword;      // Console 6. Cyan Bright
	public string ConsoleForeground    => Text;         // Console 7. Text 
	public string ConsoleForegroundAlt => TextFaded;    // Console 7. Text Bright

	// git diff marks
	public string DiffAdded    => Numeral;
	public string DiffDeleted  => Error;
	public string DiffModified => Method;
	public string DiffIgnored  => TextFaded;
	public string DiffConflict => Keyword;

	// git diff text highlights, for source git
	public required string DiffAddedHighlight    { get; set; }
	public required string DiffAddedBackground   { get; set; }
	public required string DiffDeletedHighlight  { get; set; }
	public required string DiffDeletedBackground { get; set; }

	public static string ToRgb(string hex)
	{
		string r = $"{HexadecimalToDecimal(hex.Substring(0, 2))}";
		string g = $"{HexadecimalToDecimal(hex.Substring(2, 2))}";
		string b = $"{HexadecimalToDecimal(hex.Substring(4, 2))}";

		return $"{r},{g},{b}";
	}

	private static int HexadecimalToDecimal(string hex)
	{
		hex = hex.ToUpper();

		int    hexLength = hex.Length;
		double dec       = 0;

		for (int i = 0; i < hexLength; ++i)
		{
			byte b = (byte)hex[i];

			if (b >= 48 && b <= 57)
				b -= 48;
			else if (b >= 65 && b <= 70)
				b -= 55;

			dec += b * Math.Pow(16, ((hexLength - i) - 1));
		}

		return (int)dec;
	}

	public override string ToString()
	{
		return $"{Name}";
	}
}