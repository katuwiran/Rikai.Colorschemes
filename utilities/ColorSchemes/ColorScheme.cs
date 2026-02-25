namespace ColorschemeUtils;

public partial class ColorScheme
{
	public required string Name        { get; set; }
	public required string Description { get; set; }
	public required bool   IsDark      { get; set; }
	public required string Accent      { get; set; }

	public required string Base     { get; set; }
	public required string Surface  { get; set; }
	public required string Overlay  { get; set; }
	public required string Inactive { get; set; }
	public required string Subtle   { get; set; }
	public required string Muted    { get; set; }
	public required string Text     { get; set; }

	public required string Magenta { get; set; }
	public required string Plum    { get; set; }
	public required string Blue    { get; set; }
	public required string Purple  { get; set; }
	public required string Cyan    { get; set; }
	public required string Green   { get; set; }
	public required string Yellow  { get; set; }
	public required string Red     { get; set; }
	public required string Orange  { get; set; }

	public required string Highlight         { get; set; }
	public required string HighlightInactive { get; set; }
	public required string HighlightOverlay  { get; set; }

	public string Caret => Text;

	public string MenuBackground => Base;
	public string TextForeground => Text;
	public string Error          => Red;
	public string Warning        => Orange;
	public string Info           => Yellow;
	public string Annotations    => Text;

	public string SelectedText             => Text;
	public string SelectedTextBackground   => Highlight;
	public string UnselectedText           => Text;
	public string UnselectedTextBackground => Base;

	// Console 0. Background
	public string ConsoleBackground    => Base;
	public string ConsoleBackgroundAlt => Base;

	// Console 1
	public string ConsoleRed    => Red;
	public string ConsoleRedAlt => Red;

	// Console 2
	public string ConsoleGreen    => Plum;
	public string ConsoleGreenAlt => Plum;

	// Console 3
	public string ConsoleYellow    => Cyan;
	public string ConsoleYellowAlt => Cyan;

	// Console 4
	public string ConsoleBlue    => Blue;
	public string ConsoleBlueAlt => Blue;

	// Console 5
	public string ConsoleMagenta    => Purple;
	public string ConsoleMagentaAlt => Purple;

	// Console 6
	public string ConsoleCyan    => Magenta;
	public string ConsoleCyanAlt => Magenta;

	// Console 7
	public string ConsoleForeground    => Text;
	public string ConsoleForegroundAlt => Text;

	public string SearchHighlight => Highlight;
	public string DiffAdded       => Green;
	public string DiffDeleted     => Magenta;
	public string DiffModified    => Purple;
	public string DiffIgnored     => Subtle;
	public string DiffConflict    => Plum;

	public static string ToRGB(string hex)
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