using System.Collections.Generic;
using Developers.Builder.Model;

namespace Developers.Builder.Builders
{
    public class FoundAtBuilder
    {
        private readonly List<FoundAt> _list;

        public FoundAtBuilder()
        {
            _list = new List<FoundAt>();
        }
        public IReadOnlyCollection<FoundAt> Get()
        {
            return _list.AsReadOnly();
        }

        public FoundAtBuilder Twitter(string reference)
        {
            _list.Add(FoundAt.Twitter(reference));
            return this;
        }

        public FoundAtBuilder LinkedIn(string reference)
        {
            _list.Add(FoundAt.LinkedIn(reference));
            return this;
        }
    }
}