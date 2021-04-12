using System.Text.Json;

namespace Models
{
    public class NewsItem : BaseModel
    {
        private string _headline;
        private string _story;

        public string Headline
        {
            get => _headline;
            set => SetProperty(ref _headline, value);
        }

        public string Story
        {
            get => _story;
            set => SetProperty(ref _story, value);
        }

        public override string ToJson()
        {
            return JsonSerializer.Serialize(this);
        }

        public override void FromJson(string json)
        {
            var newSelf = JsonSerializer.Deserialize<NewsItem>(json);
            if (newSelf == null) return;
            ID = newSelf.ID;
            Headline = newSelf.Headline;
            Story = newSelf.Story;
        }
    }
}