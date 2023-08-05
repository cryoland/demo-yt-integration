namespace DemoYtIntegration
{
    public record TestClass(string? LastName, string? FirstName, string? MiddleName)
    {
        public IEnumerable<string?> GetAtomicValues()
        {
            yield return LastName;
            yield return FirstName;
            yield return MiddleName;
        }

        public string FullName
            => string.Join(" ", GetAtomicValues());
    }
}
