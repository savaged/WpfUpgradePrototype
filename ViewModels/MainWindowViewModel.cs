using Data;

namespace ViewModels
{
    public class MainWindowViewModel 
        : BaseViewModel, IMainWindowViewModel
    {
        public MainWindowViewModel(IModelService modelService)
        {
            NewsItemViewModel = new NewsItemViewModel(modelService);
        }
        
        public override void Load()
        {
            NewsItemViewModel.Load();
        }
        
        public NewsItemViewModel NewsItemViewModel { get; }
        
    }
}