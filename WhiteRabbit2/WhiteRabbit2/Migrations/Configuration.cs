using System.Data.Entity.Migrations.Model;
using WhiteRabbit2.Helpers;
using WhiteRabbit2.Models;

namespace WhiteRabbit2.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<WhiteRabbit2.Models.OrderContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }
        
        //This method fill the menu table after every migration.
        //If *.txt files are updated you should:
        //Open Package Manger Console
        // Write: update-database (and add-migrations at first if it's necessary)
        protected override void Seed(OrderContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.

            foreach (var course in context.MyMenu)
            {
                context.MyMenu.Remove(course);
            }
            var menuList = new ReadFromTextFile("Snacks.txt").AddDataToCourses();
            foreach (var course in menuList)
            {
                context.MyMenu.AddOrUpdate(course);
            }
            menuList = new ReadFromTextFile("MainCourses.txt").AddDataToCourses();
            foreach (var course in menuList)
            {
                context.MyMenu.AddOrUpdate(course);
            }
            menuList = new ReadFromTextFile("Drinks.txt").AddDataToCourses();
            foreach (var course in menuList)
            {
                context.MyMenu.AddOrUpdate(course);
            }
            menuList = new ReadFromTextFile("Deserts.txt").AddDataToCourses();
            foreach (var course in menuList)
            {
                context.MyMenu.AddOrUpdate(course);
            }
        }
    }
}
