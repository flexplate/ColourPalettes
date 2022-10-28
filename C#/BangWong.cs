using System.Drawing;

namespace ColourPalettes
{
    /// <summary>
    /// Colourblind-safe palette based on the work of Bang Wong (@bangwong on Twitter).
    /// For more information, see:
    /// Wong, B. Points of view: Color blindness. Nat Methods 8, 441 (2011). https://doi.org/10.1038/nmeth.1618
    /// </summary>
    /// <remarks>These colours can be distinguished by users with protanopia and deuteranopia.</remarks>
    public static class BangWong
    {
        public static readonly Color Black = Color.FromArgb(0, 0, 0);
        public static readonly Color Orange = Color.FromArgb(230, 159, 0);
        public static readonly Color SkyBlue = Color.FromArgb(86, 180, 233);
        public static readonly Color BluishGreen = Color.FromArgb(0, 158, 115);
        public static readonly Color Yellow = Color.FromArgb(240, 228, 66);
        public static readonly Color Blue = Color.FromArgb(0, 114, 178);
        public static readonly Color Vermillion = Color.FromArgb(213, 94, 0);
        public static readonly Color ReddishPurple = Color.FromArgb(204, 121, 167);
    }
}
