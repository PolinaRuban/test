using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WhiteRabbit2.Models;

namespace WhiteRabbit2
{
    public partial class CheckForm : Form
    {
        public CheckForm(int id, int totalPrice)
        {
            InitializeComponent();
            listView1.Columns.Add("Title");
            listView1.Columns.Add("Minutes");
            listView1.View = View.Details;

            List<Course> courses = Helpers.OrderHelper.GetCoursesById(id);
            listView1.Items.Clear();
            foreach (var course in courses)
            {
                var count = Int32.Parse(course.TimeForCooking) + Int32.Parse(course.TimeForEating);
                var item = new ListViewItem(new[] { course.CourseName, count.ToString()});
                listView1.Items.Add(item);
            }
            var result =
                Helpers.CalculateCostHelper.GetTotalPrice(Helpers.CalculateCostHelper.GetHoursFromMinutes(totalPrice));
            label2.Text = result.ToString();
        }

        private void Close(object sender, EventArgs e)
        {
            Close();
        }
    }
}
