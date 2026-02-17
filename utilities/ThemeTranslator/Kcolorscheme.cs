namespace ColorschemeUtils;

public static partial class ThemeTranslator
{
	// for KDE's kcolorscheme format
	public static string KColorscheme(ColorScheme scheme)
	{
		// Base Grayscale
		const string White      = "255,255,255";
		const string OffWhite   = "245,245,245";
		const string LightGray  = "235,235,235";
		const string Gray       = "120,120,120";
		const string DarkGray   = "56,56,56";
		const string TextNormal = "36,36,36";

		// Window Manager Specific
		const string WmActiveBlend   = "86,86,86";
		const string WmActiveFg      = "66,66,66";
		const string WmInactiveBlend = "102,102,102";

		// Accents & Functional Colors
		const string AccentBlue  = "49,91,239";  // Main focus/brand color
		const string AccentLight = "74,124,239"; // Lighter selection bg
		const string HoverBlue   = "83,143,255";
		const string ActiveBlue  = "61,174,233";
		const string LinkBlue    = "41,128,185";

		// Status Colors
		const string NegativeRed   = "218,68,83";
		const string PositiveGreen = "39,174,96";
		const string NeutralOrange = "246,116,0";
		const string VisitedGray   = "127,140,141";

		// Special Contexts (Selection & Tooltips)
		const string SelectionLink  = "253,188,75"; // Yellow text on selection
		const string SelectionFgDim = "135,163,239";
		const string TooltipBg      = "33,33,33";
		const string TooltipBgAlt   = "43,43,43";
		const string TooltipText    = "222,222,222";
		
		// --------------------------------------------------------------------------------
		// 2. KCOLORSCHEME GENERATION
		// --------------------------------------------------------------------------------
		return $"""
		        [ColorEffects:Disabled]
		        Color={DarkGray}
		        ColorAmount=0
		        ColorEffect=0
		        ContrastAmount=0.65
		        ContrastEffect=1
		        IntensityAmount=0.1
		        IntensityEffect=2

		        [ColorEffects:Inactive]
		        ChangeSelectionColor=true
		        Color=112,111,110
		        ColorAmount=0.025
		        ColorEffect=2
		        ContrastAmount=0.1
		        ContrastEffect=2
		        Enable=false
		        IntensityAmount=0
		        IntensityEffect=0

		        [Colors:Button]
		        BackgroundAlternate={LightGray}
		        BackgroundNormal={OffWhite}
		        DecorationFocus={AccentBlue}
		        DecorationHover={HoverBlue}
		        ForegroundActive={ActiveBlue}
		        ForegroundInactive={Gray}
		        ForegroundLink={LinkBlue}
		        ForegroundNegative={NegativeRed}
		        ForegroundNeutral={NeutralOrange}
		        ForegroundNormal={TextNormal}
		        ForegroundPositive={PositiveGreen}
		        ForegroundVisited={VisitedGray}

		        [Colors:Complementary]
		        BackgroundAlternate=238,238,238
		        BackgroundNormal={White}
		        DecorationFocus={AccentBlue}
		        DecorationHover={HoverBlue}
		        ForegroundActive={ActiveBlue}
		        ForegroundInactive={Gray}
		        ForegroundLink={LinkBlue}
		        ForegroundNegative={NegativeRed}
		        ForegroundNeutral={NeutralOrange}
		        ForegroundNormal={TextNormal}
		        ForegroundPositive={PositiveGreen}
		        ForegroundVisited={VisitedGray}

		        [Colors:Header]
		        BackgroundAlternate=232,232,232
		        BackgroundNormal=242,242,242
		        DecorationFocus={AccentBlue}
		        DecorationHover={HoverBlue}
		        ForegroundActive={ActiveBlue}
		        ForegroundInactive={Gray}
		        ForegroundLink={LinkBlue}
		        ForegroundNegative={NegativeRed}
		        ForegroundNeutral={NeutralOrange}
		        ForegroundNormal={TextNormal}
		        ForegroundPositive={PositiveGreen}
		        ForegroundVisited={VisitedGray}

		        [Colors:Header][Inactive]
		        BackgroundAlternate=232,232,232
		        BackgroundNormal=242,242,242
		        DecorationFocus={AccentBlue},150
		        DecorationHover={HoverBlue}
		        ForegroundActive={ActiveBlue},150
		        ForegroundInactive={Gray},150
		        ForegroundLink={LinkBlue}
		        ForegroundNegative={NegativeRed}
		        ForegroundNeutral={NeutralOrange}
		        ForegroundNormal={TextNormal},150
		        ForegroundPositive={PositiveGreen}
		        ForegroundVisited={VisitedGray}

		        [Colors:Selection]
		        BackgroundAlternate={AccentLight}
		        BackgroundNormal={AccentBlue}
		        DecorationFocus={White}
		        DecorationHover={HoverBlue}
		        ForegroundActive=252,252,252
		        ForegroundInactive={SelectionFgDim}
		        ForegroundLink={SelectionLink}
		        ForegroundNegative={NegativeRed}
		        ForegroundNeutral={NeutralOrange}
		        ForegroundNormal={White}
		        ForegroundPositive={PositiveGreen}
		        ForegroundVisited=127,160,239

		        [Colors:Tooltip]
		        BackgroundAlternate={TooltipBgAlt}
		        BackgroundNormal={TooltipBg}
		        DecorationFocus={AccentBlue}
		        DecorationHover={HoverBlue}
		        ForegroundActive={ActiveBlue}
		        ForegroundInactive={Gray}
		        ForegroundLink={LinkBlue}
		        ForegroundNegative={NegativeRed}
		        ForegroundNeutral={NeutralOrange}
		        ForegroundNormal={TooltipText}
		        ForegroundPositive={PositiveGreen}
		        ForegroundVisited={VisitedGray}

		        [Colors:View]
		        BackgroundAlternate={LightGray}
		        BackgroundNormal={OffWhite}
		        DecorationFocus={AccentBlue}
		        DecorationHover={HoverBlue}
		        ForegroundActive={AccentBlue}
		        ForegroundInactive={Gray}
		        ForegroundLink={AccentBlue}
		        ForegroundNegative={NegativeRed}
		        ForegroundNeutral={NeutralOrange}
		        ForegroundNormal={TextNormal}
		        ForegroundPositive={PositiveGreen}
		        ForegroundVisited={VisitedGray}

		        [Colors:Window]
		        BackgroundAlternate=238,238,238
		        BackgroundNormal={White}
		        DecorationFocus={AccentBlue}
		        DecorationHover={HoverBlue}
		        ForegroundActive={ActiveBlue}
		        ForegroundInactive={Gray}
		        ForegroundLink={LinkBlue}
		        ForegroundNegative={NegativeRed}
		        ForegroundNeutral={NeutralOrange}
		        ForegroundNormal={TextNormal}
		        ForegroundPositive={PositiveGreen}
		        ForegroundVisited={VisitedGray}

		        [General]
		        ColorScheme={scheme.Name}
		        Name={scheme.Name}
		        shadeSortColumn=true

		        [KDE]
		        contrast=4

		        [WM]
		        activeBackground={White}
		        activeBlend={WmActiveBlend}
		        activeForeground={WmActiveFg}
		        inactiveBackground={OffWhite}
		        inactiveBlend={WmInactiveBlend}
		        inactiveForeground={Gray}
		        """;
	}
}