using System;
using Developers.Builder.Model;

namespace Developers.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Developer arley = Developer
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
                    .LinkedIn("https://www.linkedin.com/in/arleypadua/")); ;

            while (arley.HasLife)
            {
                arley.Travel();
                arley.EnjoyLife();
                arley.Code();

                System.Console.WriteLine("Keep up the good work");
            }

            // todo find out what is next
            throw new NotImplementedException();
        }
    }
}
