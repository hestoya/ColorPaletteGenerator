using System.Diagnostics;

namespace ColorPaletteGenerator.Components.Pages
{
    public partial class Error
    {
        protected override void OnInitialized() => RequestId = Activity.Current?.Id ?? HttpContext?.TraceIdentifier;
    }
}
