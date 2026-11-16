using Avalonia.Controls;

namespace InscripcionEstilos;

public partial class EtiquetaCampo : UserControl
{
    public EtiquetaCampo()
    {
        InitializeComponent();
    }

    public string Titulo
    {
        get => Label.Text ?? "";
        set => Label.Text = value;
    }

    public string TextoAyuda
    {
        get => Input.PlaceholderText ?? "";
        set => Input.PlaceholderText = value;
    }
}
