using System.Collections.Generic;
using System.Text.Json;
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
            var sample1 = new NewsItem { ID = 1, Headline = "Sample headline 1", Story = "Sample story 1" }.ToJson();
            var sample2 = new NewsItem { ID = 2, Headline = "Sample headline 2", Story = "Sample story 2" }.ToJson();
            var t1 = new T();
            var t2 = new T();
            t1.FromJson(sample1);
            t2.FromJson(sample2);
            index.Add(t1);
            index.Add(t2);
            return index;
        }

        class NewsItem : IModel
        {
            public int ID { get; set; }
            public string Headline { get; set; }
            public string Story { get; set; }

            public string ToJson()
            {
                return JsonSerializer.Serialize(this);
            }

            public void FromJson(string json)
            {
                
            }
        }
        
    }
}