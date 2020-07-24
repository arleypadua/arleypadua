namespace Developers.Builder.Model
{
    public readonly struct Interest
    {
        public Interest(string name, string details = null)
        {
            Name = name;
            Details = details;
        }

        public string Name { get; }
        public string Details { get; }
    }
}