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
    public partial class EmpProjectform : Form
    {
        OleDbConnection conn;
        OleDbCommand cmd;
        OleDbDataAdapter adapter;
        DataTable dt;

        public EmpProjectform()
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
            EmpprojectGrid.DataSource = dt;
            conn.Close();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Empdashboarform().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void EmpprojectGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void EmpProjectform_Load(object sender, EventArgs e)
        {
            GetProject();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            empproserarch.Clear();
        }

        private void empproserarch_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = String.Format("ProId like '%{0}%'", empproserarch.Text);
            EmpprojectGrid.DataSource = dv.ToTable();
        }
    }
}
