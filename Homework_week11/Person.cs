using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_week11
{
    class Person
    {
        //Instance variables
        private String name;

        //Constructors
        public Person()
        {
            name = "Name";
        }
        public Person(String theName)
        {
            name = theName;
        }
        public Person(Person obj)
        {
            name = obj.name;
        }

        //Getter/Setter
        public String Name { get => name; set => name = value; }
        
        //ToString method

        public String ToString()
        {
            return String.Format("Owner: {0}", Name);
        }

        public bool Equals(object obj)
        {
            if(this == obj)
            {
                return true;
            }
            if(this == null)
            {
                return false;
            }
            if(!(obj.GetType() == typeof(Person)))
            {
                return false;
            }
            Person other = (Person)obj;
            if(name == null)
            {
                if(other.name != name)
                {
                    return false;
                }
            }
            else if(!name.Equals(other.name))
            {
                return false;
            }
            return true;
        }

    }
}
