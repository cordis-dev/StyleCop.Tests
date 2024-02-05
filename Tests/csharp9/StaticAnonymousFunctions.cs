using System.Collections.Generic;

namespace Tests.csharp9
{
    internal class StaticAnonymousFunctions
    {
        void Test()
        {
            List<int> numbers = new List<int>();
            var filteredNumbers = numbers.Where(static number => number > 5).ToList();
        }
    }
}
