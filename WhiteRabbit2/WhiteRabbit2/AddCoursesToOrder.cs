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
    public partial class AddCoursesToOrder : Form
    {
        private List<MyMenu> coursesList;
         public string SelectedItem { get; set; } 

        public event EventHandler<MyMenu> ClickEvent;

        public AddCoursesToOrder()
        {
            InitializeComponent();
        }

        public AddCoursesToOrder(List<MyMenu> course, CreateNewOrder createNewOrder): this()
        {
            coursesList = course;
            var obj = createNewOrder;
            ClickEvent += obj.Write;
        }

        private void LoadCourses(object sender, EventArgs e)
        {
            for (int i = 0; i < coursesList.Count(); i++)
            {
                var button = new Button
                {
                    Text = coursesList[i].CourseName,
                    Size = new Size(100, 50),
                    Font = new Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204))), 
                    ImageIndex = coursesList[i].Id
                };
                button.Click += Button_Click;

                this.flowLayoutPanel.Controls.Add(button);
            }
        }
        private void Button_Click(object sender, EventArgs e)
        {
            var button = (Button) sender;
            var menuItem = Helpers.MenuHelper.GetById(button.ImageIndex);
            ClickEvent(this, menuItem);
        }
    }
}
