using System;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using ViewModels.Messages;

namespace ViewModels
{
    public class SomeMonitoringViewModel : ObservableRecipient
    {
        public SomeMonitoringViewModel()
        {
            Messenger.Register<SomeMonitoringViewModel, SomeMessage, string>(
                this, 
                nameof(MainWindowViewModel),
                (r, m) => OnTestMessage(m));
        }

        private void OnTestMessage(SomeMessage m)
        {
            Console.WriteLine(m?.Text);
        }
        
    }
}