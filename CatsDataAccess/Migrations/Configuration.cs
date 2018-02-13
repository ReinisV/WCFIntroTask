namespace CatsDataAccess.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CatsDataAccess.CatsDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CatsDataAccess.CatsDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            context.Cats.AddOrUpdate(
                new Cat
                    {
                        FirstName = "Ashes",
                        LastName = "Tiger",
                        Age = 5,
                        LastModified = DateTime.Now,
                        PictureLink = "http://www.catster.com/wp-content/uploads/2017/06/small-kitten-meowing.jpg"
                });
            context.Cats.AddOrUpdate(
                new Cat
                    {
                        FirstName = "Puss",
                        LastName = "Smokey",
                        Age = 5,
                        LastModified = DateTime.Now,
                        PictureLink = "http://r.ddmcdn.com/s_f/o_1/cx_462/cy_245/cw_1349/ch_1349/w_720/APL/uploads/2015/06/caturday-shutterstock_149320799.jpg"
                });
            context.Cats.AddOrUpdate(
                new Cat
                    {
                        FirstName = "Misty",
                        LastName = "Tigger",
                        Age = 5,
                        LastModified = DateTime.Now,
                        PictureLink = "https://www.cats.org.uk/uploads/images/featurebox_sidebar_kids/grief-and-loss.jpg"
                });
            context.Cats.AddOrUpdate(
                new Cat
                    {
                        FirstName = "Kitty",
                        LastName = "Oscar",
                        Age = 5,
                        LastModified = DateTime.Now,
                        PictureLink = "https://www.petmd.com/cat/centers/nutrition/slideshows/signs-your-cat-might-be-stressed"
                });
        }
    }
}
