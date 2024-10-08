namespace OneWare.UniversalFpgaProjectSystem.Fpga;

public class HardwareConstraint
{
    public HardwareConstraint(string name, List<string> values, string? description)
    {
        Name = name;
        Values = values;
        Description = description;
        CurrentValue = "";
    }

    public string Name { get; set; }
    public string CurrentValue { get; set; }

    public List<string> Values { get; set; }

    public string? Description { get; set; }
}