
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WhiteRabbit2.Models;

namespace WhiteRabbit2.Helpers
{
    public static class MenuHelper
    {
        public static List<MyMenu> GetSnacks()
        {
            List<MyMenu> snacks;
            using (var db = new OrderContext())
            {
                snacks = db.MyMenu.Where(s => s.CourseId >= 100 && s.CourseId < 200).ToList();
            }
            return snacks;
        }

        public static List<MyMenu> GetMainCourses()
        {
            List<MyMenu> mainCourses;
            using (var db = new OrderContext())
            {
                mainCourses = db.MyMenu.Where(s => s.CourseId >= 200 && s.CourseId < 300).ToList();
            }
            return mainCourses;
        }

        public static List<MyMenu> GetDrinks()
        {
            List<MyMenu> drinks;
            using (var db = new OrderContext())
            {
                drinks = db.MyMenu.Where(s => s.CourseId >= 300 && s.CourseId < 400).ToList();
            }
            return drinks;
        }

        public static List<MyMenu> GetDeserts()
        {
            List<MyMenu> deserts;
            using (var db = new OrderContext())
            {
                deserts = db.MyMenu.Where(s => s.CourseId >= 400 && s.CourseId < 500).ToList();
            }
            return deserts;
        }

        public static Course FindCourseById(string id)
        {
            MyMenu course = null;
            using (var db = new OrderContext())
            {
                course = db.MyMenu.Find(id);
            }
            return new Course
            {
                CourseId = course.CourseId,
                CourseName = course.CourseName,
                TimeForCooking = course.TimeForCooking,
                TimeForEating = course.TimeForEating
            };
        }

        public static MyMenu GetById(int id)
        {
            using (var db = new OrderContext())
            {
                return db.MyMenu.Find(id);
            }
        }
    }
}
