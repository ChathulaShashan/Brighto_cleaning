using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace supermarket
{
    public partial class Employeeform : Form
    {

        OleDbConnection conn;
        OleDbCommand cmd;
        OleDbDataAdapter adapter;
        DataTable dt;

        public Employeeform()
        {
            InitializeComponent();
        }

        void GetEmployee()
        {
            conn = new OleDbConnection("Provider=Microsoft.ACE.OleDb.16.0;Data Source=Brighto.accdb");
            dt = new DataTable();
            adapter = new OleDbDataAdapter("SELECT * FROM EmpTbl", conn);
            conn.Open();
            adapter.Fill(dt);
            EmployeeGrid.DataSource = dt;
            conn.Close();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fillcombo()
        {
            // M/N  this method will bind the combox with the database

        }

        private void Employeeform_Load(object sender, EventArgs e)
        {
            GetEmployee();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Dashboardform().Show();
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            String query = "INSERT INTO EmpTbl (EmpId,EmpName,EmpAge,EmpEmail,EmpGender,Con,EmpAddress) VALUES" +
             "(@empid,@empname,@empage,@empemail,@empgender,@con,@empaddress)";
            cmd = new OleDbCommand(query, conn);
            cmd.Parameters.AddWithValue("@empid", txtEmpid.Text);
            cmd.Parameters.AddWithValue("@empname", txtEmpname.Text);
            cmd.Parameters.AddWithValue("@empage", txtEmpage.Text);
            cmd.Parameters.AddWithValue("@empemail",txtEmpemail.Text);
            cmd.Parameters.AddWithValue("@empgender", EmpgenderCb.Text);
            cmd.Parameters.AddWithValue("@con", txtContactno.Text);
            cmd.Parameters.AddWithValue("@empaddress",txtEmpaddress.Text);



            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("successfully added");
            GetEmployee();



        }


        private void EmployeeGrid_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
         txtEmpid.Text = EmployeeGrid.CurrentRow.Cells[0].Value.ToString();
           txtEmpname.Text = EmployeeGrid.CurrentRow.Cells[1].Value.ToString();
           txtEmpage.Text = EmployeeGrid.CurrentRow.Cells[2].Value.ToString();
           txtEmpemail.Text = EmployeeGrid.CurrentRow.Cells[3].Value.ToString();
           EmpgenderCb.Text = EmployeeGrid.CurrentRow.Cells[4].Value.ToString();
           txtContactno.Text = EmployeeGrid.CurrentRow.Cells[5].Value.ToString();
           txtEmpaddress.Text = EmployeeGrid.CurrentRow.Cells[6].Value.ToString();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            String query = "UPDATE EmpTbl SET EmpId=@empid , EmpName=@empname,EmpAge=@empage,EmpEmail=@empemail,Con = @con,EmpAddress=@empaddress " +
           " WHERE EmpId=@empid";
            cmd = new OleDbCommand(query, conn);
            cmd.Parameters.AddWithValue("@empid", txtEmpid.Text);
            cmd.Parameters.AddWithValue("@empname", txtEmpname.Text);
            cmd.Parameters.AddWithValue("@empage", txtEmpage.Text);
            cmd.Parameters.AddWithValue("@empemail", txtEmpemail.Text);
            cmd.Parameters.AddWithValue("@con", txtContactno.Text);
            cmd.Parameters.AddWithValue("@empaddress", txtEmpaddress.Text);

            cmd.Parameters.AddWithValue("@empid", Convert.ToString(txtEmpid.Text));

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("successfully updated");
            GetEmployee();

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            String query = "DELETE FROM EmpTbl WHERE EmpId=@empid";
            cmd = new OleDbCommand(query, conn);
            cmd.Parameters.AddWithValue("@empid", txtEmpid.Text);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("successfully Deleted");
            GetEmployee();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = String.Format("EmpId like '%{0}%'", searchEmployee.Text);
            EmployeeGrid.DataSource = dv.ToTable();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            txtEmpid.Clear();
            txtEmpname.Clear();
            txtEmpaddress.Clear();
                txtEmpage.Clear();
            txtEmpaddress.Clear();
            txtEmpemail.Clear();
            txtContactno.Clear();
            
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            searchEmployee.Clear();
        }
    }
    
}
