﻿using OneWare.IceBreaker.Views;
using OneWare.UniversalFpgaProjectSystem.Services;
using Prism.Ioc;
using Prism.Modularity;

namespace OneWare.IceBreaker;

public class IceBreakerModule : IModule
{
    public void RegisterTypes(IContainerRegistry containerRegistry)
    {
        
    }

    public void OnInitialized(IContainerProvider containerProvider)
    {
        containerProvider.Resolve<FpgaService>().AddFpga(new IceBreakerFpga());
    }
}