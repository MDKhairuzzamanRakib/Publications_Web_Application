namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WebApplication1.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<WebApplication1.Models.ArticleDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WebApplication1.Models.ArticleDbContext db)
        {
            Tag t1 = new Tag { TagName = "Computer Fundamentals" };
            Tag t2 = new Tag { TagName = "SQL" };
            Tag t3 = new Tag { TagName = "C#" };
            Tag t4 = new Tag { TagName = "HTML" };
            Tag t5 = new Tag { TagName = "MVC" };
            Tag t6 = new Tag { TagName = "MVC Core" };
            Tag t7 = new Tag { TagName = "Angular" };

            db.Tags.AddRange(new Tag[] { t1, t2, t3, t4, t5, t6, t7 });

            Article a1 = new Article { Title = "Getting Started With MVC", PublishDate = new DateTime(2023, 11, 15) };
            Article a2 = new Article { Title = "Getting Started Development", PublishDate = new DateTime(2022, 01, 30) };

            a1.ArticleTags.Add(new ArticleTag { Tag = t5 });
            a1.ArticleTags.Add(new ArticleTag { Tag = t6 });
            a2.ArticleTags.Add(new ArticleTag { Tag = t3 });
            a2.ArticleTags.Add(new ArticleTag { Tag = t4 });
            a2.ArticleTags.Add(new ArticleTag { Tag = t7 });

            db.Articles.AddRange(new Article[] { a1, a2 });

            db.SaveChanges();
        }
    }
}
