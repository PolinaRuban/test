

using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WhiteRabbit2.Models;

namespace WhiteRabbit2.Helpers
{
    public static class OrderHelper
    {
        public static List<Order> GetAllOrders()
        {
            List<Order> openedOrders = null;
            using (var db = new OrderContext())
            {
                if (db.Orders.Count() != 0)
                {
                    openedOrders = db.Orders.Where(s => s.IsOpen).ToList();
                }
            }
            return openedOrders;
        }

        public static int GetCountOfOrders()
        {
            int count = 0;
            using (var db = new OrderContext())
            {
                count = db.Orders.Count();
            }
            return count;
        }

        public static List<Course> GetCoursesById(int id)
        {
            using (var db = new OrderContext())
            {
                return db.Courses.Where(s => s.Order.OrderId == id).ToList();
            }
        }

        public static void CreateOrder(ICollection<Course> courses)
        {
            if(courses == null)
                return;
            using (var db = new OrderContext())
            {
                db.Orders.Add(new Order()
                {
                    Courses = courses,
                    IsOpen = true
                });
                db.SaveChanges();
            }
        }

        public static void CloseOrder(int id)
        {
            using (var db = new OrderContext())
            {
                var order = db.Orders.FirstOrDefault(x => x.OrderId == id);
                order.IsOpen = false;
                db.SaveChanges();
            }
        }

        public static void ClearOrder(int id)
        {
            CloseOrder(id);
        }
    }
}
