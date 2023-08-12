namespace MVCDemo.Infrastructure;

using MVCDemo.Domain;

public class PersonRepository : IPersonRepository
{
    public Person GetPersonById(int id)
    {
        return new Person("John", new DateTime(1981, 5, 12)); // Mock implementation
    }
}

