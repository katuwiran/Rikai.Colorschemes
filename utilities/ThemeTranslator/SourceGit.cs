namespace ColorschemeUtils;

public class SourceGit : ITheme
{
	public string      FilePath { get; set; }
	public ColorScheme Scheme   { get; set; }

	public SourceGit(ColorScheme colorScheme)
	{
		FilePath = $"SourceGit{Path.DirectorySeparatorChar}{colorScheme.Name}.json";
		Scheme   = colorScheme;
	}

	public override string ToString()
	{
		return
			$$"""
			  {
			    "BasicColors": {
			      "Window": "#{{Scheme.Background}}",
			      "WindowBorder": "#{{Scheme.BackgroundEdges}}",
			      "TitleBar": "#{{Scheme.Background}}",
			      "ToolBar": "#{{Scheme.Background}}",
			      "Popup": "#{{Scheme.Background}}",
			      "Contents": "#{{Scheme.Background}}",

			      "Badge": "#{{Scheme.Keyword}}",
			      "BadgeFG": "#{{Scheme.Background}}",
			      "Conflict": "#{{Scheme.DiffConflict}}",
			      "Conflict.Foreground": "#{{Scheme.Background}}",

			      "Border0": "#{{Scheme.BackgroundEdges}}",
			      "Border1": "#{{Scheme.HoverBackground}}",
			      "Border2": "#{{Scheme.BackgroundOverlay}}",

			      "FlatButton.Background": "#{{Scheme.BackgroundEdges}}",
			      "FlatButton.BackgroundHovered": "#{{Scheme.HoverBackground}}",

			      "FG1": "#{{Scheme.Text}}",
			      "FG2": "#{{Scheme.TextFaded}}",

			      "Diff.EmptyBG": "#{{Scheme.Background}}",

			      "Diff.AddedBG": "#{{Scheme.DiffAddedBackground}}",
			      "Diff.AddedHighlight": "#{{Scheme.DiffAddedHighlight}}",

			      "Diff.DeletedBG": "#{{Scheme.DiffDeletedBackground}}",
			      "Diff.DeletedHighlight": "#{{Scheme.DiffDeletedHighlight}}",

			      "SystemAccentColor": "#{{Scheme.Keyword}}",
			      "Link": "#{{Scheme.Field}}"
			    },

			    "GraphPenThickness": 2,
			    "OpacityForNotMergedCommits": 0.5,

			    "GraphColors": [
			      "#{{Scheme.Class}}",
			      "#{{Scheme.Method}}",
			      "#{{Scheme.Keyword}}",
			      "#{{Scheme.Field}}",
			      "#{{Scheme.String}}",
			      "#{{Scheme.Warning}}"
			    ]
			  }
			  """;
	}
}