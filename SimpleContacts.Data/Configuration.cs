namespace SimpleContacts.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SimpleContacts.Data.SimpleContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(SimpleContacts.Data.SimpleContext context)
        {
            Seeder.Seed(context);
        }
    }
}
