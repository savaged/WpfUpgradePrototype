using System.Collections.Generic;
using Interfaces;

namespace Data
{
    public class ModelService : IModelService
    {
        public T GetModel<T>(int id)
            where T : IModel
        {
            return default;
        }

        public IEnumerable<T> GetIndex<T>()
            where T : IModel
        {
            var index = new List<T>();
            return index;
        }

        public void StoreModel<T>(T model)
            where T : IModel
        {
            
        }
        
        public void UpdateModel<T>(T model)
            where T : IModel
        {
            
        }
        
    }
}