using System;
using Avalonia.Media;
using Avalonia.Media.Imaging;
using Avalonia.Platform;
using OneWare.Essentials.Services;

namespace OneWare.Studio.Desktop.ViewModels;

public class SplashWindowViewModel
{
    public IImage? SplashScreen { get; }

    public SplashWindowViewModel(IPaths paths)
    {
        SplashScreen = new Bitmap(AssetLoader.Open(new Uri("avares://OneWareStudio/Assets/Startup.jpg")));
    }
}