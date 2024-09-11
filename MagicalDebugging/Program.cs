
using MagicalDebugging;

List<Person> ListOfPerson = new List<Person>() 
{
  new Person(){ FirstName="Henry", LastName="Maske", City="Berlin", Country="DE" },
  new Person(){ FirstName="Robert", LastName="Lewandowski", City="Poznan", Country="PL" },
  new Person(){ FirstName="Manuel", LastName="Neuer", City="München", Country="DE" }
};


Console.WriteLine(ListOfPerson.Count);