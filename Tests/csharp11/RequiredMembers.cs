namespace Tests.csharp11
{
    class RequiredAsClassParam
    {
        public RequiredAsClassParam(string featured, string required)
        {
            Featured = featured;
            Required = required;
        }

        public string Featured { get; protected set; }
        public string Required { get; protected set; }
    }

    internal class RequiredMembers
    {
        public required string Prop1 { get; set; }
        public required string Field1 = null;
    }
}
