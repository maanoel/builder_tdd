using BuilderTDD.Implementations;
using BuilderTDD.Models;
using Xunit;

namespace TestProject1
{
  public class UnitTest1
  {
    [Fact]
    public void TestMethod1()
    {
      Person person = new Person();
      person.age = 12;
      person.name = "vitor brito";
      person.oz = 5;

      PersonValidatorBuilder personBuilderValidator = new PersonValidatorBuilder();
      personBuilderValidator.AddPerson(person);

      personBuilderValidator.AddValidation(new AgeMoreThan18());

      PersonValidator personValidator = personBuilderValidator.Builder();

      Assert.True(!personValidator.IsValid);

    }
  }
}