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
using TheArtOfDev.HtmlRenderer.Adapters;

namespace supermarket
{

    public partial class Resourceform : Form
    {

        OleDbConnection conn;
        OleDbCommand cmd;
        OleDbDataAdapter adapter;
        DataTable dt;
        public Resourceform()
        {
            InitializeComponent();
        }
        void GetResource()
        {
            conn = new OleDbConnection("Provider=Microsoft.ACE.OleDb.16.0;Data Source=Brighto.accdb");
            dt = new DataTable();
            adapter = new OleDbDataAdapter("SELECT * FROM ReTbl", conn);
            conn.Open();
            adapter.Fill(dt);
            ResourcesGrid.DataSource = dt;
            conn.Close();
        }

        private void testResourceform_Load(object sender, EventArgs e)
        {
            GetResource();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            String query = "INSERT INTO ReTbl (RID,Empid,ProID,Category,Quantity) VALUES" +
            "(@rid,@empid,@proid,@category,@quantity)";
            cmd = new OleDbCommand(query, conn);
            cmd.Parameters.AddWithValue("@rid", txtRID.Text);
            cmd.Parameters.AddWithValue("@empid", txtEmpId.Text);
            cmd.Parameters.AddWithValue("@proid", txtProID.Text);
           cmd.Parameters.AddWithValue("@category",CategoryCb.Text);
            cmd.Parameters.AddWithValue("@quantity",txtquantity.Text);


            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("successfully added");
            GetResource();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String query = "UPDATE ReTbl SET RID=@rid ,EmpId=@empid,ProID=@proid,Category=@category,Quantity=@quantity " +
                " WHERE RID=@rid";

            cmd = new OleDbCommand(query, conn);
            cmd.Parameters.AddWithValue("@rid", txtRID.Text);
            cmd.Parameters.AddWithValue("@empid", txtEmpId.Text);
            cmd.Parameters.AddWithValue("@proid", txtProID.Text);
            cmd.Parameters.AddWithValue("category",CategoryCb.Text);
            cmd.Parameters.AddWithValue("quantity", txtquantity.Text);
           


            cmd.Parameters.AddWithValue("@rid", Convert.ToInt32(txtRID.Text));

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("successfully updated");
            GetResource();

        }

        private void ResourcesGrid_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtRID.Text = ResourcesGrid.CurrentRow.Cells[0].Value.ToString();
            txtEmpId.Text = ResourcesGrid.CurrentRow.Cells[1].Value.ToString();
            txtProID.Text = ResourcesGrid.CurrentRow.Cells[2].Value.ToString();
            CategoryCb.Text = ResourcesGrid.CurrentRow.Cells[3].Value.ToString();
            txtquantity.Text = ResourcesGrid.CurrentRow.Cells[4].Value.ToString();



        }

        private void ResourcesGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            String query = "DELETE FROM ReTbl WHERE RID=@rid";
            cmd = new OleDbCommand(query, conn);
            cmd.Parameters.AddWithValue("@rid",txtRID.Text);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("successfully Deleted");
            GetResource();
        }

        private void searchResources_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = String.Format("RID like '%{0}%'", searchResources.Text);
            ResourcesGrid.DataSource = dv.ToTable();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Dashboardform().Show();
            this.Hide();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            txtRID.Clear();
            txtEmpId.Clear();
            txtProID.Clear();
            txtquantity.Clear();
           
            
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            searchResources.Clear();
        }
    }
}
