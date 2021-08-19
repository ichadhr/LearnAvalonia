using System.Reactive;
using ReactiveUI;

namespace LearnAvalonia.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private bool _isMenuItemChecked;
        public MainWindowViewModel()
        {
            ToggleMenuItemCheckedCommand = ReactiveCommand.Create(() =>
            {
                IsMenuItemChecked = !IsMenuItemChecked;
            });
        }
        
        public bool IsMenuItemChecked
        {
            get => _isMenuItemChecked;
            set => this.RaiseAndSetIfChanged(ref _isMenuItemChecked, value);
        }
        
        public ReactiveCommand<Unit, Unit> ToggleMenuItemCheckedCommand { get; }
    }
}
