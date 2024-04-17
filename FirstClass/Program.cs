namespace FirstClass
{
    internal class Program
    {
        static void Main()
        {
            Dog dog1 = new Dog();
            Dog pumiar4e = new Dog();

            dog1.name = "Sara";
            dog1.breed = "Golden Retriever";
            dog1.age = 2;
            dog1.weight = 6.78;

            dog1.CanBark();

            pumiar4e.name = "Cezar";
            pumiar4e.breed = "uli4naPrevazhodna";
            pumiar4e.age = 6;

            pumiar4e.CanBark();

        }
    }
}
