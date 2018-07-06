using System;

namespace AttributeSample
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public class Author : Attribute
    {
        private string name;
        public double version;

        public Author(string name)
        {
            this.name = name;
            version = 1.0;
        }

        public string GetName()
        {
            return name;
        }
    }

    // Class with the Author attribute.  
    [Author("P. Ackerman")]
    public class FirstClass
    {
        // ...  
    }

    // Class without the Author attribute.  
    public class SecondClass
    {
        // ...  
    }

    // Class with multiple Author attributes.  
    [Author("P. Ackerman"), Author("R. Koch", version = 2.0)]
    public class ThirdClass
    {
        // ...  
    }

    class Program
    {
        static void Main(string[] args)
        {
            PrintAuthorInfo(typeof(FirstClass));
            PrintAuthorInfo(typeof(SecondClass));
            PrintAuthorInfo(typeof(ThirdClass));
        }

        private static void PrintAuthorInfo(System.Type t)
        {
            System.Console.WriteLine("Author information for {0}", t);

            // Using reflection.  
            System.Attribute[] attrs = System.Attribute.GetCustomAttributes(t);  // Reflection.  

            // Displaying output.  
            foreach (System.Attribute attr in attrs)
            {
                if (attr is Author)
                {
                    Author a = (Author)attr;
                    System.Console.WriteLine("   {0}, version {1:f}", a.GetName(), a.version);
                }
            }
        }
    }
}
