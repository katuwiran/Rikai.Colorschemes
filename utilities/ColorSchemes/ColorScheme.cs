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

	public required string Magenta { get; set; }
	public required string Plum    { get; set; }
	public required string Blue    { get; set; }
	public required string Purple  { get; set; }
	public required string Cyan    { get; set; }
	public required string Green   { get; set; }
	public required string Yellow  { get; set; }
	public required string Red     { get; set; }
	public required string Orange  { get; set; }

	public required string Highlight     { get; set; } // selected result, on press
	public required string HighlightLow  { get; set; } // search results, unpressed
	public required string HighlightHigh { get; set; } // on hover

	public string HoverText                   => Background;    // on hover, text
	public string HoverBackground             => HighlightHigh; // on hover, background
	public string PressedText                 => Magenta;       // on press, text
	public string PressedBackground           => Highlight;     // on press, background
	public string SelectionText               => Background;    // selection, text
	public string SelectionBackground         => Background;    // selection, background
	public string SelectionInactiveText       => HighlightLow;  // inactive selection, text
	public string SelectionInactiveBackground => HighlightLow;  // inactive selection, background
	public string InactiveText                => Highlight;     // inactive, text
	public string InactiveBackground          => HighlightLow;  // inactive, backgroud

	public string MenuBackground => Background;
	public string TextForeground => Text;


	// linting
	public string Error       => Red;
	public string Warning     => Orange;
	public string Info        => Yellow;
	public string Annotations => Text;

	// Console
	public string Caret                => Text;
	public string ConsoleBackground    => Background; // Console 0. Background
	public string ConsoleBackgroundAlt => Background; // Console 0. Bright
	public string ConsoleRed           => Magenta;    // Console 1. Red
	public string ConsoleRedAlt        => Magenta;    // Console 1. Red
	public string ConsoleGreen         => Purple;     // Console 2. Green
	public string ConsoleGreenAlt      => Purple;     // Console 2. Green Bright
	public string ConsoleYellow        => Cyan;       // Console 3. Yellow
	public string ConsoleYellowAlt     => Cyan;       // Console 3. Yellow Bright
	public string ConsoleBlue          => Blue;       // Console 4. Blue
	public string ConsoleBlueAlt       => Blue;       // Console 4. Blue Bright
	public string ConsoleMagenta       => Red;        // Console 5. Magenta
	public string ConsoleMagentaAlt    => Red;        // Console 5. Magenta Bright
	public string ConsoleCyan          => Plum;       // Console 6. Cyan
	public string ConsoleCyanAlt       => Plum;       // Console 6. Cyan Bright
	public string ConsoleForeground    => Text;       // Console 7. Text 
	public string ConsoleForegroundAlt => Text;       // Console 7. Text Bright

	// git diffs
	public string DiffAdded    => Green;
	public string DiffDeleted  => Magenta;
	public string DiffModified => Purple;
	public string DiffIgnored  => TextFaded;
	public string DiffConflict => Plum;

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