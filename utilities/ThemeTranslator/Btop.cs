namespace ColorschemeUtils;

public class Btop : ITheme
{
	public string      FilePath { get; set; }
	public ColorScheme Scheme   { get; set; }

	public Btop(ColorScheme colorScheme)
	{
		FilePath = $"Btop{Path.DirectorySeparatorChar}{colorScheme.Name}.theme";
		Scheme   = colorScheme;
	}

	// for Kvantum's svg format
	public override string ToString()
	{
		return
			$"""
			 # Main background, empty for terminal default, need to be empty if you want transparent background
			 theme[main_bg]="#{Scheme.Background}"

			 # Main text color
			 theme[main_fg]="#{Scheme.Text}"

			 # Title color for boxes
			 theme[title]="#{Scheme.Text}"

			 # Highlight color for keyboard shortcuts
			 theme[hi_fg]="#{Scheme.Highlight}"

			 # Background color of selected item in processes box
			 theme[selected_bg]="#{Scheme.Highlight}"

			 # Foreground color of selected item in processes box
			 theme[selected_fg]="#{Scheme.Text}"

			 # Color of inactive/disabled text
			 theme[inactive_fg]="#{Scheme.TextInactive}"

			 # Color of text appearing on top of graphs, i.e uptime and current network graph scaling
			 theme[graph_text]="#{Scheme.Error}"

			 # Background color of the percentage meters
			 theme[meter_bg]="#{Scheme.Highlight}"

			 # Misc colors for processes box including mini cpu graphs, details memory graph and details status text
			 theme[proc_misc]="#{Scheme.Error}"

			 # CPU, Memory, Network, Proc box outline colors
			 theme[cpu_box]="#{Scheme.Method}" #Mauve
			 theme[mem_box]="#{Scheme.Numeral}" #Green
			 theme[net_box]="#{Scheme.Class}" #Maroon
			 theme[proc_box]="#{Scheme.Field}" #Blue

			 # Box divider line and small boxes line color
			 theme[div_line]="#{Scheme.TextInactive}"

			 # Temperature graph color (Green -> Yellow -> Red)
			 theme[temp_start]="#{Scheme.Numeral}"
			 theme[temp_mid]="#{Scheme.Info}"
			 theme[temp_end]="#{Scheme.Numeral}"

			 # CPU graph colors (Teal -> Plum)
			 theme[cpu_start]="#{Scheme.Numeral}"
			 theme[cpu_mid]="#{Scheme.String}"
			 theme[cpu_end]="#{Scheme.Method}"

			 # Mem/Disk free meter (Mauve -> Plum -> Blue)
			 theme[free_start]="#{Scheme.Class}"
			 theme[free_mid]="#{Scheme.Method}"
			 theme[free_end]="#8caaee"

			 # Mem/Disk cached meter (Sapphire -> Plum)
			 theme[cached_start]="#{Scheme.String}"
			 theme[cached_mid]="#8caaee"
			 theme[cached_end]="#{Scheme.Method}"

			 # Mem/Disk available meter (Plum -> Red)
			 theme[available_start]="#{Scheme.Keyword}"
			 theme[available_mid]="#{Scheme.Class}"
			 theme[available_end]="#{Scheme.Error}"

			 # Mem/Disk used meter (Green -> Sky)
			 theme[used_start]="#{Scheme.Numeral}"
			 theme[used_mid]="#{Scheme.String}"
			 theme[used_end]="#{Scheme.Field}"

			 # Download graph colors (Plum -> Red)
			 theme[download_start]="#{Scheme.Keyword}"
			 theme[download_mid]="#{Scheme.Class}"
			 theme[download_end]="#{Scheme.Error}"

			 # Upload graph colors (Green -> Sky)
			 theme[upload_start]="#{Scheme.Numeral}"
			 theme[upload_mid]="#{Scheme.String}"
			 theme[upload_end]="#{Scheme.Field}"

			 # Process box color gradient for threads, mem and cpu usage (Sapphire -> Mauve)
			 theme[process_start]="#{Scheme.String}"
			 theme[process_mid]="#{Scheme.Method}"
			 theme[process_end]="#{Scheme.Class}"
			 """;
	}
}