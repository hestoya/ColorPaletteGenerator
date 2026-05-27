using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace ColorPaletteGenerator.Components
{
    public partial class Tile
    {
        [Parameter]
        public required string Color { get; set; }

        [Parameter]
        public required string HexValue { get; set; }

        [Inject] IJSRuntime JS { get; set; } = default!;

        private string tooltipText = "Copy";

        public string Style => $"background-color: #{Color};";
    }
}
