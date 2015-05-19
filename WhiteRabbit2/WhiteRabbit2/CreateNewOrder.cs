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
    public partial class CreateNewOrder : Form
    {
        List<Course> courses = new List<Course>(); 
        public CreateNewOrder()
        {
            InitializeComponent();
            label2.Text = (Helpers.OrderHelper.GetCountOfOrders() + 1).ToString();
            label2.ImageIndex = Helpers.OrderHelper.GetCountOfOrders() + 1;
        }

        private void Cancel(object sender, EventArgs e)
        {
            Close();
        }

        private void CreateOrder(object sender, EventArgs e)
        {
            Helpers.OrderHelper.CreateOrder(courses);
            Close();
        }

        private void AddSnacks(object sender, EventArgs e)
        {
            var menuItems = Helpers.MenuHelper.GetSnacks();
            var form = new AddCoursesToOrder(menuItems, this);
            this.AddOwnedForm(form);
            form.Show();
        }
        
        private void AddMainCourses(object sender, EventArgs e)
        {
            var menuItems = Helpers.MenuHelper.GetMainCourses();

            var form = new AddCoursesToOrder(menuItems, this);
            this.AddOwnedForm(form);
            form.Show();
        }
        private void AddDrinks(object sender, EventArgs e)
        {
            var menuItems = Helpers.MenuHelper.GetDrinks();

            var form = new AddCoursesToOrder(menuItems, this);
            this.AddOwnedForm(form);
            form.Show();
        }

        private void AddDeserts(object sender, EventArgs e)
        {
            var menuItems = Helpers.MenuHelper.GetDeserts();
            var courses = new List<Course>();

            var form = new AddCoursesToOrder(menuItems, this);
            this.AddOwnedForm(form);
            form.Show();
        }

        public void Write(object sender, MyMenu e)
        {
            courses.Add(new Course()
            {
                CourseId = e.CourseId,
                CourseName = e.CourseName,
                TimeForCooking = e.TimeForCooking,
                TimeForEating = e.TimeForEating
            });
            listOrder.Items.Add(e.CourseName);
        }

    }
}
