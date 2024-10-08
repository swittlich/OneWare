namespace OneWare.UniversalFpgaProjectSystem.Fpga;

public class HardwarePin
{
    public HardwarePin(string name, string? description, string? interfacePin = null, List<HardwareConstraint>? constraints = null)
    {
        Name = name;
        Description = description;
        InterfacePin = interfacePin;
        Constraints = constraints ?? [];
    }

    public string Name { get; }
    
    public string? InterfacePin { get; }

    public string? Description { get; }
    
    public List<HardwareConstraint> Constraints { get; }
}