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
    public partial class Empdashboarform : Form
    {
        public Empdashboarform()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            new EmpProjectform().Show();
                this.Hide();
        }

            private void button3_Click(object sender, EventArgs e)
            {
                new EmpResourcesform().Show();
                this.Hide();
            }

            private void button4_Click(object sender, EventArgs e)
            {
            new Loginform().Show();
            this.Hide();
        }
        }
    }
