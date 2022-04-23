using System.Collections.Generic;

namespace BuilderTDD.Models
{
  public class PersonBuilderValidator
  {
    public Person Person { get; private set; }
    public List<ICommandValidation> CommandList { get; private set; }

    public PersonBuilderValidator()
    {
      CommandList = new List<ICommandValidation>();
    }

    public PersonBuilderValidator AddPerson(Person person)
    {
      Person = person;
      return this;
    }

    public PersonBuilderValidator AddValidation(ICommandValidation commandValidation)
    {
      CommandList.Add(commandValidation);
      return this;
    }

    public PersonValidator Builder()
    {
      foreach (var validation in CommandList)
      {
        if (!validation.Validate(Person))
          return new PersonValidator(false);
      }

      return new PersonValidator(true);
    }
  }
}
