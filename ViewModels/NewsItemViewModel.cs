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
        private IList<NewsItem> _index;
        private NewsItem _modelObject;
        
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

        public IList<NewsItem> Index
        {
            get => _index; 
            private set => SetProperty(ref _index, value);
        }

        public NewsItem ModelObject
        {
            get => _modelObject;
            set => SetProperty(ref _modelObject, value);
        }

        public ICommand AddCmd { get; }
        public ICommand EditCmd { get; }

        public bool CanAdd => true;
        public bool CanEdit => ModelObject?.ID > 0;

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