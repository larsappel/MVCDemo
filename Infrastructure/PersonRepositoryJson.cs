using System.Text.Json;

using MVCDemo.Domain;

namespace MVCDemo.Infrastructure;
public class PersonRepositoryJson : IPersonRepository
{
    private readonly string _filePath = "persons.json";

    public Person GetPersonById(int id)
    {
        var persons = ReadFromFile();
        var personData = persons.Find(p => p.Id == id);

        return personData != null ? new Person(personData.Name, personData.BirthDate) : null;
    }

    private List<PersonEntityJson> ReadFromFile()
    {
        if (File.Exists(_filePath))
        {
            var json = File.ReadAllText(_filePath);
            return JsonSerializer.Deserialize<List<PersonEntityJson>>(json) ?? new List<PersonEntityJson>();
        }

        return new List<PersonEntityJson>();
    }
}

