using System.Collections.Generic;
using Interfaces;

namespace Data
{
    public interface IModelService
    {
        T GetModel<T>(int id)
            where T : IModel;

        IEnumerable<T> GetIndex<T>()
            where T : IModel, new();
        
        T CreateModel<T>()
            where T : IModel, new();

        void StoreModel<T>(T model)
            where T : IModel;

        void UpdateModel<T>(T model)
            where T : IModel;
    }
}