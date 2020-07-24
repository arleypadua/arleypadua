using System;

namespace Developer.Builder.Model
{
    public readonly struct FoundAt
    {
        private FoundAt(string local, string reference)
        {
            Local = local ?? throw new ArgumentNullException(nameof(local));
            Reference = reference ?? throw new ArgumentNullException(nameof(reference));
        }

        public string Local { get; }
        public string Reference { get; }

        public static FoundAt Twitter(string reference) => new FoundAt("Twitter", reference);
        public static FoundAt LinkedIn(string reference) => new FoundAt("LinkedIn", reference);
    }
}