namespace ColorPaletteGenerator.Components
{
    public partial class Palette
    {
        public void GeneratePalette()
        {
            Color1 = GenerateColor();
            Color2 = GenerateColor();
            Color3 = GenerateColor();
            Color4 = GenerateColor();
            Color5 = GenerateColor();
            Color6 = GenerateColor();
            Color7 = GenerateColor();
            Color8 = GenerateColor();
        }

        public string GenerateColor()
        {
            var random = new Random();

            var r = random.Next(0, 256);
            var g = random.Next(0, 256);
            var b = random.Next(0, 256);

            return $"{r:X2}{g:X2}{b:X2}";
        }
    }
}
