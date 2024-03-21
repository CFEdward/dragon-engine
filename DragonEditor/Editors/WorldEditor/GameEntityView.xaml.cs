using System.Windows.Controls;

namespace DragonEditor.Editors;

public partial class GameEntityView : UserControl
{
    public static GameEntityView Instance { get; private set; }
    
    public GameEntityView()
    {
        InitializeComponent();
        DataContext = null;
        Instance = this;
    }
}