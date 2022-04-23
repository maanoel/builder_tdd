using System;

namespace BuilderTDD.Models
{
  public class PersonValidator
  {
    public bool IsValid { get; private set; }

    public PersonValidator(bool value)
    {
      this.IsValid = value;
    }
  }
}
