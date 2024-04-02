using System.Windows;

namespace DragonEditor.Utilities.Controls;

class ScalarBox : NumberBox
{
    static ScalarBox()
    {
        DefaultStyleKeyProperty.OverrideMetadata(typeof(ScalarBox), new FrameworkPropertyMetadata(typeof(ScalarBox)));
    }
}