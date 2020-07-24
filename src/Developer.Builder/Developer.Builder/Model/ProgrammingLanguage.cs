namespace Developer.Builder.Model
{
    public readonly struct ProgrammingLanguage
    {
        private ProgrammingLanguage(string name)
        {
            Name = name;
        }

        public string Name { get; }

        public static readonly ProgrammingLanguage CSharp = new ProgrammingLanguage("C#");
        public static readonly ProgrammingLanguage TypeScript = new ProgrammingLanguage("TypeScript");
        public static readonly ProgrammingLanguage JavaScript = new ProgrammingLanguage("JavaScript");
    }
}