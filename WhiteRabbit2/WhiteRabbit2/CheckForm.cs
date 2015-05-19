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
            listView1.Columns.Add("Price");
            listView1.View = View.Details;

            List<Course> courses = Helpers.OrderHelper.GetCoursesById(id);
            listView1.Items.Clear();
            foreach (var course in courses)
            {
                var item = new ListViewItem(new[] { course.CourseName, course.TimeForCooking, course.TimeForEating });
                listView1.Items.Add(item);
            }
            label2.Text = totalPrice.ToString(CultureInfo.InvariantCulture);
        }

        private void Close(object sender, EventArgs e)
        {
            Close();
        }
    }
}
