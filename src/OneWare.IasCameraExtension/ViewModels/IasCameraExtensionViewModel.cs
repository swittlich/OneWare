﻿using OneWare.UniversalFpgaProjectSystem.Fpga;
using OneWare.UniversalFpgaProjectSystem.Models;
using OneWare.UniversalFpgaProjectSystem.ViewModels;

namespace OneWare.IasCameraExtension.ViewModels;

public class IasCameraExtensionViewModel : ExtensionViewModelBase
{
    public IasCameraExtensionViewModel(FpgaExtensionModel fpgaExtension) : base(fpgaExtension)
    {
    }
}