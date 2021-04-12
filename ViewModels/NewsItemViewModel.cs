using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using Data;
using Microsoft.Toolkit.Mvvm.Input;
using Models;

namespace ViewModels
{
    public class NewsItemViewModel : BaseViewModel
    {
        private readonly IModelService _modelService;
        
        public NewsItemViewModel(IModelService modelService)
        {
            _modelService = modelService ??
                throw new ArgumentNullException(nameof(modelService));

            AddCmd = new RelayCommand(OnAdd, () => CanAdd);
            EditCmd = new RelayCommand(OnEdit, () => CanEdit);
        }
        
        public override void Load()
        {
            Index = _modelService.GetIndex<NewsItem>()?.ToList();
        }
        
        public IList<NewsItem> Index { get; private set; }
        
        public NewsItem ModelObject { get; set; }
        
        public ICommand AddCmd { get; }
        public ICommand EditCmd { get; }

        public bool CanAdd => true;
        public bool CanEdit => ModelObject != null;

        private void OnAdd()
        {
            // TODO add dialog open
        }
        
        private void OnEdit()
        {
            // TODO add dialog open
        }
    }
}