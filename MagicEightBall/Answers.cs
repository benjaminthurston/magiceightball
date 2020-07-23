using System.Text.Json.Serialization;

namespace eightball
{

    public class Answers
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("answer")]
        public string Answer { get; set; }

    }
}