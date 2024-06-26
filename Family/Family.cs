﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Family
{
    public class Family
    {
        private string familyName;

        public string FamilyName
        {
            get { return familyName; }
            set { familyName = value; }
        }

        private List<Person> members = new List<Person>();
        public List<Person> Members
        {
            get
            {
                return members;
            }
            set
            {
                members = value;
            }
        }
        
           
        public void PrintAll()
        {
            Console.WriteLine($"Family: {this.FamilyName}");
            foreach( Person item in this.Members )
            {
                item.IntroduseYourself();
            }
        }
         
        public void PrintYoungest()
        {
            Person young = new Person();
            int minAge = int.MaxValue;
            foreach(Person item in this.Members)
            {
                if ( item.Age < minAge )
                {
                   minAge = item.Age;
                    young = item;
                }
            }
            Console.WriteLine("The youngest is: ");
            young.IntroduseYourself();
        }

        public void PrintOldest()
        {
            Person young = new Person();
            int minAge = 0;
            foreach (Person item in this.Members)
            {
                if (item.Age > minAge)
                {
                    minAge = item.Age;
                    young = item;
                }
            }
            Console.WriteLine("The youngest is: ");
            young.IntroduseYourself();
        }

        public int Sum()
        {
            int sum = 0;
            foreach(Person item in this.Members)
            {
                sum = sum + item.Age;
            }
            return sum;
        }
    }
}
