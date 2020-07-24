using Developer.Builder.Model;

namespace Developer.Builder
{
    public static class Developers
    {
        public static readonly Model.Developer Arley = Model.Developer
            .Married()
            .Musician("🎷", Musician.Level.Ok)
            .BornIn(Countries.Brazil, year: 1991)
            .LivesIn(Countries.Netherlands, since: 2017)
            .CodesIn(languages => languages
                .CSharp()
                .Typescript()
                .JavaScript())
            .Interested(@in => @in
                .SoftwareArchitecture()
                .DomainDrivenDesign()
                .DistributedSystems()
                .ShareIdeas(at: "https://medium.com/@arleypadua"))
            .Found(at => at
                .Twitter("https://twitter.com/_arleypadua")
                .LinkedIn("https://www.linkedin.com/in/arleypadua/"));
    }
}