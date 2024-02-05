namespace Tests.csharp7
{
	public class TupleTests
	{
		private object age;
		private object age2;
		
        void Test()
        {
            // Create a tuple
            var person = ("John", 30, 35);

            // Deconstruct the tuple
            (var name, age, age2) = person;
        }
	}
}