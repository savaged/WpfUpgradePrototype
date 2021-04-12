using System;

namespace Interfaces
{
    public interface IModel
    {
        int ID { get; set; }

        string ToJson();
        
        void FromJson(string json);
    }
}