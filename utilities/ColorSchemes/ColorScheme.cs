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

	public required string Magenta  { get; set; }
	public required string Lavender { get; set; }
	public required string Blue     { get; set; }
	public required string Purple   { get; set; }
	public required string Cyan     { get; set; }
	public required string Green    { get; set; }
	public required string Yellow   { get; set; }
	public required string Red      { get; set; }
	public required string Orange   { get; set; }

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

	public string ConsoleWhite       => Subtle;
	public string ConsoleWhiteBright => Text;
	public string ConsoleBlack       => Surface;
	public string ConsoleBlackBright => Text;
	public string SearchHighlight    => Highlight;

	public string DiffAdded    => Green;
	public string DiffDeleted  => Magenta;
	public string DiffModified => Purple;
	public string DiffIgnored  => Subtle;
	public string DiffConflict => Lavender;
}