using Developer.Builder.Model;
using System.Collections.Generic;

namespace Developer.Builder.Builders
{
    public class InterestSetBuilder
    {
        private readonly List<Interest> _list;

        public InterestSetBuilder()
        {
            _list = new List<Interest>();
        }
        public IReadOnlyCollection<Interest> Get()
        {
            return _list.AsReadOnly();
        }

        public InterestSetBuilder SoftwareArchitecture()
        {
            _list.Add(new Interest("Software Architecture"));
            return this;
        }

        public InterestSetBuilder DomainDrivenDesign()
        {
            _list.Add(new Interest("Domain Driver Design"));
            return this;
        }

        public InterestSetBuilder DistributedSystems()
        {
            _list.Add(new Interest("Distributed Systems"));
            return this;
        }

        public InterestSetBuilder ShareIdeas(string at)
        {
            _list.Add(new Interest("Share ideas", at));
            return this;
        }
    }
}