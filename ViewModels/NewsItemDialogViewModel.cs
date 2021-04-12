using System;
using Data;
using Models;

namespace ViewModels
{
    public class NewsItemDialogViewModel : BaseViewModel
    {
        private IModelService _modelService;
        
        public NewsItemDialogViewModel(IModelService modelService)
        {
            _modelService = modelService ??
                throw new ArgumentNullException(nameof(modelService));
        }
        
        public void Seed(NewsItem modelObject)
        {
            ModelObject = modelObject ??
               throw new ArgumentNullException(nameof(modelObject));
        }
        
        public override void Load()
        {
            if (ModelObject == null)
            {
                ModelObject = _modelService.CreateModel<NewsItem>();
            }
        }
        
        public NewsItem ModelObject { get; private set; }
    }
}