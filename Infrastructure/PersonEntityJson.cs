using System.Text.Json.Serialization;

namespace MVCDemo.Infrastructure;
public class PersonEntityJson
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("birth_date")]
    public DateTime BirthDate { get; set; }

}
