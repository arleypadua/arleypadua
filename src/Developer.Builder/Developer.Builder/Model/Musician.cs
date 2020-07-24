using System;

namespace Developer.Builder.Model
{
    public readonly struct Musician
    {
        public Musician(string instrument, Level skillLevel)
        {
            Instrument = instrument ?? throw new ArgumentNullException(nameof(instrument));
            SkillLevel = skillLevel;
        }

        public string Instrument { get; }
        public Level SkillLevel { get; }
        public enum Level
        {
            Bad,
            Ok,
            Good
        }
    }
}