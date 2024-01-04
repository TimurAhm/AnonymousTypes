internal class Program
{
    private static void Main(string[] args)
    {

        var o1 = new { Name = "Jeff", Year = 1996 };
        Console.WriteLine($"{ o1.Name} из {o1.Year}");


        var people = new[]
        {
            o1,
            new { Name = "Kristin", Year = 1970 },
            new { Name = "Timur", Year = 2003 },
            new { Name = "Grant", Year = 2008},
        };

        foreach (var person in people)
        {
            Console.WriteLine($"{person.Name} {person.Year.ToString()}");
        }
    }

    // анонимный тип - олицетворение инкапсуляции
    // так нызываемая "одноразовая функция"
}