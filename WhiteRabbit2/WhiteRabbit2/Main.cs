using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhiteRabbit2
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void ShowAllOrders(object sender, EventArgs e)
        {
            var form = new AllOrders();
            this.AddOwnedForm(form);
            form.Show();
        }

        private void CreateNewOrder(object sender, EventArgs e)
        {
            var form = new CreateNewOrder();
            this.AddOwnedForm(form);
            form.Show();
        }
    }
}
