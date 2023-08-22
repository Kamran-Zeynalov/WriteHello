namespace ContryLanuages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FrenchPerson frenchPerson = new();
            frenchPerson.Speak();

            SpanishPerson spanishPerson = new();
            spanishPerson.Speak();

            RussianPerson russianPerson = new();
            russianPerson.Speak();
        }
    }
}