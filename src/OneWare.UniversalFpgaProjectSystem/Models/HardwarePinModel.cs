using CommunityToolkit.Mvvm.ComponentModel;
using OneWare.UniversalFpgaProjectSystem.Fpga;

namespace OneWare.UniversalFpgaProjectSystem.Models;

public class HardwarePinModel : ObservableObject
{
    private FpgaNodeModel? _connectedNode;

    private string _toolTipText;

    private bool _isSelected;

    private List<HardwareConstraintModel> _constraints;

    public HardwarePinModel(HardwarePin pin, FpgaModel fpgaModel)
    {
        Pin = pin;
        _toolTipText = "Click to connect " + Pin.Name;
        FpgaModel = fpgaModel;
        _constraints = [];
        foreach (var constraint in pin.Constraints)
        {
            _constraints.Add(new HardwareConstraintModel(constraint));
        }
    }

    public void AddConstraint(HardwareConstraintModel constraint)
    {
        _constraints.Add(constraint);
    }
    
    public HardwarePin Pin { get; }
    
    public FpgaModel FpgaModel { get; }

    public string ToolTipText
    {
        get => _toolTipText;
        set => SetProperty(ref _toolTipText, value);
    }

    public bool IsSelected
    {
        get => _isSelected;
        set => SetProperty(ref _isSelected, value);
    }
    
    public FpgaNodeModel? ConnectedNode
    {
        get => _connectedNode;
        set
        {
            SetProperty(ref _connectedNode, value);
            if (_connectedNode == null) ToolTipText = "Click to connect " + Pin.Name;
            else ToolTipText = Pin.Name + " is connected with " + _connectedNode.Node.Name;
        }
    }

    public override string ToString()
    {
        return ConnectedNode is null ? Pin.Name : $"{Pin.Name} <-> {ConnectedNode.Node.Name}";
    }
}