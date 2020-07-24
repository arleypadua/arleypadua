using Developer.Builder.Model;
using System.Collections.Generic;

namespace Developer.Builder.Builders
{
    public class CodeLanguageSetBuilder
    {
        private readonly List<ProgrammingLanguage> _list;

        public CodeLanguageSetBuilder()
        {
            _list = new List<ProgrammingLanguage>();
        }
        public IReadOnlyCollection<ProgrammingLanguage> Get()
        {
            return _list.AsReadOnly();
        }

        public CodeLanguageSetBuilder CSharp()
        {
            _list.Add(ProgrammingLanguage.CSharp);
            return this;
        }

        public CodeLanguageSetBuilder Typescript()
        {
            _list.Add(ProgrammingLanguage.TypeScript);
            return this;
        }

        public CodeLanguageSetBuilder JavaScript()
        {
            _list.Add(ProgrammingLanguage.JavaScript);
            return this;
        }
    }
}