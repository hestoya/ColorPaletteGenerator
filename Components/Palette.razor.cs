namespace ColorPaletteGenerator.Components
{
    public partial class Palette
    {
        public required string Color1 { get; set; }
        public required string Color2 { get; set; }
        public required string Color3 { get; set; }
        public required string Color4 { get; set; }
        public required string Color5 { get; set; }
        public required string Color6 { get; set; }
        public required string Color7 { get; set; }
        public required string Color8 { get; set; }

        public string Color1Hex => $"#{Color1}";
        public string Color2Hex => $"#{Color2}";
        public string Color3Hex => $"#{Color3}";
        public string Color4Hex => $"#{Color4}";
        public string Color5Hex => $"#{Color5}";
        public string Color6Hex => $"#{Color6}";
        public string Color7Hex => $"#{Color7}";
        public string Color8Hex => $"#{Color8}";
    }
}
