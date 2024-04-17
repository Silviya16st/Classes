using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons
{
    public class Persons
    {
        public string name;
        public int age;


        public void IntroduseYourself()
        {
            Console.WriteLine($"{this.name} {this.age}");        
        }

        public void CanSleep()
        {
            Console.WriteLine("Zzz--ZzZ-zZz");
        }

        public void CantSleep()
        {
            Console.WriteLine("is dead");
        }

        public void CanEat()
        {
            Console.WriteLine("is eating");
        }


    }

}
