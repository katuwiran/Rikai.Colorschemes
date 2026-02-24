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
theme[main_bg]="#{Scheme.Base}"

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
theme[inactive_fg]="#{Scheme.Inactive}"

# Color of text appearing on top of graphs, i.e uptime and current network graph scaling
theme[graph_text]="#{Scheme.Red}"

# Background color of the percentage meters
theme[meter_bg]="#{Scheme.Highlight}"

# Misc colors for processes box including mini cpu graphs, details memory graph and details status text
theme[proc_misc]="#{Scheme.Red}"

# CPU, Memory, Network, Proc box outline colors
theme[cpu_box]="#{Scheme.Purple}" #Mauve
theme[mem_box]="#{Scheme.Green}" #Green
theme[net_box]="#{Scheme.Magenta}" #Maroon
theme[proc_box]="#{Scheme.Blue}" #Blue

# Box divider line and small boxes line color
theme[div_line]="#{Scheme.Inactive}"

# Temperature graph color (Green -> Yellow -> Red)
theme[temp_start]="#{Scheme.Green}"
theme[temp_mid]="#{Scheme.Yellow}"
theme[temp_end]="#{Scheme.Green}"

# CPU graph colors (Teal -> Lavender)
theme[cpu_start]="#{Scheme.Green}"
theme[cpu_mid]="#{Scheme.Cyan}"
theme[cpu_end]="#{Scheme.Purple}"

# Mem/Disk free meter (Mauve -> Lavender -> Blue)
theme[free_start]="#{Scheme.Magenta}"
theme[free_mid]="#{Scheme.Purple}"
theme[free_end]="#8caaee"

# Mem/Disk cached meter (Sapphire -> Lavender)
theme[cached_start]="#{Scheme.Cyan}"
theme[cached_mid]="#8caaee"
theme[cached_end]="#{Scheme.Purple}"

# Mem/Disk available meter (Peach -> Red)
theme[available_start]="#{Scheme.Lavender}"
theme[available_mid]="#{Scheme.Magenta}"
theme[available_end]="#{Scheme.Red}"

# Mem/Disk used meter (Green -> Sky)
theme[used_start]="#{Scheme.Green}"
theme[used_mid]="#{Scheme.Cyan}"
theme[used_end]="#{Scheme.Blue}"

# Download graph colors (Peach -> Red)
theme[download_start]="#{Scheme.Lavender}"
theme[download_mid]="#{Scheme.Magenta}"
theme[download_end]="#{Scheme.Red}"

# Upload graph colors (Green -> Sky)
theme[upload_start]="#{Scheme.Green}"
theme[upload_mid]="#{Scheme.Cyan}"
theme[upload_end]="#{Scheme.Blue}"

# Process box color gradient for threads, mem and cpu usage (Sapphire -> Mauve)
theme[process_start]="#{Scheme.Cyan}"
theme[process_mid]="#{Scheme.Purple}"
theme[process_end]="#{Scheme.Magenta}"
""";
	}
}