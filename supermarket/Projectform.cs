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
    public partial class Projectform : Form
    {

        OleDbConnection conn;
        OleDbCommand cmd;
        OleDbDataAdapter adapter;
        DataTable dt;

        public Projectform()
        {
            InitializeComponent();
        }

        void GetProject()
        {
            conn = new OleDbConnection("Provider=Microsoft.ACE.OleDb.16.0;Data Source=Brighto.accdb");
            dt = new DataTable();
            adapter = new OleDbDataAdapter("SELECT * FROM ProTbl", conn);
            conn.Open();
            adapter.Fill(dt);
            ProjectGrid.DataSource = dt;
            conn.Close();
        }

        private void testproject_Load(object sender, EventArgs e)
        {
            GetProject();

        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            String query = "INSERT INTO ProTbl (Proid,Proowner,Location,Cost,Startdate) VALUES" +
       "(@proid,@proowner,@location,@cost,@startdate)";
            cmd = new OleDbCommand(query, conn);
            cmd.Parameters.AddWithValue("@proid", txtEmpID.Text);
            cmd.Parameters.AddWithValue("@proowner", txtProowner.Text);
            cmd.Parameters.AddWithValue("@location", txtLocation.Text);
            cmd.Parameters.AddWithValue("@cost", txtCost.Text);
            cmd.Parameters.AddWithValue("@startdate", txtStartdate.Text);
           

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("successfully added");
            GetProject();



        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            String query = "UPDATE ProTbl SET ProID=@proid , Proowner=@proowner,Location=@location,Cost=@cost,Startdate = @startdate " +
                " WHERE ProID=@proid";
            cmd = new OleDbCommand(query, conn);
            cmd.Parameters.AddWithValue("@proid", txtEmpID.Text);
            cmd.Parameters.AddWithValue("@proowner", txtProowner.Text);
            cmd.Parameters.AddWithValue("@location", txtLocation.Text);
            cmd.Parameters.AddWithValue("@cost", txtCost.Text);
            cmd.Parameters.AddWithValue("@startdate", txtStartdate.Text);
            cmd.Parameters.AddWithValue("@proid",txtEmpID.Text);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("successfully updated");
            GetProject();

        }

        private void ProjectGrid_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtEmpID.Text = ProjectGrid.CurrentRow.Cells[0].Value.ToString();
            txtProowner.Text = ProjectGrid.CurrentRow.Cells[1].Value.ToString();
            txtLocation.Text = ProjectGrid.CurrentRow.Cells[2].Value.ToString();
            txtCost.Text = ProjectGrid.CurrentRow.Cells[3].Value.ToString();
            txtStartdate.Text = ProjectGrid.CurrentRow.Cells[4].Value.ToString();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            String query = "DELETE FROM ProTbl WHERE ProID=@proid";
            cmd = new OleDbCommand(query, conn);
            cmd.Parameters.AddWithValue("@proid",txtEmpID.Text);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("successfully Deleted");
            GetProject();
        }

        private void prosearch_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter= String.Format("ProId like '%{0}%'", prosearch.Text);
            ProjectGrid.DataSource = dv.ToTable();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Dashboardform().Show();
            this.Hide();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
           txtProowner.Clear();
            txtCost.Clear();
            txtStartdate.Clear();
            txtEmpID.Clear();
            txtLocation.Clear();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            prosearch.Clear();
        }

        private void ProjectGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ProjectGrid_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ProjectGrid_CellEnter_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
