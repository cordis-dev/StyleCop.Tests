namespace Tests
{
    public record class NewPerson
    {
        public string LastName { get; }
        public string FirstName { get; }

        public NewPerson(string first, string last) => (FirstName, LastName) = (first, last);
    }
}
