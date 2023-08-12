using System.Text.Json.Serialization;

namespace MVCDemo.Infrastructure;
public class PersonEntityJson
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("age")]
    public int Age { get; set; }
}
