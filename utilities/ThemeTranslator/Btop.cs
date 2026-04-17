namespace Rikai.Colorschemes;

public class Btop : ITheme
{
	public string      FilePath { get; set; }
	public ColorScheme Scheme   { get; set; }

	public Btop(ColorScheme scheme)
	{
		FilePath = Path.Combine("Btop", $"{scheme.Name}.theme");
		Scheme   = scheme;
	}

	// for Kvantum's svg format
	public override string ToString()
	{
		return
			$"""
			# Main background, empty for terminal default, need to be empty if you want transparent background
			theme[main_bg]="#{Scheme.Colors.Background}"

			# Main text color
			theme[main_fg]="#{Scheme.Colors.Text}"

			# Title color for boxes
			theme[title]="#{Scheme.Colors.Text}"

			# Highlight color for keyboard shortcuts
			theme[hi_fg]="#{Scheme.Colors.Highlight}"

			# Background color of selected item in processes box
			theme[selected_bg]="#{Scheme.Colors.Highlight}"

			# Foreground color of selected item in processes box
			theme[selected_fg]="#{Scheme.Colors.Text}"

			# Color of inactive/disabled text
			theme[inactive_fg]="#{Scheme.Colors.TextInactive}"

			# Color of text appearing on top of graphs, i.e uptime and current network graph scaling
			theme[graph_text]="#{Scheme.Colors.Error}"

			# Background color of the percentage meters
			theme[meter_bg]="#{Scheme.Colors.Highlight}"

			# Misc colors for processes box including mini cpu graphs, details memory graph and details status text
			theme[proc_misc]="#{Scheme.Colors.Error}"

			# CPU, Memory, Network, Proc box outline colors
			theme[cpu_box]="#{Scheme.Colors.Method}" #Mauve
			theme[mem_box]="#{Scheme.Colors.Numeral}" #Green
			theme[net_box]="#{Scheme.Colors.Class}" #Maroon
			theme[proc_box]="#{Scheme.Colors.Field}" #Blue

			# Box divider line and small boxes line color
			theme[div_line]="#{Scheme.Colors.TextInactive}"

			# Temperature graph color (Green -> Yellow -> Red)
			theme[temp_start]="#{Scheme.Colors.Numeral}"
			theme[temp_mid]="#{Scheme.Colors.Info}"
			theme[temp_end]="#{Scheme.Colors.Numeral}"

			# CPU graph colors (Teal -> Plum)
			theme[cpu_start]="#{Scheme.Colors.Numeral}"
			theme[cpu_mid]="#{Scheme.Colors.String}"
			theme[cpu_end]="#{Scheme.Colors.Method}"

			# Mem/Disk free meter (Mauve -> Plum -> Blue)
			theme[free_start]="#{Scheme.Colors.Class}"
			theme[free_mid]="#{Scheme.Colors.Method}"
			theme[free_end]="#8caaee"

			# Mem/Disk cached meter (Sapphire -> Plum)
			theme[cached_start]="#{Scheme.Colors.String}"
			theme[cached_mid]="#8caaee"
			theme[cached_end]="#{Scheme.Colors.Method}"

			# Mem/Disk available meter (Plum -> Red)
			theme[available_start]="#{Scheme.Colors.Keyword}"
			theme[available_mid]="#{Scheme.Colors.Class}"
			theme[available_end]="#{Scheme.Colors.Error}"

			# Mem/Disk used meter (Green -> Sky)
			theme[used_start]="#{Scheme.Colors.Numeral}"
			theme[used_mid]="#{Scheme.Colors.String}"
			theme[used_end]="#{Scheme.Colors.Field}"

			# Download graph colors (Plum -> Red)
			theme[download_start]="#{Scheme.Colors.Keyword}"
			theme[download_mid]="#{Scheme.Colors.Class}"
			theme[download_end]="#{Scheme.Colors.Error}"

			# Upload graph colors (Green -> Sky)
			theme[upload_start]="#{Scheme.Colors.Numeral}"
			theme[upload_mid]="#{Scheme.Colors.String}"
			theme[upload_end]="#{Scheme.Colors.Field}"

			# Process box color gradient for threads, mem and cpu usage (Sapphire -> Mauve)
			theme[process_start]="#{Scheme.Colors.String}"
			theme[process_mid]="#{Scheme.Colors.Method}"
			theme[process_end]="#{Scheme.Colors.Class}"
			""";
	}
}
