namespace Tests.csharp8
{
    internal class VerbatimInterpolatedStrings
    {
        public void Test()
        {
            var s1 = $@"Hello\n{"A"}";
            var s2 = @$"World\n{"B"}";
            var s3 = $"{"C"}\n{"D"}";
            var s4 = @"\n";
        }
    }
}
