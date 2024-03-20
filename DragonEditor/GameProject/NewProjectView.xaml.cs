using System.Windows;
using System.Windows.Controls;

namespace DragonEditor.GameProject;

public partial class NewProjectView : UserControl
{
    public NewProjectView()
    {
        InitializeComponent();
    }

    private void OnCreate_Button_Click(object sender, RoutedEventArgs e)
    {
        var vm = DataContext as NewProject;
        var projectPath = vm.CreateProject(templateListBox.SelectedItem as ProjectTemplate);
        bool dialogResult = false;
        var win = Window.GetWindow(this);
        if (!string.IsNullOrEmpty(projectPath))
        {
            dialogResult = true;
        }

        win.DialogResult = dialogResult;
        win.Close();
    }
}