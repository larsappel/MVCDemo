namespace MVCDemo.ApplicationServices;
using MVCDemo.Domain;

public class PersonService : IPersonService
{
    private readonly IPersonRepository _personRepository;

    public PersonService(IPersonRepository personRepository)
    {
        _personRepository = personRepository;
    }

    public PersonDTO GetPerson()
    {
        // Get a Person object from the repository
        var person = _personRepository.GetPersonById(1);
        return new PersonDTO
        {
            Name = person.Name,
            BirthDate = person.BirthDate
        };

        // // Return a mock PersonDTO object
        // return new PersonDTO
        // {
        //     Name = "JohnDoe",
        //     Age = 44
        // };
    }
}
