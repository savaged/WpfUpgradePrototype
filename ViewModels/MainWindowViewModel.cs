using System.Windows.Input;
using Data;
using Microsoft.Toolkit.Mvvm.Input;
using ViewModels.Messages;

namespace ViewModels
{
    public class MainWindowViewModel 
        : BaseViewModel, IMainWindowViewModel
    {
        public MainWindowViewModel(IModelService modelService)
        {
            NewsItemViewModel = new NewsItemViewModel(modelService);

            SomeMonitoringViewModel = new SomeMonitoringViewModel();

            TestMessageCmd = new RelayCommand(OnTestMessageCmd, () => true);
        }

        public override void Load()
        {
            NewsItemViewModel.Load();
        }
        
        public NewsItemViewModel NewsItemViewModel { get; }
        
        public ICommand TestMessageCmd { get; }
        
        private void OnTestMessageCmd()
        {
            Messenger.Send(new SomeMessage("test message"), nameof(MainWindowViewModel));
        }
        
        public SomeMonitoringViewModel SomeMonitoringViewModel { get; }
        
    }
}