using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WhiteRabbit2.Models;

namespace WhiteRabbit2
{
    public partial class AllOrders : Form
    {
        public AllOrders()
        {
            InitializeComponent();

            ReDrawOrders();
            listCourses.Columns.Add("Title");
            listCourses.Columns.Add("Price");
            listCourses.Columns.Add("Time for eating");
            listCourses.View = View.Details;
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel1.Visible = true;
            var id = this.listView.FocusedItem.ImageIndex;
            label2.Text = id.ToString();
            label2.ImageIndex = id;
            List<Course> courses = Helpers.OrderHelper.GetCoursesById(id);
            if (courses == null || courses.Count == 0)
            {
            }
            else
            {
                listCourses.Items.Clear();
                foreach (var course in courses)
                {
                    var item = new ListViewItem(new []{course.CourseName, course.TimeForCooking, course.TimeForEating});
                    listCourses.Items.Add(item);
                }
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Helpers.OrderHelper.ClearOrder(label2.ImageIndex);
            ReDrawOrders();
            panel1.Visible = false;
        }

        private void ReDrawOrders()
        {
            listView.Clear();
            var orders = Helpers.OrderHelper.GetAllOrders();
            listView.View = View.List;
            if (orders == null || orders.Count == 0)
            {
                ListViewItem item = null;
            }
            else
            {
                foreach (var order in orders)
                {
                    var item = new ListViewItem("Order # " + order.OrderId, order.OrderId);
                    listView.Items.Add(item);
                }
            }
        }

        private int CheckTime()
        {
            int min;
            Int32.TryParse(minutes.Text, out min);
            if (min <= 0)
            {
                MessageBox.Show("Wrong time!");
                return -1;
            }
            return min;
        }

        private void PrintCheck(object sender, EventArgs e)
        {
            //Total:
            int totalMinutes = CheckTime();
            var minTimeForEating = Helpers.CalculateCostHelper.GetTimeForEatingByOrderId(Int32.Parse(label2.Text));

            if (totalMinutes < minTimeForEating)
            {
                if (totalMinutes != -1)
                {
                    MessageBox.Show("You are a little lier!");
                }
            }
            else
            {
                var form = new CheckForm(label2.ImageIndex, totalMinutes);
                form.Show();
                Helpers.OrderHelper.CloseOrder(label2.ImageIndex);
                Close();
            }
        }
    }
}
