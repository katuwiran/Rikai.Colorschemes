namespace Rikai.Colorschemes;

public class SourceGit : ITheme
{
	public string      FilePath { get; set; }
	public ColorScheme Scheme   { get; set; }

	public SourceGit(ColorScheme scheme)
	{
		FilePath = Path.Combine("SourceGit", $"{scheme.Name}.json");
		Scheme   = scheme;
	}

	public override string ToString()
	{
		return
			$$"""
			  {
			    "BasicColors": {
			      "Window": "#{{Scheme.Colors.Background}}",
			      "WindowBorder": "#{{Scheme.Colors.BackgroundEdges}}",
			      "TitleBar": "#{{Scheme.Colors.Background}}",
			      "ToolBar": "#{{Scheme.Colors.Background}}",
			      "Popup": "#{{Scheme.Colors.Background}}",
			      "Contents": "#{{Scheme.Colors.Background}}",

			      "Badge": "#{{Scheme.Colors.Keyword}}",
			      "BadgeFG": "#{{Scheme.Colors.Background}}",
			      "Conflict": "#{{Scheme.Diff.Conflict}}",
			      "Conflict.Foreground": "#{{Scheme.Colors.Background}}",

			      "Border0": "#{{Scheme.Colors.BackgroundEdges}}",
			      "Border1": "#{{Scheme.Colors.BackgroundOverlay}}",
			      "Border2": "#{{Scheme.Colors.TextHidden}}",

			      "FlatButton.Background": "#{{Scheme.Colors.BackgroundEdges}}",
			      "FlatButton.BackgroundHovered": "#{{Scheme.Ui.HoverBackground}}",

			      "FG1": "#{{Scheme.Colors.Text}}",
			      "FG2": "#{{Scheme.Colors.TextFaded}}",

			      "Diff.EmptyBG": "#{{Scheme.Colors.Background}}",

			      "Diff.AddedBG": "#{{Scheme.Diff.AddedBackground}}",
			      "Diff.AddedHighlight": "#{{Scheme.Diff.AddedHighlight}}",

			      "Diff.DeletedBG": "#{{Scheme.Diff.DeletedBackground}}",
			      "Diff.DeletedHighlight": "#{{Scheme.Diff.DeletedHighlight}}",

			      "SystemAccentColor": "#{{Scheme.Colors.Keyword}}",
			      "Link": "#{{Scheme.Colors.Field}}"
			    },

			    "GraphPenThickness": 2,
			    "OpacityForNotMergedCommits": 0.5,

			    "GraphColors": [
			      "#{{Scheme.Colors.Class}}",
			      "#{{Scheme.Colors.Method}}",
			      "#{{Scheme.Colors.Keyword}}",
			      "#{{Scheme.Colors.Field}}",
			      "#{{Scheme.Colors.String}}",
			      "#{{Scheme.Colors.Warning}}"
			    ]
			  }
			  """;
	}
}