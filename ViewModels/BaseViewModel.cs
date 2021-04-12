using System;
using Microsoft.Toolkit.Mvvm.ComponentModel;

namespace ViewModels
{
    public abstract class BaseViewModel : ObservableRecipient
    {
        public abstract void Load();
        
    }
}