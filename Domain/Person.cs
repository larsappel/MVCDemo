using System.Text.RegularExpressions;

namespace MVCDemo.Domain;

public class Person
{
    private string _name = string.Empty;
    private DateTime _birthDate;

    public string Name
    {
        get => _name;
        private set
        {
            if (string.IsNullOrEmpty(value) || !Regex.IsMatch(value, @"^[a-zA-Z]+( [a-zA-Z]+)*$"))
            {
                throw new ArgumentException("Name must be letters only and may contain one space character between names.");
            }
            _name = value;
        }
    }

    public DateTime BirthDate
    {
        get => _birthDate;
        private set
        {
            if (value > DateTime.Now)
            {
                throw new ArgumentException("Birthdate cannot be in the future.");
            }
            _birthDate = value;
        }
    }

    public Person(string name, DateTime birthDate)
    {
        Name = name;
        BirthDate = birthDate;
    }
}

