using System;
using Data;
using Models;

namespace ViewModels
{
    public class MainWindowViewModel 
        : BaseViewModel, IMainWindowViewModel
    {
        private readonly IModelService _modelService;
        
        public MainWindowViewModel(IModelService modelService)
        {
            _modelService = modelService ??
                throw new ArgumentNullException(nameof(modelService));
        }
        
        public override void Load()
        {
            var index = _modelService.GetIndex<NewsItem>();
        }
    }
}