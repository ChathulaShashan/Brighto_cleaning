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
    public partial class EmpResourcesform : Form
    {
        OleDbConnection conn;
        OleDbCommand cmd;
        OleDbDataAdapter adapter;
        DataTable dt;

        public EmpResourcesform()
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
            EmpresourceGrid.DataSource = dt;
            conn.Close();
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

        private void EmpResourcesform_Load(object sender, EventArgs e)
        {
            GetResource();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            empproresearch.Clear();
        }

        private void empproresearch_TextChanged(object sender, EventArgs e)
        {
           DataView dv = dt.DefaultView;
            dv.RowFilter = String.Format("RID like '%{0}%'", empproresearch.Text);
            EmpresourceGrid.DataSource = dv.ToTable();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
