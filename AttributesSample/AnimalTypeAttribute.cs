using System;
using AttributesSample.Enums;

namespace AttributesSample
{
    // A custom attribute to allow a target to have a pet.
    public class AnimalTypeAttribute : Attribute
    {
        // The constructor is called when the attribute is set.
        public AnimalTypeAttribute(Animal pet)
        {
            thePet = pet;
        }

        // Keep a variable internally ...
        protected Animal thePet;

        // .. and show a copy to the outside world.
        public Animal Pet
        {
            get { return thePet; }
            set { thePet = value; }
        }
    }
}