using Microsoft.JSInterop;

namespace ColorPaletteGenerator.Components
{
    public partial class Tile
    {
        private async Task CopyColorToClipboard()
        {
            await JS.InvokeVoidAsync("navigator.clipboard.writeText", HexValue);

            tooltipText = "Copied!";
            StateHasChanged();

            await Task.Delay(1200);

            tooltipText = "Copy";
            StateHasChanged();
        }
    }
}
