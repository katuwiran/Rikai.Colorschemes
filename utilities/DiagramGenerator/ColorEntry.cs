public class ColorEntry
{
	public required string Name    { get; set; }
	public required string HexCode { get; set; }
	public required string Index   { get; set; }

	public ColorEntry()
	{
	}

	public ColorEntry(string name, string hexCode, string index)
	{
		Name    = name;
		HexCode = hexCode;
		Index   = index;
	}

	public override string ToString()
	{
		return HexCode;
	}
}
