namespace Tests.csharp9
{
    // https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/csharp-9.0/nullable-reference-types-specification#the-null-forgiving-operator
    internal class NullableReferenceTypes
    {
        public void Test()
        {
            SomeClass expr = null;
            var v = expr!;
            expr!.M();
        }

        class SomeClass
        {
            public void M() { }
        }
    }
}
