using BuilderTDD.Models;

namespace BuilderTDD.Implementations
{
  public class AgeMoreThan18 : ICommandValidation
  {
    public bool Validate(Person person)
    {
      if (person.age > 18) return true;

      return false;
    }
  }
}
