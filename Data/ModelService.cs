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
            where T : IModel, new()
        {
            return SampleData<T>();
        }

        public T CreateModel<T>()
            where T : IModel, new()
        {
            return new T();
        }

        public void StoreModel<T>(T model)
            where T : IModel
        {
            
        }
        
        public void UpdateModel<T>(T model)
            where T : IModel
        {
            
        }

        private IList<T> SampleData<T>()
            where T: IModel, new()
        {
            var index = new List<T>();
            //var sample = new NewsItem { Headline = "Sample headline 1", Story = "Sample story 1" };
            return index;
        }
        
    }
}