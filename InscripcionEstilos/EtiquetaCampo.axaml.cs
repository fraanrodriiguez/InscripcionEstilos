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
        get => TextoEtiqueta.Text ?? "";
        set => TextoEtiqueta.Text = value;
    }

    public string TextoAyuda
    {
        get => CajaTexto.Watermark ?? "";
        set => CajaTexto.Watermark = value;
    }

    public string Texto
    {
        get => CajaTexto.Text ?? "";
        set => CajaTexto.Text = value;
    }
}
