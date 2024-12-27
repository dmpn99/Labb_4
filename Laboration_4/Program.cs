namespace Laboration_4;

class Program
{
    static void Main(string[] args)
    {
        Gender gender1 = Gender.NoneBinary;
        Gender gender2 = Gender.Male;
        Hair hair1 = new Hair(45, "Svart");
        Hair hair2 = new Hair(30, "Brun");
        
        Person person1 = new Person("Fredrik", "8 Maj, 1991", "Vit", hair1, gender1);
        Person person2 = new Person("Pär", "17 September, 1999", "Svart", hair2, gender2);
        
        Console.WriteLine(person1.ToString());
        Console.WriteLine(person2.ToString());

    }
}