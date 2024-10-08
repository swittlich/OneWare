using OneWare.UniversalFpgaProjectSystem.Fpga;

namespace OneWare.UniversalFpgaProjectSystem.Models;

public class HardwareConstraintModel
{
    public HardwareConstraintModel(HardwareConstraint constraint)
    {
        Constraint = constraint;
    }

    public HardwareConstraint Constraint { get; set; }
}