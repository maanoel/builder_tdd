using System.Collections.Generic;

namespace BuilderTDD.Models
{
  public class PersonValidatorBuilder
  {
    public Person Person { get; private set; }
    public List<ICommandValidation> CommandList { get; private set; }

    public PersonValidatorBuilder()
    {
      CommandList = new List<ICommandValidation>();
    }

    public PersonValidatorBuilder AddPerson(Person person)
    {
      Person = person;
      return this;
    }

    public PersonValidatorBuilder AddValidation(ICommandValidation commandValidation)
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
