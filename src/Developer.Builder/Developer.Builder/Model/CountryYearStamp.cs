namespace Developer.Builder.Model
{
    public readonly struct CountryYearStamp
    {
        public CountryYearStamp(Countries country, int year)
        {
            Country = country;
            Year = year;
        }

        public int Year { get; }
        public Countries Country { get; }
    }
}