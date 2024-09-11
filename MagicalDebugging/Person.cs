using System.Diagnostics;

namespace MagicalDebugging
{

  [DebuggerDisplay("Full name: {FullName} City: {City} Country: {Country}")]
  public class Person
  {
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public string? FullName { get => $"{LastName} {FirstName}"; }
    public string? City { get; set; }
    public string? Country { get; set; }
  }
}
