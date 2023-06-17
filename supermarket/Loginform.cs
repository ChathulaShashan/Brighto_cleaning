using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace supermarket
{
    public partial class Loginform : Form
    {
        public Loginform()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtusername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Enter the uname or password");
            }
            else
            {
                if (RoleCb.SelectedItem.ToString() == "Admin")
                {
                    if (txtusername.Text == "admin" && txtPassword.Text == "admin123")
                    {

                        new Dashboardform().Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Enter correct user name and password");
                    }
                }
                else if (RoleCb.SelectedItem.ToString() == "Employee")
                {

                    if (txtusername.Text == "employee" && txtPassword.Text == "employee123")
                    {

                        new Empdashboarform().Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Enter correct user name and password");
                    }
                }


            }

        }




        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void GenderCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

