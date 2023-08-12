namespace MVCDemo.Infrastructure;

using MVCDemo.Domain;

public class PersonRepository : IPersonRepository
{
    public Person GetPersonById(int id)
    {
        return new Person("John", 42); // Mock implementation
    }
}

