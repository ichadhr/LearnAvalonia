using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using LearnAvalonia.ViewModels;

namespace LearnAvalonia.Pages
{
    public class OverviewPage : UserControl
    {
        public OverviewPage()
        {
            InitializeComponent();
            DataContext = new OverviewPageViewModel();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}