using Avalonia.Media;
using OneWare.UniversalFpgaProjectSystem.Models;

namespace OneWare.UniversalFpgaProjectSystem.ViewModels.FpgaGuiElements;

public class FpgaGuiElementCruviHsViewModel : FpgaGuiElementViewModelBase
{
    public HardwareInterfaceModel? InterfaceModel { get; init; }

    public FpgaGuiElementCruviHsViewModel(int x, int y) : base(x, y)
    {
    }
}