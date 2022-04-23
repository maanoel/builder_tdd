using BuilderTDD.Models;

namespace BuilderTDD
{
  public interface ICommandValidation
  {
    public bool Validate(Person person);
  }
}
