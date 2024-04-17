namespace Persons
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persons firstPerson = new Persons();
            Persons secondPerson = new Persons();
            Persons thirdPerson = new Persons();


            firstPerson.name = "Pesho";
            firstPerson.age = 20;

            secondPerson.name = "Gosho";
            secondPerson.age = 18;

            thirdPerson.name = "Stamat";
            thirdPerson.age = 43;


            firstPerson.IntroduseYourself();

            secondPerson.IntroduseYourself();

            thirdPerson.IntroduseYourself();

        }
    }
}
