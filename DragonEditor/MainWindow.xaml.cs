using System.ComponentModel;
using System.IO;
using System.Windows;
using DragonEditor.GameProject;

namespace DragonEditor;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public static string DragonPath { get; private set; } = @"G:\repositories\Dragon Engine\Dragon";

    public MainWindow()
    {
        InitializeComponent();
        Loaded += OnMainWindowLoaded;
        Closing += OnMainWindowClosing;
    }

    private void OnMainWindowLoaded(object sender, RoutedEventArgs e)
    {
        Loaded -= OnMainWindowLoaded;
        GetEnginePath();
        OpenProjectBrowserDialog();
    }

    private void GetEnginePath()
    {
        var dragonPath = Environment.GetEnvironmentVariable("DRAGON_ENGINE", EnvironmentVariableTarget.User);
        if (dragonPath == null || !Directory.Exists(Path.Combine(dragonPath, @"Engine\EngineAPI")))
        {
            var dlg = new EnginePathDialog();
            if (dlg.ShowDialog() == true)
            {
                DragonPath = dlg.DragonPath;
                Environment.SetEnvironmentVariable("DRAGON_ENGINE", DragonPath.ToUpper(), EnvironmentVariableTarget.User);
            }
            else
            {
                Application.Current.Shutdown();
            }
        }
        else
        {
            DragonPath = dragonPath;
        }
    }

    private void OnMainWindowClosing(object sender, CancelEventArgs e)
    {
        Closing -= OnMainWindowClosing;
        Project.Current?.Unload();
    }

    private void OpenProjectBrowserDialog()
    {
        var projectBrowser = new ProjectBrowserDialog();
        if (projectBrowser.ShowDialog() == false || projectBrowser.DataContext == null)
        {
            Application.Current.Shutdown();
        }
        else
        {
            Project.Current?.Unload();
            DataContext = projectBrowser.DataContext;
        }
    }
}