using supermarket.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace supermarket
{
    public partial class Dashboardform : Form
    {
        public Dashboardform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Employeeform().Show();
            this.Hide();    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Projectform().Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Resourceform().Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Loginform().Show();
            this.Hide();
        }
    }
}
