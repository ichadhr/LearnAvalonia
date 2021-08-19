using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace LearnAvalonia.Pages
{
    public class FormPage : UserControl
    {
        public FormPage()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}