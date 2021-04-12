using Interfaces;
using Microsoft.Toolkit.Mvvm.ComponentModel;

namespace Models
{
    public abstract class BaseModel : ObservableObject, IModel
    {
        private int _id;

        public int ID
        {
            get => _id;
            set => SetProperty(ref _id, value);
        }

        public abstract string ToJson();

        public abstract void FromJson(string json);
    }
}