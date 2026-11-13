using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Styling;

namespace InscripcionEstilos;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        Title = "Inscripción · " + DateTime.Now.Year;
        CursoComboBox.SelectedIndex = 0;
        var etiqueta = new TextBlock
        {
            Text = "Formulario abierto el " + DateTime.Now.ToString("dd/MM/yyyy"),
            FontSize = 12,
            Margin = new Thickness(0, 8, 0, 0)
        };
        PanelFormulario.Children.Add(etiqueta);
    }

    private void TemaSwitch_IsCheckedChanged(object? sender, RoutedEventArgs e)
    {
        if (Application.Current is null)
            return;
        Application.Current.RequestedThemeVariant = TemaSwitch.IsChecked == true ? ThemeVariant.Dark : ThemeVariant.Light;
    }
}
