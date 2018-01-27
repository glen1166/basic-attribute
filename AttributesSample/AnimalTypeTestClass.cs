using System;
using AttributesSample.Enums;

namespace AttributesSample
{
    // A test class where each method has its own pet.
    public class AnimalTypeTestClass
    {
        [AnimalType(Animal.Dog)]
        public void DogMethod() { }

        [AnimalType(Animal.Cat)]
        public void CatMethod() { }

        [AnimalType(Animal.Bird)]
        public void BirdMethod() { }
    }
}