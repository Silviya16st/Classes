using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Family
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //Persons chovek = new Persons();
           // chovek.Age = -15;
           // chovek.Name = "Silviya";
           // chovek.IntroduseYourself();

           // List<Persons> group2 = new List<Persons>();
           
            
           // int index = 0; 
           // while (true)
           // {
           //     Persons person = new Persons();
           //     Console.WriteLine($"Vavedi imeto na {index} chovek: ");
           //     person.Name =Console.ReadLine();
               
           //     Console.WriteLine($"Vavedi imeto na {index} chovek: ");
           //    person.Age= int.Parse(Console.ReadLine());

           //     group2.Add(person);
           //     Console.WriteLine("Do you want more? ");

           // }

                //create a family
            Family myFamily = new Family();

            myFamily.FamilyName = "Stefanovi";

            Console.Write("Input count of family members: ");
            int counMembers = int.Parse(Console.ReadLine());

            for (int i = 0 ; i < myFamily.Members.Count-1; i++)
            {
                for (int j = 0 ; j < myFamily.Members.Count;)
                {
                    if (myFamily.Members[j].Age > myFamily.Members[j+1].Age)
                    {
                        Person temp = myFamily.Members[j];
                        myFamily.Members[j] = myFamily.Members[j+1];
                        myFamily.Members[j+1] = temp;
                    }
                }
            }


            for(int i = 0; i < counMembers; i++)
            {
                Console.WriteLine($"Vavedi {i + 1} person: ");
                
                Person currentPerson = new Person();   
                
                Console.Write("Input name: ");
                currentPerson.Name = Console.ReadLine();

                Console.Write("Input age: ");
                currentPerson.Age = int.Parse(Console.ReadLine());

                myFamily.Members.Add(currentPerson);

            }
            //pechatane na cqloto semeistvocw  
            myFamily.PrintAll();

            myFamily.PrintYoungest();

            int sum = myFamily.Sum();
            Console.WriteLine(myFamily.Sum);
            Console.WriteLine($"The sum of all ages is {sum}");


        }
    }
}
