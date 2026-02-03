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
		this.Name    = name;
		this.HexCode = hexCode;
		this.Index   = index;
	}

	public override string ToString()
	{
		return HexCode;
	}
}