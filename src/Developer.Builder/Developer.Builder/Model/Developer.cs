using System;
using System.Collections.Generic;
using Developer.Builder.Builders;

namespace Developer.Builder.Model
{
    public class Developer
    {
        private Developer()
        {
            ProgrammingLanguages = Array.Empty<ProgrammingLanguage>();
            Interests = Array.Empty<Interest>();
            FoundAt = Array.Empty<FoundAt>();
        }

        public bool IsMarried { get; private set; }
        public Musician MusicianInfo { get; private set; }
        public CountryYearStamp Born { get; private set; }
        public CountryYearStamp Lives { get; private set; }

        public IReadOnlyCollection<ProgrammingLanguage> ProgrammingLanguages { get; private set; }
        public IReadOnlyCollection<Interest> Interests { get; set; }
        public IReadOnlyCollection<FoundAt> FoundAt { get; set; }

        public static Developer Married()
        {
            return new Developer
            {
                IsMarried = true
            };
        }

        public static Developer Single()
        {
            return new Developer
            {
                IsMarried = false
            };
        }

        public Developer Musician(string instrument, Musician.Level level)
        {
            MusicianInfo = new Musician(instrument, level);
            return this;
        }

        public Developer BornIn(Countries country, int year)
        {
            Born = new CountryYearStamp(country, year);
            return this;
        }

        public Developer LivesIn(Countries country, int since)
        {
            Lives = new CountryYearStamp(country, since);
            return this;
        }

        public Developer CodesIn(Func<CodeLanguageSetBuilder, CodeLanguageSetBuilder> languages)
        {
            var builder = new CodeLanguageSetBuilder();
            languages(builder);
            ProgrammingLanguages = builder.Get();
            return this;
        }

        public Developer Interested(Func<InterestSetBuilder, InterestSetBuilder> @in)
        {
            var builder = new InterestSetBuilder();
            @in(builder);
            Interests = builder.Get();
            return this;
        }

        public Developer Found(Func<FoundAtBuilder, FoundAtBuilder> at)
        {
            var builder = new FoundAtBuilder();
            at(builder);
            FoundAt = builder.Get();
            return this;
        }

        public void Travel() { }
        public void EnjoyLife() { }
        public void Code() { }
    }
}
