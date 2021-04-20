using Person;

namespace Program_namespace
{
    class Program
    {
        static void Main(string[] args)
        {
            type_Person john = new type_Person("John Doe", "1.234.567-2");
            type_Person jane = new type_Person("Jane Doe", "8.765.432-7");
            john.IntroduceYourself();
            jane.IntroduceYourself();
        }

    
    }
}
